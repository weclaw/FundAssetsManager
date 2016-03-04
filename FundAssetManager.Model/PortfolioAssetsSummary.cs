using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundAssetManager.Model
{
    public class PortfolioAssetsSummary
    {
        public int Count { get; set; }
        public decimal StockWeight { get; set; }
        public decimal MarketValue { get; set; }
    }
}
