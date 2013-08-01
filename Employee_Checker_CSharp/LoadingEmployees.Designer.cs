namespace Employee_Checker_CSharp
{
    partial class LoadingEmployees
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
            this.richTxtBx_employees = new System.Windows.Forms.RichTextBox();
            this.btn_ParseEmployee = new System.Windows.Forms.Button();
            this.btn_LoadIntoChecker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTxtBx_employees
            // 
            this.richTxtBx_employees.Location = new System.Drawing.Point(12, 60);
            this.richTxtBx_employees.Name = "richTxtBx_employees";
            this.richTxtBx_employees.Size = new System.Drawing.Size(465, 225);
            this.richTxtBx_employees.TabIndex = 0;
            this.richTxtBx_employees.Text = "";
            // 
            // btn_ParseEmployee
            // 
            this.btn_ParseEmployee.Location = new System.Drawing.Point(12, 301);
            this.btn_ParseEmployee.Name = "btn_ParseEmployee";
            this.btn_ParseEmployee.Size = new System.Drawing.Size(114, 38);
            this.btn_ParseEmployee.TabIndex = 1;
            this.btn_ParseEmployee.Text = "Obtain Names";
            this.btn_ParseEmployee.UseVisualStyleBackColor = true;
            this.btn_ParseEmployee.Click += new System.EventHandler(this.btn_ParseEmployee_Click);
            // 
            // btn_LoadIntoChecker
            // 
            this.btn_LoadIntoChecker.Location = new System.Drawing.Point(363, 301);
            this.btn_LoadIntoChecker.Name = "btn_LoadIntoChecker";
            this.btn_LoadIntoChecker.Size = new System.Drawing.Size(114, 38);
            this.btn_LoadIntoChecker.TabIndex = 2;
            this.btn_LoadIntoChecker.Text = "Load into EmployeeChecker";
            this.btn_LoadIntoChecker.UseVisualStyleBackColor = true;
            this.btn_LoadIntoChecker.Click += new System.EventHandler(this.btn_LoadIntoChecker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please copy and paste your names here";
            // 
            // LoadingEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LoadIntoChecker);
            this.Controls.Add(this.btn_ParseEmployee);
            this.Controls.Add(this.richTxtBx_employees);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingEmployees";
            this.Text = "LoadingEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBx_employees;
        private System.Windows.Forms.Button btn_ParseEmployee;
        private System.Windows.Forms.Button btn_LoadIntoChecker;
        private System.Windows.Forms.Label label1;
    }
}