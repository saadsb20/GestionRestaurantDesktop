using GesRes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesRes.UC
{
    public partial class ucTable : UserControl
    {
        public int Nb_Place { get; set; }
        public int NUm_Table { get; set; }
        Data data = new Data();
        TablesForm tablesForm;
        public ucTable(TablesForm tablesForm1)
        {
            InitializeComponent();
            this.tablesForm = tablesForm1;

        }

        private void ucTable_Load(object sender, EventArgs e)
        {
            NbPersLabel.Text = this.Nb_Place.ToString();
            NumeTableLabel.Text = this.NUm_Table.ToString();
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            data.DeleteTable(this.NUm_Table);
            this.tablesForm.TablesForm_Load(sender,e);
            MessageBox.Show("Table Deleted Successfully");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.tablesForm.ShowUpdateForm(this.NUm_Table);
        }
    }
}
