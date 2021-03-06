﻿namespace Employee_Checker_CSharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutEmployeeCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_GradeBook = new System.Windows.Forms.Button();
            this.btn_Province = new System.Windows.Forms.Button();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.tab_Employees = new System.Windows.Forms.TabControl();
            this.tabPage_Gradebook = new System.Windows.Forms.TabPage();
            this.dataGridView_gradeBook = new System.Windows.Forms.DataGridView();
            this.tabPage_Learners = new System.Windows.Forms.TabPage();
            this.btn_clearRichTextBox = new System.Windows.Forms.Button();
            this.btn_convertLearners = new System.Windows.Forms.Button();
            this.richTextBox_Learners = new System.Windows.Forms.RichTextBox();
            this.dataGridView_Learners = new System.Windows.Forms.DataGridView();
            this.tabPage_Compare = new System.Windows.Forms.TabPage();
            this.dataGridView_Missing = new System.Windows.Forms.DataGridView();
            this.EmployeeMissing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_print = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox_toolBox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox_Actions = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.printDocument_GradeBook = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.tab_Employees.SuspendLayout();
            this.tabPage_Gradebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gradeBook)).BeginInit();
            this.tabPage_Learners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learners)).BeginInit();
            this.tabPage_Compare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Missing)).BeginInit();
            this.groupBox_toolBox.SuspendLayout();
            this.groupBox_Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutEmployeeCheckerToolStripMenuItem});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutEmployeeCheckerToolStripMenuItem
            // 
            this.aboutEmployeeCheckerToolStripMenuItem.Name = "aboutEmployeeCheckerToolStripMenuItem";
            this.aboutEmployeeCheckerToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.aboutEmployeeCheckerToolStripMenuItem.Text = "About Employee Checker";
            // 
            // btn_GradeBook
            // 
            this.btn_GradeBook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GradeBook.Image = ((System.Drawing.Image)(resources.GetObject("btn_GradeBook.Image")));
            this.btn_GradeBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GradeBook.Location = new System.Drawing.Point(12, 42);
            this.btn_GradeBook.Name = "btn_GradeBook";
            this.btn_GradeBook.Size = new System.Drawing.Size(275, 59);
            this.btn_GradeBook.TabIndex = 1;
            this.btn_GradeBook.Text = "Step 1. Load GradeBook";
            this.btn_GradeBook.UseVisualStyleBackColor = true;
            this.btn_GradeBook.Click += new System.EventHandler(this.btn_GradeBook_Click);
            // 
            // btn_Province
            // 
            this.btn_Province.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Province.Image = ((System.Drawing.Image)(resources.GetObject("btn_Province.Image")));
            this.btn_Province.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Province.Location = new System.Drawing.Point(12, 107);
            this.btn_Province.Name = "btn_Province";
            this.btn_Province.Size = new System.Drawing.Size(273, 59);
            this.btn_Province.TabIndex = 2;
            this.btn_Province.Text = "Step 2. Load Learners Groups";
            this.btn_Province.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Province.UseVisualStyleBackColor = true;
            this.btn_Province.Click += new System.EventHandler(this.btn_Province_Click);
            // 
            // btn_Compare
            // 
            this.btn_Compare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compare.Image = ((System.Drawing.Image)(resources.GetObject("btn_Compare.Image")));
            this.btn_Compare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Compare.Location = new System.Drawing.Point(12, 172);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(273, 59);
            this.btn_Compare.TabIndex = 3;
            this.btn_Compare.Text = "Step 3. Compare files";
            this.btn_Compare.UseVisualStyleBackColor = true;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click);
            // 
            // tab_Employees
            // 
            this.tab_Employees.Controls.Add(this.tabPage_Gradebook);
            this.tab_Employees.Controls.Add(this.tabPage_Learners);
            this.tab_Employees.Controls.Add(this.tabPage_Compare);
            this.tab_Employees.Controls.Add(this.tabPage1);
            this.tab_Employees.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Employees.Location = new System.Drawing.Point(301, 42);
            this.tab_Employees.Name = "tab_Employees";
            this.tab_Employees.SelectedIndex = 0;
            this.tab_Employees.Size = new System.Drawing.Size(755, 506);
            this.tab_Employees.TabIndex = 4;
            // 
            // tabPage_Gradebook
            // 
            this.tabPage_Gradebook.Controls.Add(this.dataGridView_gradeBook);
            this.tabPage_Gradebook.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Gradebook.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Gradebook.Name = "tabPage_Gradebook";
            this.tabPage_Gradebook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Gradebook.Size = new System.Drawing.Size(747, 479);
            this.tabPage_Gradebook.TabIndex = 0;
            this.tabPage_Gradebook.Text = "Gradebook";
            this.tabPage_Gradebook.UseVisualStyleBackColor = true;
            // 
            // dataGridView_gradeBook
            // 
            this.dataGridView_gradeBook.AllowUserToAddRows = false;
            this.dataGridView_gradeBook.AllowUserToDeleteRows = false;
            this.dataGridView_gradeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_gradeBook.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_gradeBook.Name = "dataGridView_gradeBook";
            this.dataGridView_gradeBook.Size = new System.Drawing.Size(735, 467);
            this.dataGridView_gradeBook.TabIndex = 0;
            // 
            // tabPage_Learners
            // 
            this.tabPage_Learners.Controls.Add(this.btn_clearRichTextBox);
            this.tabPage_Learners.Controls.Add(this.btn_convertLearners);
            this.tabPage_Learners.Controls.Add(this.richTextBox_Learners);
            this.tabPage_Learners.Controls.Add(this.dataGridView_Learners);
            this.tabPage_Learners.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Learners.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Learners.Name = "tabPage_Learners";
            this.tabPage_Learners.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Learners.Size = new System.Drawing.Size(747, 479);
            this.tabPage_Learners.TabIndex = 1;
            this.tabPage_Learners.Text = "Learners Group";
            this.tabPage_Learners.UseVisualStyleBackColor = true;
            // 
            // btn_clearRichTextBox
            // 
            this.btn_clearRichTextBox.Image = ((System.Drawing.Image)(resources.GetObject("btn_clearRichTextBox.Image")));
            this.btn_clearRichTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clearRichTextBox.Location = new System.Drawing.Point(154, 284);
            this.btn_clearRichTextBox.Name = "btn_clearRichTextBox";
            this.btn_clearRichTextBox.Size = new System.Drawing.Size(117, 80);
            this.btn_clearRichTextBox.TabIndex = 3;
            this.btn_clearRichTextBox.Text = "     Reset";
            this.btn_clearRichTextBox.UseVisualStyleBackColor = true;
            this.btn_clearRichTextBox.Click += new System.EventHandler(this.btn_clearRichTextBox_Click);
            // 
            // btn_convertLearners
            // 
            this.btn_convertLearners.Image = ((System.Drawing.Image)(resources.GetObject("btn_convertLearners.Image")));
            this.btn_convertLearners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_convertLearners.Location = new System.Drawing.Point(154, 191);
            this.btn_convertLearners.Name = "btn_convertLearners";
            this.btn_convertLearners.Size = new System.Drawing.Size(117, 87);
            this.btn_convertLearners.TabIndex = 2;
            this.btn_convertLearners.Text = "      Convert";
            this.btn_convertLearners.UseVisualStyleBackColor = true;
            this.btn_convertLearners.Click += new System.EventHandler(this.btn_convertLearners_Click);
            // 
            // richTextBox_Learners
            // 
            this.richTextBox_Learners.Location = new System.Drawing.Point(154, 15);
            this.richTextBox_Learners.Name = "richTextBox_Learners";
            this.richTextBox_Learners.Size = new System.Drawing.Size(469, 158);
            this.richTextBox_Learners.TabIndex = 1;
            this.richTextBox_Learners.Text = "";
            this.richTextBox_Learners.TextChanged += new System.EventHandler(this.richTextBox_Learners_TextChanged);
            // 
            // dataGridView_Learners
            // 
            this.dataGridView_Learners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Learners.Location = new System.Drawing.Point(308, 185);
            this.dataGridView_Learners.Name = "dataGridView_Learners";
            this.dataGridView_Learners.Size = new System.Drawing.Size(315, 266);
            this.dataGridView_Learners.TabIndex = 0;
            // 
            // tabPage_Compare
            // 
            this.tabPage_Compare.Controls.Add(this.dataGridView_Missing);
            this.tabPage_Compare.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Compare.Name = "tabPage_Compare";
            this.tabPage_Compare.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Compare.Size = new System.Drawing.Size(747, 479);
            this.tabPage_Compare.TabIndex = 2;
            this.tabPage_Compare.Text = "Missing from GradeBook";
            this.tabPage_Compare.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Missing
            // 
            this.dataGridView_Missing.AllowUserToAddRows = false;
            this.dataGridView_Missing.AllowUserToDeleteRows = false;
            this.dataGridView_Missing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Missing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeMissing});
            this.dataGridView_Missing.Location = new System.Drawing.Point(152, 24);
            this.dataGridView_Missing.Name = "dataGridView_Missing";
            this.dataGridView_Missing.ReadOnly = true;
            this.dataGridView_Missing.Size = new System.Drawing.Size(383, 333);
            this.dataGridView_Missing.TabIndex = 0;
            // 
            // EmployeeMissing
            // 
            this.EmployeeMissing.HeaderText = "EmployeeMissing";
            this.EmployeeMissing.MinimumWidth = 10;
            this.EmployeeMissing.Name = "EmployeeMissing";
            this.EmployeeMissing.ReadOnly = true;
            this.EmployeeMissing.Width = 200;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 479);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "GradeBook merged with missing Learners ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.Image")));
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(18, 19);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(143, 50);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "Print";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(18, 75);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(143, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Download";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(18, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Email";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox_toolBox
            // 
            this.groupBox_toolBox.Controls.Add(this.btn_print);
            this.groupBox_toolBox.Controls.Add(this.button3);
            this.groupBox_toolBox.Controls.Add(this.button2);
            this.groupBox_toolBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_toolBox.Location = new System.Drawing.Point(1062, 42);
            this.groupBox_toolBox.Name = "groupBox_toolBox";
            this.groupBox_toolBox.Size = new System.Drawing.Size(183, 196);
            this.groupBox_toolBox.TabIndex = 8;
            this.groupBox_toolBox.TabStop = false;
            this.groupBox_toolBox.Text = "Tools";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(12, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "Step 4. Merge with Gradebook";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox_Actions
            // 
            this.groupBox_Actions.Controls.Add(this.btn_Calculate);
            this.groupBox_Actions.Controls.Add(this.radioButton1);
            this.groupBox_Actions.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Actions.Location = new System.Drawing.Point(12, 301);
            this.groupBox_Actions.Name = "groupBox_Actions";
            this.groupBox_Actions.Size = new System.Drawing.Size(275, 111);
            this.groupBox_Actions.TabIndex = 10;
            this.groupBox_Actions.TabStop = false;
            this.groupBox_Actions.Text = "Actions";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(93, 82);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(87, 23);
            this.btn_Calculate.TabIndex = 11;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(267, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Total employees with certificates";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(763, 562);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(165, 16);
            this.lbl_Message.TabIndex = 11;
            this.lbl_Message.Text = "Output Message Here";
            // 
            // printDocument_GradeBook
            // 
            this.printDocument_GradeBook.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_GradeBook_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 607);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.groupBox_Actions);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox_toolBox);
            this.Controls.Add(this.tab_Employees);
            this.Controls.Add(this.btn_Compare);
            this.Controls.Add(this.btn_Province);
            this.Controls.Add(this.btn_GradeBook);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Employee Checker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_Employees.ResumeLayout(false);
            this.tabPage_Gradebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_gradeBook)).EndInit();
            this.tabPage_Learners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learners)).EndInit();
            this.tabPage_Compare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Missing)).EndInit();
            this.groupBox_toolBox.ResumeLayout(false);
            this.groupBox_Actions.ResumeLayout(false);
            this.groupBox_Actions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutEmployeeCheckerToolStripMenuItem;
        private System.Windows.Forms.Button btn_GradeBook;
        private System.Windows.Forms.Button btn_Province;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.TabControl tab_Employees;
        private System.Windows.Forms.TabPage tabPage_Gradebook;
        private System.Windows.Forms.TabPage tabPage_Learners;
        private System.Windows.Forms.TabPage tabPage_Compare;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView_gradeBook;
        private System.Windows.Forms.GroupBox groupBox_toolBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox_Actions;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView_Learners;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_convertLearners;
        private System.Windows.Forms.RichTextBox richTextBox_Learners;
        public System.Windows.Forms.Button btn_clearRichTextBox;
        private System.Windows.Forms.DataGridView dataGridView_Missing;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeMissing;
        private System.Drawing.Printing.PrintDocument printDocument_GradeBook;
    }
}

