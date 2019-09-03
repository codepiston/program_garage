using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                

namespace SearchApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Search_Directory_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input_Directory_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sDir,find_string;
            sDir = Input_Directory.Text;
            find_string = textBox2.Text;

            foreach(string file in Directory.EnumerateFiles(sDir,"*.xml",SearchOption.AllDirectories))
            {
                Console.WriteLine(file);
            }

            richTextBox1.Text = Input_Directory.Text;
            MessageBox.Show(sDir, find_string);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
