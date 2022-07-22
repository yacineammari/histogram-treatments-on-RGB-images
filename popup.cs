using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class popup : Form
    {
        public int valr { set; get; }
        public int valb { set; get; }
        public int valg { set; get; }
        public popup()
        {
            InitializeComponent();
            valr = 0;
            valb = 0;
            valg = 0;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valr = trackBar1.Value;
            label2.Text = ("Rouge:: " + trackBar1.Value.ToString());

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            valb = trackBar2.Value;
            label3.Text = ("Bleu: " + trackBar2.Value.ToString());
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            valg = trackBar3.Value;
            label4.Text = ("Vert: " + trackBar3.Value.ToString());

        }
    }
}
