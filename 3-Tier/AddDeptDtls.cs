using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
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
            objEntityAddDept = new EntityAddDepartment();
            Businessobj = new BusinessAddDepartment();
        }
        public void FillData()
        {
            dt = new DataTable();
            Businessobj = new BusinessAddDepartment();
            dt = Businessobj.BusinessFillLocation();
            cmbxLocation.DisplayMember = dt.Columns[1].ToString();
            cmbxLocation.DataSource = dt;
            cmbxLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            txtDeptId.Text = (Businessobj.BusinessGetLastDeptId()+1).ToString();
        }
        private void AddDeptDtls_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StoreData(txtDeptName.Text, txtDeptSal.Text, cmbxLocation.Text);
            FillData();
        }

        public void StoreData(string name, string sal, string loc)
        {
            int result =0;
            var reg = new Regex("^[a-zA-Z ]*$");
            if (double.TryParse(sal, out double _))
            {
                objEntityAddDept = new EntityAddDepartment
                {                    
                    DeptName = name.Trim(),
                    DeptSal = Convert.ToDouble(sal),
                    DeptLoc = loc
                };                
                if (!reg.IsMatch(objEntityAddDept.DeptName) || String.IsNullOrWhiteSpace(objEntityAddDept.DeptName) || objEntityAddDept.DeptName.Length > 25)
                {
                    if (objEntityAddDept.DeptName.Any(char.IsDigit))
                    {
                        MessageBox.Show("Invalid Department Name. Only Alphabets allowed!");
                    }
                    else if (objEntityAddDept.DeptName.Length > 25)
                    {
                        MessageBox.Show("Department name must be less than 25 characters!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Department Name. Null/Empty Not Allowed!");
                    }
                }

                else if (objEntityAddDept.DeptSal < 10000 ||
                    objEntityAddDept.DeptSal > 1000000)
                {
                    MessageBox.Show("Invalid Salary. Must be an int in between 10000 and 1000000!");
                }
                else if (String.IsNullOrWhiteSpace(objEntityAddDept.DeptLoc))
                {
                    MessageBox.Show("Invalid Location. Null/Empty not allowed!");
                  
                }
                else
                {
                    result = Businessobj.BusinessAddDeptDtls(objEntityAddDept);
                    if (result == 0)
                    {
                        MessageBox.Show("Error occured. Department not Added.");
                    }
                    else if (result == 1)
                    {
                        MessageBox.Show("Department Successfully Added");
                    }
                    else if (result == 3)
                    {
                        MessageBox.Show("Program Error Occurred");
                    }
                    else
                    {
                        MessageBox.Show("Department Id already Exist!");
                    }
                }
            }            
            else if (!double.TryParse(sal, out double _))
            {
                MessageBox.Show("Invalid Department Salary Must be only Digits!");
            }
                        
        }
    }
}
