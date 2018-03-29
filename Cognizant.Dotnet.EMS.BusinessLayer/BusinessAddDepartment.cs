using System.Data;
using System.Data.SqlClient;
using Cognizant.Dotnet.Ems.DataLayer;
using Cognizant.Dotnet.Ems.EntityLayer;

namespace Cognizant.Dotnet.EMS.BusinessLayer
{
    public class BusinessAddDepartment
    {
        private DataTable objDatatable;
        private DataAddDepartment objDataAddDept;

        public BusinessAddDepartment()
        {
            objDatatable = new DataTable();
            objDataAddDept = new DataAddDepartment();
        }
        public int BusinessAddDeptDtls(EntityAddDepartment objEntityAddDept)
        {

            SqlParameter[] objDataParams = new SqlParameter[4];
            objDataParams[0] = new SqlParameter("@DeptId", SqlDbType.Int) { Value = objEntityAddDept.DeptId };

            objDataParams[1] =
                new SqlParameter("@DeptName", SqlDbType.VarChar, 25) { Value = objEntityAddDept.DeptName };


            objDataParams[2] =
                new SqlParameter("@DeptSalary", SqlDbType.VarChar, 25) { Value = objEntityAddDept.DeptSal };

            objDataParams[3] =
                new SqlParameter("@DeptLocation", SqlDbType.VarChar, 25) { Value = objEntityAddDept.DeptLoc };


            var result = objDataAddDept.DataAddDepartmentDetails(objDataParams);

            return result;

        }

        public DataTable BusinessFillLocation()
        {
            objDatatable.Clear();
            objDatatable = objDataAddDept.DataFillLocationDetails().Tables["Location"];
            return objDatatable;
        }
    }
}