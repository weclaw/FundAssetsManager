using System;
using FundAssetManager.Model;

namespace FundAssetManager.ViewModel
{
    public class AssetViewModel
    {
        public AssetViewModel(Asset asset)
        {
            MapFromAssetModel(asset);
        }

        public void MapFromAssetModel(Asset asset)
        {
            Name = asset.Name;
            Type = asset.Type;
            Price = asset.Price;
            Quantity = asset.Quantity;
            MarketValue = asset.MarketValue;
            TransactionCost = asset.TransactionCost;
            RedZone = asset.RedZone;
        }

        public string Name { get; set; }
        public AssetType Type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal MarketValue { get; set; }
        public decimal TransactionCost { get; set; }
        public bool RedZone { get; set; }
        public float StockWeight { get; set; }

    }
}
