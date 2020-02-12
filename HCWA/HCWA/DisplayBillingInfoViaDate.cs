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
    public partial class DisplayBillingInfoViaDate : Form
    {
        public DisplayBillingInfoViaDate()
        {
            InitializeComponent();
            /*checkedListBox1.Items.Add("01/01/2019 - 02/01/2019");
            checkedListBox1.Items.Add("02/02/2019 - 04/01/2019");
            checkedListBox1.Items.Add("04/02/2019 - 06/01/2019");
            checkedListBox1.Items.Add("06/02/2019 - 08/01/2019");
            checkedListBox1.Items.Add("08/02/2019 - 10/01/2019");
            checkedListBox1.Items.Add("10/02/2019 - 12/31/2019");*/

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] amounts = new int[20];
            string[] services = new string[20];

            Boolean done = false;
            int i = 0;
            while(!done)
            {
                if(checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    amounts = DBMng.getBillAmountsViaDate(checkedListBox1.CheckedIndices[i].ToString());
                    services = DBMng.getBillServicesViaDate(checkedListBox1.CheckedIndices[i].ToString());
                    done = true;

                    i++;
                }
            }

            for (int j = 0; j < amounts.Length; j++)
            {
                listBox1.Items.Add((j + 1) + ". amount paid: $" + amounts[j] + ", services: " + services[j]);

            }

        }
    }
}
