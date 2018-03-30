using System.Data;
using System.Data.SqlClient;
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
        public int BusinessAddEmpDetails(EntityAddEmployee objEntityAddEmployee) {

            //objDatatable.Clear();
            if (objEntityAddEmployee.EmpID!=null && objEntityAddEmployee.EmpName != null &&
                objEntityAddEmployee.DepartmentName != null &&
                objEntityAddEmployee.Location!= null &&
                objEntityAddEmployee.ContactNo != null)
            {
                if (objEntityAddEmployee.EmpID < 1000 ||
                    objEntityAddEmployee.EmpID > 2000000)
                {
                    return 3;
                }
                if (objEntityAddEmployee.ContactNo < 1500000000 ||
                    objEntityAddEmployee.ContactNo > 1999999999)
                {
                    return 3;
                }
                if (int.TryParse(objEntityAddEmployee.EmpName, out int _))
                {
                    return 3;
                }
                if (int.TryParse(objEntityAddEmployee.Location, out int _))
                {
                    return 3;
                }
                if (int.TryParse(objEntityAddEmployee.DepartmentName, out int _))
                {
                    return 3;
                }
            }
            SqlParameter[] objDataParams = new SqlParameter[5];
            objDataParams[0] = new SqlParameter("@EmpId", SqlDbType.Int) {Value = objEntityAddEmployee.EmpID};

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
