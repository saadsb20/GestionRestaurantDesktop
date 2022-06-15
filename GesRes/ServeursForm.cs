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
    public partial class ServeursForm : Form
    {
        Data data = new Data();
        List<Serveur> serveurs = new List<Serveur>(); 
        int ServeurToUpdate { get; set; }
        Accueil Accueil = new Accueil();
        public ServeursForm(Accueil accueil)
        {
            InitializeComponent();
            this.Accueil = accueil;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NomTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Nom du Serveur");
                return;
            }
            if (PrenomTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Prenom du Serveur");
                return;
            }
            if (btnUpdate.Text == "Modifier")
            {
                data.UpdateServeur(ServeurToUpdate, NomTextBox.Text.Trim(), PrenomTextBox.Text.Trim());
                MessageBox.Show("Serveur Updated Successfully");
                NomTextBox.Clear();
                PrenomTextBox.Clear();
                this.ServeursForm_Load(sender, e);
                this.Accueil.Form1_Load(sender, e);
            }
        }
        public void ShowUpdateButton(int Num_Serv, string nom,string prenom)
        {
            this.btnSubmit.Visible = false;
            this.btnUpdate.Visible = true;
            this.NomTextBox.Text = nom;
            this.PrenomTextBox.Text = prenom;
            this.ServeurToUpdate = Num_Serv;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (NomTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Nom du Serveur");
                return;
            }
            if (PrenomTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le Prenom du Serveur");
                return;
            }
            if (btnSubmit.Text == "Enregistrer")
            {
                Serveur serveur = new Serveur(NomTextBox.Text.Trim(), PrenomTextBox.Text.Trim());
                data.AddServeur(serveur);
                MessageBox.Show("Serveur Added Successfully");
                NomTextBox.Clear();
                PrenomTextBox.Clear();
                this.ServeursForm_Load(sender, e);
                this.Accueil.Form1_Load(sender, e);
            }
        }
        public void ShowServeurs()
        {
            serveurs = data.SelectServeurs();
            int y = 0;
            foreach (Serveur serveur in serveurs)
            {
                ucServeur s = new ucServeur(this);
                s.Nom = serveur.Nom;
                s.Prenom = serveur.Prenom;
                s.Num_Serv = serveur.Num_Serv;
                s.Location = new System.Drawing.Point(1, 1 + y);
                this.ServeursListpanel.Controls.Add(s);
                y += s.Height + 10;
            }
        }

        public void ServeursForm_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
            serveurs.Clear();
            this.ServeursListpanel.Controls.Clear();
            ShowServeurs();
        }
    }
}
