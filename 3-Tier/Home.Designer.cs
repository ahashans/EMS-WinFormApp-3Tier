namespace _3_Tier
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.emoloyeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmployeeRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeeRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emoloyeeToolStripMenuItem,
            this.departmentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // emoloyeeToolStripMenuItem
            // 
            this.emoloyeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmployeeRecordToolStripMenuItem,
            this.viewEmployeeRecordToolStripMenuItem});
            this.emoloyeeToolStripMenuItem.Name = "emoloyeeToolStripMenuItem";
            this.emoloyeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.emoloyeeToolStripMenuItem.Text = "Emoloyee";
            // 
            // createEmployeeRecordToolStripMenuItem
            // 
            this.createEmployeeRecordToolStripMenuItem.Name = "createEmployeeRecordToolStripMenuItem";
            this.createEmployeeRecordToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createEmployeeRecordToolStripMenuItem.Text = "Create Employee Record";
            this.createEmployeeRecordToolStripMenuItem.Click += new System.EventHandler(this.createEmployeeRecordToolStripMenuItem_Click);
            // 
            // viewEmployeeRecordToolStripMenuItem
            // 
            this.viewEmployeeRecordToolStripMenuItem.Name = "viewEmployeeRecordToolStripMenuItem";
            this.viewEmployeeRecordToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.viewEmployeeRecordToolStripMenuItem.Text = "View Employee Record";
            this.viewEmployeeRecordToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeeRecordToolStripMenuItem_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem});
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.departmentToolStripMenuItem.Text = "Department";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 502);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem emoloyeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmployeeRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeeRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
    }
}