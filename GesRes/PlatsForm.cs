using GesRes.Models;
using GesRes.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesRes
{
    public partial class PlatsForm : Form
    {
        Data data = new Data();
        List<Plat> plats = new List<Plat>();
        int PlatToUpdate { get; set; }
        public PlatsForm()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (LibelleTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Libelle du Plat");
                return;
            }
            if (Type_PlatTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Type du Plat");
                return;
            }
            if (PrixTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Prix du Plat");
                return;
            }
            if (btnUpdate.Text == "Modifier")
            {
                data.UpdatePlat(PlatToUpdate, LibelleTextBox.Text.Trim(), Type_PlatTextBox.Text.Trim(), int.Parse(PrixTextBox.Text.Trim()));
                MessageBox.Show("Plat Updated Successfully");
                LibelleTextBox.Clear();
                Type_PlatTextBox.Clear();
                PrixTextBox.Clear();
                this.PlatsForm_Load(sender, e);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (LibelleTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Libelle du Plat");
                return;
            }
            if (Type_PlatTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Type du Plat");
                return;
            }
            if (PrixTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Prix du Plat");
                return;
            }
            if (btnSubmit.Text == "Enregistrer")
            {
                Plat plat = new Plat(LibelleTextBox.Text.Trim(), Type_PlatTextBox.Text.Trim(), int.Parse(PrixTextBox.Text.Trim()));
                data.AddPlat(plat);
                MessageBox.Show("Plat Added Successfully");
                LibelleTextBox.Clear();
                Type_PlatTextBox.Clear();
                PrixTextBox.Clear();
                this.PlatsForm_Load(sender, e);
            }
        }

        public void PlatsForm_Load(object sender, EventArgs e)
        {
            this.btnUpdate.Visible = false;
            this.btnSubmit.Visible = true;
            plats.Clear();
            this.PlatsListpanel.Controls.Clear();
            ShowPlats();
        }
        public void ShowPlats()
        {
            plats = data.SelectPlats();
            int y = 0;
            foreach (Plat plat in plats)
            {
                ucPlat p = new ucPlat(this);
                p.Code_Plat = plat.Code_Plat;
                p.Type_Plat = plat.Type_Plat;
                p.Libelle = plat.Libelle;
                p.Prix = plat.Prix;
                p.Location = new System.Drawing.Point(1, 1 + y);
                this.PlatsListpanel.Controls.Add(p);
                y += p.Height + 10;
            }
        }
        public void ShowUpdateButton(int Code_plat, string Libelle, string Type_Plat, int Prix)
        {
            this.btnSubmit.Visible = false;
            this.btnUpdate.Visible = true;
            this.LibelleTextBox.Text = Libelle;
            this.Type_PlatTextBox.Text = Type_Plat;
            this.PrixTextBox.Text = Prix.ToString();
            this.PlatToUpdate = Code_plat;
        }
    }
}
