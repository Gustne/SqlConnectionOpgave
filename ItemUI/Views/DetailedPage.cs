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
    public partial class DetailedPage : Form
    {
        //oprette elementer der skal bruges igennem formen
        ItemBL db = new ItemBL();
        Form main;
        int id;
        public DetailedPage(Form f1, int id)
        {
            InitializeComponent();
            this.Text = dgvSettings(id);
            this.main = f1;
            this.id = id;
        }

        public string dgvSettings(int id)
        {
            //henter data fra min database på den id som er blevet markeret i main dgv
            Item item = db.Get(id);
            List<Item> list = new List<Item>();
            list.Add(item);
            //tilføjer den til en liste for at jeg kan lave et dgv
            dgvDetail.DataSource = list;
            //skjuler kun ID her
            dgvDetail.Columns["Id"].Visible = false;

            //Samme ting som i main
            foreach (DataGridViewColumn column in dgvDetail.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dgvDetail.AutoSize = true;

            return item.Name;

        }

        //igen simpel metode der sender dig tilbage til main
        private void btnNavToMain_Click(object sender, EventArgs e)
        {
            this.Close();

            main.Show();
        }

        //Sikre samme opførsel hvis du lukker vinduet so hvis du klikkede på back to main knappen
        protected override void OnClosing(CancelEventArgs e)
        {
            main.Show();
            base.OnClosing(e);
        }

        //Her kalder vi Delete Funktionen
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Vi kalder delete på det item vi er i detailed view på så vi spørger lige om brugeren er sikker
            DialogResult result = MessageBox.Show("Sure you want to Delete this entry", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //hvis der trykkes ja så sletter vi den og hvis det lykkedes går vi tilbage til main ellers fortæller vi det mislykkedes og bliver
                bool DeleteSucces = db.Delete(this.id);
                if (DeleteSucces)
                {

                    MessageBox.Show("Den er nu slettet");

                    this.Close();

                    main.Show();


                }
                else
                {
                    MessageBox.Show("Sletning mislykkedes");
                }
            }
        }

        //igen her kalder vi bare hvis vi klikker på opdatere knappen
        private void btnUpdateClick(object sender, EventArgs e)
        {
            UpdatePage updatePage = new UpdatePage(this, this.id);

            this.Hide();

            updatePage.Show();


        }
        // Her er igen hvad der sker hvis vi viser denne form igen. på samme måde opdatere vi lige data til DGV så hvis du har opdatere værdier kan du se det når du kommer tilbage
        protected override void OnVisibleChanged(EventArgs e)
        {
            if (this.Visible) 
            {
                Item item = db.Get(id);
                List<Item> list = new List<Item>();
                list.Add(item);
                dgvDetail.DataSource = list;
                dgvDetail.Refresh();

            }
            base.OnVisibleChanged(e);
        }
    }
}
