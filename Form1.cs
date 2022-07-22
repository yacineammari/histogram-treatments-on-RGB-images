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
    public partial class Form1 : Form
    {
        public my_imge my_obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void importeUnImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap o_img = new Bitmap(openFileDialog1.FileName);
                my_obj = new my_imge(o_img);
                pictureBox1.Image = my_obj.o_img;
            }
        }

        private void histogrammeSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null  )
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                my_obj.fun_hs(my_obj.o_img);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart2.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();
                }
                
                for (int i=0;i< 256;i++)
                {

                    chart1.Series["Series1"].Points.AddXY(i, my_obj.h[0,i]);
                    chart1.Series["Series1"].LegendText = "histogramme Simple pour le rouge";

                    chart2.Series["Series1"].Points.AddXY(i, my_obj.h[1, i]);
                    chart2.Series["Series1"].LegendText = "histogramme Simple pour le bleu";

                    chart3.Series["Series1"].Points.AddXY(i, my_obj.h[2, i]);
                    chart3.Series["Series1"].LegendText = "histogramme Simple pour le  vert";

                }

            }

        }

        private void lhistogrammeNormaliséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null)
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (my_obj.h == null)
                {
                    my_obj.fun_hs(my_obj.o_img);
                }

                my_obj.fun_hn(my_obj.h,my_obj.o_img.Width, my_obj.o_img.Height);


                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart2.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < 256; i++)
                {

                    chart1.Series["Series1"].Points.AddXY(i, my_obj.hn[0, i]);
                    chart1.Series["Series1"].LegendText = "histogramme Simple pour le rouge";

                    chart2.Series["Series1"].Points.AddXY(i, my_obj.hn[1, i]);
                    chart2.Series["Series1"].LegendText = "histogramme Simple pour le bleu";

                    chart3.Series["Series1"].Points.AddXY(i, my_obj.hn[2, i]);
                    chart3.Series["Series1"].LegendText = "histogramme Simple pour le  vert";

                }

            }

        }

        private void lhistogrammeCumuléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null)
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (my_obj.h == null)
                {
                    my_obj.fun_hs(my_obj.o_img);
                }
                my_obj.fun_hc(my_obj.h);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart2.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < 256; i++)
                {

                    chart1.Series["Series1"].Points.AddXY(i, my_obj.hc[0, i]);
                    chart1.Series["Series1"].LegendText = "histogramme Simple pour le rouge";

                    chart2.Series["Series1"].Points.AddXY(i, my_obj.hc[1, i]);
                    chart2.Series["Series1"].LegendText = "histogramme Simple pour le bleu";

                    chart3.Series["Series1"].Points.AddXY(i, my_obj.hc[2, i]);
                    chart3.Series["Series1"].LegendText = "histogramme Simple pour le  vert";

                }



            }


        }

        private void lhistogrammeCumuléNormaliséToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null)
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (my_obj.h == null)
                {
                    my_obj.fun_hs(my_obj.o_img);
                }

                if (my_obj.hc == null)
                {
                    my_obj.fun_hn(my_obj.h, my_obj.o_img.Width, my_obj.o_img.Height);
                }

                my_obj.fun_hcn(my_obj.hc, my_obj.o_img.Width, my_obj.o_img.Height);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart2.Series)
                {
                    series.Points.Clear();
                }
                foreach (var series in chart3.Series)
                {
                    series.Points.Clear();
                }

                for (int i = 0; i < 256; i++)
                {

                    chart1.Series["Series1"].Points.AddXY(i, my_obj.hcn[0, i]);
                    chart1.Series["Series1"].LegendText = "histogramme Simple pour le rouge";

                    chart2.Series["Series1"].Points.AddXY(i, my_obj.hcn[1, i]);
                    chart2.Series["Series1"].LegendText = "histogramme Simple pour le bleu";

                    chart3.Series["Series1"].Points.AddXY(i, my_obj.hcn[2, i]);
                    chart3.Series["Series1"].LegendText = "histogramme Simple pour le  vert";

                }

            }

        }

        private void laTranslationDhistogrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null)
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (popup p = new popup())
                {
                    if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        
                        my_obj.laTranslationDhistogramme(my_obj.o_img, p.valr, p.valg, p.valb);
                        pictureBox2.Image = my_obj.translation_img;
                    }
                }

                
            }


        }

        private void linversionDhistogrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null)
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                my_obj.linversionDhistogramme(my_obj.o_img);
                pictureBox2.Image = my_obj.inversion_img;

                
            }


        }

        private void lexpansionDeDynamiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null)
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(my_obj.h == null){
                MessageBox.Show("vous devez calculer l'histogramme simple.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                my_obj.lexpansionDeDynamique(my_obj.o_img, my_obj.max, my_obj.min);

                pictureBox2.Image = my_obj.Expansion_img;
            }



        }

        private void egalisationDeLhistogrammeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (my_obj == null || my_obj.o_img == null)
            {

                MessageBox.Show("vous devez importer un image avec d\'effectuer n\'importe quelles traitement.", "pas d\'image", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                my_obj.fun_heq(my_obj.max, my_obj.hcn);
                my_obj.Egalisation(my_obj.heq, my_obj.o_img);
                pictureBox2.Image = my_obj.Egalisation_img;
            }


        }
    }




}
