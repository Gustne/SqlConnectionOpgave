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
    public partial class Mainpage : Form
    {   
        // kalder mit BL og initiere en liste
        ItemBL db = new ItemBL();
        List<Item> items = new List<Item>();
        public Mainpage()
        {
            //initialize er det der starter alle elementer i formen og derfor er ændringer efter denne
            InitializeComponent();
            dgvSettings();
            this.Text = "Liqour Store";

        }



        public void dgvSettings()
        {
            //loader data og skjuler nogle kolonner
            this.items = db.Get();
            dgvItems.DataSource = this.items;
            dgvItems.Columns["Id"].Visible = false;
            dgvItems.Columns["PurchasePrice"].Visible = false;
            dgvItems.Columns["Profit"].Visible = false;
            dgvItems.Columns["Sellprice"].Visible = false;

            // sætter så kolonnerne selv sætte size så man kan se hvad der står
            foreach (DataGridViewColumn column in dgvItems.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
            // her lader jeg formen autosize så man altid kan se hele dgv'et
            dgvItems.AutoSize = true;

        }

        // funktion til 2x klik i dgv
        private void DgvDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //finder hvilket row der er tale om i eventet
            DataGridView dgv = (DataGridView)sender;
            int row = e.RowIndex;

            // gemmer pågældende row og finder id'et
            DataGridViewRow temp = dgv.Rows[row];
            int id = (int)temp.Cells["Id"].Value;

            NavToDetails(id);

        }

        private void NavToDetails(int id)
        {
            DetailedPage dp = new DetailedPage(this, id);

            this.Hide();

            dp.Show();
        }

        // her overrider jeg så når main form bliver vist så opdatere den dgv
        protected override void OnVisibleChanged(EventArgs e)
        {
            if (this.Visible)
            {
                //Da jeg måske har opdateret eller slettet noget så opdatere jeg dgv'et datasource og så Refresher jeg det
                dgvItems.DataSource = db.Get();
                dgvItems.Refresh();
            }
            // det er de ting som sker hvis mn ikke overrider som jeg kalder igen
            base.OnVisibleChanged(e);
        }

        // her er eventet hvis du klikker på knappet til at tilføje nye entries
        private void addNewClick(object sender, EventArgs e)
        {
            CreatePage create = new CreatePage(this);

            this.Hide();

            create.Show();
        }
    }
}
