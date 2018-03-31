using System;
using Cognizant.Dotnet.EMS.BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cognizant.Dotnet.EMS.UnitTest
{
    [TestClass]
    public class BusinessViewEmpDtlsTest
    {
        private BusinessViewEmpDtls objBusinessViewEmpDtls;
        private string[] stringVal = new[] {"", " ","A string"};
        [TestInitialize]
        public void Init()
        {
            objBusinessViewEmpDtls = new BusinessViewEmpDtls();
        }
        [TestMethod]
        public void TestBusinessViewEmpDtlsWithNullDeptName()
        {
            Assert.ThrowsException<ArgumentNullException>(()=>objBusinessViewEmpDtls.ValidateDeptName(stringVal[0]));
        }
        [TestMethod]
        public void TestBusinessViewEmpDtlsWithEmptyDeptName()
        {
            Assert.ThrowsException<ArgumentNullException>(() => objBusinessViewEmpDtls.ValidateDeptName(stringVal[1]));
        }
        [TestMethod]
        public void TestBusinessViewEmpDtlsWithCorrectDeptName()
        {
            Assert.AreEqual(1,objBusinessViewEmpDtls.ValidateDeptName(stringVal[2]));
        }
    }
}
