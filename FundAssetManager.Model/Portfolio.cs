using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundAssetManager.Model
{
    public class Portfolio
    {
        private List<Asset> _assets = new List<Asset>();

        public List<Asset> All
        {
            get { return _assets; }
        }

        public List<Bond> Bonds
        {
            get { return _assets.OfType<Bond>().ToList(); }
        }

        public List<Equity> Equities
        {
            get { return _assets.OfType<Equity>().ToList(); }
        }

        public void AddAsset(Asset assetToAdd)
        {
            _assets.Add(assetToAdd);
        }

        public PortfolioAssetsSummary GetAssetsSummary<T>()
            where T : Asset
        {
            var assets = All.OfType<T>();
            var marketValue = assets.Sum(a => a.MarketValue);

            return new PortfolioAssetsSummary
            {
                Count = assets.Count(),
                MarketValue = marketValue,
                StockWeight = assets.Any() ? Math.Round((marketValue / All.Sum(a => a.MarketValue)), 4) : 0
            };
        }

        public PortfolioAssetsSummary GetPortfolioAssetsSummary()
        {
            return new PortfolioAssetsSummary
            {
                Count = All.Count(),
                MarketValue = All.Sum(a => a.MarketValue),
                StockWeight = All.Any() ? 1 : 0
            };
        }
    }
}
