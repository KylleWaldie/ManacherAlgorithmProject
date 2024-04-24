using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_Project
{
    public partial class Form2 : Form
    {
        Form3 errorForm;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                if (errorForm == null)
                {
                    errorForm = new Form3();
                    errorForm.FormClosed += frm3_FormClosed;
                }
                errorForm.Show(this);

            }
            else
            {
                textBox2.Clear();
                string userInput = textBox1.Text;
                string longestPalindrome = ManacherAlgorithm.LongestPalindrome(userInput);
                textBox2.Visible = true;
                textBox2.AppendText(longestPalindrome);
            }
        }

        void frm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            errorForm = null;
            Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
