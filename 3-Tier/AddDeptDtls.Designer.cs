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
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.txtDeptSal = new System.Windows.Forms.TextBox();
            this.lblDeptSal = new System.Windows.Forms.Label();
            this.lblDeptLoc = new System.Windows.Forms.Label();
            this.cmbxLocation = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDeptId = new System.Windows.Forms.Label();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.lblDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptName.Location = new System.Drawing.Point(4, 83);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(133, 16);
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
            this.lblDeptSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptSal.Location = new System.Drawing.Point(4, 123);
            this.lblDeptSal.Name = "lblDeptSal";
            this.lblDeptSal.Size = new System.Drawing.Size(137, 16);
            this.lblDeptSal.TabIndex = 4;
            this.lblDeptSal.Text = "Department Salary";
            // 
            // lblDeptLoc
            // 
            this.lblDeptLoc.AutoSize = true;
            this.lblDeptLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptLoc.Location = new System.Drawing.Point(4, 162);
            this.lblDeptLoc.Name = "lblDeptLoc";
            this.lblDeptLoc.Size = new System.Drawing.Size(151, 16);
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
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptId.Location = new System.Drawing.Point(4, 46);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(105, 16);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.Text = "Department Id";
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(157, 46);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.Size = new System.Drawing.Size(100, 20);
            this.txtDeptId.TabIndex = 1;
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
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox txtDeptSal;
        private System.Windows.Forms.Label lblDeptSal;
        private System.Windows.Forms.Label lblDeptLoc;
        private System.Windows.Forms.ComboBox cmbxLocation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.TextBox txtDeptId;
    }
}