using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAssetManager.Model;
using System.Linq;

namespace FundAssetManager.Test
{
    [TestClass]
    public class BondTest
    {

        private readonly decimal BOND_TRANSACTION_COST_TOLERANCE = 100000;
        private readonly decimal BOND_TRANSACTION_COST_PERCENTAGE = 0.02M;

        [TestMethod]
        public void CheckBondMarketValue()
        {
            const string NAME = "Bond1";
            const decimal PRICE = 55;
            const int QUANTITY = 140000;

            var portfolio = new Portfolio();
            var bond = new Bond(NAME, AssetType.Bond, PRICE, QUANTITY);
            portfolio.AddAsset(bond);

            var addedBond = portfolio.Bonds.Single(b => b.Name == NAME);
            Assert.AreEqual(Math.Round(PRICE *QUANTITY, 2), addedBond.MarketValue);
        }

        [TestMethod]
        public void CheckBondTransactionCost()
        {
            const string NAME = "Bond1";
            const decimal PRICE = 120;
            const int QUANTITY = 400;

            var portfolio = new Portfolio();
            var bond = new Bond(NAME, AssetType.Bond, PRICE, QUANTITY);
            portfolio.AddAsset(bond);

            var addedBond = portfolio.Bonds.Single(b => b.Name == NAME);
            Assert.AreEqual(Math.Round(addedBond.MarketValue * addedBond.TransactionCostPercentage, 2), 
                addedBond.TransactionCost);
        }

        [TestMethod]
        public void CheckRedZoneFlagBond()
        {
            const string NAME_RED_ZONE_MARKET_VALUE = "Bond1";
            const string NAME_RED_ZONE_TRANSACTION_COST = "Bond2";
            const string NAME_NOT_RED_ZONE = "Bond3";
            const string NAME_NOT_RED_ZONE_CORNER_CASE_MV = "Bond4";
            const string NAME_NOT_RED_ZONE_CORNER_CASE_TC = "Bond5";

            var portfolio = new Portfolio();
            portfolio.AddAsset(new Bond(NAME_RED_ZONE_MARKET_VALUE, AssetType.Bond, -10, 10000));
            portfolio.AddAsset(new Bond(NAME_RED_ZONE_TRANSACTION_COST, AssetType.Bond, 10, 
                (int)(BOND_TRANSACTION_COST_TOLERANCE * (1/BOND_TRANSACTION_COST_PERCENTAGE))));
            portfolio.AddAsset(new Bond(NAME_NOT_RED_ZONE, AssetType.Bond, 10, 10));
            portfolio.AddAsset(new Bond(NAME_NOT_RED_ZONE_CORNER_CASE_MV, AssetType.Bond, 0, 10000));
            portfolio.AddAsset(new Bond(NAME_NOT_RED_ZONE_CORNER_CASE_TC, AssetType.Bond, 1, 
                (int)(BOND_TRANSACTION_COST_TOLERANCE * (1 / BOND_TRANSACTION_COST_PERCENTAGE))));

            Assert.IsTrue(portfolio.Bonds.Single(b => b.Name == NAME_RED_ZONE_MARKET_VALUE).RedZone);
            Assert.IsTrue(portfolio.Bonds.Single(b => b.Name == NAME_RED_ZONE_TRANSACTION_COST).RedZone);
            Assert.IsFalse(portfolio.Bonds.Single(b => b.Name == NAME_NOT_RED_ZONE).RedZone);
            Assert.IsFalse(portfolio.Bonds.Single(b => b.Name == NAME_NOT_RED_ZONE_CORNER_CASE_MV).RedZone);
            Assert.IsFalse(portfolio.Bonds.Single(b => b.Name == NAME_NOT_RED_ZONE_CORNER_CASE_TC).RedZone);
        }
    }
}
