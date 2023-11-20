namespace ItemUI.Views
{
    partial class UpdatePage
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
            txtProfit = new TextBox();
            txtPurchasePrice = new TextBox();
            txtStock = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblProfit = new Label();
            lblPurchasePrice = new Label();
            lblStock = new Label();
            lblDescription = new Label();
            lblName = new Label();
            btnNavToDetailed = new Button();
            btnUpdateItem = new Button();
            SuspendLayout();
            // 
            // txtProfit
            // 
            txtProfit.Location = new Point(10, 325);
            txtProfit.Name = "txtProfit";
            txtProfit.Size = new Size(125, 27);
            txtProfit.TabIndex = 20;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(10, 259);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(125, 27);
            txtPurchasePrice.TabIndex = 19;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(12, 193);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 18;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 128);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 17;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 16;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Location = new Point(10, 302);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(45, 20);
            lblProfit.TabIndex = 15;
            lblProfit.Text = "Profit";
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Location = new Point(10, 223);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(104, 20);
            lblPurchasePrice.TabIndex = 14;
            lblPurchasePrice.Text = "Purchase price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 158);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 100);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 11;
            lblName.Text = "Name";
            // 
            // btnNavToDetailed
            // 
            btnNavToDetailed.Location = new Point(616, 320);
            btnNavToDetailed.Name = "btnNavToDetailed";
            btnNavToDetailed.Size = new Size(135, 58);
            btnNavToDetailed.TabIndex = 22;
            btnNavToDetailed.Text = "Go back to Detailed view";
            btnNavToDetailed.UseVisualStyleBackColor = true;
            btnNavToDetailed.Click += btnNavToDetailed_Click;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(616, 32);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(135, 64);
            btnUpdateItem.TabIndex = 21;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // UpdatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNavToDetailed);
            Controls.Add(btnUpdateItem);
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
            Name = "UpdatePage";
            Text = "UpdatePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProfit;
        private TextBox txtPurchasePrice;
        private TextBox txtStock;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblProfit;
        private Label lblPurchasePrice;
        private Label lblStock;
        private Label lblDescription;
        private Label lblName;
        private Button btnNavToDetailed;
        private Button btnUpdateItem;
    }
}