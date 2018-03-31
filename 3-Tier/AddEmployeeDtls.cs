using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Cognizant.Dotnet.EMS.BusinessLayer;
using Cognizant.Dotnet.Ems.EntityLayer;




namespace _3_Tier
{
    public partial class AddEmployeeDtls : Form
    {
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        private BusinessAddEmployee Businessobj;
        private EntityAddEmployee objEntityAddEmployee;

        public AddEmployeeDtls()
        {
            InitializeComponent();
            objEntityAddEmployee = new EntityAddEmployee();
            Businessobj = new BusinessAddEmployee();
        }

        public int ValidateEmpDtlsInfo(string id, string name, string dept, string loc, string cont)
        {
            if (int.TryParse(id, out int _) && long.TryParse(cont, out long _))
            {
                objEntityAddEmployee.EmpID = Convert.ToInt32(id);
                objEntityAddEmployee.EmpName = name;
                objEntityAddEmployee.DepartmentName = dept;
                objEntityAddEmployee.Location = loc;
                objEntityAddEmployee.ContactNo = Convert.ToInt64(cont);

                if (objEntityAddEmployee.EmpID < 1000 ||
                    objEntityAddEmployee.EmpID > 2000000)
                {
                    MessageBox.Show("Invalid Employee Id");
                    return 2;
                }

                else if (
                    objEntityAddEmployee.EmpName.Any(char.IsDigit) ||
                         String.IsNullOrWhiteSpace(objEntityAddEmployee.EmpName))
                {
                    MessageBox.Show("Invalid Employee Name");
                    return 2;
                }
                else if (double.TryParse(objEntityAddEmployee.Location, out double _) ||
                         String.IsNullOrWhiteSpace(objEntityAddEmployee.Location))
                {
                    MessageBox.Show("Invalid Location");
                    return 2;
                }
                else if (objEntityAddEmployee.DepartmentName == null ||
                         double.TryParse(objEntityAddEmployee.DepartmentName, out double _) ||
                         String.IsNullOrWhiteSpace(objEntityAddEmployee.DepartmentName))
                {
                    MessageBox.Show("Invalid Department Name");
                    return 2;
                }
                else if (objEntityAddEmployee.ContactNo < 1500000000 ||
                         objEntityAddEmployee.ContactNo > 1999999999)
                {
                    MessageBox.Show("Invalid Contact Number");
                    return 2;
                }
                else
                {
                    int res = Businessobj.BusinessAddEmpDetails(objEntityAddEmployee);
                    return res; 
                }
            }
            else if (!int.TryParse(id, out int _))
            {
                MessageBox.Show("Invalid Employee Id");
                return 2;
            }
            else 
            {
                MessageBox.Show("Invalid Contact Number");
                return 2;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int result = ValidateEmpDtlsInfo(txtEid.Text, txtEname.Text, cmbDept.Text, txtLocation.Text, txtContactno.Text);
            if (result == 1)
            {
                MessageBox.Show("Registration successfull");
                txtLocation.Text = "";
                txtContactno.Text = "";
                txtEid.Text = "";
                txtEname.Text = "";
                cmbDept.SelectedIndex = 0;
            }
            else if (result == 2)
            {
                //MessageBox.Show("You have Registered successfully");

            }
            else if (result == 3)
            {
                MessageBox.Show("Server Error!");

            }
            else if (result == 4)
            {
                MessageBox.Show("System Error!");

            }
            else
            {
                MessageBox.Show("Registration Failed");
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
//            dt1 = Businessobj.BusinessFillLocation();
//            Cmbloc.DisplayMember = dt1.Columns[1].ToString();
//
//            Cmbloc.DataSource = dt1;

        }
    }
}