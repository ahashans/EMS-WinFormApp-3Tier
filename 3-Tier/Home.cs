using System;
using System.Windows.Forms;

namespace _3_Tier
{
    public partial class Home : Form
    {
        private AddEmployeeDtls objAddEmpDtlsForm;
        private ViewEmpByDept objViewEmpdByDeptForm;
        private AddDeptDtls objAddDeptDtlsForm;
        public Home()
        {
            InitializeComponent();
            //objAddDeptDtlsForm = new AddDeptDtls();
            //objAddEmpDtlsForm = new AddEmployeeDtls();
            //objViewEmpdByDeptForm = new ViewEmpByDept();
        }
        private void createEmployeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objAddEmpDtlsForm == null)
            {
                objAddEmpDtlsForm = new AddEmployeeDtls();
                objAddEmpDtlsForm.MdiParent = this;
                objAddEmpDtlsForm.FormClosed += ObjAddEmpDtlsForm_FormClosed;
                objAddEmpDtlsForm.Show();
            }
            else
            {
                objAddEmpDtlsForm.Activate();
            }
        }

        private void ObjAddEmpDtlsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            objAddEmpDtlsForm = null;
            //throw new NotImplementedException();
        }

        private void viewEmployeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objViewEmpdByDeptForm == null)
            {
                objViewEmpdByDeptForm = new ViewEmpByDept();
                objViewEmpdByDeptForm.MdiParent = this;
                objViewEmpdByDeptForm.FormClosed += ObjViewEmpdByDeptForm_FormClosed;
                objViewEmpdByDeptForm.Show();
            }
            else
            {
                objViewEmpdByDeptForm.Activate();
            }
        }

        private void ObjViewEmpdByDeptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            objViewEmpdByDeptForm = null;
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objAddDeptDtlsForm == null)
            {
                objAddDeptDtlsForm  = new AddDeptDtls();
                objAddDeptDtlsForm.MdiParent = this;
                objAddDeptDtlsForm.FormClosed += ObjAddDeptDtlsForm_FormClosed;
                objAddDeptDtlsForm.Show();
            }
            else
            {
                objAddDeptDtlsForm.Activate();
            }
        }

        private void ObjAddDeptDtlsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            objAddDeptDtlsForm = null;
            //throw new NotImplementedException();
        }
    }
}
