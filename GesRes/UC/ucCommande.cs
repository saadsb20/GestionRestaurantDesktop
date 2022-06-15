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
    public partial class ucCommande : UserControl
    {
        public int Num_Table { get; set; }
        public int Num_Com { get; set; }
        public DateTime Date_Com { get; set; }
        public int Nb_Pers { get; set; }
        public DateTime Heure_Pay { get; set; }
        public string Mode_Pay { get; set; }
        CommandesForm CommandesForm;

        public ucCommande(CommandesForm commandesForm)
        {
            InitializeComponent();
            this.CommandesForm = commandesForm;
        }

        private void ucCommande_Load(object sender, EventArgs e)
        {
            this.label1.Text = Num_Table.ToString();
            this.label2.Text = Date_Com.Day.ToString()+"\\"+Date_Com.Month.ToString()+"\\" + Date_Com.Year.ToString();
            this.label3.Text = Nb_Pers.ToString();
            this.label4.Text = Heure_Pay.TimeOfDay.Hours.ToString() +" : " + Heure_Pay.TimeOfDay.Minutes.ToString();
            this.label5.Text = Mode_Pay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CommandesForm.Num_Com = Num_Com;
            this.CommandesForm.ShowContients(Num_Com);
        }
    }
}
