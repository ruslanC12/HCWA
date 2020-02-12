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
    public partial class SeeBillsGUI : Form
    {
        List<Bills> billList = new List<Bills>();
        int enrid;
        BillController cntrl = new BillController();
        public SeeBillsGUI(int id)
        {
            InitializeComponent();
            enrid = id;
            billList = DBMng.getBillsFromEnrollee(enrid);
             foreach(Bills bill in billList)
            {
                if (bill.getIsPaid() != true)
                {
                    billBox.Items.Add(cntrl.getEnrolleePayAmt(bill).ToString());
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            int index;
            index = billBox.SelectedIndex;
            Bills b = DBMng.getBill(index); 
            label2.Text = cntrl.payBill(b);
            billBox.Items.RemoveAt(index);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrolleeHomePage newEnrolleeInfo = new EnrolleeHomePage(enrid);
            newEnrolleeInfo.ShowDialog();
        }

        private void BillBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
