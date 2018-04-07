using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Cognizant.Dotnet.Ems.DataLayer;

namespace Cognizant.Dotnet.EMS.BusinessLayer
{
    public class BusinessViewEmpDtls
    {
        private DataTable objDatatable;
        private DataTable objDatatable1;
        private DataViewEmpDtls objDataViewEmpDtls;

        public BusinessViewEmpDtls()
        {
            objDatatable = new DataTable();
            objDatatable1 = new DataTable();
            objDataViewEmpDtls = new DataViewEmpDtls();
        }
        public DataTable BusinessFillDepartment()
        {

            objDatatable.Clear();
            objDatatable = objDataViewEmpDtls.DataFillDeptDetails().Tables["Department"];
            return objDatatable;
        }

        public int ValidateDeptName(string DeptName)
        {
            int res = 0;
            var reg = new Regex("^[a-zA-Z ]*$");
            if (!reg.IsMatch(DeptName) ||String.IsNullOrWhiteSpace(DeptName))
            {
                throw new ArgumentNullException();
            }
            else
            {
                res = 1;
            }
                return res;
        }
        public DataTable BusinessFillEmpDtls(string DeptName)
        {
            int DeptNameStatus = ValidateDeptName(DeptName);
            if (DeptNameStatus == 1)
            {
                objDatatable1.Clear();
                SqlParameter DataParamDeptName = new SqlParameter("@DeptName", SqlDbType.VarChar, 25) { Value = DeptName };

                try
                {
                    objDatatable1 = objDataViewEmpDtls.DataFillEmpDtls(DataParamDeptName).Tables["EmpInfo"];
                }
                catch (SqlException e)
                {
                    throw new Exception();
                }

                
            }
            return objDatatable1;
        }
    }
}