
namespace TP2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importeUnImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationHistogrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogrammeSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lhistogrammeNormaliséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lhistogrammeCumuléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lhistogrammeCumuléNormaliséToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitementDimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laTranslationDhistogrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linversionDhistogrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexpansionDeDynamiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egalisationDeLhistogrammeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherToolStripMenuItem,
            this.operationHistogrameToolStripMenuItem,
            this.traitementDimageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficherToolStripMenuItem
            // 
            this.ficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importeUnImageToolStripMenuItem});
            this.ficherToolStripMenuItem.Name = "ficherToolStripMenuItem";
            this.ficherToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ficherToolStripMenuItem.Text = "Ficher";
            // 
            // importeUnImageToolStripMenuItem
            // 
            this.importeUnImageToolStripMenuItem.Name = "importeUnImageToolStripMenuItem";
            this.importeUnImageToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.importeUnImageToolStripMenuItem.Text = "Importe un image";
            this.importeUnImageToolStripMenuItem.Click += new System.EventHandler(this.importeUnImageToolStripMenuItem_Click);
            // 
            // operationHistogrameToolStripMenuItem
            // 
            this.operationHistogrameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogrammeSimpleToolStripMenuItem,
            this.lhistogrammeNormaliséToolStripMenuItem,
            this.lhistogrammeCumuléToolStripMenuItem,
            this.lhistogrammeCumuléNormaliséToolStripMenuItem});
            this.operationHistogrameToolStripMenuItem.Name = "operationHistogrameToolStripMenuItem";
            this.operationHistogrameToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.operationHistogrameToolStripMenuItem.Text = "Modification d\'Histogramme";
            // 
            // histogrammeSimpleToolStripMenuItem
            // 
            this.histogrammeSimpleToolStripMenuItem.Name = "histogrammeSimpleToolStripMenuItem";
            this.histogrammeSimpleToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.histogrammeSimpleToolStripMenuItem.Text = "Histogramme simple";
            this.histogrammeSimpleToolStripMenuItem.Click += new System.EventHandler(this.histogrammeSimpleToolStripMenuItem_Click);
            // 
            // lhistogrammeNormaliséToolStripMenuItem
            // 
            this.lhistogrammeNormaliséToolStripMenuItem.Name = "lhistogrammeNormaliséToolStripMenuItem";
            this.lhistogrammeNormaliséToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.lhistogrammeNormaliséToolStripMenuItem.Text = "L\'histogramme normalisé";
            this.lhistogrammeNormaliséToolStripMenuItem.Click += new System.EventHandler(this.lhistogrammeNormaliséToolStripMenuItem_Click);
            // 
            // lhistogrammeCumuléToolStripMenuItem
            // 
            this.lhistogrammeCumuléToolStripMenuItem.Name = "lhistogrammeCumuléToolStripMenuItem";
            this.lhistogrammeCumuléToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.lhistogrammeCumuléToolStripMenuItem.Text = "L\'histogramme cumulé";
            this.lhistogrammeCumuléToolStripMenuItem.Click += new System.EventHandler(this.lhistogrammeCumuléToolStripMenuItem_Click);
            // 
            // lhistogrammeCumuléNormaliséToolStripMenuItem
            // 
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Name = "lhistogrammeCumuléNormaliséToolStripMenuItem";
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Text = "L\'histogramme cumulé normalisé";
            this.lhistogrammeCumuléNormaliséToolStripMenuItem.Click += new System.EventHandler(this.lhistogrammeCumuléNormaliséToolStripMenuItem_Click);
            // 
            // traitementDimageToolStripMenuItem
            // 
            this.traitementDimageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laTranslationDhistogrammeToolStripMenuItem,
            this.linversionDhistogrammeToolStripMenuItem,
            this.lexpansionDeDynamiqueToolStripMenuItem,
            this.egalisationDeLhistogrammeToolStripMenuItem});
            this.traitementDimageToolStripMenuItem.Name = "traitementDimageToolStripMenuItem";
            this.traitementDimageToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.traitementDimageToolStripMenuItem.Text = "Traitement d\'image";
            // 
            // laTranslationDhistogrammeToolStripMenuItem
            // 
            this.laTranslationDhistogrammeToolStripMenuItem.Name = "laTranslationDhistogrammeToolStripMenuItem";
            this.laTranslationDhistogrammeToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.laTranslationDhistogrammeToolStripMenuItem.Text = "La translation d\'histogramme";
            this.laTranslationDhistogrammeToolStripMenuItem.Click += new System.EventHandler(this.laTranslationDhistogrammeToolStripMenuItem_Click);
            // 
            // linversionDhistogrammeToolStripMenuItem
            // 
            this.linversionDhistogrammeToolStripMenuItem.Name = "linversionDhistogrammeToolStripMenuItem";
            this.linversionDhistogrammeToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.linversionDhistogrammeToolStripMenuItem.Text = "L\'inversion d\'histogramme";
            this.linversionDhistogrammeToolStripMenuItem.Click += new System.EventHandler(this.linversionDhistogrammeToolStripMenuItem_Click);
            // 
            // lexpansionDeDynamiqueToolStripMenuItem
            // 
            this.lexpansionDeDynamiqueToolStripMenuItem.Name = "lexpansionDeDynamiqueToolStripMenuItem";
            this.lexpansionDeDynamiqueToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.lexpansionDeDynamiqueToolStripMenuItem.Text = "L\'expansion de dynamique";
            this.lexpansionDeDynamiqueToolStripMenuItem.Click += new System.EventHandler(this.lexpansionDeDynamiqueToolStripMenuItem_Click);
            // 
            // egalisationDeLhistogrammeToolStripMenuItem
            // 
            this.egalisationDeLhistogrammeToolStripMenuItem.Name = "egalisationDeLhistogrammeToolStripMenuItem";
            this.egalisationDeLhistogrammeToolStripMenuItem.Size = new System.Drawing.Size(271, 24);
            this.egalisationDeLhistogrammeToolStripMenuItem.Text = "Egalisation de l\'histogramme";
            this.egalisationDeLhistogrammeToolStripMenuItem.Click += new System.EventHandler(this.egalisationDeLhistogrammeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(450, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image originale:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dernier traitement:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(878, 77);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(494, 150);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(878, 233);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(494, 150);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(878, 389);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(494, 150);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 561);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importeUnImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationHistogrameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traitementDimageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem histogrammeSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lhistogrammeNormaliséToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lhistogrammeCumuléToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lhistogrammeCumuléNormaliséToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laTranslationDhistogrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linversionDhistogrammeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lexpansionDeDynamiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egalisationDeLhistogrammeToolStripMenuItem;
    }
}

