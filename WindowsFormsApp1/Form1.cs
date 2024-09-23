using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateChecked()
        {
            if (radioButton1.Checked)
            {                
                pictureBox1.Image = Resources.Boy;
            }
            else if (radioButton2.Checked)
            {            
                pictureBox1.Image = Resources.Girl;
            }
            else if (radioButton3.Checked)
            {            
                pictureBox1.Image = Resources.Book;
            }
            else
            {
                pictureBox1.Image = Resources.Pen;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text= ((RadioButton)sender).Tag.ToString();
            UpdateChecked();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Tag.ToString();
            UpdateChecked();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Tag.ToString();
            UpdateChecked();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Tag.ToString();
            UpdateChecked();
        }
    }
}
