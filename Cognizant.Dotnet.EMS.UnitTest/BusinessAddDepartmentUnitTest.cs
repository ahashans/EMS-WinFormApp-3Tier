using System;
using Cognizant.Dotnet.Ems.EntityLayer;
using Cognizant.Dotnet.EMS.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cognizant.Dotnet.EMS.UnitTest
{
    [TestClass]
    public class BusinessAddDepartmentUnitTest
    {
        private BusinessAddDepartment objBusinessAddDept;
        private EntityAddDepartment objEntityAddDept;
        private int[] DeptId = new[] { 0, 1, 1000, 1999, 2000 };
        private int[] DeptSal = new[] { 0, 1, 10000, 2000000, 2000001 };
        private string[] DeptName = new[] { "A String", "123456", " ", "" };
        private string[] DeptLoc = new[] { "Building A", "Building B", " ","" };
        [TestInitialize]
        public void Init()
        {
            objBusinessAddDept = new BusinessAddDepartment();
            objEntityAddDept = new EntityAddDepartment();
        }


        //DeptId//
        [TestMethod]
        public void TestBusinessAddDepartmentWithZeroDeptId1()
        {
            objEntityAddDept.DeptId= DeptId[0];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[0];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.ThrowsException<ArgumentOutOfRangeException>(()=> objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithUnderRangeDeptId3()
        {
            objEntityAddDept.DeptId = DeptId[1];
            objEntityAddDept.DeptName = DeptName[3];
            objEntityAddDept.DeptSal = DeptSal[2];
            objEntityAddDept.DeptLoc = DeptLoc[3];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithOverRangeDeptId4()
        {
            objEntityAddDept.DeptId = DeptId[4];
            objEntityAddDept.DeptName = DeptName[2];
            objEntityAddDept.DeptSal = DeptSal[3];
            objEntityAddDept.DeptLoc = DeptLoc[2];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }




        //DeptSal
        [TestMethod]
        public void TestBusinessAddDepartmentWithZeroDeptSal2()
        {
            objEntityAddDept.DeptId = DeptId[2];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[0];
            objEntityAddDept.DeptLoc = DeptLoc[1];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
       
        
        [TestMethod]
        public void TestBusinessAddDepartmentWithUnderRangeDeptSal5()
        {
            objEntityAddDept.DeptId = DeptId[2];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[1];
            objEntityAddDept.DeptLoc = DeptLoc[3];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithOverRangeDeptSal6()
        {
            objEntityAddDept.DeptId = DeptId[3];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[4];
            objEntityAddDept.DeptLoc = DeptLoc[3];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        




        //DeptName
        [TestMethod]
        public void TestBusinessAddDepartmentWithEmptyDeptName8()
        {
            objEntityAddDept.DeptId = DeptId[2];
            objEntityAddDept.DeptName = DeptName[2];
            objEntityAddDept.DeptSal = DeptSal[1];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithNumericDeptName10()
        {
            objEntityAddDept.DeptId = DeptId[3];
            objEntityAddDept.DeptName = DeptName[1];
            objEntityAddDept.DeptSal = DeptSal[4];
            objEntityAddDept.DeptLoc = DeptLoc[2];
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithNullDeptName13()
        {
            objEntityAddDept.DeptId = DeptId[3];
            objEntityAddDept.DeptName = DeptName[3];
            objEntityAddDept.DeptSal = DeptSal[4];
            objEntityAddDept.DeptLoc = DeptLoc[1];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }




        //DeptLoc//
        [TestMethod]
        public void TestBusinessAddDepartmentWithNullDeptLoc9()
        {
            objEntityAddDept.DeptId = DeptId[2];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[3];
            objEntityAddDept.DeptLoc = DeptLoc[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }              
        [TestMethod]
        public void TestBusinessAddDepartmentWithEmptyDeptLoc12()
        {
            objEntityAddDept.DeptId = DeptId[3];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[2];
            objEntityAddDept.DeptLoc = DeptLoc[2];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }



        //Correct
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal1()
        {
            objEntityAddDept.DeptId = DeptId[2];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[2];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1,objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal2()
        {
            objEntityAddDept.DeptId = DeptId[3];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[2];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1, objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal3()
        {
            objEntityAddDept.DeptId = DeptId[2];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[3];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1, objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal4()
        {
            objEntityAddDept.DeptId = DeptId[3];
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[3];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1, objBusinessAddDept.ValidateDeptDtls(objEntityAddDept));
        }
    }

}
