using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
    public class HealthServiceProvider
    {
        private String companyName;
        private String[] listOfServices;
        private String personnelContactPhone;
        private String personnelContactEmail;
        private String remittanceAddress;
        private String loginPIN;

        private String bankName;
        private String accountNum;
        private String routingNum;

        public static List<HealthServiceProvider> HealthServiceProvidersList = new List<HealthServiceProvider>();

        
        public HealthServiceProvider(String name, String[] services, String phone, String email, String address, String pin, String bank, String account, String routing)
        {
            companyName = name;

            listOfServices = new String[services.Length];
            for (int i = 0; i < listOfServices.Length; ++i) { listOfServices[i] = services[i];  }

            personnelContactPhone = phone;
            personnelContactEmail = email;
            remittanceAddress = address;
            loginPIN = pin;

            bankName = bank;
            accountNum = account;
            routingNum = routing;
        }

        public HealthServiceProvider(String name, String[] services, String phone, String email, String address, String pin)
        {
            companyName = name;

            listOfServices = new String[services.Length];
            for (int i = 0; i < listOfServices.Length; ++i) { listOfServices[i] = services[i]; }

            personnelContactPhone = phone;
            personnelContactEmail = email;
            remittanceAddress = address;
            loginPIN = pin;
        }

        public String getCompanyName() { return companyName; }
        public String getListOfServices()
        {
            String list = "";
            for (int i = 0; i < listOfServices.Length; ++i) { list = list + listOfServices[i] + " "; }
            return list;
        }
        public String getPersonnelContactPhone() { return personnelContactPhone;  }
        public String getPersonnelContactEmail() { return personnelContactEmail;  }
        public String getRemittanceAddress() { return remittanceAddress; }
        public String getBankName() { return bankName; }
        public String getAccountNum() { return accountNum; }
        public String getRoutingNum() { return routingNum; }
        public String getLoginPIN() { return loginPIN; }



       


    }
}
