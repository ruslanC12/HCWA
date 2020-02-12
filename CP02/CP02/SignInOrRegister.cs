using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP02
{
    public partial class SignInOrRegister : Form
    {
        public SignInOrRegister()
        {
            InitializeComponent();
        }

        private void EnrolleeRegistration(object sender, EventArgs e)
        {
            this.Hide();
            EnrolleeRegistration newform = new EnrolleeRegistration();
            newform.ShowDialog();

        }

        private void HSPLogin(object sender, EventArgs e)
        {
            this.Hide();
            HSPLogin newform = new HSPLogin();
            newform.ShowDialog();

        }

        private void EnrolleeLogin(object sender, EventArgs e)
        {
            this.Hide();
            EnrolleeLogin newform = new EnrolleeLogin();
            newform.ShowDialog();
        }

        private void HSPRegistration(object sender, EventArgs e)
        {
            this.Hide();
            HSPRegistration newform = new HSPRegistration();
            newform.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string adminnum = textBox1.Text;
            string fullname = textBox2.Text;

            if(DBMng.validateManager(adminnum, fullname))
            {
                this.Hide();
                ManagerDisplay newform = new ManagerDisplay();
                newform.ShowDialog();
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                this.label3.Visible = true;
            }

        }
    }
}
