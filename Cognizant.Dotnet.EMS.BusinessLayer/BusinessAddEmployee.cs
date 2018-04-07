using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using Cognizant.Dotnet.Ems.EntityLayer;
using Cognizant.Dotnet.Ems.DataLayer;


namespace Cognizant.Dotnet.EMS.BusinessLayer {
    public class BusinessAddEmployee {
        DataTable objDatatable ;
        DataTable objDatatable1 ;
        DataAddEmployee objDataAddEmp ;


        public BusinessAddEmployee()
        {
            objDatatable = new DataTable();
            objDatatable1 = new DataTable();
            objDataAddEmp = new DataAddEmployee();
        }

        public int ValidateEmpDtlsInfo(EntityAddEmployee objEntityAddEmployee)
        {
            int flag = 0;
            var reg = new Regex("^[a-zA-Z ]*$");            
            if (!reg.IsMatch(objEntityAddEmployee.EmpName)  || String.IsNullOrWhiteSpace(objEntityAddEmployee.EmpName) || objEntityAddEmployee.EmpName.Length>25)
            {
                if (String.IsNullOrWhiteSpace(objEntityAddEmployee.EmpName))
                {
                    throw new ArgumentNullException();
                }
                else if (objEntityAddEmployee.EmpName.Length > 25)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            if (double.TryParse(objEntityAddEmployee.DepartmentName, out double _) || String.IsNullOrWhiteSpace(objEntityAddEmployee.DepartmentName))
            {
                if (String.IsNullOrWhiteSpace(objEntityAddEmployee.DepartmentName))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    throw new ArgumentException();
                  }
            }
            if (double.TryParse(objEntityAddEmployee.Location, out double _ ) || String.IsNullOrWhiteSpace(objEntityAddEmployee.Location) || objEntityAddEmployee.Location.Length>250)
            {
                if (String.IsNullOrWhiteSpace(objEntityAddEmployee.Location))
                {
                    throw new ArgumentNullException();
                }
                else if (objEntityAddEmployee.Location.Length > 250)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    throw new ArgumentException();
                }

            }
            if (objEntityAddEmployee.ContactNo< 1500000000 ||
                objEntityAddEmployee.ContactNo > 1999999999
            )
            {                
                throw new ArgumentOutOfRangeException();
            }            
            flag= 1;
            return flag;
        }
        public int BusinessAddEmpDetails(EntityAddEmployee objEntityAddEmployee) {

            if (ValidateEmpDtlsInfo(objEntityAddEmployee) != 1)
            {
                return 4;
            }
            SqlParameter[] objDataParams = new SqlParameter[4];


            objDataParams[0] =
                new SqlParameter("@EmpName", SqlDbType.VarChar, 30) {Value = objEntityAddEmployee.EmpName};


            objDataParams[1] =
                new SqlParameter("@DeptName", SqlDbType.VarChar, 25) {Value = objEntityAddEmployee.DepartmentName};

            objDataParams[2] =
                new SqlParameter("@Location", SqlDbType.VarChar, 250) {Value = objEntityAddEmployee.Location};

            objDataParams[3] = 
                new SqlParameter("@ContactNumber", SqlDbType.BigInt) {Value = objEntityAddEmployee.ContactNo};


            var result = objDataAddEmp.DataAddEmployeeDetails(objDataParams);

            return result;

        }


        public DataTable BusinessFillDepartment() {

            objDatatable.Clear();
            try
            {
                objDatatable = objDataAddEmp.DataFillDeptDetails().Tables["Department"];
            }
            catch (SqlException)
            {
                //throw e;
            }
            return objDatatable;


        }
        public int BusinessGetLastEmpId()
        {
            SqlParameter EmpId = new SqlParameter("@EmpId", SqlDbType.Int) { Direction = ParameterDirection.Output };
            DataAddEmployee objDataAddEmployee = new DataAddEmployee();

            try
            {
                EmpId  = objDataAddEmployee.DataGetLastEmpId(EmpId);
            }
            catch (SqlException)
            {
                throw new InvalidOperationException();
            }
            int empId = (int)EmpId.Value;
            return empId;
        }
    }
}
