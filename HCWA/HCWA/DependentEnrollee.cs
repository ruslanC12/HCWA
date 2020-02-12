using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
    public class DependentEnrollee : Enrollee
    {
        private String relationship;

        public DependentEnrollee(String fullname, String relationship)
        {
            this.fullname = fullname;
            this.relationship = relationship;
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

        public override void login()
        {
            throw new NotImplementedException();
        }
    }
}
