using System.Xml.Linq;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        Form2 main_form;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (main_form == null)
            {
                main_form = new Form2();
                main_form.FormClosed += frm2_FormClosed;
            }
            main_form.Show(this);
            Hide();
        }

        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_form = null;  //If form is closed make sure reference is set to null
            Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
