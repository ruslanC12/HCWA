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
    public partial class HSPinfoGUI : Form
    {
        int hspid;
        public HSPinfoGUI(int id)
        {
            InitializeComponent();
            hspid = id;
            string[] info = DBMng.getHSPInfo(hspid);
            string[] services = info[2].Split(',');

            displayServices(services);

            NameTxt.Text = info[1];
            phoneTxt.Text = info[7];
            addressTxt.Text = info[8];
            bankTxt.Text = info[9];
            acctNumTxt.Text = info[10];
            routingTxt.Text = info[11];
            pinTxt.Text = info[5];


        }

        private void HSPinfoGUI_Load(object sender, EventArgs e)
        {

        }

        private void displayServices(string[] servs)
        {
            int index;
            int i = 0;
            while(i < servs.Length)
            {
                index = int.Parse(servs[i]);
                switch (index)
                {
                    case 0:
                        listView1.Items.Add("Inpatient");
                        break;
                    case 1:
                        listView1.Items.Add("Inpatient (Behavioral Health)");
                        break;
                    case 2:
                        listView1.Items.Add("Emergency Room");
                        break;
                    case 3:
                        listView1.Items.Add("Outpatient (level 1)");
                        break;
                    case 4:
                        listView1.Items.Add("Outpatient (level 2)");
                        break;
                    case 5:
                        listView1.Items.Add("Outpatient (level 3)");
                        break;
                    case 6:
                        listView1.Items.Add("Diagnostic Lab & X-Ray");
                        break;
                    case 7:
                        listView1.Items.Add("Physician Office Visits");
                        break;
                    case 8:
                        listView1.Items.Add("Specialist Office Visits");
                        break;
                    case 9:
                        listView1.Items.Add("Preventive Services");
                        break;
                    case 10:
                        listView1.Items.Add("Baby Care");
                        break;
                    case 11:
                        listView1.Items.Add("Durable Medical Equipment");
                        break;
                    case 12:
                        listView1.Items.Add("Nursing Facility");
                        break;
                    case 13:
                        listView1.Items.Add("Physical Therapy");
                        break;
                    default:
                        listView1.Items.Add("No Services");
                        return;
                }
                i++;
                
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            submitBills newform = new submitBills(hspid);
            newform.Show();

        }
    }
}
