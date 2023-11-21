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

namespace ItemUI.Views
{
    public partial class CreatePage : Form
    {

        // opretter instans af mit BL, starter en form og laver bools for alle værdier er falske fordi felterne er tomme
        ItemBL db = new ItemBL();
        Form main;
        bool nameIsValid = false;
        bool DescriptionIsValid = false;
        bool stockIsValid = false;
        bool purchasePriceIsValid = false;
        bool profitIsValid = false;

        public CreatePage(Form f1)
        {   
            
            this.main = f1;
            InitializeComponent();
            //Her disabler jeg createKnappen
            btnCreateItem.Enabled = false;
            //her sætter jeg alle labels til rød så man kan se om man har tastet korrekt
            SetLabelColor();
            this.Text = "Add new Liqour";
            // starter events for samtlige tekstfelter hvis de ændre sig
            txtName.TextChanged += TxtNameChanged;
            txtDescription.TextChanged += TxtDescriptionChanged;
            txtStock.TextChanged += TxtStockChanged;
            txtPurchasePrice.TextChanged += TxtPurchasePriceChanged;
            txtProfit.TextChanged += TxtProfitChanged;
        }

        private void SetLabelColor()
        {
            lblName.ForeColor = Color.Red;
            lblDescription.ForeColor = Color.Red;
            lblStock.ForeColor = Color.Red;
            lblPurchasePrice.ForeColor = Color.Red;
            lblProfit.ForeColor = Color.Red;

        }
        // jeg gennemgår en af metoderne fordi de minder enormt om hinanden
        private void TxtNameChanged(object? sender, EventArgs e)
        {
            //gemmer værdien i tekstfeltet
            string name = txtName.Text;
            // kontrollere om det overholder mine opsatte kriterier
            if (name.Length > 2 && name.Length < 50)
            {
                //hvis den gør så sætter jeg label farve til grøn og siger nu min bool for name is valid
                lblName.ForeColor = Color.Green;
                this.nameIsValid = true;
                //her ser jeg om alle bool (alle tekstfelter) er valide og hvis de er enabler jeg knappen)
                EnableCreateBotton();
            }
            else
            {
                //omvendt så hvis du ændre i feltet så det ikke længere er validt så skal den gøre det hele bare modsat
                // Jeg kan stadig kalde samme funktion fordi den tester på om alle bools er true
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




        // simple metode der bare tester for om alle Bools er true så enabler den knappen ellers sætter den som disabled
        private void EnableCreateBotton()
        {
            if (this.nameIsValid && this.DescriptionIsValid && stockIsValid && purchasePriceIsValid && purchasePriceIsValid && profitIsValid)
            {
                btnCreateItem.Enabled = true;
            }
            else
            {
                btnCreateItem.Enabled = false;
            }
        }

        //Knappen der sender dig tilbage til main lukker bare formen og viser main frem igen
        private void btnNavToMain_Click(object sender, EventArgs e)
        {
            this.Close();

            main.Show();
        }

        // her er override af closing så den opfører sig som hvis du klikkede på back to main knappen eller lukker formen ned ved alt+f4
        protected override void OnClosing(CancelEventArgs e)
        {
            main.Show();
            base.OnClosing(e);
        }

        // hvis vi klikker på create knappen så ved vi at alle inputs er valide og har tjekket om de kan parses til respektive værdier
        private void btnCreateItem_Click(object sender, EventArgs e)
        {
            //laver et item hvor jeg læser de respektive felter ind i mit Item. Jeg bruger bare parse funktioner fordi valideringen sikre at de kan parses
            Item item = new Item();
            item.Name = txtName.Text;
            item.Description = txtDescription.Text;
            item.Stock = int.Parse(txtStock.Text);
            item.PurchasePrice = double.Parse(txtPurchasePrice.Text);
            item.Profit = double.Parse(txtProfit.Text);
            
            //her kalder jeg min BL som returnere en bool hvis Create(item) lykkedes
            if (db.Create(item))
            {
                //Dette kaster en messageBox der fortæller det lykkedes at tilføje et item og så spørger den om du vil tilføje flere
                DialogResult result = MessageBox.Show("It was a succes do you want to add more items", "More?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                //hvis man vil tilføje flere så sætter den alle tekstbokse tomme og går tilbage til formen
                if (result == DialogResult.Yes)
                {
                    txtName.Text = string.Empty;
                    txtDescription.Text = string.Empty;
                    txtStock.Text = string.Empty;
                    txtPurchasePrice.Text = string.Empty;
                    txtProfit.Text = string.Empty;

                }
                else
                {
                    //ellers lukker vi den og viser main igen
                    this.Close();
                    main.Show();
                }


            }
        }
    }
}
