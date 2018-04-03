using System;
using System.Windows.Forms;

namespace _3_Tier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddEmployeeDtls());
            //Application.Run(new AddDeptDtls());
            //Application.Run(new ViewEmpByDept());
            Application.Run(new Home());
        }
    }
}
