using System;
using System.Data;
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
        private int[] DeptSal = new[] { 0, 1, 10000, 2000000, 2000001 };
        private string[] DeptName = new[] { "A String", "123456", " ", "", "abcdefghijklmnopqrstuvwxyz" };
        private string[] DeptLoc = new[] { "Building A", "Building B", " ","" };
        [TestInitialize]
        public void Init()
        {
            objBusinessAddDept = new BusinessAddDepartment();
            objEntityAddDept = new EntityAddDepartment();
        }


        




        //DeptSal
        [TestMethod]
        public void TestBusinessAddDepartmentWithZeroDeptSal2()
        {            
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[0];
            objEntityAddDept.DeptLoc = DeptLoc[1];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
       
        
        [TestMethod]
        public void TestBusinessAddDepartmentWithUnderRangeDeptSal5()
        {
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[1];
            objEntityAddDept.DeptLoc = DeptLoc[3];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithOverRangeDeptSal6()
        {            
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[4];
            objEntityAddDept.DeptLoc = DeptLoc[3];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
        




        //DeptName
        [TestMethod]
        public void TestBusinessAddDepartmentWithEmptyDeptName8()
        {            
            objEntityAddDept.DeptName = DeptName[2];
            objEntityAddDept.DeptSal = DeptSal[1];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithNumericDeptName10()
        {            
            objEntityAddDept.DeptName = DeptName[1];
            objEntityAddDept.DeptSal = DeptSal[4];
            objEntityAddDept.DeptLoc = DeptLoc[2];
            Assert.ThrowsException<ArgumentException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithNullDeptName13()
        {

            objEntityAddDept.DeptName = DeptName[3];
            objEntityAddDept.DeptSal = DeptSal[4];
            objEntityAddDept.DeptLoc = DeptLoc[1];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }

        [TestMethod]
        public void TestBusinessAddDepartmentWithOverRangeString()
        {
            objEntityAddDept.DeptName = DeptName[4];
            objEntityAddDept.DeptSal = DeptSal[4];
            objEntityAddDept.DeptLoc = DeptLoc[1];
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));

        }


        //DeptLoc//
        [TestMethod]
        public void TestBusinessAddDepartmentWithNullDeptLoc9()
        {            
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[3];
            objEntityAddDept.DeptLoc = DeptLoc[3];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }              
        [TestMethod]
        public void TestBusinessAddDepartmentWithEmptyDeptLoc12()
        {            
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[2];
            objEntityAddDept.DeptLoc = DeptLoc[2];
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }



        //Correct
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal1()
        {
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[2];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1,objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal2()
        {            
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[2];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1, objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal3()
        {            
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[3];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1, objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }
        [TestMethod]
        public void TestBusinessAddDepartmentWithCorrectVal4()
        {            
            objEntityAddDept.DeptName = DeptName[0];
            objEntityAddDept.DeptSal = DeptSal[3];
            objEntityAddDept.DeptLoc = DeptLoc[0];
            Assert.AreEqual(1, objBusinessAddDept.BusinessAddDeptDtls(objEntityAddDept));
        }




        //GetDeptIdTest
        [TestMethod]
        public void TestBusinessGetLastDeptId()
        {            
            Assert.IsTrue(objBusinessAddDept.BusinessGetLastDeptId() > 999);

        }
        [TestMethod]
        public void TestBusinessFillDepartment()
        {
            DataTable dt = objBusinessAddDept.BusinessFillLocation();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }

}
