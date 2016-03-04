using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundAssetManager.Model
{
    public class Bond : Asset
    {
        private readonly decimal TRANSACTION_COST_TOLERANCE = 100000;
        private readonly decimal TRANSACTION_COST_PERCENTAGE = 0.02M;

        public Bond(string name, AssetType type, decimal price, int quantity)
            : base(name, type, price, quantity)
        { }

        public override decimal TransactionCostPercentage
        {
            get
            {
                return TRANSACTION_COST_PERCENTAGE;
            }
        }

        public override decimal TransactionCostTolerance
        {
            get
            {
                return TRANSACTION_COST_TOLERANCE;
            }
        }
    }
}
