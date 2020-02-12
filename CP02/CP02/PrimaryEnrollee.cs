using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
    public class PrimaryEnrollee : Enrollee
    {

        private String MailingAddress;
        private String BillingAddress;
        private String username;
        private String password;
        private double deductible;


        public PrimaryEnrollee(String fullname, String ssn, String MailingAddress, String BillingAddress, String username, String password, String pin)
        {
            this.fullname = fullname;
            this.ssn = ssn;
            this.MailingAddress = MailingAddress;
            this.BillingAddress = BillingAddress;
            this.username = username;
            this.password = password;
            this.pin = pin;
        }

        public override String getFullname()
        {
            return this.fullname;
        }
        public override String getSSN()
        {
            return this.ssn;
        }
        public override void setFullname(String fullname)
        {
            this.fullname = fullname;
        }
        public override void setSSN(String ssn)
        {
            this.ssn = ssn;
        }

        public String getMAddress()
        {
            return this.MailingAddress;
        }
        public String getBAddress()
        {
            return this.BillingAddress;
        }
        public void setMAddress(String mAddr)
        {
            this.MailingAddress = mAddr;
        }
        public void setbAddress(String bAddr)
        {
            this.BillingAddress = bAddr;
        }
        public String getUsername()
        {
            return this.username;
        }
        public String getPassword()
        {
            return this.password;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public void setUsername(String username)
        {
            this.username = username;
        }
        public String getPIN()
        {
            return pin;
        }
        public void setPIN(String pin)
        {
            this.pin = pin;
        }


        public override void login()
        {
            throw new NotImplementedException();
        }
        
        public void setDeductible(double num)
        {
            deductible = num;
        }

        public double getDeductible()
        {
            return deductible;
        }

    }
}
