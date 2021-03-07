using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseFile_WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = " Image Files(*.BMP; *.JPG; *.GIF)|(*.BMP; *.JPG; *.GIF)";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
