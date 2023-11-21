using BuisnessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Denne side er meget kopieret fra Create vinduet med lidt ændringer
namespace ItemUI.Views
{
    public partial class UpdatePage : Form
    {
        // vi initiere det samme som i create, men her gemmer vi også ID fordi det er hvad vi loader data på
        ItemBL db = new ItemBL();
        Form Detailed;
        int id;
        Item item;
        bool nameIsValid = true;
        bool DescriptionIsValid = true;
        bool stockIsValid = true;
        bool purchasePriceIsValid = true;
        bool profitIsValid = true;

        public UpdatePage(Form f1, int id)
        {
            // Her henter vi og sætter op med de allerede eksiterende værdier i databasen og derfor er alting true og klar til at opdatere fordi det er lovlige værdier
            this.Detailed = f1;
            this.id = id;
            this.item = db.Get(id);
            InitializeComponent();
            this.Text = $"Updating: {this.item.Name}";
            Setup(item);
            
            //Disse funktioner er identiske med dem i Create da de gør det samme
            txtName.TextChanged += TxtNameChanged;
            txtDescription.TextChanged += TxtDescriptionChanged;
            txtStock.TextChanged += TxtStockChanged;
            txtPurchasePrice.TextChanged += TxtPurchasePriceChanged;
            txtProfit.TextChanged += TxtProfitChanged;
        }

        // her sætter vi alt omvendt og henter data ind fra vores loaded item

        private void Setup(Item item)
        {
            lblName.ForeColor = Color.Green;
            lblDescription.ForeColor = Color.Green;
            lblStock.ForeColor = Color.Green;
            lblPurchasePrice.ForeColor = Color.Green;
            lblProfit.ForeColor = Color.Green;

            txtName.Text = item.Name;
            txtDescription.Text = item.Description;
            txtStock.Text = item.Stock.ToString();
            txtPurchasePrice.Text = item.PurchasePrice.ToString();
            txtProfit.Text = item.Profit.ToString();

        }


        private void TxtNameChanged(object? sender, EventArgs e)
        {
            string name = txtName.Text;

            if (name.Length > 2 && name.Length < 50)
            {
                lblName.ForeColor = Color.Green;
                this.nameIsValid = true;
                EnableCreateBotton();
            }
            else
            {
                lblName.ForeColor = System.Drawing.Color.Red;
                this.nameIsValid = false;
                EnableCreateBotton();
            }
        }


        private void TxtDescriptionChanged(object? sender, EventArgs e)
        {
            string description = txtDescription.Text;

            if (description.Length > 5 && description.Length < 150)
            {
                lblDescription.ForeColor = Color.Green;
                this.DescriptionIsValid = true;
                EnableCreateBotton();
            }
            else
            {
                lblDescription.ForeColor = Color.Red;
                this.DescriptionIsValid = false;
                EnableCreateBotton();

            }
        }
        private void TxtStockChanged(object? sender, EventArgs e)
        {
            string stocktxt = txtStock.Text;
            int stock;
            bool isInt = int.TryParse(stocktxt, out stock);
            if (isInt && stock >= 0)
            {
                lblStock.ForeColor = Color.Green;
                this.stockIsValid = true;
                EnableCreateBotton();
            }
            else
            {
                lblStock.ForeColor = Color.Red;
                this.stockIsValid = false;
                EnableCreateBotton();
            }
        }
        private void TxtPurchasePriceChanged(object? sender, EventArgs e)
        {
            bool isdouble = double.TryParse(txtPurchasePrice.Text, out double price);

            if (isdouble && price >= 0)
            {
                lblPurchasePrice.ForeColor = Color.Green;
                this.purchasePriceIsValid = true;
                EnableCreateBotton();
            }
            else
            {
                lblPurchasePrice.ForeColor = Color.Red;
                this.purchasePriceIsValid = false;
                EnableCreateBotton();
            }
        }

        private void TxtProfitChanged(object? sender, EventArgs e)
        {

            bool isdouble = double.TryParse(txtProfit.Text, out double profit);

            if (isdouble && profit >= 0)
            {
                lblProfit.ForeColor = Color.Green;
                this.profitIsValid = true;
                EnableCreateBotton();
            }
            else
            {
                lblProfit.ForeColor = Color.Red;
                this.profitIsValid = false;
                EnableCreateBotton();
            }
        }

        //igen komplet kopi
        private void EnableCreateBotton()
        {
            if (this.nameIsValid && this.DescriptionIsValid && stockIsValid && purchasePriceIsValid && purchasePriceIsValid && profitIsValid)
            {
                btnUpdateItem.Enabled = true;
            }
            else
            {
                btnUpdateItem.Enabled = false;
            }
        }

        //back knappen virker som tidligere back knapper
        private void btnNavToDetailed_Click(object sender, EventArgs e)
        {
            this.Close();
            Detailed.Show();
        }
        // samme override mod hardclosing
        protected override void OnClosing(CancelEventArgs e)
        {
            Detailed.Show();
            base.OnClosing(e);
        }
        //Updateknappen gemmer de nye værdier som igen er validerede men i det oprindelige Item så vi beholder ID da DA opdatere på ID
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            this.item.Name = txtName.Text;
            this.item.Description = txtDescription.Text;
            this.item.Stock = int.Parse(txtStock.Text);
            this.item.PurchasePrice = double.Parse(txtPurchasePrice.Text);
            this.item.Profit = double.Parse(txtProfit.Text);

            // ved succefull opdatering lukker vi opdate ned
            if (db.Update(this.item))
            {
                MessageBox.Show("Updated succesfully");
                this.Close();
                Detailed.Show();
            }



        }
    }
}
