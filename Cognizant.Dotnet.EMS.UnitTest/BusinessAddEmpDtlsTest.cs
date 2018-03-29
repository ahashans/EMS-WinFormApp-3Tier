using System;
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
        [TestMethod]
        public void TestBusinessAddEmpDtls1()
        {
            objEntityAddEmp.EmpID = null;
            objEntityAddEmp.EmpName = "John Corben";
            objEntityAddEmp.DepartmentName = null;
            objEntityAddEmp.Location = null;
            objEntityAddEmp.ContactNo= 0;
            Assert.ThrowsException<InvalidOperationException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtls14()
        {
            objEntityAddEmp.EmpID = 1999999999;
            objEntityAddEmp.EmpName = "John Corben";
            objEntityAddEmp.DepartmentName = "Audit";
            objEntityAddEmp.Location = "Dhaka";
            objEntityAddEmp.ContactNo = 2000000000;
            //Assert.ThrowsException<InvalidOperationException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
            Assert.AreEqual(3, objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }

    }
}
