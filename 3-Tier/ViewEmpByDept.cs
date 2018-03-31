using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognizant.Dotnet.Ems.EntityLayer;
using Cognizant.Dotnet.EMS.BusinessLayer;

namespace _3_Tier
{
    public partial class ViewEmpByDept : Form
    {
        private DataTable dt;
        private DataTable dt1 ;
        private BusinessViewEmpDtls Businessobj;
        private EntityAddEmployee objEntityAddEmployee;
        public ViewEmpByDept()
        {
            InitializeComponent();
            Businessobj = new BusinessViewEmpDtls();
            objEntityAddEmployee = new EntityAddEmployee();
            dt1 = new DataTable();
            dt = new DataTable();
        }

        private void cmbxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Res = ValidateDeptName(cmbxDept.Text);
            dtgvEmpDtls.DataSource = null;
            dtgvEmpDtls.Rows.Clear();
            dtgvEmpDtls.Columns.Clear();
            dtgvEmpDtls.Refresh();
            if (Res == 1)
            {
                dt1 = Businessobj.BusinessFillEmpDtls(cmbxDept.Text);
                if (dt1.Rows.Count > 0)
                {
                    dtgvEmpDtls.DataSource = dt1;
                    dtgvEmpDtls.Refresh();
                }
                else
                {
                    MessageBox.Show("No Record Found!");
                                        
                }
                
            }
        }
        private void FillData()
        {            
            dt = Businessobj.BusinessFillDepartment();
            cmbxDept.DisplayMember = dt.Columns[1].ToString();
            cmbxDept.DataSource = dt;            

        }

        private void ViewEmpByDept_Load(object sender, EventArgs e)
        {
            FillData();
        }

        public int ValidateDeptName(string deptName)
        {
            if (String.IsNullOrWhiteSpace(deptName))
                return 0;
            else
                return 1;
        }
    }
}
