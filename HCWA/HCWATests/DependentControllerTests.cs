using Microsoft.VisualStudio.TestTools.UnitTesting;
using CP02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP02.Tests
{
    [TestClass()]
    public class DependentControllerTests
    {
        [TestMethod()]
        public void addDependentTest()
        {
            PrimaryEnrollee P = new PrimaryEnrollee("testname", "333", "adr", "adr", "user", "pass", "asdf");
            DependentController DCont = new DependentController();
            DCont.addDependent("testname2","relate", P);
            Assert.IsNotNull(P.dependents);
        }

        [TestMethod()]
        public void removeDependentTest()
        {
            PrimaryEnrollee J = new PrimaryEnrollee("testname", "333", "adr", "adr", "user", "pass");
            PrimaryEnrollee P = new PrimaryEnrollee("testname", "333", "adr", "adr", "user", "pass");
            DependentController DCont = new DependentController();
            DependentEnrollee d = new DependentEnrollee("name", "relate");
            P.dependents.Add(d);
            DCont.removeDependent(0, P);
            CollectionAssert.AreEqual(P.dependents, J.dependents);
        }
    }
}