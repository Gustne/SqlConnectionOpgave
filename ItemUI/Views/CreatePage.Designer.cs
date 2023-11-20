namespace ItemUI.Views
{
    partial class CreatePage
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
            btnCreateItem = new Button();
            lblName = new Label();
            lblDescription = new Label();
            lblStock = new Label();
            lblPurchasePrice = new Label();
            lblProfit = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtStock = new TextBox();
            txtPurchasePrice = new TextBox();
            txtProfit = new TextBox();
            btnNavToMain = new Button();
            SuspendLayout();
            // 
            // btnCreateItem
            // 
            btnCreateItem.Location = new Point(640, 36);
            btnCreateItem.Name = "btnCreateItem";
            btnCreateItem.Size = new Size(135, 64);
            btnCreateItem.TabIndex = 0;
            btnCreateItem.Text = "Add item to inventory";
            btnCreateItem.UseVisualStyleBackColor = true;
            btnCreateItem.Click += btnCreateItem_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 99);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(20, 157);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Location = new Point(18, 222);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(104, 20);
            lblPurchasePrice.TabIndex = 4;
            lblPurchasePrice.Text = "Purchase price";
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Location = new Point(18, 301);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(45, 20);
            lblProfit.TabIndex = 5;
            lblProfit.Text = "Profit";
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 127);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(20, 192);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 8;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(18, 258);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(125, 27);
            txtPurchasePrice.TabIndex = 9;
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(18, 324);
            txtProfit.Name = "txtProfit";
            txtProfit.Size = new Size(125, 27);
            txtProfit.TabIndex = 10;
            // 
            // btnNavToMain
            // 
            btnNavToMain.Location = new Point(640, 324);
            btnNavToMain.Name = "btnNavToMain";
            btnNavToMain.Size = new Size(135, 58);
            btnNavToMain.TabIndex = 11;
            btnNavToMain.Text = "Go back to main page";
            btnNavToMain.UseVisualStyleBackColor = true;
            btnNavToMain.Click += btnNavToMain_Click;
            // 
            // CreatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNavToMain);
            Controls.Add(txtProfit);
            Controls.Add(txtPurchasePrice);
            Controls.Add(txtStock);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblProfit);
            Controls.Add(lblPurchasePrice);
            Controls.Add(lblStock);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(btnCreateItem);
            Name = "CreatePage";
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateItem;
        private Label lblName;
        private Label lblDescription;
        private Label lblStock;
        private Label lblPurchasePrice;
        private Label lblProfit;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtStock;
        private TextBox txtPurchasePrice;
        private TextBox txtProfit;
        private Button btnNavToMain;
    }
}