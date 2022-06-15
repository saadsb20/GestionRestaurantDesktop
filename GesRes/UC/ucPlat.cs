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
    public partial class ucPlat : UserControl
    {
        public int Code_Plat { get;set; }
        public string Libelle { get;set; }
        public string Type_Plat { get;set; }
        public int Prix { get;set; }
        PlatsForm PlatsForm = new PlatsForm();
        Data data = new Data();
        public ucPlat(PlatsForm platsForm)
        {
            InitializeComponent();
            this.PlatsForm = platsForm;
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            data.DeletePlat(Code_Plat);
            this.PlatsForm.PlatsForm_Load(sender, e);
            MessageBox.Show("Plat Deleted Successfully");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.PlatsForm.ShowUpdateButton(Code_Plat, Libelle, Type_Plat,Prix);
        }

        private void ucPlat_Load(object sender, EventArgs e)
        {
            this.LibelleLabel.Text = Libelle;
            this.Type_Plat_Label.Text = Type_Plat;
            this.PrixLabel.Text = Prix.ToString() ;
        }
    }
}
