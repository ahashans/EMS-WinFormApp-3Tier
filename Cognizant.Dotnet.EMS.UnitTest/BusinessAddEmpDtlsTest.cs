using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Cognizant.Dotnet.Ems.EntityLayer;
using Cognizant.Dotnet.EMS.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cognizant.Dotnet.EMS.UnitTest
{
    [TestClass]
    public class BusinessAddEmpDtlsTest
    {
        private BusinessAddEmployee objBusinessAddEmp;
        private EntityAddEmployee objEntityAddEmp;
        [TestInitialize]
        public void Init()
        {
            objBusinessAddEmp = new BusinessAddEmployee();
            objEntityAddEmp = new EntityAddEmployee();

        }
        [TestCleanup]
        public void Dest()
        {
            

        }
        [TestMethod]
        //[ExpectedException())]
        public void TestBusinessAddEmpDtls1()
        {
            objEntityAddEmp.EmpID = null;
            objEntityAddEmp.EmpName = "John Corben";
            objEntityAddEmp.DepartmentName = null;
            objEntityAddEmp.Location = null;
            objEntityAddEmp.ContactNo= 0;
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtls14()
        {
            objEntityAddEmp.EmpID = 19999;
            objEntityAddEmp.EmpName = "John Corben";
            objEntityAddEmp.DepartmentName = "Audit";
            objEntityAddEmp.Location = "Dhaka";
            objEntityAddEmp.ContactNo = 2000000000;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]        
        public void TestBusinessAddEmpDtls15()
        {
            Random r = new Random();
            
            objEntityAddEmp.EmpID = r.Next(1000, 2000000);
            objEntityAddEmp.EmpName = "John Die";
            objEntityAddEmp.DepartmentName = "Audit";
            objEntityAddEmp.Location = "Dhaka";
            objEntityAddEmp.ContactNo = Convert.ToInt64(01999999999);           
            Assert.AreEqual(1, objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));            
        }
    }
}
