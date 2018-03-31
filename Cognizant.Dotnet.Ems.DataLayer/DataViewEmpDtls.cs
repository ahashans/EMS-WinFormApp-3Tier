using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Cognizant.Dotnet.Ems.DataLayer
{
    public class DataViewEmpDtls
    {
        private static string conStr;

        private SqlConnection objConnnection;
        SqlCommand objCommand;
        SqlDataAdapter objAdapter;
        SqlDataAdapter objAdapter2;
        private DataSet objDataSet;
        private DataSet objDataSet2;
        public DataViewEmpDtls()
        {
            conStr = ConfigurationManager.AppSettings["Connection"];
            objConnnection = new SqlConnection(conStr);
            objDataSet = new DataSet();
            objDataSet2 = new DataSet();
        }
        public DataSet DataFillDeptDetails()
        {
            objCommand = new SqlCommand("USPDept");
            objCommand.Connection = objConnnection;
            objCommand.CommandType = CommandType.StoredProcedure;
            objConnnection.Open();
            objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet, "Department");
            objConnnection.Close();
            return objDataSet;

        }

        public DataSet DataFillEmpDtls(SqlParameter DeptName)
        {
            objCommand = new SqlCommand("USPViewEmpDtlsByDept");
            objCommand.Connection = objConnnection;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.Add(DeptName);
            objConnnection.Open();
            objAdapter2 = new SqlDataAdapter(objCommand);
            objAdapter2.Fill(objDataSet2, "EmpInfo");
            objConnnection.Close();
            return objDataSet2;

        }
    }

}