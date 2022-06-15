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
    public partial class CommandesForm : Form
    {
        List<Table> Tables = new List<Table>();
        List<Commande> Commandes = new List<Commande>();
        List<Contient> Contients = new List<Contient>(); 
        List<Plat> Plats = new List<Plat>(); 
        Data data = new Data();
        public int Num_Com { get; set; }
        List<string> ModesPay = new List<string>();
        public CommandesForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(btnSubmit.Text == "Enregistrer")
            {
                Commande commande = new Commande(int.Parse(TablecomboBox.SelectedItem.ToString()),DateTime.Now,int.Parse(Nbr_Pers_textBox.Text.ToString()),DateTime.Now,Mod_Pay_comboBox.SelectedItem.ToString());
                data.AddCommande(commande);
                this.CommandesForm_Load(sender,e);
                MessageBox.Show("Commande added Successsfully");
            }
        }


        public void ShowCommandes()
        {
            Commandes.Clear();
            CommandesListpanel.Controls.Clear();
            Commandes = data.SelectCommandes();
            int y = 0;
            foreach (Commande commande in Commandes)
            {
                ucCommande c = new ucCommande(this);
                c.Num_Table = commande.Num_Table;
                c.Nb_Pers = commande.Nb_Pers;
                c.Heure_Pay = commande.Heure_Pay;
                c.Date_Com  = commande.Date_Com;
                c.Mode_Pay = commande.Mode_Pay;
                c.Num_Com = commande.Num_Com;
                c.Location = new System.Drawing.Point(1, 1 + y);
                this.CommandesListpanel.Controls.Add(c);
                y += c.Height + 10;
            }
        }

        public void ShowContients(int Num_Com)
        {
            Contients.Clear();
            ContientListpanel.Controls.Clear();
            Contients = data.SelectContient(Num_Com);
            int y = 0;
            int PrixCommande = 0;
            foreach (Contient contient in Contients)
            {
                ucContient c = new ucContient();
                c.Qte = contient.Qte;
                c.Code_Plat = contient.Code_Plat;
                c.Num_Com = contient.Num_Com;
                c.Location = new System.Drawing.Point(1, 1 + y);
                this.ContientListpanel.Controls.Add(c);
                y += c.Height + 10;
                PrixCommande += data.SelectOnePlat(contient.Code_Plat).Prix * contient.Qte;
                Console.WriteLine("QTE CONTIENT " + contient.Qte);
                Console.WriteLine("PRIX PLAT CONTIENT " + data.SelectOnePlat(contient.Code_Plat).Prix);
            }
            this.PrixLabel.Text = PrixCommande.ToString(); 
        }

        private void CommandesForm_Load(object sender, EventArgs e)
        {
            ModesPay.Add("Espèce");
            ModesPay.Add("Carte Bancaire");
            ModesPay.Add("Bon d'Achat");
            this.Tables.Clear();
            this.Tables = data.SelectTables();
            Plats = data.SelectPlats();
            foreach (Table table in Tables)
            {
                this.TablecomboBox.Items.Add(table.Num_Table);
            }
            foreach(string mode in ModesPay)
            {
                this.Mod_Pay_comboBox.Items.Add(mode);
            }
            foreach(Plat plat in Plats)
            {
                this.PlatcomboBox.Items.Add(plat.Code_Plat);
            }
            
            ShowCommandes();
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            if (btnSubmit2.Text == "Enregistrer")
            {
                Contient contient= new Contient(Num_Com,int.Parse(PlatcomboBox.SelectedItem.ToString()),int.Parse(QuantiteTextBox.Text.ToString()));
                data.AddContient(contient);
                MessageBox.Show("Added Successsfully");
                ShowContients(Num_Com);
            }
        }
    }
}
