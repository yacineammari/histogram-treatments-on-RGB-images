using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class my_imge
    {
        public Bitmap o_img;  //image originale
        public Bitmap translation_img;  //image après  translation
        public Bitmap inversion_img;    //image après  inversion
        public Bitmap Expansion_img;    //image après  Expansion
        public Bitmap Egalisation_img;  //image après  Egalisation

        public int[] max = new int[3]; //color max 
        public int[] min = new int[3]; //color min


        public int[,] h; //Histogramme simple
        public double[,] hn; //L'histogramme normalisé
        public int[,] hc; //L'histogramme cumulé
        public double[,] hcn; //L'histogramme cumulé normalisé
        public double[,] heq;  //modification des intensités


        public my_imge(Bitmap o_img)
        {
            this.o_img = new Bitmap(o_img);
        }

        //min et max des RGB
 
        public Tuple<int[],int[]> fun_max_min(int[,] h)
        {
            int[] max = new int[3];
            int[] min = new int[3];

            for (int i=0;i<3; i++)
            {
                max[i] = 0;
                min[i] = 255;
            }

            for (int i = 0; i < 256; i++)
            {
                if (h[0,i] != 0 && i > max[0]) { max[0] = i; }
                if (h[0,i] != 0 && i < min[0]) { min[0] = i; }

                if (h[1, i] != 0 && i > max[1]) { max[1] = i; }
                if (h[1, i] != 0 && i < min[1]) { min[1] = i; }


                if (h[2, i] != 0 && i > max[2]) { max[2] = i; }
                if (h[2, i] != 0 && i < min[2]) { min[2] = i; }
            }

            return Tuple.Create(max, min);
            Console.WriteLine("this.max: " + this.max[0] + " , " + this.max[1] + " , " + this.max[2]);
            Console.WriteLine("this.min: " + this.min[0] + " , " + this.min[1] + " , " + this.min[2]);
        }

        //histogramme s
        public void fun_hs(Bitmap img)
        {
            int[,] level = new int[3, 265];
            int j = 0;
            while (j < 3)
            {
                for (int i = 0; i < 265; i++)
                {
                    level[j, i] = 0;
                }
                j++;
            }

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {

                    level[0, img.GetPixel(x, y).R]++;
                    level[1, img.GetPixel(x, y).G]++;
                    level[2, img.GetPixel(x, y).B]++;

                }
            }

            this.h = level;

            Tuple<int[], int[]> data = this.fun_max_min(this.h);
            this.max = data.Item1;
            this.min = data.Item2;
        }

        //L'histogramme normalisé
        public void fun_hn(int[,] hs, int w, int h)
        {
            double[,] levels = new double[3, 265];
            double q = w * h;
            int i;
            for (i = 0; i < 256; i++)
            {
                levels[0,i] = hs[0,i] / q;
                levels[1,i] = hs[1, i] / q;
                levels[2,i] = hs[2, i] / q;
            }

            this.hn = levels;
        }

        //L'histogramme cumulé
        public void fun_hc(int[,] hs)
        {
            int[,] levels = new int[3, 265];

            levels[0,0] = hs[0,0];
            levels[1, 0] = hs[1, 0];
            levels[2, 0] = hs[2, 0];

            for (int i = 1; i < 256; i++)
            {
                levels[0,i] = levels[0,i - 1] + hs[0,i];
                levels[1, i] = levels[1, i - 1] + hs[1, i];
                levels[2, i] = levels[2, i - 1] + hs[2, i];
            }

            this.hc = levels;
        }

        //L'histogramme cumulé normalisé
        public void fun_hcn(int[,] hc, int w, int h)
        {
            double[,] levels = new double[3, 265];
            double q = w * h;

            for (int i = 0; i < 256; i++)
            {
                levels[0,i] = hc[0,i] / q;
                levels[1, i] = hc[1, i] / q;
                levels[2, i] = hc[2, i] / q;
            }

            this.hcn = levels;

        }

        /// /////////////////////////////////////////////////////////


        //La translation d'histogramme
        public void laTranslationDhistogramme(Bitmap img, int valr, int valg, int valb)
        {
            Bitmap img2 = new Bitmap(img.Width, img.Height);
            int[] shift_tab = new int[3];
            
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pix;
                    pix = img.GetPixel(x, y);
                    
                    shift_tab[0] = valr;
                    shift_tab[1] = valg;
                    shift_tab[2] = valb;

                    
                        if (shift_tab[0] > 0)
                        {
                            ///+///
                            
                            //red
                            if (shift_tab[0] + pix.R > 255)
                            {shift_tab[0] = 255;}
                            else
                            {shift_tab[0] = shift_tab[0] + pix.R;}

                        }
                        else
                        {
                        ///-///
                        ///

                            //red
                            if (shift_tab[0] + pix.R < 0)
                            { shift_tab[0] = 0; }
                            else
                            { shift_tab[0] = shift_tab[0] + pix.R; }

                     

                            }
                        
                        if (shift_tab[1] > 0)
                        {
                            //green 
                            if (shift_tab[1] + pix.G > 255)
                            {shift_tab[1] = 255;}
                            else
                            {shift_tab[1] = shift_tab[1] + pix.G;}

                            
                        }
                        else
                        {
                        //green 
                        if (shift_tab[1] + pix.G < 0)
                        { shift_tab[1] = 0; }
                        else
                        { shift_tab[1] = shift_tab[1] + pix.G; }

                        

                            }

                        if (shift_tab[2] > 0) {
                        //blue
                        if (shift_tab[2] + pix.B > 255)
                        { shift_tab[2] = 255; }
                        else
                        { shift_tab[2] = shift_tab[2] + pix.B; }
                        }
                        else
                        {

                        //blue

                        if (shift_tab[2] + pix.B < 0)
                        { shift_tab[2] = 0; }
                        else
                        { shift_tab[2] = shift_tab[2] + pix.B; }

                             }



                        img2.SetPixel(x, y, Color.FromArgb(shift_tab[0], shift_tab[1], shift_tab[2]));
                 }

            }    
            

            this.translation_img = img2;

        }

        //L'inversion d'histogramme
        public void linversionDhistogramme(Bitmap img)
        {
            Bitmap img2 = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pix;
                    pix = img.GetPixel(x, y);

                    img2.SetPixel(x, y, Color.FromArgb(255 - pix.R, 255 - pix.G, 255 - pix.B));

                }
            }

            this.inversion_img = img2;
        }

        //Expansion de dynamique
        public void lexpansionDeDynamique(Bitmap img, int[] max, int[] min)
        {
            //quotient = [255/(max[x,y] - min[x,y])]

            if (this.h == null)
            {   
                this.fun_hs(img);
                
                max = this.max;
                min = this.min;
            }



            int[] max_min = new int[3];
            max_min[0] = max[0] - min[0];
            max_min[1] = max[1] - min[1];
            max_min[2] = max[2] - min[2];
            double[] quotient = new double[3];
            quotient[0]=255 / max_min[0];
            quotient[1] = 255 / max_min[1];
            quotient[2] = 255 / max_min[2];

            

            Bitmap img2 = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pix;
                    pix = img.GetPixel(x, y);

                    int[] col = new int[3];
                    col[0] = (int)Math.Round(quotient[0] * (pix.R - min[0]));
                    col[1] = (int)Math.Round(quotient[1] * (pix.R - min[1]));
                    col[2] = (int)Math.Round(quotient[2] * (pix.R - min[2]));


                    if (col[0] > 255) { col[0] = 255; }
                    if (col[1] > 255) { col[1] = 255; } 
                    if (col[2] > 255) { col[2] = 255; }

                    if (col[0] < 0) { col[0] = 0; }
                    if (col[1] < 0) { col[1] = 0; }
                    if (col[2] < 0) { col[2] = 0; }

                    img2.SetPixel(x, y, Color.FromArgb(col[0], col[1], col[2]));
                }
            }

            this.Expansion_img = img2;
        }

        //modification des intensités
        public void fun_heq(int[] max, double[,] hcn)
        {
            if (this.hcn == null)
            {
                if (this.hc == null)
                {
                    if (this.h == null)
                    {
                        this.fun_hs(this.o_img);
                        max = this.max;
                    }
                    this.fun_hc(this.h);

                }


                this.fun_hcn(this.hc, this.o_img.Width, this.o_img.Height);
                hcn = this.hcn;
            }
            
            double[,] levels = new double[3,256];

            for (int i = 0; i < 256; i++)
            {
                levels[0,i] = max[0] * hcn[0,i];
                levels[1, i] = max[1] * hcn[1, i];
                levels[2, i] = max[2] * hcn[2, i];
            }
            this.heq = levels;
        }

        //Egalisation d'histogramme
        public void Egalisation(double[,] heq, Bitmap img)
        {
            Bitmap img2 = new Bitmap(img.Width, img.Height);
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    img2.SetPixel(x, y, Color.FromArgb((int)Math.Round(heq[0,img.GetPixel(x, y).R]), (int)Math.Round(heq[1,img.GetPixel(x, y).G]), (int)Math.Round(heq[2,img.GetPixel(x, y).B])));


                }
            }

            this.Egalisation_img = img2;
        }


    }
}
