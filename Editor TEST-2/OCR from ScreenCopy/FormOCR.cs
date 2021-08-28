using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using AutoItX3Lib;
using System.Runtime.InteropServices;

namespace OCR_from_ScreenCopy
{
    public partial class FormOCR : FormText2
    {

        Bitmap img;
        FormText2 Form2;
        

        AutoIt Cautoit = new AutoIt();
        AutoItX3 auto = new AutoItX3();

        public FormOCR()
        {
            InitializeComponent();
            this.TopMost = true; //formu en önde tut

        }
        private Bitmap capturearea(Control control)
        {
            Size size = control.ClientSize;
            Bitmap tmpBmp = new Bitmap(size.Width, size.Height);
            Graphics g;
            g = Graphics.FromImage(tmpBmp);
            g.CopyFromScreen(control.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(size.Width, size.Height));
            return tmpBmp;
        }
        
        private void btOCR_Click(object sender, EventArgs e)
        {
           
            Form2 = new FormText2(richTextBox1);
            img = capturearea(pictureBox1);
            TesseractEngine engine = new TesseractEngine("./tessdata", "tur", EngineMode.Default);
            Page page = engine.Process(img, PageSegMode.Auto);
            Form2.richTextBox2.Text = page.GetText();
            Form2.Show();
        }
        private void btOCR2_Click(object sender, EventArgs e)
        {
            FormText2 formmain = new FormText2(richTextBox2);
            if (formmain.ShowDialog(richTextBox2) == DialogResult.OK)
            {    
                Application.Run(new FormText2(richTextBox1));
            }
            Form2 = new FormText2(richTextBox1);
            img = capturearea(pictureBox1);

           



        }
    }
}

