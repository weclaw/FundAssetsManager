using System;

namespace FundAssetManager.Model
{
    public abstract class Asset
    {
        protected string _name;
        protected AssetType _type;
        protected decimal _price;
        protected int _quantity;

        public abstract decimal TransactionCostTolerance { get; }
        public abstract decimal TransactionCostPercentage { get; }

        public Asset(string name, AssetType type, decimal price, int quantity)
        {
            _name = name;
            _type = type;
            _price = price;
            _quantity = quantity;
        }

        public string Name
        {
            get { return _name; }
        }

        public AssetType Type
        {
            get { return _type; }
        }

        public decimal Price
        {
            get { return _price; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

        public decimal MarketValue
        {
            get { return Math.Round(_price * _quantity,2); }
        }

        public decimal TransactionCost
        {
            get
            {
                return Math.Round(MarketValue * TransactionCostPercentage,2);
            }
        }

        public bool RedZone
        {
            get { return MarketValue < 0 ||
                    TransactionCost > TransactionCostTolerance; }
        }
    }
}
