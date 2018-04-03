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
            if (objEntityAddEmployee.EmpID < 1000 ||
                objEntityAddEmployee.EmpID >= 2000000
            )
            {
                if (objEntityAddEmployee.EmpID < 1000 ||
                    objEntityAddEmployee.EmpID >= 2000000)
                {
                    throw new ArgumentOutOfRangeException();
                }               
            }
            if (!reg.IsMatch(objEntityAddEmployee.EmpName)  || String.IsNullOrWhiteSpace(objEntityAddEmployee.EmpName))
            {
                if (String.IsNullOrWhiteSpace(objEntityAddEmployee.EmpName))
                {
                    throw new ArgumentNullException();
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
            if (double.TryParse(objEntityAddEmployee.Location, out double _ ) || String.IsNullOrWhiteSpace(objEntityAddEmployee.Location))
            {
                if (String.IsNullOrWhiteSpace(objEntityAddEmployee.Location))
                {
                    throw new ArgumentNullException();
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
                if (objEntityAddEmployee.ContactNo< 1500000000 ||
                    objEntityAddEmployee.ContactNo > 1999999999)
                {
                    throw new ArgumentOutOfRangeException();
                }                
            }            
            flag= 1;
            return flag;
        }
        public int BusinessAddEmpDetails(EntityAddEmployee objEntityAddEmployee) {

            if (ValidateEmpDtlsInfo(objEntityAddEmployee) != 1)
            {
                return 4;
            }
            SqlParameter[] objDataParams = new SqlParameter[5];

            objDataParams[0] = 
                new SqlParameter("@EmpId", SqlDbType.Int) {Value = objEntityAddEmployee.EmpID};

            objDataParams[1] =
                new SqlParameter("@EmpName", SqlDbType.VarChar, 25) {Value = objEntityAddEmployee.EmpName};


            objDataParams[2] =
                new SqlParameter("@DeptName", SqlDbType.VarChar, 25) {Value = objEntityAddEmployee.DepartmentName};

            objDataParams[3] =
                new SqlParameter("@Location", SqlDbType.VarChar, 25) {Value = objEntityAddEmployee.Location};

            objDataParams[4] = 
                new SqlParameter("@ContactNumber", SqlDbType.BigInt) {Value = objEntityAddEmployee.ContactNo};


            var result = objDataAddEmp.DataAddEmployeeDetails(objDataParams);

            return result;

        }


        public DataTable BusinessFillDepartment() {

            objDatatable.Clear();
            objDatatable = objDataAddEmp.DataFillDeptDetails().Tables["Department"];
            return objDatatable;


        }
        public DataTable BusinessFillLocation() {
            objDatatable1.Clear();
            objDatatable1 = objDataAddEmp.DataFillLocationDetails().Tables["Location"];
            return objDatatable1;
        }

    }
}
