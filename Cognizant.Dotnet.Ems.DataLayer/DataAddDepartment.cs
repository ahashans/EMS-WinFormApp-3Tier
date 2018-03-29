using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Cognizant.Dotnet.Ems.DataLayer
{
    public class DataAddDepartment
    {
        private static readonly string conStr = ConfigurationManager.AppSettings["Connection"];

        SqlConnection objConnnection = new SqlConnection(conStr);
        SqlCommand objCommand;
        SqlDataAdapter objAdapter;
        DataSet objDataSet = new DataSet();

        public int DataAddDepartmentDetails(SqlParameter[] objParams)
        {
            objCommand = new SqlCommand("USPAddDept", objConnnection) {CommandType = CommandType.StoredProcedure};


            objCommand.Parameters.AddRange(objParams);
            objConnnection.Open();

            var result = objCommand.ExecuteNonQuery();
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