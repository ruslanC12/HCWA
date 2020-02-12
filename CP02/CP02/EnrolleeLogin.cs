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
    public partial class EnrolleeLogin : Form
    {
        int id;
        public EnrolleeLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.textBox1.Text;
            String password = this.textBox2.Text;
            id = DBMng.validateEnrollee(username, password);
            if(id != 0)
            {
                // We can make a list of users for the next iteration
                // I don't feel like it right now
                // this should be in an if-else branch

                Enrollee.CurrentUser = username;

                this.Hide();
                EnrolleeHomePage newform = new EnrolleeHomePage(id);
                newform.ShowDialog();
            }
            else
            {
                this.label3.Visible = true;
            }
            this.textBox1.Text = "";
            this.textBox2.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportSpecialistCall newform = new SupportSpecialistCall(0);
            newform.ShowDialog();
        }
    }
}
