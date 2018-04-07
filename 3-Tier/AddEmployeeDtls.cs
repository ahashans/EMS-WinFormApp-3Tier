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

        public int ValidateEmpDtlsInfo(string name, string dept, string loc, string cont)
        {
            var reg = new Regex("^[a-zA-Z ]*$");
            if (long.TryParse(cont, out long _))
            {                
                objEntityAddEmployee.EmpName = name;
                objEntityAddEmployee.DepartmentName = dept;
                objEntityAddEmployee.Location = loc;
                objEntityAddEmployee.ContactNo = Convert.ToInt64(cont);
                if (!reg.IsMatch(objEntityAddEmployee.EmpName) ||
                         String.IsNullOrWhiteSpace(objEntityAddEmployee.EmpName)|| objEntityAddEmployee.EmpName.Length>30)
                {
                    if (!reg.IsMatch(objEntityAddEmployee.EmpName))
                    {
                        MessageBox.Show("Invalid Employee Name. Only letters and space allowed!");
                    }
                    else if (objEntityAddEmployee.EmpName.Length > 30)
                    {
                        MessageBox.Show("Employee Name must be less than 30 characters");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee Name. Empty field not allowed");
                    }
                    return 2;
                }
                else if (double.TryParse(objEntityAddEmployee.Location, out double _) ||
                         String.IsNullOrWhiteSpace(objEntityAddEmployee.Location) || objEntityAddEmployee.Location.Length>250)
                {
                    if (double.TryParse(objEntityAddEmployee.Location, out double _))
                    {
                        MessageBox.Show("Invalid Location. Must contain some alphabets!");
                    }
                    else if (objEntityAddEmployee.Location.Length > 250)
                    {
                        MessageBox.Show("Location Must be less than 250 characters");
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
            else 
            {
                MessageBox.Show("Invalid Contact Number. Empty/Null/Alphabets Not allowed!");
                return 2;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int result = ValidateEmpDtlsInfo(txtEname.Text, cmbDept.Text, txtLocation.Text, txtContactno.Text);
            if (result == 1)
            {
                MessageBox.Show("Registration successfull");
                txtLocation.Text = "";
                txtContactno.Text = "";
                txtEname.Text = "";
                cmbDept.SelectedIndex = 0;
            }
            else if (result == 2)
            {
                //MessageBox.Show("You have Registered successfully");

            }
            else if (result == 3)
            {
                MessageBox.Show("Database Error!");

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
            BusinessAddEmployee objBusinessAddEmpDtls = new BusinessAddEmployee();
            dt = objBusinessAddEmpDtls.BusinessFillDepartment();
            cmbDept.DisplayMember = dt.Columns[1].ToString();
            cmbDept.DataSource = dt;
            cmbDept.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEid.Text = (objBusinessAddEmpDtls.BusinessGetLastEmpId()+1).ToString();

        }
    }
}