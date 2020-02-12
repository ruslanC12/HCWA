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
    public partial class AccountantLogin : Form
    {
        public AccountantLogin()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            Boolean doesExist = DBMng.checkAccountantExists(firstName, lastName);

            if (!doesExist)
            {
                // show error message "Accountant does not exist"
                AccountantLoginError a = new AccountantLoginError();
                a.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                // send them to generate report page
                this.Hide();
                GenerateFormGUI g = new GenerateFormGUI();
                g.ShowDialog();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string firstname = textBox3.Text;
            string lastname = textBox4.Text;
            DBMng.addAccountant(firstname, lastname);

            this.Hide();
            GenerateFormGUI g = new GenerateFormGUI();
            g.ShowDialog();
        }
    }
}
