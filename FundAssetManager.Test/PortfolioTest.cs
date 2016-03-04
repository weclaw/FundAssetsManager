using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FundAssetManager.Model;
using System.Linq;

namespace FundAssetManager.Test
{
    [TestClass]
    public class PortfolioTest
    {
        [TestMethod]
        public void AddBondToPortfolio()
        {
            const string NAME = "Bond1";
            const decimal PRICE = 5;
            const int QUANTITY = 10000;

            var portfolio = new Portfolio();
            var bond = new Bond(NAME, AssetType.Bond, PRICE, QUANTITY);
            portfolio.AddAsset(bond);

            var addedBond = portfolio.Bonds.Single(b => b.Name == NAME);
            Assert.AreEqual(NAME, addedBond.Name);
            Assert.AreEqual(AssetType.Bond, addedBond.Type);
            Assert.AreEqual(PRICE, addedBond.Price);
            Assert.AreEqual(QUANTITY, addedBond.Quantity);

            Assert.IsFalse(portfolio.Equities.Any(b => b.Name == NAME));
            Assert.IsTrue(portfolio.All.Any(b => b.Name == NAME));
        }

        [TestMethod]
        public void AddEquityToPortfolio()
        {
            const string NAME = "Equity1";
            const decimal PRICE = 45;
            const int QUANTITY = 15000;

            var portfolio = new Portfolio();
            var equity = new Equity(NAME, AssetType.Equity, PRICE, QUANTITY);
            portfolio.AddAsset(equity);

            var addedEquity = portfolio.Equities.Single(b => b.Name == NAME);
            Assert.AreEqual(NAME, addedEquity.Name);
            Assert.AreEqual(AssetType.Equity, addedEquity.Type);
            Assert.AreEqual(PRICE, addedEquity.Price);
            Assert.AreEqual(QUANTITY, addedEquity.Quantity);

            Assert.IsFalse(portfolio.Bonds.Any(b => b.Name == NAME));
            Assert.IsTrue(portfolio.All.Any(b => b.Name == NAME));
        }

        private Portfolio GeneratePortfolioForAssetSummaryTest()
        {
            var portfolio = new Portfolio();

            portfolio.AddAsset(new Bond("Bond1", AssetType.Bond, ASSET_SUMMARY_TEST_BOND_PRICE_DATA[0],
                ASSET_SUMMARY_TEST_BOND_QUANTITY_DATA[0]));
            portfolio.AddAsset(new Bond("Bond2", AssetType.Bond, ASSET_SUMMARY_TEST_BOND_PRICE_DATA[1],
                ASSET_SUMMARY_TEST_BOND_QUANTITY_DATA[1]));
            portfolio.AddAsset(new Bond("Bond3", AssetType.Bond, ASSET_SUMMARY_TEST_BOND_PRICE_DATA[2],
                ASSET_SUMMARY_TEST_BOND_QUANTITY_DATA[2]));

            portfolio.AddAsset(new Equity("Equity1", AssetType.Equity, ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA[0],
                ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA[0]));
            portfolio.AddAsset(new Equity("Equity2", AssetType.Equity, ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA[1],
                ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA[1]));
            portfolio.AddAsset(new Equity("Equity3", AssetType.Equity, ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA[2],
                ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA[2]));
            portfolio.AddAsset(new Equity("Equity4", AssetType.Equity, ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA[3],
                ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA[3]));

            return portfolio;
        }

        private readonly decimal[] ASSET_SUMMARY_TEST_BOND_PRICE_DATA = new decimal[] { 15, 5.5M, 150 };
        private readonly decimal[] ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA = new decimal[] { 7, 19.4M, 78, 4.34M };
        private readonly int[] ASSET_SUMMARY_TEST_BOND_QUANTITY_DATA = new int[] { 100000, 67500, 23344};
        private readonly int[] ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA = new int[] { 900000, 98976, 1654, 10000};

        [TestMethod]
        public void CheckPortfolioAssetSummary()
        {
            var portfolio = GeneratePortfolioForAssetSummaryTest();
            var assetSummary = portfolio.GetPortfolioAssetsSummary();
            decimal MarketValue = 0;

            for(int i=0; i < 3; i++)
            {
                MarketValue += Math.Round(ASSET_SUMMARY_TEST_BOND_PRICE_DATA[i] * ASSET_SUMMARY_TEST_BOND_QUANTITY_DATA[i],2 );
            }

            for (int i = 0; i < 4; i++)
            {
                MarketValue += Math.Round(ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA[i] * ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA[i], 2);
            }

            Assert.AreEqual(7,assetSummary.Count);
            Assert.AreEqual(MarketValue, assetSummary.MarketValue);
            Assert.AreEqual(1, assetSummary.StockWeight);
        }

        [TestMethod]
        public void CheckBondAssetSummary()
        {
            var portfolio = GeneratePortfolioForAssetSummaryTest();
            var assetSummary = portfolio.GetAssetsSummary<Bond>();
            decimal BondMarketValue = 0, EquityMarketValue = 0;

            for (int i = 0; i < 3; i++)
            {
                BondMarketValue += Math.Round(ASSET_SUMMARY_TEST_BOND_PRICE_DATA[i] * ASSET_SUMMARY_TEST_BOND_QUANTITY_DATA[i], 2);
            }

            for (int i = 0; i < 4; i++)
            {
                EquityMarketValue += Math.Round(ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA[i] * ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA[i], 2);
            }

            Assert.AreEqual(3, assetSummary.Count);
            Assert.AreEqual(BondMarketValue, assetSummary.MarketValue);
            Assert.AreEqual(Math.Round((BondMarketValue / (BondMarketValue + EquityMarketValue)), 4), assetSummary.StockWeight);
        }

        [TestMethod]
        public void CheckEquitiesAssetSummary()
        {
            var portfolio = GeneratePortfolioForAssetSummaryTest();
            var assetSummary = portfolio.GetAssetsSummary<Equity>();
            decimal BondMarketValue = 0, EquityMarketValue = 0;

            for (int i = 0; i < 3; i++)
            {
                BondMarketValue += ASSET_SUMMARY_TEST_BOND_PRICE_DATA[i] * ASSET_SUMMARY_TEST_BOND_QUANTITY_DATA[i];
            }

            for (int i = 0; i < 4; i++)
            {
                EquityMarketValue += ASSET_SUMMARY_TEST_EQUITY_PRICE_DATA[i] * ASSET_SUMMARY_TEST_EQUITY_QUANTITY_DATA[i];
            }

            Assert.AreEqual(4, assetSummary.Count);
            Assert.AreEqual(EquityMarketValue, assetSummary.MarketValue);
            Assert.AreEqual(Math.Round((EquityMarketValue / (BondMarketValue + EquityMarketValue)), 4), assetSummary.StockWeight);
        }
        
    }
}
