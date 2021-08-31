﻿
namespace MasterDetailsCRUDapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvEmpCompany = new System.Windows.Forms.DataGridView();
            this.btnImageClear = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.rbtContractual = new System.Windows.Forms.RadioButton();
            this.rbtRegular = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmpCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 792);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvEmpCompany);
            this.tabPage1.Controls.Add(this.btnImageClear);
            this.tabPage1.Controls.Add(this.btnImageBrowse);
            this.tabPage1.Controls.Add(this.pbxPhoto);
            this.tabPage1.Controls.Add(this.rbtContractual);
            this.tabPage1.Controls.Add(this.rbtRegular);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbGender);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtpDOB);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbPosition);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEmpName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textEmpCode);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 759);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(6, 681);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 62);
            this.panel1.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SandyBrown;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(563, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 34);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(474, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(385, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvEmpCompany
            // 
            this.dgvEmpCompany.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmpCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpCompany.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpCompany.Location = new System.Drawing.Point(6, 428);
            this.dgvEmpCompany.Name = "dgvEmpCompany";
            this.dgvEmpCompany.RowTemplate.Height = 25;
            this.dgvEmpCompany.Size = new System.Drawing.Size(1097, 238);
            this.dgvEmpCompany.TabIndex = 16;
            // 
            // btnImageClear
            // 
            this.btnImageClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnImageClear.Location = new System.Drawing.Point(894, 321);
            this.btnImageClear.Name = "btnImageClear";
            this.btnImageClear.Size = new System.Drawing.Size(84, 31);
            this.btnImageClear.TabIndex = 15;
            this.btnImageClear.Text = "Clear";
            this.btnImageClear.UseVisualStyleBackColor = false;
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnImageBrowse.Location = new System.Drawing.Point(894, 268);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(84, 31);
            this.btnImageBrowse.TabIndex = 14;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = false;
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxPhoto.Location = new System.Drawing.Point(591, 57);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(270, 302);
            this.pbxPhoto.TabIndex = 13;
            this.pbxPhoto.TabStop = false;
            // 
            // rbtContractual
            // 
            this.rbtContractual.AutoSize = true;
            this.rbtContractual.Location = new System.Drawing.Point(252, 330);
            this.rbtContractual.Name = "rbtContractual";
            this.rbtContractual.Size = new System.Drawing.Size(109, 24);
            this.rbtContractual.TabIndex = 12;
            this.rbtContractual.TabStop = true;
            this.rbtContractual.Text = "Contractual";
            this.rbtContractual.UseVisualStyleBackColor = true;
            // 
            // rbtRegular
            // 
            this.rbtRegular.AutoSize = true;
            this.rbtRegular.Location = new System.Drawing.Point(158, 330);
            this.rbtRegular.Name = "rbtRegular";
            this.rbtRegular.Size = new System.Drawing.Size(83, 24);
            this.rbtRegular.TabIndex = 11;
            this.rbtRegular.TabStop = true;
            this.rbtRegular.Text = "Regular";
            this.rbtRegular.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "State";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(158, 270);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(326, 28);
            this.cmbGender.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(158, 210);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(326, 26);
            this.dtpDOB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Of Birth";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(158, 155);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(326, 28);
            this.cmbPosition.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Position";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(158, 107);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(326, 26);
            this.txtEmpName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emp. Name";
            // 
            // textEmpCode
            // 
            this.textEmpCode.Location = new System.Drawing.Point(158, 57);
            this.textEmpCode.Name = "textEmpCode";
            this.textEmpCode.Size = new System.Drawing.Size(326, 26);
            this.textEmpCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp. Code";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 759);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Register";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.Location = new System.Drawing.Point(28, 21);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(1054, 709);
            this.dgvEmployee.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 814);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "C# Master Details CRUD APP";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvEmpCompany;
        private System.Windows.Forms.Button btnImageClear;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.RadioButton rbtContractual;
        private System.Windows.Forms.RadioButton rbtRegular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmpCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}
