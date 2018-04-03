using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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
            var reg = new Regex("^[a-zA-Z ]*$");
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
                    MessageBox.Show("Invalid Employee Id. Must be an int in between 10000 to 2000000.");
                    return 2;
                }

                else if (
                    !reg.IsMatch(objEntityAddEmployee.EmpName) ||
                         String.IsNullOrWhiteSpace(objEntityAddEmployee.EmpName))
                {
                    if (!reg.IsMatch(objEntityAddEmployee.EmpName))
                    {
                        MessageBox.Show("Invalid Employee Name. Only letters and space allowed!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee Name. Empty field not allowed");
                    }
                    return 2;
                }
                else if (double.TryParse(objEntityAddEmployee.Location, out double _) ||
                         String.IsNullOrWhiteSpace(objEntityAddEmployee.Location))
                {
                    if (double.TryParse(objEntityAddEmployee.Location, out double _))
                    {
                        MessageBox.Show("Invalid Location. Must contain some alphabets!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Location. Empty/Null Not allowed!");
                    }
                    return 2;
                }
                else if (String.IsNullOrWhiteSpace(objEntityAddEmployee.DepartmentName))
                {
                    MessageBox.Show("Invalid Department Name. Please Select a Department!");
                    return 2;
                }
                else if (objEntityAddEmployee.ContactNo < 1500000000 ||
                         objEntityAddEmployee.ContactNo > 1999999999)
                {
                    MessageBox.Show("Invalid Contact Number. Must be an int in between 01500000000 and 01999999999");
                    return 2;
                }
                else
                {
                    BusinessAddEmployee objBusinessAddEmpDtls = new BusinessAddEmployee();
                    int res = objBusinessAddEmpDtls.BusinessAddEmpDetails(objEntityAddEmployee);
                    return res; 
                }
            }
            else if (!int.TryParse(id, out int _))
            {
                MessageBox.Show("Invalid Employee Id. Empty/Null Not allowed!");
                return 2;
            }
            else 
            {
                MessageBox.Show("Invalid Contact Number. Empty/Null Not allowed!");
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
                MessageBox.Show("Employee Id already exist!");

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
            BusinessAddEmployee objBusinessAddEmpDtls = new BusinessAddEmployee();
            dt = objBusinessAddEmpDtls.BusinessFillDepartment();
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