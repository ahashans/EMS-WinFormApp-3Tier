using System;
using System.Data;
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
        private int[] ContactNo = new[] { 0, 1, 1500000000, 1999999999, 2000000000};
        private string[] stringVal = new[] {"A String", "123456"," ","", "abcdefghijklmnopqrstuvwxyzabcde", "abcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcdeabcdefghijklmnopqrstuvwxyzabcde" };
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
               
        //EmpName
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNumericEmpName6()
        {
           
            objEntityAddEmp.EmpName = stringVal[1];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[4];
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithOverRangeEmpName8()
        {

            objEntityAddEmp.EmpName = stringVal[4];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithEmptyEmpName8()
        {
           
            objEntityAddEmp.EmpName = stringVal[2];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNullEmpName7()
        {
            
            objEntityAddEmp.EmpName = stringVal[3];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
              
               
        
        
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNumericDeptName16()
        {
            
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[1];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = 1;
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithEmptyDeptName15()
        {
            
            objEntityAddEmp.DepartmentName = stringVal[2];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNullDeptName12()
        {

            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[3];
            objEntityAddEmp.Location = stringVal[2];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }






        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNumericLoc17()
        {
            
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[1];
            objEntityAddEmp.ContactNo = ContactNo[2];
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithEmptyLoc()
        {

            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[2];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithOverRangeLoc8()
        {

            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[5];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithNullLoc()
        {            
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[3];
            objEntityAddEmp.ContactNo = ContactNo[4];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }

        [TestMethod]
        public void TestBusinessAddEmpDtlsWithZeroContactNo13()
        {
            
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[0];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithUnderRangeContactNo()
        {
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[1];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithOverRangeContactNo()
        {
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[4];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue1()
        {
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[2];
            Assert.AreEqual(1,objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue2()
        {            
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[2];
            Assert.AreEqual(1, objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue3()
        {

            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.AreEqual(1, objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessAddEmpDtlsWithCorrectValue4()
        {
            
            objEntityAddEmp.EmpName = stringVal[0];
            objEntityAddEmp.DepartmentName = stringVal[0];
            objEntityAddEmp.Location = stringVal[0];
            objEntityAddEmp.ContactNo = ContactNo[3];
            Assert.AreEqual(1, objBusinessAddEmp.BusinessAddEmpDetails(objEntityAddEmp));
        }
        [TestMethod]
        public void TestBusinessGetLastEmpId()
        {
            
            Assert.IsTrue(objBusinessAddEmp.BusinessGetLastEmpId()>999);
        }
        [TestMethod]
        public void TestBusinessFillDepartment()
        {

            DataTable dt = objBusinessAddEmp.BusinessFillDepartment();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count>0);            
        }
    }
}
