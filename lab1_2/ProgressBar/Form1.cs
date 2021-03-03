using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void enterButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;
            try
            {
                progressBar1.Value = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
            }
        }

        private void pushButton_Click(object sender, EventArgs e)
        {           
            pictureBox1.Visible = true;
            pictureBox1.Enabled = true;
            try
            {
                progressBar1.Value = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("При выполнении преобразования типов возникла ошибка");
                return;
            }

            for (; progressBar1.Value < progressBar1.Maximum; progressBar1.Value++) ;
        }
    }
}
