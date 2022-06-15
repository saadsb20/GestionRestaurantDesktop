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
    public partial class TablesForm : Form
    {
        Data data = new Data();
        List<Table> tables = new List<Table>();
        int TableToUpdate { get; set; }
        Accueil Accueil = new Accueil();
        public TablesForm(Accueil accueil)
        {
            InitializeComponent();
            this.Accueil = accueil;
        }

        private void TablesFormpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void TablesForm_Load(object sender, EventArgs e)
        {
            UpdatePanel.Visible = false;
            TablesFormpanel.Location = new Point(27, 200);
            TablesFormpanel.Visible = true;
            tables.Clear();
            this.TablesListpanel.Controls.Clear();
            ShowTables();
        }
        public void ShowUpdateForm(int id_table)
        {
            TablesFormpanel.Visible = false;
            UpdatePanel.Location = new Point(27, 180);
            UpdatePanel.Visible = true;
            this.TableToUpdate = id_table;
            NmTableLabel.Text = id_table.ToString();
            Console.WriteLine("Table to Update : " + this.TableToUpdate);
        }

        public void ShowTables()
        {
            tables = data.SelectTables();
            int y = 0;
            foreach (Table table in tables)
            {
                ucTable t = new ucTable(this);
                t.NUm_Table = table.Num_Table;
                t.Nb_Place= table.Nb_Place;
                t.Location = new System.Drawing.Point(1, 1 + y);
                this.TablesListpanel.Controls.Add(t);
                y += t.Height + 10;
            }
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            if (TablesTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le nombre de Places");
                return;
            }
            if(btnSubmit.Text == "Enregistrer")
            {
                Table table = new Table(int.Parse(TablesTextBox.Text.Trim()));
                data.AddTable(table);
                MessageBox.Show("Table Added Successfully");
                TablesTextBox.Clear();
                this.TablesForm_Load(sender,e);
                this.Accueil.Form1_Load(sender, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TablesListpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdatetextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Entrer le nombre de Places");
                return;
            }
            if (btnUpdate.Text == "Enregistrer")
            {
                data.UpdateTable(this.TableToUpdate, int.Parse(UpdatetextBox.Text.Trim()));
                MessageBox.Show("Table Updated Successfully");
                UpdatetextBox.Clear();
                this.TablesForm_Load(sender, e);
            }
            
        }
    }
}
