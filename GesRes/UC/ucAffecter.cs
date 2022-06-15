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
    public partial class ucAffecter : UserControl
    {
        Accueil Accueil;
        public int Num_Table { get; set; } 
        public int Num_Serveur { get; set; } 
        public DateTime Date_Affect { get; set; }
        Data data = new Data();
        Serveur serveur { get; set; }
        public ucAffecter(Accueil accueil)
        {
            InitializeComponent();
            this.Accueil = accueil;
            
        }

        private void ucAffecter_Load(object sender, EventArgs e)
        {
            this.serveur = data.SelectOneServeur(Num_Serveur);
            this.ServeurLabel.Text = this.serveur.Prenom + " " + this.serveur.Nom;
            this.TableLabel.Text = Num_Table.ToString();
            this.DateLabel.Text = Date_Affect.Day.ToString() + "\\" + Date_Affect.Month.ToString() + "\\" + Date_Affect.Year.ToString();
        }
    }
}
