using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;
using System.Runtime.InteropServices;


namespace OCR_from_ScreenCopy
{
    public partial class FormText : Form
    {

        AutoIt Cautoit = new AutoIt();
        AutoItX3 auto = new AutoItX3();

        public FormText()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public FormText(RichTextBox richTextBox1)
        {
            this.richTextBox1 = richTextBox1;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != null)
            { richTextBox1.Copy(); }

        }
        private void MousePaste(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }



        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void selectAllCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                //FormText f2 = new FormText();
                //f2.Show();
                richTextBox1.SelectAll();
                richTextBox1.Copy();
                Cautoit.mClick("LEFT", 659, 60, 2, -1);
                richTextBox1.Paste();

            }
        }
    }
}








