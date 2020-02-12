using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace CP02
{
    /*
     * 
     * The four tables are
     * 
     *      plan with attributes(id, type) 
     *      id is auto incremented and type is a enum with the only choices are basic and extended
     *      
     *      primaryEnrolllee with attributes(id, plan$id, name, username, password, email, phoneNumber, mAddress, bAddress, ssn) 
     *      id is Auto Incremented and plan$id, phoneNumber, and ssn are ints while everything else is a string. email and phone are optional
     *      
     *      dependentEnrollee with attributes(id, primary$id, name, ssn, phoneNumber, email, relationship)
     *      id is auto incremented and primary$id, ssn, phoneNumber are ints everthing else is a string
     *      
     *      hsp with attributes(id, company, services, personEmail, personPhone, remittanceAddress, bankName, accountNumber, routineNumber)
     *      id is auto incremented services is a set and address is optional as well as account num and routine num
     *       
     * 
     */
    static class DBMng
    {
        public static MySqlConnection connectAtSIUE()
        {
            string server = "vm-07.cs.siue.edu";
            string database = "numbers";
            string uid = "twonotten";
            string password = "whatdotheymean2010";
            string connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Connection Timeout=60";
            MySqlConnection mycon = new MySqlConnection(connectionString);
            return mycon;
        }

        public static MySqlConnection connectOutOfSIUE()
        {
            string server = "127.0.0.1";
            string database = "numbers";
            string uid = "twonotten";
            string password = "whatdotheymean2010";
            string connectionString = "SERVER=" + server + "; PORT = 3306 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Connection Timeout=60";
            MySqlConnection mycon = new MySqlConnection(connectionString);
            return mycon;
        }

        public static void insertIntoPlan(string type)
        {
            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "insert into plan (type) values ('" + type + "')";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void insertIntoPrimaryEnrollee(string planType, string name, string username, string password, string mAdd, string bAdd, string ssn, string pin)
        {
            int deductible = 0;
            if(planType == "basic") { deductible = 250; }
            insertIntoPlan(planType);
            int id = getPlanId();
            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "insert into primaryEnrollee (plan$id, name, username, password, mAddress, bAddress, ssn, pin, deductible) " +
                            " values (" + id + ", '" + name + "', '" + username + "', '" + password + "', '" + mAdd + "', '" + bAdd + "', " + ssn + ", " + pin + ", deductible=" + deductible + ")";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static void insertIntoBills(Bills bill)
        {
            
            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "insert into bills (enrollee$id, amount, service, copayment, networkCharge, isPaid) " +
                            " values (" + bill.getEnrolleeId() + ", " + bill.getAmount() + ", " + bill.getServiceNumber() + ", " + bill.getCopay() + ", " + bill.getNetworkCharge() + ", '" + "False" + "')";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }



        public static void insertIntohsp(string name, string services, string username, string password, string email, string phone, string address, string bankName, string accNum, string routineNum, string pin)
        {
            string phoneNum = phone;
            string bank = bankName;
            string accountNum = accNum;
            string routine = routineNum;

            if (phoneNum == "") { phoneNum = "NULL"; };
            if (bank == "") { bank = "NULL"; };
            if (accountNum == "") { accountNum = "NULL"; };
            if (routine == "") { routine = "NULL"; };

            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "insert into hsp (company, services, password, username, pin, personalEmail, personalPhone, remittanceAddress, bankName, accountNumber, routineNumber) " +
                            " values (\"" + name + "\", \"" + services + "\", '" + password + "', '" + username + "', " + pin + ", '" + email + "', " + phoneNum + ", '" + address + "', '" 
                            + bank + "', " + accountNum + ", " + routine + ")";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }



        public static int getPlanId()
        {
            int id = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from plan";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                id = rd.GetInt32(0);
            }
            rd.Close();
            mycon.Close();
            return id;
        }

        public static int getNumOfEnrollees()
        {
            int i = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from primaryEnrollee";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                i++;
            }
            rd.Close();
            mycon.Close();
            return i;
        }

        public static string[,] getEnrollees(int num)
        {
            string[,] enrollees = new string[num,3];
            int i = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select id, plan$id, name from primaryEnrollee";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                enrollees[i,0] = rd.GetString(0);
                enrollees[i,1] = rd.GetString(1);
                enrollees[i,2] = rd.GetString(2);
                i++;
            }
            rd.Close();
            mycon.Close();
            return enrollees;
        }

        public static bool validateManager(string pin, string name)
        {
            bool found = false;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from admin where adminNumber=" + pin + " and name='" + name + "'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                found = true;
            }
            rd.Close();
            mycon.Close();
            return found;
        }

        public static int validateEnrollee(string username, string password)
        {
            int id = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from primaryEnrollee where username='" + username + "' and password='" + password + "'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                id = rd.GetInt32(0);
            }
            rd.Close();
            mycon.Close();
            return id;
        }

        public static int validateHSP(string username, string password)
        {
            int id = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from hsp where username='" + username + "' and password='" + password + "'";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                id = rd.GetInt32(0);
            }
            rd.Close();
            mycon.Close();
            return id;
        }
        public static string getEnrolleeInfo(int id)
        {
            string plan;
            string info =  "";
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select plan$id, name, username, mAddress from primaryEnrollee where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                plan = getPlanType(rd.GetInt32(0));
                info = "Welcome: " + rd.GetString(1) + "\n\n\nYour Username is: " + rd.GetString(2) +
                                     "\n\n\nYour Mailing Address is: " + rd.GetString(3) + "\n\n\nYour plan is:" + plan +
                                     "\n\n\n THAT IS ALL HAVE A NICE DAY";
            }
            rd.Close();
            mycon.Close();
            return info;
        }

        public static string[] getHSPInfo(int id)
        {
            string[] info = new string[12];
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from hsp where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                info[0] = rd.GetString(0);
                info[1] = rd.GetString(1);
                info[2] = rd.GetString(2);
                info[3] = rd.GetString(3);
                info[4] = rd.GetString(4);
                info[5] = rd.GetString(5);
                info[6] = rd.GetString(6);
                info[7] = rd.GetString(7);
                info[8] = rd.GetString(8);
                if (!rd.IsDBNull(9)) { info[9] = rd.GetString(9); }
                if (!rd.IsDBNull(10)) { info[10] = rd.GetString(10); }
                if (!rd.IsDBNull(11)) { info[11] = rd.GetString(11); }
 
            }
            rd.Close();
            mycon.Close();
            return info;
        }

        public static Bills getBill(int id)
        {
            int enrollee = 0;
            double amount = 0;
            int servicenumber = 0;
            int billid = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select id, enrollee$id, amount, service from bills where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                billid = rd.GetInt32(0);
                enrollee = rd.GetInt32(1);
                amount = rd.GetDouble(2);
                servicenumber = rd.GetInt32(3);
            }
            Bills b = new Bills(amount, enrollee, servicenumber, billid);
            rd.Close();
            mycon.Close();
            return b;
        }

        public static List<Bills> getBillsFromEnrollee(int id)
        {
            List<Bills> bills = new List<Bills>();
            int i = 0;
            int enrollee;
            double amount;
            int billid;
            int servicenumber;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select id, enrollee$id, amount, service, isPaid from bills where enrollee$id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                billid = rd.GetInt32(0);
                enrollee = rd.GetInt32(1);
                amount = rd.GetDouble(2);
                servicenumber = rd.GetInt32(3);
                bills.Add(new Bills(amount, enrollee, servicenumber, billid));
                i++;
            }
            rd.Close();
            mycon.Close();
            return bills;
        }
        public static bool findHSP(string name)
        {
            bool found = false;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from hsp where company=" + name;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                found = true;
            }
            rd.Close();
            mycon.Close();
            return found;
        }

        public static string getPlanType(int id)
        {
            string plan = "";
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select * from plan where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                plan = rd.GetString(1);
            }
            rd.Close();
            mycon.Close();
            return plan;
        }


        public static int validateEnrolleeWithPin(string pin)
        {
            int id = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select id from primaryEnrollee where pin=" + pin;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                id = rd.GetInt32(0);
            }
            rd.Close();
            mycon.Close();
            return id;
        }

        public static int validateHSPWithPin(string pin)
        {
            int id = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select id from hsp where pin=" + pin;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                id = rd.GetInt32(0);
            }
            rd.Close();
            mycon.Close();
            return id;
        }

        public static void changePlan(int id)
        {
            int planid = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select plan$id from primaryEnrollee where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                planid = rd.GetInt32(0);
            }

            string type = "";
            query = "select type from plan where id=" + planid;
            cmd.CommandText = query;
            cmd.Prepare();
            rd.Close();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                type = rd.GetString(0);
            }

            if (type == "basic")
            {
                query = "update plan set type = 'extended' where id=" + planid;
            }
            else
            {
                query = "update plan set type = 'basic' where id=" + planid;
            }
            rd.Close();
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
            if(type == "basic") { DBMng.updateDeductible(id, 250); }
            else { DBMng.updateDeductible(id, 0); }
        }

        public static void editPrimaryEnrollee(int id, string name, string username, string password, string mAdd, string bAdd, string email, string phone, string pin)
        {
            int allempty = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "update primaryEnrollee SET";
            if (name != "") { query = query + " name=" + name + ","; allempty = 1; }
            if (username != "") { query = query + " username=" + username + ","; allempty = 1; }
            if (password != "") { query = query + " password=" + password + ","; allempty = 1; }
            if (mAdd != "") { query = query + " mAddress=" + mAdd + ","; allempty = 1; }
            if (bAdd != "") { query = query + " bAddress=" + bAdd + ","; allempty = 1; }
            if (email != "") { query = query + " email=" + email + ","; allempty = 1; }
            if (phone != "") { query = query + " phoneNumber=" + phone + ","; allempty = 1; }
            if (pin != "") { query = query + " pin=" + pin + ","; allempty = 1; }
            if (allempty != 0) { query = query.TrimEnd(',') + " ";}
            query = query + " where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static string getPlanTypeEnrollee(int id)
        {
            int planid = 0;
            string plantype;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select plan$id from primaryEnrollee where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                planid = rd.GetInt32(0);
            }
            rd.Close();
            mycon.Close();
            plantype = DBMng.getPlanType(planid);
            return plantype;
        }
        public static int getDeductible(int id)
        {
            int deductible = 0;
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select deductible from primaryEnrollee where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                deductible = rd.GetInt32(0);
            }
            rd.Close();
            mycon.Close();
            return deductible;
        }
        public static void updateDeductible(int id, int amt)
        {   
            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "update primaryEnrollee set deductible=" + amt + " where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();   
        } 

        public static void updateIsPaid(int id)
        {
            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "update bills set isPaid='True' where id=" + id;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

       



        public static int getCurrentMonth()
        {

            MySqlConnection mycon = new MySqlConnection();
            mycon = connectAtSIUE();
            mycon.Open();

            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            string getDate = "SELECT MONTH(CURRENT_TIMESTAMP);";
            cmd.CommandText = getDate;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();
            int month = rd.GetInt32(0);
            rd.Close();
            return month;
        }

        public static int[] findNumEnrollees() 
        {
            MySqlConnection mycon = new MySqlConnection();
            mycon = connectAtSIUE();
            mycon.Open();

            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            

            // creating array to hold number of enrollees per plan. Length =  2 because there are two plans
            int[] enrolleesInEachPlan = new int[2];
            int j = 1;

            string getEnrollees = "SELECT COUNT(*) FROM primaryEnrollee" +
                                      "WHERE plan$id = " + j + ";";
            cmd.CommandText = getEnrollees;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();

            enrolleesInEachPlan[j - 1] = rd.GetInt32(0);

            j++;

            getEnrollees = "SELECT COUNT(*) FROM primaryEnrollee" +
                                      "WHERE plan$id = " + j + ";";
            cmd.CommandText = getEnrollees;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();

            enrolleesInEachPlan[j - 1] = rd.GetInt32(0);

            rd.Close();
            return enrolleesInEachPlan;
        }

        

        

        public static int getNumBills()
        {
            MySqlConnection mycon = new MySqlConnection();
            mycon = connectAtSIUE();
            mycon.Open();

            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            string getBills = "SELECT COUNT (*) FROM bills;";
            cmd.CommandText = getBills;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();
            int numBills = rd.GetInt32(0);
            rd.Close();
            // mycon.Close();
            return numBills;
        }

        

        public static int[] getBillAmountsViaDate(string dateEntered)
        {
            string[] parsing = dateEntered.Split('-');
            string firstDate = parsing[0];
            string secondDate = parsing[1];

            int[] amounts = new int[20];
            
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select amount from bills where date BETWEEN '" + firstDate + "' 00:00:00.00" + "AND '" + secondDate + "' 00:00:00.00;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            int i = 0;
            while (rd.Read())
            {
                amounts[i] = rd.GetInt32(0);
                
                i++;
            }
            rd.Close();
            mycon.Close();
            return amounts;
        }
        public static string[] getBillServicesViaDate(string dateEntered)
        {
            string[] parsing = dateEntered.Split('-');
            string firstDate = parsing[0];
            string secondDate = parsing[1];

            
            string[] services = new string[20];
            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select service from bills where date BETWEEN '" + firstDate + "' 00:00:00.00" + "AND '" + secondDate + "' 00:00:00.00;";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            int i = 0;
            while (rd.Read())
            {
               
                services[i] = rd.GetString(0);
                i++;
            }
            rd.Close();
            mycon.Close();
            return services;
        }

        public static void addAccountant(string firstName, string lastName)
        {
            MySqlConnection mycon = connectOutOfSIUE();
            mycon.Open();
            string query = "insert into accountants (firstName, lastName) " +
                            " values (\"" + firstName + "\", \"" + lastName + "\" )";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }

        public static Boolean checkAccountantExists(string firstName, string lastName)
        {
            Boolean doesExist = false;

            MySqlConnection mycon = connectOutOfSIUE();
            MySqlDataReader rd;
            mycon.Open();
            string query = "select firstName,lastName from accountants where firstName = \"" + firstName + "\" AND lastName = \"" + lastName +"\";";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            cmd.CommandText = query;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            
            if (rd.Read())
            {
                doesExist = true;
            }
            rd.Close();
            mycon.Close();
            return doesExist;
        }
    }
}
