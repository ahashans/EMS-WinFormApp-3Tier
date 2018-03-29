using System;
using System.Data;
using System.Windows.Forms;
using Cognizant.Dotnet.EMS.BusinessLayer;
using Cognizant.Dotnet.Ems.EntityLayer;

namespace _3_Tier
{
    public partial class AddDeptDtls : Form
    {
        BusinessAddDepartment Businessobj;
        private EntityAddDepartment objEntityAddDept;
        DataTable dt;
        public AddDeptDtls()
        {
            InitializeComponent();
        }

        public void FillData()
        {
            dt = new DataTable();
            Businessobj = new BusinessAddDepartment();
            dt = Businessobj.BusinessFillLocation();
            cmbxLocation.DisplayMember = dt.Columns[1].ToString();

            cmbxLocation.DataSource = dt;
        }
        private void AddDeptDtls_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StoreData(Convert.ToInt32(txtDeptId.Text),txtDeptName.Text, Convert.ToDouble(txtDeptSal.Text), cmbxLocation.Text);
        }

        public void StoreData(int id, string name, double sal, string loc)
        {
            Businessobj = new BusinessAddDepartment();
            objEntityAddDept = new EntityAddDepartment
            {
                DeptId = id,
                DeptName = name,
                DeptSal = sal,
                DeptLoc = loc
            };
            var result = Businessobj.BusinessAddDeptDtls(objEntityAddDept);
            MessageBox.Show(result == 1 ? "Department Successfully Added" : "Error occured. Department not Added.");
        }
    }
}
