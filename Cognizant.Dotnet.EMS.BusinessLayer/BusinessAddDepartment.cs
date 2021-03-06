﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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

        public int ValidateDeptDtls(EntityAddDepartment objEntityAddDept)
        {
            var reg = new Regex("^[a-zA-Z ]*$");
            int res = 0;
            if (!reg.IsMatch(objEntityAddDept.DeptName) ||
                     String.IsNullOrWhiteSpace(objEntityAddDept.DeptName) || objEntityAddDept.DeptName.Length>25)
            {
                if (String.IsNullOrWhiteSpace(objEntityAddDept.DeptName))
                {
                    throw new ArgumentNullException();
                }
                else if (objEntityAddDept.DeptName.Length > 25)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                    throw new ArgumentException();
            }
            else if (objEntityAddDept.DeptSal < 10000 ||
                objEntityAddDept.DeptSal > 2000000)
            {

                throw new ArgumentOutOfRangeException();
            }
            else if (double.TryParse(objEntityAddDept.DeptLoc, out double _) || String.IsNullOrWhiteSpace(objEntityAddDept.DeptLoc))
            {
                if (String.IsNullOrWhiteSpace(objEntityAddDept.DeptLoc))
                {
                    throw new ArgumentNullException();
                }
                else 
                    throw new ArgumentException();
            }
            
            else
            {
                res = 1;
            }
            return res;
        }
        public int BusinessAddDeptDtls(EntityAddDepartment objEntityAddDept)
        {
            if (ValidateDeptDtls(objEntityAddDept)==1)
            {
                SqlParameter[] objDataParams = new SqlParameter[3];               
                objDataParams[0] =
                    new SqlParameter("@DeptName", SqlDbType.VarChar, 25) { Value = objEntityAddDept.DeptName };


                objDataParams[1] =
                    new SqlParameter("@DeptSalary", SqlDbType.VarChar, 25) { Value = objEntityAddDept.DeptSal };

                objDataParams[2] =
                    new SqlParameter("@DeptLocation", SqlDbType.VarChar, 25) { Value = objEntityAddDept.DeptLoc };


                int result;
                try
                {
                    result = objDataAddDept.DataAddDepartmentDetails(objDataParams);
                }
                catch (SqlException)
                {
                    return 4;
                }
                return result;
            }
            return 3;
        }

        public DataTable BusinessFillLocation()
        {
            objDatatable.Clear();
            objDatatable = objDataAddDept.DataFillLocationDetails().Tables["Location"];
            return objDatatable;
        }

        public int BusinessGetLastDeptId()
        {
            SqlParameter deptId = new SqlParameter("@DeptId", SqlDbType.Int) {Direction = ParameterDirection.Output};
            DataAddDepartment objDataAddDepartment  = new DataAddDepartment();

            try
            {
                deptId = objDataAddDepartment.DataGetLastDeptId(deptId);
            }
            catch (SqlException)
            {                
                throw new InvalidOperationException();
            }
            int DeptId = (int)deptId.Value;
            return DeptId;  
        }
    }
}