using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
    public abstract class Enrollee
    {
        protected String fullname;
        protected String ssn;
        protected String pin;
        public static Boolean plan; // if plan == true, enrollee has extended plan
        
        public static List<PrimaryEnrollee> primaries = new List<PrimaryEnrollee>();
        public List<DependentEnrollee> dependents = new List<DependentEnrollee>();
        public static String CurrentUser;

        abstract public String getFullname();
        abstract public String getSSN();
        abstract public void setFullname(String fullname);
        abstract public void setSSN(String ssn);

        // Feel free to add to this if you think of any use cases I forgot
        abstract public void login();

    }
}
