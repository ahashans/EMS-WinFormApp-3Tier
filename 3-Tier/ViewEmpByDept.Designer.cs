namespace _3_Tier
{
    partial class ViewEmpByDept
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
            this.lblDept = new System.Windows.Forms.Label();
            this.cmbxDept = new System.Windows.Forms.ComboBox();
            this.dtgvEmpDtls = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpDtls)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(12, 26);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 0;
            this.lblDept.Text = "Department";
            // 
            // cmbxDept
            // 
            this.cmbxDept.FormattingEnabled = true;
            this.cmbxDept.Location = new System.Drawing.Point(80, 26);
            this.cmbxDept.Name = "cmbxDept";
            this.cmbxDept.Size = new System.Drawing.Size(121, 21);
            this.cmbxDept.TabIndex = 1;
            this.cmbxDept.SelectedIndexChanged += new System.EventHandler(this.cmbxDept_SelectedIndexChanged);
            // 
            // dtgvEmpDtls
            // 
            this.dtgvEmpDtls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpDtls.Location = new System.Drawing.Point(33, 102);
            this.dtgvEmpDtls.Name = "dtgvEmpDtls";
            this.dtgvEmpDtls.Size = new System.Drawing.Size(613, 179);
            this.dtgvEmpDtls.TabIndex = 2;
            // 
            // ViewEmpByDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 350);
            this.Controls.Add(this.dtgvEmpDtls);
            this.Controls.Add(this.cmbxDept);
            this.Controls.Add(this.lblDept);
            this.Name = "ViewEmpByDept";
            this.Text = "ViewEmpByDept";
            this.Load += new System.EventHandler(this.ViewEmpByDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpDtls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.ComboBox cmbxDept;
        private System.Windows.Forms.DataGridView dtgvEmpDtls;
    }
}