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
        private int[] EmpId = new[] {0, 1,1000 ,1999999, 2000000};
        private int[] ContactNo = new[] { 0, 1, 1500000000, 1999999999, 2000000000};
        private string[] stringVal = new[] {"A String", "123456"," ",""};
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
        public void TestBusinessAddEmpDtlsWithZeroEmpId1()
        {
            objEntityAddEmp.EmpID = EmpId[0];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithUnderRangeEmpId3()
        {
            objEntityAddEmp.EmpID = EmpId[1];
            objEntityAddEmp.EmpName = stringVal[2];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[3];
            objEntityAddEmp.ContactNo = ContactNo[1];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithOverRangeEmpId8()
        {
            objEntityAddEmp.EmpID = EmpId[4];
            objEntityAddEmp.EmpName = stringVal[3];
            objEntityAddEmp.DepartmentName = stringVal[3];
            objEntityAddEmp.Location = stringVal[2];
            objEntityAddEmp.ContactNo = ContactNo[4];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
       

        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNumericEmpName6()
        {
            objEntityAddEmp.EmpID = EmpId[2];
            objEntityAddEmp.EmpName = stringVal[1];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[4];
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithEmptyEmpName8()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[2];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNullEmpName7()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[3];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
              
               
        
        
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNumericDeptName16()
        {
            objEntityAddEmp.EmpID = EmpId[2];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[1];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = 1;
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithEmptyDeptName15()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[2];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNullDeptName12()
        {
            objEntityAddEmp.EmpID = EmpId[2];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[3];
            objEntityAddEmp.Location = stringVal[2];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }






        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNumericLoc17()
        {
            objEntityAddEmp.EmpID = EmpId[2];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[2];
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithEmptyLoc()
        {
            objEntityAddEmp.EmpID = EmpId[2];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[2];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNullLoc()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[3];
            objEntityAddEmp.ContactNo = ContactNo[4];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }

        [TestMethod]
        public void TestBusinessAddEmpDtlsWithZeroContactNo13()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithUnderRangeContactNo()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[1];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithOverRangeContactNo()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[4];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue1()
        {
            objEntityAddEmp.EmpID = EmpId[2];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[2];
            Assert.AreEqual(1,objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue2()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[2];
            Assert.AreEqual(1, objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue3()
        {
            objEntityAddEmp.EmpID = EmpId[2];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.AreEqual(1, objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue4()
        {
            objEntityAddEmp.EmpID = EmpId[3];
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.AreEqual(1, objBusinessAddEmp.ValidateEmpDtlsInfo(objEntityAddEmp));
        }
    }
}
