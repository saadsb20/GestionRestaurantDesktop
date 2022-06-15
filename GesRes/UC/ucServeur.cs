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
    public partial class ucServeur : UserControl
    {
        ServeursForm ServeursForm ;
        public int Num_Serv { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        Data data = new Data();
        public ucServeur(ServeursForm serveursForm)
        {
            InitializeComponent();
            this.ServeursForm = serveursForm;
        }

        private void ucServeur_Load(object sender, EventArgs e)
        {
            this.Nom_Label.Text = Nom;
            this.Prenom_Label.Text = Prenom;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.ServeursForm.ShowUpdateButton(Num_Serv,Nom, Prenom);
        }

        private void bntSupprimer_Click(object sender, EventArgs e)
        {
            data.DeleteServeur(Num_Serv);
            this.ServeursForm.ServeursForm_Load(sender, e);
            MessageBox.Show("Serveur Deleted Successfully");
        }
    }
}
