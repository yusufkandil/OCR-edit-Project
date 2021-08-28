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
using AutoItX3Lib;
using System.Timers;
using System.Runtime.InteropServices;

namespace OCR_from_ScreenCopy
{

    public partial class FormText2 : Form
    {



        AutoIt Cautoit = new AutoIt();
        AutoItX3 auto = new AutoItX3();


        public FormText2(object richTextBox2)
        {
            InitializeComponent();

            this.TopMost = true; //formu en önde tut

        }
        public FormText2()
        {

        }


        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox2.SelectedText != null)
            { richTextBox2.Copy(); }

        }
        private void MousePaste(object sender, EventArgs e)
        {

            richTextBox2.Paste();

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
        }

        private void selectAllCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectAll();
            richTextBox2.Copy();
        }



        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox2.SelectAll();
                richTextBox2.Copy();
                this.Close();
                Cautoit.mClick("LEFT", 659, 60, 2, -1);
                SendKeys.Send("^V");
                //System.Threading.Thread.Sleep(2000);
                //string xx = Clipboard.GetText();
                //timer1.Start();
                //timer1.Interval = 6000;
                //richTextBox2.Paste();
                //timer1.Enabled = true;
                //richTextBox2.Text = richTextBox2.Text.Insert(richTextBox2.SelectionStart, xx);
               
            }
            

        }

    }
}
