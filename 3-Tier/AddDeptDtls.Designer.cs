namespace _3_Tier
{
    partial class AddDeptDtls
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
            this.lblDeptId = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtDeptSal = new System.Windows.Forms.TextBox();
            this.lblDeptSal = new System.Windows.Forms.Label();
            this.lblDeptLoc = new System.Windows.Forms.Label();
            this.cmbxLocation = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(58, 45);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(74, 13);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.Text = "Department Id";
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(157, 42);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(100, 20);
            this.txtDeptId.TabIndex = 1;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(157, 79);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(100, 20);
            this.txtDeptName.TabIndex = 3;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(39, 82);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(93, 13);
            this.lblDeptName.TabIndex = 2;
            this.lblDeptName.Text = "Department Name";
            // 
            // txtDeptSal
            // 
            this.txtDeptSal.Location = new System.Drawing.Point(157, 118);
            this.txtDeptSal.Name = "txtDeptSal";
            this.txtDeptSal.Size = new System.Drawing.Size(100, 20);
            this.txtDeptSal.TabIndex = 5;
            // 
            // lblDeptSal
            // 
            this.lblDeptSal.AutoSize = true;
            this.lblDeptSal.Location = new System.Drawing.Point(39, 122);
            this.lblDeptSal.Name = "lblDeptSal";
            this.lblDeptSal.Size = new System.Drawing.Size(94, 13);
            this.lblDeptSal.TabIndex = 4;
            this.lblDeptSal.Text = "Department Salary";
            // 
            // lblDeptLoc
            // 
            this.lblDeptLoc.AutoSize = true;
            this.lblDeptLoc.Location = new System.Drawing.Point(40, 164);
            this.lblDeptLoc.Name = "lblDeptLoc";
            this.lblDeptLoc.Size = new System.Drawing.Size(106, 13);
            this.lblDeptLoc.TabIndex = 6;
            this.lblDeptLoc.Text = "Department Location";
            // 
            // cmbxLocation
            // 
            this.cmbxLocation.FormattingEnabled = true;
            this.cmbxLocation.Location = new System.Drawing.Point(157, 161);
            this.cmbxLocation.Name = "cmbxLocation";
            this.cmbxLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbxLocation.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(157, 220);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddDeptDtls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 368);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbxLocation);
            this.Controls.Add(this.lblDeptLoc);
            this.Controls.Add(this.txtDeptSal);
            this.Controls.Add(this.lblDeptSal);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.lblDeptId);
            this.Name = "AddDeptDtls";
            this.Text = "Add Department Details";
            this.Load += new System.EventHandler(this.AddDeptDtls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptSal;
        private System.Windows.Forms.Label lblDeptSal;
        private System.Windows.Forms.Label lblDeptLoc;
        private System.Windows.Forms.ComboBox cmbxLocation;
        private System.Windows.Forms.Button btnSubmit;
    }
}