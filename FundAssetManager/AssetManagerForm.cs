using System.Windows.Forms;
using FundAssetManager.Model;
using FundAssetManager.ViewModel;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace FundAssetManager
{
    public partial class AssetManagerForm : Form
    {
        private Portfolio _portfolio;
        private BindingSource _bindingSource = new BindingSource();
        private List<AssetViewModel> _assets = new List<AssetViewModel>();

        public AssetManagerForm()
        {
            InitializeComponent();
            _portfolio = new Portfolio();
            
            cbAssetType.DataSource = Enum.GetValues(typeof(AssetType));

            _bindingSource.DataSource = _assets;          

            dataGridStocks.AutoGenerateColumns = false;
            dataGridStocks.DataSource = _bindingSource;

            RefreshFundSummaryLabels();
        }

        private void RefreshFundSummaryLabels()
        {
            var equitySummary = _portfolio.GetAssetsSummary<Equity>();
            var bondSummary = _portfolio.GetAssetsSummary<Bond>();
            var portfolioSummary = _portfolio.GetPortfolioAssetsSummary();

            lblEquityNumber.Text = equitySummary.Count.ToString();
            lblEquityWeight.Text = String.Format("{0:P2}", equitySummary.StockWeight);
            lblEquityMV.Text = equitySummary.MarketValue.ToString();

            lblBondNumber.Text = bondSummary.Count.ToString();
            lblBondWeight.Text = String.Format("{0:P2}", bondSummary.StockWeight);
            lblBondMV.Text = bondSummary.MarketValue.ToString();

            lblAllNumber.Text = portfolioSummary.Count.ToString();
            lblAllWeight.Text = String.Format("{0:P2}", portfolioSummary.StockWeight);
            lblAllMV.Text = portfolioSummary.MarketValue.ToString();
        }

        private void RecalculateStockWeights()
        {
            var portfolioMarketValue = _portfolio.GetPortfolioAssetsSummary().MarketValue;
            _assets.ForEach(a => a.StockWeight = (float)Math.Round(a.MarketValue / portfolioMarketValue, 4));
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (cbAssetType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(tbPrice.Text) 
                || string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("Price, Quantity and Type are required.");
            }
            else
            {
                Asset newAsset;

                switch ((AssetType)cbAssetType.SelectedItem)
                {
                    case AssetType.Bond:
                        newAsset = new Bond(string.Format("Bond{0}", _portfolio.Bonds.Count),
                            AssetType.Bond, decimal.Parse(tbPrice.Text), int.Parse(tbQuantity.Text));
                        break;
                    case AssetType.Equity:
                        newAsset = new Equity(string.Format("Equity{0}", _portfolio.Equities.Count), 
                            AssetType.Equity, decimal.Parse(tbPrice.Text), int.Parse(tbQuantity.Text));
                      break;
                    default:
                        throw new ApplicationException("Incorrect AssetType!");
                }

                _portfolio.AddAsset(newAsset);
                _assets.Add(new AssetViewModel(newAsset));
                RecalculateStockWeights();
                _bindingSource.ResetBindings(false);
                RefreshFundSummaryLabels();
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar))
            {
                int i;
                var textBox = (sender as TextBox);
                var newText = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());

                e.Handled = !int.TryParse(newText, out i);
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                decimal i;
                var textBox = (sender as TextBox);
                var newText = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString());

                e.Handled = !decimal.TryParse(newText, out i) || i != Math.Round(i, 2);
            }
        }

        private void dataGridStocks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((sender as DataGridView).Columns[e.ColumnIndex].Name == "colStockName")
            {
                if ((_bindingSource[e.RowIndex] as AssetViewModel).RedZone)
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
