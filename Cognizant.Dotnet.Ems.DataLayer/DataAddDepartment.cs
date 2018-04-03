using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Cognizant.Dotnet.Ems.DataLayer
{
    public class DataAddDepartment
    {
        private static string conStr;
        private SqlConnection objConnnection;
        SqlCommand objCommand;
        SqlDataAdapter objAdapter;
        DataSet objDataSet;
        public DataAddDepartment()
        {
            conStr = ConfigurationManager.AppSettings["Connection"];
            objConnnection = new SqlConnection(conStr);
            objDataSet = new DataSet();
            objDataSet = new DataSet();
        }
        


        public int DataAddDepartmentDetails(SqlParameter[] objParams)
        {
            objCommand = new SqlCommand("USPAddDept");
            objCommand.Connection = objConnnection;
            objCommand.CommandType = CommandType.StoredProcedure;


            objCommand.Parameters.AddRange(objParams);
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
            return result;


        }
        public DataSet DataFillLocationDetails()
        {
            objCommand = new SqlCommand("USPLocation", objConnnection) {CommandType = CommandType.StoredProcedure};
            objConnnection.Open();
            objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet, "Location");
            objConnnection.Close();
            return objDataSet;

        }
    }
}