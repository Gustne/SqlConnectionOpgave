namespace ItemUI.Views
{
    partial class DetailedPage
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
            dgvDetail = new DataGridView();
            btnNavToMain = new Button();
            button1 = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvDetail
            // 
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(21, 192);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.RowTemplate.Height = 29;
            dgvDetail.Size = new Size(739, 87);
            dgvDetail.TabIndex = 0;
            // 
            // btnNavToMain
            // 
            btnNavToMain.Location = new Point(613, 341);
            btnNavToMain.Name = "btnNavToMain";
            btnNavToMain.Size = new Size(120, 52);
            btnNavToMain.TabIndex = 1;
            btnNavToMain.Text = "Go back to main";
            btnNavToMain.UseVisualStyleBackColor = true;
            btnNavToMain.Click += btnNavToMain_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 341);
            button1.Name = "button1";
            button1.Size = new Size(176, 52);
            button1.TabIndex = 2;
            button1.Text = "Delete this entry and go back to main";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(326, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(163, 52);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update values";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdateClick;
            // 
            // DetailedPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Controls.Add(btnNavToMain);
            Controls.Add(dgvDetail);
            Name = "DetailedPage";
            Text = "DetailedPagecs";
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDetail;
        private Button btnNavToMain;
        private Button button1;
        private Button btnUpdate;
    }
}