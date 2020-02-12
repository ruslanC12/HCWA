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
    public partial class SupportSpecialistCall : Form
    {
        private int userId = 0;
        private int whoLogged = 0;
        public SupportSpecialistCall(int whoLoginedIn)
        {
            InitializeComponent();
            // Enrollee = 0 and hsp = 1
            whoLogged = whoLoginedIn;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (whoLogged == 0)
            {
                userId = DBMng.validateEnrolleeWithPin(textBox1.Text);
                if (userId != 0)
                {
                    this.Hide();
                    EnrolleeHomePage newform = new EnrolleeHomePage(userId);
                    newform.ShowDialog();
                }
                label2.Visible = true;
                textBox1.Text = "";
            }
            else
            {
                userId = DBMng.validateHSPWithPin(textBox1.Text);
                if(userId != 0)
                {
                    this.Hide();
                    HSPinfoGUI info = new HSPinfoGUI(userId);
                    info.ShowDialog();
                }
                label2.Visible = true;
                textBox1.Text = "";
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (whoLogged == 0)
            {
                this.Hide();
                EnrolleeLogin newform = new EnrolleeLogin();
                newform.ShowDialog();
            }
            else
            {
                this.Hide();
                HSPLogin newform = new HSPLogin();
                newform.ShowDialog();
            }
        }
    }
}
