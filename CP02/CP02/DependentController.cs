using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02
{
    //controller class for dependent
    public class DependentController
    {
        //adding dependent to an Enrollee
        public string addDependent(String fullname, String relationship, PrimaryEnrollee P)
        {
            //creating dependent enrollee
            DependentEnrollee d = new DependentEnrollee(fullname, relationship);
            //linking dependent enrollee to their primary
            P.dependents.Add(d);
            return "Successfully added";

        }
        //removing dependent from Enrollee
        public string removeDependent(int index, PrimaryEnrollee P)
        {
            //removing dependent from Primary Enrollee
            P.dependents.RemoveAt(index);
            return "Successfully Removed";

        }
    }
}