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
    public partial class ucContient : UserControl
    {
        public int Num_Com { get; set; }
        public int Code_Plat { get; set; }
        public int Qte { get; set; }
        Data data = new Data(); 
        public ucContient()
        {
            InitializeComponent();
        }

        private void ucContient_Load(object sender, EventArgs e)
        {
            this.QuantiteLabel.Text = Qte.ToString();
            this.PlatLabel.Text = data.SelectOnePlat(Code_Plat).Libelle;
        }
    }
}
