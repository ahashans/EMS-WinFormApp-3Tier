using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Cognizant.Dotnet.Ems.DataLayer
{
    public class DataAddEmployee {

        static string conStr = ConfigurationManager.AppSettings["Connection"];

        SqlConnection objConnnection = new SqlConnection(conStr);
        SqlCommand objCommand;
        SqlDataAdapter objAdapter;
        DataSet objDataSet = new DataSet();

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
            catch (Exception e)
            {
                throw new InvalidOperationException();
            }
            objConnnection.Close();
            return result;


        }
        public DataSet DataFillDeptDetails() {
            objCommand = new SqlCommand("USPDept", objConnnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            objConnnection.Open();
            objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet, "Department");
            objConnnection.Close();
            return objDataSet;

        }

        public DataSet DataFillLocationDetails() {
            objCommand = new SqlCommand("USPLocation", objConnnection);
            objCommand.CommandType = CommandType.StoredProcedure;
            objConnnection.Open();
            objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet, "Location");
            objConnnection.Close();
            return objDataSet;

        }


    }
}
