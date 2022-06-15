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
    public partial class Accueil : Form
    {
        List<Serveur> serveurs = new List<Serveur>();
        List<Table> tables = new List<Table>();
        List<Affecter> Affecters = new List<Affecter>();
        Data data = new Data();

        public Accueil()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.serveurs.Clear();
            this.tables.Clear();
            this.ServeurcomboBox.Items.Clear();
            this.TablecomboBox.Items.Clear();
            ShowAffecters();
            this.serveurs = data.SelectServeurs();
            this.tables = data.SelectTables();
            foreach(Serveur serveur in serveurs)
            {
                this.ServeurcomboBox.Items.Add(serveur.Num_Serv);

            }
            foreach(Table table in tables)
            {
                this.TablecomboBox.Items.Add(table.Num_Table);

            }


        }
        public void TablePanel_Click(object sender, EventArgs e)
        {
            TablesForm tablesForm = new TablesForm(this);
            tablesForm.Visible = true;
        }
        public void CommandePanel_Click(object sender, EventArgs e)
        {
            CommandesForm commandesForm = new CommandesForm();
            commandesForm.Visible = true;
        }
        public void ServeurPanel_Click(object sender, EventArgs e)
        {
            ServeursForm serveursForm = new ServeursForm(this);
            serveursForm.Visible = true;
        }   
        public void PlatPanel_Click(object sender, EventArgs e)
        {
            PlatsForm platsForm = new PlatsForm();
            platsForm.Visible = true;
        }
        private void btnAffecter_Click(object sender, EventArgs e)
        {
            Affecter affecter = new Affecter(int.Parse(ServeurcomboBox.SelectedItem.ToString()),int.Parse(TablecomboBox.SelectedItem.ToString()),DateTime.Now);
            data.AddAffecter(affecter);
            MessageBox.Show("Table : " + TablecomboBox.SelectedItem.ToString() + " Serveur : " + ServeurcomboBox.SelectedIndex.ToString());
            Form1_Load(sender, e);
        }

        public void ShowAffecters()
        {
            Affecters.Clear();
            AffectationsPanel.Controls.Clear();
            Affecters = data.SelectAffecters();
            int y = 0;
            foreach (Affecter affecter in Affecters)
            {
                ucAffecter a = new ucAffecter(this);
                a.Num_Serveur = affecter.Num_Serveur;
                a.Num_Table = affecter.Num_Table;
                a.Date_Affect = affecter.Date_Affect;
                a.Location = new System.Drawing.Point(1, 1 + y);
                this.AffectationsPanel.Controls.Add(a);
                y += a.Height + 10;
            }
        }

        private void ServeurcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TablecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
