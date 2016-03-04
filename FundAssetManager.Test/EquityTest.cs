using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAssetManager.Model;
using System.Linq;

namespace FundAssetManager.Test
{
    [TestClass]
    public class EquityTest
    {
        private readonly decimal EQUITY_TRANSACTION_COST_TOLERANCE = 200000;
        private readonly decimal EQUITY_TRANSACTION_COST_PERCENTAGE = 0.005M;

        [TestMethod]
        public void CheckEquityMarketValue()
        {
            const string NAME = "Equity1";
            const decimal PRICE = 4;
            const int QUANTITY = 1324;

            var portfolio = new Portfolio();
            var equity = new Equity(NAME, AssetType.Equity, PRICE, QUANTITY);
            portfolio.AddAsset(equity);

            var addedEquity = portfolio.Equities.Single(b => b.Name == NAME);
            Assert.AreEqual(Math.Round(PRICE * QUANTITY, 2), addedEquity.MarketValue);
        }

        [TestMethod]
        public void CheckEquityTransactionCost()
        {
            const string NAME = "Equity1";
            const decimal PRICE = 13;
            const int QUANTITY = 435000;

            var portfolio = new Portfolio();
            var equity = new Equity(NAME, AssetType.Equity, PRICE, QUANTITY);
            portfolio.AddAsset(equity);

            var addedEquity = portfolio.Equities.Single(b => b.Name == NAME);
            Assert.AreEqual(Math.Round(addedEquity.MarketValue * addedEquity.TransactionCostPercentage, 2)
                , addedEquity.TransactionCost);
        }

        [TestMethod]
        public void CheckRedZoneFlagEquity()
        {
            const string NAME_RED_ZONE_MARKET_VALUE = "Equity1";
            const string NAME_RED_ZONE_TRANSACTION_COST = "Equity2";
            const string NAME_NOT_RED_ZONE = "Equity3";
            const string NAME_NOT_RED_ZONE_CORNER_CASE_MV = "Equity4";
            const string NAME_NOT_RED_ZONE_CORNER_CASE_TC = "Equity5";

            var portfolio = new Portfolio();
            portfolio.AddAsset(new Equity(NAME_RED_ZONE_MARKET_VALUE, AssetType.Equity, -10, 10000));
            portfolio.AddAsset(new Equity(NAME_RED_ZONE_TRANSACTION_COST, AssetType.Equity, 10, 
                (int)(EQUITY_TRANSACTION_COST_TOLERANCE * (1 / EQUITY_TRANSACTION_COST_PERCENTAGE))));
            portfolio.AddAsset(new Equity(NAME_NOT_RED_ZONE, AssetType.Equity, 10, 10));
            portfolio.AddAsset(new Equity(NAME_NOT_RED_ZONE_CORNER_CASE_MV, AssetType.Equity, 0, 10000));
            portfolio.AddAsset(new Equity(NAME_NOT_RED_ZONE_CORNER_CASE_TC, AssetType.Equity, 1,
                (int)(EQUITY_TRANSACTION_COST_TOLERANCE * (1 / EQUITY_TRANSACTION_COST_PERCENTAGE))));

            Assert.IsTrue(portfolio.Equities.Single(b => b.Name == NAME_RED_ZONE_MARKET_VALUE).RedZone);
            Assert.IsTrue(portfolio.Equities.Single(b => b.Name == NAME_RED_ZONE_TRANSACTION_COST).RedZone);
            Assert.IsFalse(portfolio.Equities.Single(b => b.Name == NAME_NOT_RED_ZONE).RedZone);
            Assert.IsFalse(portfolio.Equities.Single(b => b.Name == NAME_NOT_RED_ZONE_CORNER_CASE_MV).RedZone);
            Assert.IsFalse(portfolio.Equities.Single(b => b.Name == NAME_NOT_RED_ZONE_CORNER_CASE_TC).RedZone);
        }
    }
}
