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
    public partial class HSPLogin : Form
    {
        public HSPLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox1.Text;
            int id = DBMng.validateHSP(username, password);
            if (id != 0)
            {
                this.Hide();
                HSPinfoGUI info = new HSPinfoGUI(id);
                info.ShowDialog();
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInOrRegister home = new SignInOrRegister();
            home.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupportSpecialistCall hspSupport = new SupportSpecialistCall(1);
            hspSupport.ShowDialog();
        }
    }
}
