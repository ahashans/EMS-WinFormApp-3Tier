using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Cognizant.Dotnet.Ems.DataLayer
{
    public class DataAddEmployee
    {
        private static string conStr;

        private SqlConnection objConnnection;
        SqlCommand objCommand;
        SqlDataAdapter objAdapter;
        private DataSet objDataSet;

        public DataAddEmployee()
        {

            conStr = ConfigurationManager.AppSettings["Connection"];
            objConnnection = new SqlConnection(conStr);
            objDataSet = new DataSet();
        }
        public int DataAddEmployeeDetails(SqlParameter[] objParams) {
            objCommand = new SqlCommand("USPEmpDtls", objConnnection);
            objCommand.CommandType = CommandType.StoredProcedure;

            objCommand.Parameters.AddRange(objParams);
            objConnnection.Open();
    
            int result;

            try
            {
                result = objCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                objConnnection.Close();
                return 3;
            }
            finally
            {
                objConnnection.Close();
            }
            //result = objCommand.ExecuteNonQuery();
            //objConnnection.Close();
            return result;
        }
        public DataSet DataFillDeptDetails()
        {
            objCommand = new SqlCommand("USPDept");
            objCommand.Connection = objConnnection;
            objCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                if (objConnnection.State != ConnectionState.Open)
                {
                    objConnnection.Close();
                    objConnnection.Open();
                }
                objAdapter = new SqlDataAdapter(objCommand);
            }
            catch (Exception e)
            {
                objConnnection.Close();
                throw e;
            }
            finally
            {
                objConnnection.Close();
            }
            objAdapter.Fill(objDataSet, "Department");
            objConnnection.Close();
            return objDataSet;

        }

        public SqlParameter DataGetLastEmpId(SqlParameter EmpId)
        {

            objCommand = new SqlCommand("USPGetLastEmptId", objConnnection) { CommandType = CommandType.StoredProcedure };
            objCommand.Parameters.Add(EmpId);
            objConnnection.Open();
            int result;
            try
            {
                result = objCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                objConnnection.Close();
                throw e;
            }
            objConnnection.Close();
            return objCommand.Parameters["@EmpId"];
        }


    }
}
