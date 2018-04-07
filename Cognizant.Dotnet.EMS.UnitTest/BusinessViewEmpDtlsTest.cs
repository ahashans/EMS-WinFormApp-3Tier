using System;
using System.Data;
using Cognizant.Dotnet.EMS.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cognizant.Dotnet.EMS.UnitTest
{
    [TestClass]
    public class BusinessViewEmpDtlsTest
    {
        private BusinessViewEmpDtls objBusinessViewEmpDtls;
        private string[] stringVal = new[] {"", " ","Audit"};
        [TestInitialize]
        public void Init()
        {
            objBusinessViewEmpDtls = new BusinessViewEmpDtls();
        }
        [TestMethod]
        public void TestBusinessViewEmpDtlsWithNullDeptName()
        {
            Assert.ThrowsException<ArgumentNullException>(()=>objBusinessViewEmpDtls.BusinessFillEmpDtls(stringVal[0]));
        }
        [TestMethod]
        public void TestBusinessViewEmpDtlsWithEmptyDeptName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessViewEmpDtls.BusinessFillEmpDtls(stringVal[1]));
        }
        [TestMethod]
        public void TestBusinessViewEmpDtlsWithCorrectDeptName()
        {
            DataTable dt = objBusinessViewEmpDtls.BusinessFillEmpDtls(stringVal[2]);
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count>0);
        }
        [TestMethod]
        public void TestBusinessFillDepartment()
        {
            DataTable dt = objBusinessViewEmpDtls.BusinessFillDepartment();
            Assert.IsNotNull(dt);
            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }
}
