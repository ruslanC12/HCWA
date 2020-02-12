using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace CP02
{
    public partial class HSPRegistration : Form
    {
        public HSPRegistration()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String name = companyNameTxtBox.Text;

            string services = "";
            foreach(object itemChecked in checkedListBox1.CheckedIndices)
            {
                services = services + itemChecked.ToString() + ",";
            }
            services = services.Remove(services.Length - 1, 1);

            string username = textBox1.Text;
            string password = textBox2.Text;
            String phoneNumber = phoneNumberTxtBox.Text;
            String companyEmail = companyEmailTxtBox.Text;
            String remittanceAddress = addressTxtBox.Text;
            String bank = bankTxtBox.Text;
            String accountNum = accountNumTxtBox.Text;
            String routingNum = routingNumTxtBox.Text;
            String loginPIN = loginPinTxtBox.Text;

            DBMng.insertIntohsp(name, services, username, password, companyEmail, phoneNumber, remittanceAddress, bank, accountNum, routingNum, loginPIN);

            int id = DBMng.validateHSPWithPin(loginPIN);

            this.Hide();
            HSPinfoGUI info = new HSPinfoGUI(id);
            info.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInOrRegister newform = new SignInOrRegister();
            newform.ShowDialog();
        }

        private void HSPRegistration_Load(object sender, EventArgs e)
        {

        }

    }

}
