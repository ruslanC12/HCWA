using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
    public class Bills
    {
        private int id;
        private int enid;
        private double amt;
        private int servicenumber;
        private string service;
        private double copay;
        private string plan;
        private double networkCharge;
        private Boolean isPaid = false;

        public Bills(double amount, int enrid, int servicenumber)
        {
            amt = amount;
            enid = enrid;
            service = setService(servicenumber);
            plan = DBMng.getPlanTypeEnrollee(enrid);
        }
        public Bills(double amount, int enrid, int servicenumber, int id)
        {
            amt = amount;
            enid = enrid;
            service = setService(servicenumber);
            plan = DBMng.getPlanTypeEnrollee(enrid);
            this.id = id;
        }

         public string setService(int servicenumber)
        {
            switch (servicenumber)
            {
                case 0:
                   if (plan == "basic")
                    {
                        copay = 400;
                        networkCharge = 0.9;
                    }
                   else
                    {
                        networkCharge = 1;
                        copay = 300;
                    }
                    return "Inpatient";
                case 1:
                    if (plan == "basic")
                    {
                        copay = 400;
                        networkCharge = 0.9;
                    }
                    else
                    {
                        networkCharge = 1;
                        copay = 300;
                    }
                    return "Behavioral Health";
                case 2:
                    if (plan == "basic")
                    {
                        copay = 250;
                        networkCharge = 1;
                    }
                    else
                    {
                        copay = 250;
                        networkCharge = 1;
                    }
                    return "Emergency Room";
                case 3:
                    if (plan == "basic")
                    {
                        copay = 250;
                        networkCharge = 0.9;
                    }
                    else
                    {
                        copay = 250;
                        networkCharge = 1;
                    }
                    return "Outpatient (level 1)";
                case 4:
                    if (plan == "basic")
                    {
                        copay = 250;
                        networkCharge = 0.9;
                    }
                    else
                    {
                        copay = 250;
                        networkCharge = 1;
                    }
                    return "Outpatient (level 2)";
                case 5:
                    if (plan == "basic")
                    {
                        copay = 250;
                        networkCharge = 0.9;
                    }
                    else
                    {
                        copay = 250;
                        networkCharge = 1;
                    }
                    return "Outpatient (level 3)";
                case 6:
                    copay = 0;
                    if (plan == "basic")
                    {
                        networkCharge = 0.9;
                    }
                    else
                    {
                        networkCharge = 1;
                    }
                    return "Diagnostic Lab & X-Ray";
                case 7:
                    if (plan == "basic")
                    {
                        copay = 0;
                        networkCharge = 0.9;
                    }
                    else
                    {
                        copay = 20;
                        networkCharge = 1;
                    }
                    return "Physician Office Visits";
                case 8:
                    if (plan == "basic")
                    {
                        copay = 0;
                        networkCharge = 0.9;
                    }
                    else
                    {
                        copay = 30;
                        networkCharge = 1;
                    }
                    return "Specialist Office Visits";
                case 9:
                    copay = 0;
                    networkCharge = 1;
                    return "Preventive Services";
                case 10:
                    copay = 0;
                    networkCharge = 1;
                    return "Baby Care";
                case 11:
                    copay = 0;
                    networkCharge = 0.8;
                    return "Durable Medical Equipment";
                case 12:
                    copay = 0;
                    if (plan == "basic")
                    {
                        networkCharge = 0.9;
                    }
                    else
                    {
                        networkCharge = 1;
                    }
                    return "Nursing Facility";
                case 13:
                    if (plan == "basic")
                    {
                        copay = 0;
                        networkCharge = 0.9;
                    }
                    else
                    {
                        copay = 30;
                        networkCharge = 1;
                    }
                    return "Physical Therapy";
                default:
                    return "Other Service";

            }
                   
            }
        public double getAmount()
        {
            return amt;
        }
        public double getNetworkCharge()
        {
            return networkCharge;
        }
        public double getCopay()
        {
            return copay;
        }
        public int getEnrolleeId()
        {
            return id;
        }
        public string getService()
        {
            return service;
        }
        public Boolean getIsPaid()
        {
            return isPaid;
        }
     
        public int getServiceNumber()
        {
            return servicenumber;
        }
        public int getBillId()
        {
            return id;
        }
    }
}
