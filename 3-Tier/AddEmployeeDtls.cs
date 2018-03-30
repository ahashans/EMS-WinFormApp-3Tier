using System;
using System.Data;
using System.Windows.Forms;
using Cognizant.Dotnet.EMS.BusinessLayer;
using Cognizant.Dotnet.Ems.EntityLayer;




namespace _3_Tier
{
    public partial class AddEmployeeDtls : Form
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        BusinessAddEmployee Businessobj = new BusinessAddEmployee();


        public AddEmployeeDtls()
        {
            InitializeComponent();
        }

        public int InsertIntoDb(EntityAddEmployee objEntityAddEmployee)
        {
            if (objEntityAddEmployee.EmpID == null || objEntityAddEmployee.EmpID < 100 ||
                objEntityAddEmployee.EmpID > 20000)
            {
                MessageBox.Show("Invalid Employee Id");
                return 2;
            }
            if (objEntityAddEmployee.ContactNo == null || objEntityAddEmployee.ContactNo < 1500000000 ||
                objEntityAddEmployee.ContactNo > 1999999999)
            {
                MessageBox.Show("Invalid Contact Number");
                return 2;
            }
            if (objEntityAddEmployee.EmpName == null || int.TryParse(objEntityAddEmployee.EmpName, out int _))
            {
                MessageBox.Show("Invalid Employee Name");
                return 2;
            }
            if (objEntityAddEmployee.Location == null || int.TryParse(objEntityAddEmployee.Location, out int _))
            {
                MessageBox.Show("Invalid Location");
                return 2;
            }
            if (objEntityAddEmployee.DepartmentName == null || int.TryParse(objEntityAddEmployee.DepartmentName, out int _))
            {
                MessageBox.Show("Invalid Department Name");
                return 2;
            }
            int res = Businessobj.BusinessAddEmpDetails(objEntityAddEmployee);
            return res;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            EntityAddEmployee Entityobj = new EntityAddEmployee();
            int result = 0;
            Entityobj.EmpID = Convert.ToInt32(txtEid.Text);
            Entityobj.EmpName = txtEname.Text;
            Entityobj.DepartmentName = cmbDept.Text;
            Entityobj.Location = Cmbloc.Text;
            Entityobj.ContactNo = Convert.ToInt64(txtContactno.Text);
            //result = Businessobj.BusinessAddEmpDetails(Entityobj);
            result = InsertIntoDb(Entityobj);

            if (result == 1)
            {
                MessageBox.Show("You have Registered successfully");
            }
            else if (result == 2)
            {
                //MessageBox.Show("You have Registered successfully");

            }
            else if (result == 3)
            {
                MessageBox.Show("Invalid Input occured in Business Layer!");

            }
            else
            {
                MessageBox.Show("You have Not Registered successfully"); ;
            }
            FillData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {                   

           FillData();

        }

       private void FillData()
        {
            //cmbDept.ValueMember = Businessobj.BusinessFillDepartment().Columns[1].ToString();
            dt = Businessobj.BusinessFillDepartment();
            cmbDept.DisplayMember = dt.Columns[1].ToString();
            cmbDept.DataSource = dt;
           // cmbDept.ValueMember = Businessobj.BusinessFillDepartment().Columns[1].ToString();
            dt1 = Businessobj.BusinessFillLocation();
            Cmbloc.DisplayMember = dt1.Columns[1].ToString();

            Cmbloc.DataSource = dt1;

        }
    }
}