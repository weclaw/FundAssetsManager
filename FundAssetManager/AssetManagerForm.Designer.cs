namespace FundAssetManager
{
    partial class AssetManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNewStock = new System.Windows.Forms.Panel();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.cbAssetType = new System.Windows.Forms.ComboBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridStocks = new System.Windows.Forms.DataGridView();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEquityNumber = new System.Windows.Forms.Label();
            this.lblEquityWeight = new System.Windows.Forms.Label();
            this.lblEquityMV = new System.Windows.Forms.Label();
            this.lblBondMV = new System.Windows.Forms.Label();
            this.lblBondWeight = new System.Windows.Forms.Label();
            this.lblBondNumber = new System.Windows.Forms.Label();
            this.lblAllMV = new System.Windows.Forms.Label();
            this.lblAllWeight = new System.Windows.Forms.Label();
            this.lblAllNumber = new System.Windows.Forms.Label();
            this.colStockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelNewStock.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewStock
            // 
            this.panelNewStock.Controls.Add(this.btnAddStock);
            this.panelNewStock.Controls.Add(this.cbAssetType);
            this.panelNewStock.Controls.Add(this.tbQuantity);
            this.panelNewStock.Controls.Add(this.tbPrice);
            this.panelNewStock.Controls.Add(this.label4);
            this.panelNewStock.Controls.Add(this.label3);
            this.panelNewStock.Controls.Add(this.label2);
            this.panelNewStock.Location = new System.Drawing.Point(12, 4);
            this.panelNewStock.Name = "panelNewStock";
            this.panelNewStock.Size = new System.Drawing.Size(551, 68);
            this.panelNewStock.TabIndex = 0;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(431, 33);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(102, 23);
            this.btnAddStock.TabIndex = 4;
            this.btnAddStock.Text = "Add New Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // cbAssetType
            // 
            this.cbAssetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssetType.FormattingEnabled = true;
            this.cbAssetType.Location = new System.Drawing.Point(42, 8);
            this.cbAssetType.Name = "cbAssetType";
            this.cbAssetType.Size = new System.Drawing.Size(98, 21);
            this.cbAssetType.TabIndex = 1;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(349, 8);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(71, 20);
            this.tbQuantity.TabIndex = 3;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(203, 8);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(71, 20);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridStocks);
            this.panelGrid.Location = new System.Drawing.Point(12, 77);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(551, 290);
            this.panelGrid.TabIndex = 1;
            // 
            // dataGridStocks
            // 
            this.dataGridStocks.AllowUserToAddRows = false;
            this.dataGridStocks.AllowUserToDeleteRows = false;
            this.dataGridStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStockType,
            this.colStockName,
            this.colPrice,
            this.colQuantity,
            this.colMarketValue,
            this.colTransactionCost,
            this.colStockWeight});
            this.dataGridStocks.Location = new System.Drawing.Point(3, 3);
            this.dataGridStocks.Name = "dataGridStocks";
            this.dataGridStocks.ReadOnly = true;
            this.dataGridStocks.Size = new System.Drawing.Size(545, 284);
            this.dataGridStocks.TabIndex = 2;
            this.dataGridStocks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridStocks_CellFormatting);
            // 
            // panelSummary
            // 
            this.panelSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSummary.Controls.Add(this.tableLayoutPanel3);
            this.panelSummary.Controls.Add(this.tableLayoutPanel2);
            this.panelSummary.Controls.Add(this.tableLayoutPanel1);
            this.panelSummary.Controls.Add(this.label7);
            this.panelSummary.Controls.Add(this.label6);
            this.panelSummary.Controls.Add(this.label1);
            this.panelSummary.Controls.Add(this.label5);
            this.panelSummary.Location = new System.Drawing.Point(569, 4);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(257, 363);
            this.panelSummary.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.85F));
            this.tableLayoutPanel3.Controls.Add(this.lblAllMV, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblAllWeight, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblAllNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 285);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 80);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 26);
            this.label14.TabIndex = 10;
            this.label14.Text = "Number:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Location = new System.Drawing.Point(3, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 26);
            this.label15.TabIndex = 11;
            this.label15.Text = "Weight:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Location = new System.Drawing.Point(3, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 28);
            this.label16.TabIndex = 12;
            this.label16.Text = "Market Value";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.85F));
            this.tableLayoutPanel2.Controls.Add(this.lblBondMV, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBondWeight, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblBondNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 170);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(183, 80);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 26);
            this.label11.TabIndex = 10;
            this.label11.Text = "Number:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(3, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 26);
            this.label12.TabIndex = 11;
            this.label12.Text = "Weight:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Location = new System.Drawing.Point(3, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "Market Value";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.14754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.85246F));
            this.tableLayoutPanel1.Controls.Add(this.lblEquityMV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEquityWeight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEquityNumber, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(183, 80);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 26);
            this.label8.TabIndex = 10;
            this.label8.Text = "Number:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 26);
            this.label9.TabIndex = 11;
            this.label9.Text = "Weight:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(3, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "Market Value";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "All";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bond";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Equity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(17, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fund Summary";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEquityNumber
            // 
            this.lblEquityNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEquityNumber.Location = new System.Drawing.Point(60, 0);
            this.lblEquityNumber.Name = "lblEquityNumber";
            this.lblEquityNumber.Size = new System.Drawing.Size(71, 26);
            this.lblEquityNumber.TabIndex = 13;
            this.lblEquityNumber.Text = "label17";
            this.lblEquityNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEquityWeight
            // 
            this.lblEquityWeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEquityWeight.Location = new System.Drawing.Point(60, 26);
            this.lblEquityWeight.Name = "lblEquityWeight";
            this.lblEquityWeight.Size = new System.Drawing.Size(71, 26);
            this.lblEquityWeight.TabIndex = 14;
            this.lblEquityWeight.Text = "label17";
            this.lblEquityWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEquityMV
            // 
            this.lblEquityMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEquityMV.Location = new System.Drawing.Point(60, 52);
            this.lblEquityMV.Name = "lblEquityMV";
            this.lblEquityMV.Size = new System.Drawing.Size(71, 28);
            this.lblEquityMV.TabIndex = 15;
            this.lblEquityMV.Text = "label17";
            this.lblEquityMV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBondMV
            // 
            this.lblBondMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBondMV.Location = new System.Drawing.Point(60, 52);
            this.lblBondMV.Name = "lblBondMV";
            this.lblBondMV.Size = new System.Drawing.Size(71, 28);
            this.lblBondMV.TabIndex = 18;
            this.lblBondMV.Text = "lblBondMV";
            this.lblBondMV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBondWeight
            // 
            this.lblBondWeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBondWeight.Location = new System.Drawing.Point(60, 26);
            this.lblBondWeight.Name = "lblBondWeight";
            this.lblBondWeight.Size = new System.Drawing.Size(71, 26);
            this.lblBondWeight.TabIndex = 17;
            this.lblBondWeight.Text = "lblBondWeight";
            this.lblBondWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBondNumber
            // 
            this.lblBondNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBondNumber.Location = new System.Drawing.Point(60, 0);
            this.lblBondNumber.Name = "lblBondNumber";
            this.lblBondNumber.Size = new System.Drawing.Size(71, 26);
            this.lblBondNumber.TabIndex = 16;
            this.lblBondNumber.Text = "label17";
            this.lblBondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllMV
            // 
            this.lblAllMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAllMV.Location = new System.Drawing.Point(60, 52);
            this.lblAllMV.Name = "lblAllMV";
            this.lblAllMV.Size = new System.Drawing.Size(71, 28);
            this.lblAllMV.TabIndex = 21;
            this.lblAllMV.Text = "label17";
            this.lblAllMV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllWeight
            // 
            this.lblAllWeight.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAllWeight.Location = new System.Drawing.Point(60, 26);
            this.lblAllWeight.Name = "lblAllWeight";
            this.lblAllWeight.Size = new System.Drawing.Size(71, 26);
            this.lblAllWeight.TabIndex = 20;
            this.lblAllWeight.Text = "label18";
            this.lblAllWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAllNumber
            // 
            this.lblAllNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAllNumber.Location = new System.Drawing.Point(60, 0);
            this.lblAllNumber.Name = "lblAllNumber";
            this.lblAllNumber.Size = new System.Drawing.Size(71, 26);
            this.lblAllNumber.TabIndex = 19;
            this.lblAllNumber.Text = "label17";
            this.lblAllNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colStockType
            // 
            this.colStockType.DataPropertyName = "Type";
            this.colStockType.HeaderText = "Stock Type";
            this.colStockType.Name = "colStockType";
            this.colStockType.ReadOnly = true;
            this.colStockType.Width = 65;
            // 
            // colStockName
            // 
            this.colStockName.DataPropertyName = "Name";
            this.colStockName.HeaderText = "Stock Name";
            this.colStockName.Name = "colStockName";
            this.colStockName.ReadOnly = true;
            this.colStockName.Width = 65;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 62;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 80;
            // 
            // colMarketValue
            // 
            this.colMarketValue.DataPropertyName = "MarketValue";
            this.colMarketValue.HeaderText = "Market Value";
            this.colMarketValue.Name = "colMarketValue";
            this.colMarketValue.ReadOnly = true;
            this.colMarketValue.Width = 80;
            // 
            // colTransactionCost
            // 
            this.colTransactionCost.DataPropertyName = "TransactionCost";
            this.colTransactionCost.HeaderText = "Transaction Cost";
            this.colTransactionCost.Name = "colTransactionCost";
            this.colTransactionCost.ReadOnly = true;
            this.colTransactionCost.Width = 70;
            // 
            // colStockWeight
            // 
            this.colStockWeight.DataPropertyName = "StockWeight";
            dataGridViewCellStyle1.Format = "p";
            this.colStockWeight.DefaultCellStyle = dataGridViewCellStyle1;
            this.colStockWeight.HeaderText = "Stock Weight";
            this.colStockWeight.Name = "colStockWeight";
            this.colStockWeight.ReadOnly = true;
            this.colStockWeight.Width = 80;
            // 
            // AssetManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 379);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelNewStock);
            this.Name = "AssetManagerForm";
            this.Text = "Fund Asset Manager";
            this.panelNewStock.ResumeLayout(false);
            this.panelNewStock.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStocks)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewStock;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.DataGridView dataGridStocks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox cbAssetType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEquityNumber;
        private System.Windows.Forms.Label lblEquityWeight;
        private System.Windows.Forms.Label lblEquityMV;
        private System.Windows.Forms.Label lblBondMV;
        private System.Windows.Forms.Label lblBondWeight;
        private System.Windows.Forms.Label lblBondNumber;
        private System.Windows.Forms.Label lblAllMV;
        private System.Windows.Forms.Label lblAllWeight;
        private System.Windows.Forms.Label lblAllNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockType;
    }
}

