namespace ItemUI.Views
{
    partial class Mainpage
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
            dgvItems = new DataGridView();
            button1 = new Button();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(43, 201);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.RowTemplate.Height = 29;
            dgvItems.Size = new Size(323, 439);
            dgvItems.TabIndex = 0;
            dgvItems.CellDoubleClick += DgvDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(808, 45);
            button1.Name = "button1";
            button1.Size = new Size(163, 63);
            button1.TabIndex = 1;
            button1.Text = "Add a new liqour to the inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addNewClick;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(43, 113);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(459, 20);
            lblInfo.TabIndex = 2;
            lblInfo.Text = "Double click on an item to get more information and update/delete";
            // 
            // Mainpage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 665);
            Controls.Add(lblInfo);
            Controls.Add(button1);
            Controls.Add(dgvItems);
            Name = "Mainpage";
            Text = "Mainpage";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private Button button1;
        private Label lblInfo;
    }
}