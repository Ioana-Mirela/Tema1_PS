namespace app1
{
    partial class FormAdmin
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
            this.button_addAccount = new System.Windows.Forms.Button();
            this.button_deleteAccount = new System.Windows.Forms.Button();
            this.label_logged = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.label_employee = new System.Windows.Forms.Label();
            this.panel_newAccount = new System.Windows.Forms.Panel();
            this.button_generatePass = new System.Windows.Forms.Button();
            this.textBox_newName = new System.Windows.Forms.TextBox();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.textBox_newUserName = new System.Windows.Forms.TextBox();
            this.label_newName = new System.Windows.Forms.Label();
            this.label_newPassword = new System.Windows.Forms.Label();
            this.label_newUsername = new System.Windows.Forms.Label();
            this.label_new_account = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_deleteUsername = new System.Windows.Forms.TextBox();
            this.label_deleteUsername = new System.Windows.Forms.Label();
            this.label_deleteAccount = new System.Windows.Forms.Label();
            this.panel_update = new System.Windows.Forms.Panel();
            this.button_displayUpdate = new System.Windows.Forms.Button();
            this.button_generateUpdatePass = new System.Windows.Forms.Button();
            this.button_updateAccount = new System.Windows.Forms.Button();
            this.textBox_updateRole = new System.Windows.Forms.TextBox();
            this.textBox_updateName = new System.Windows.Forms.TextBox();
            this.textBox_updatePassword = new System.Windows.Forms.TextBox();
            this.textBox_updateUsername = new System.Windows.Forms.TextBox();
            this.label_updateRole = new System.Windows.Forms.Label();
            this.label_updateName = new System.Windows.Forms.Label();
            this.label_updatePassword = new System.Windows.Forms.Label();
            this.label_updateUsername = new System.Windows.Forms.Label();
            this.label_update = new System.Windows.Forms.Label();
            this.panel_Raport = new System.Windows.Forms.Panel();
            this.panel_tabel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_report = new System.Windows.Forms.TableLayoutPanel();
            this.button_generateReport = new System.Windows.Forms.Button();
            this.panel_newAccount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_update.SuspendLayout();
            this.panel_Raport.SuspendLayout();
            this.panel_tabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_addAccount
            // 
            this.button_addAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addAccount.Location = new System.Drawing.Point(160, 116);
            this.button_addAccount.Name = "button_addAccount";
            this.button_addAccount.Size = new System.Drawing.Size(111, 25);
            this.button_addAccount.TabIndex = 0;
            this.button_addAccount.Text = "Add Account";
            this.button_addAccount.UseVisualStyleBackColor = true;
            this.button_addAccount.Click += new System.EventHandler(this.button_addAccount_Click);
            // 
            // button_deleteAccount
            // 
            this.button_deleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deleteAccount.Location = new System.Drawing.Point(104, 118);
            this.button_deleteAccount.Name = "button_deleteAccount";
            this.button_deleteAccount.Size = new System.Drawing.Size(114, 25);
            this.button_deleteAccount.TabIndex = 1;
            this.button_deleteAccount.Text = "Delete Account";
            this.button_deleteAccount.UseVisualStyleBackColor = true;
            this.button_deleteAccount.Click += new System.EventHandler(this.button_deleteAccount_Click);
            // 
            // label_logged
            // 
            this.label_logged.AutoSize = true;
            this.label_logged.Location = new System.Drawing.Point(499, 12);
            this.label_logged.Name = "label_logged";
            this.label_logged.Size = new System.Drawing.Size(103, 13);
            this.label_logged.TabIndex = 2;
            this.label_logged.Text = "Logged in as Admin:";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(680, 4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(80, 28);
            this.button_logout.TabIndex = 3;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_employee
            // 
            this.label_employee.AutoSize = true;
            this.label_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_employee.Location = new System.Drawing.Point(12, 41);
            this.label_employee.Name = "label_employee";
            this.label_employee.Size = new System.Drawing.Size(193, 20);
            this.label_employee.TabIndex = 4;
            this.label_employee.Text = "Operations on employees:";
            // 
            // panel_newAccount
            // 
            this.panel_newAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_newAccount.Controls.Add(this.button_generatePass);
            this.panel_newAccount.Controls.Add(this.textBox_newName);
            this.panel_newAccount.Controls.Add(this.textBox_newPassword);
            this.panel_newAccount.Controls.Add(this.textBox_newUserName);
            this.panel_newAccount.Controls.Add(this.label_newName);
            this.panel_newAccount.Controls.Add(this.label_newPassword);
            this.panel_newAccount.Controls.Add(this.label_newUsername);
            this.panel_newAccount.Controls.Add(this.label_new_account);
            this.panel_newAccount.Controls.Add(this.button_addAccount);
            this.panel_newAccount.Location = new System.Drawing.Point(23, 83);
            this.panel_newAccount.Name = "panel_newAccount";
            this.panel_newAccount.Size = new System.Drawing.Size(319, 157);
            this.panel_newAccount.TabIndex = 5;
            // 
            // button_generatePass
            // 
            this.button_generatePass.Location = new System.Drawing.Point(223, 59);
            this.button_generatePass.Name = "button_generatePass";
            this.button_generatePass.Size = new System.Drawing.Size(75, 23);
            this.button_generatePass.TabIndex = 8;
            this.button_generatePass.Text = "Generate";
            this.button_generatePass.UseVisualStyleBackColor = true;
            this.button_generatePass.Click += new System.EventHandler(this.button_generatePass_Click);
            // 
            // textBox_newName
            // 
            this.textBox_newName.Location = new System.Drawing.Point(89, 82);
            this.textBox_newName.Name = "textBox_newName";
            this.textBox_newName.Size = new System.Drawing.Size(128, 20);
            this.textBox_newName.TabIndex = 7;
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Location = new System.Drawing.Point(89, 59);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.ReadOnly = true;
            this.textBox_newPassword.Size = new System.Drawing.Size(128, 20);
            this.textBox_newPassword.TabIndex = 6;
            // 
            // textBox_newUserName
            // 
            this.textBox_newUserName.Location = new System.Drawing.Point(89, 36);
            this.textBox_newUserName.Name = "textBox_newUserName";
            this.textBox_newUserName.Size = new System.Drawing.Size(128, 20);
            this.textBox_newUserName.TabIndex = 5;
            // 
            // label_newName
            // 
            this.label_newName.AutoSize = true;
            this.label_newName.Location = new System.Drawing.Point(12, 89);
            this.label_newName.Name = "label_newName";
            this.label_newName.Size = new System.Drawing.Size(38, 13);
            this.label_newName.TabIndex = 4;
            this.label_newName.Text = "Name:";
            // 
            // label_newPassword
            // 
            this.label_newPassword.AutoSize = true;
            this.label_newPassword.Location = new System.Drawing.Point(12, 66);
            this.label_newPassword.Name = "label_newPassword";
            this.label_newPassword.Size = new System.Drawing.Size(56, 13);
            this.label_newPassword.TabIndex = 3;
            this.label_newPassword.Text = "Password:";
            // 
            // label_newUsername
            // 
            this.label_newUsername.AutoSize = true;
            this.label_newUsername.Location = new System.Drawing.Point(12, 43);
            this.label_newUsername.Name = "label_newUsername";
            this.label_newUsername.Size = new System.Drawing.Size(58, 13);
            this.label_newUsername.TabIndex = 2;
            this.label_newUsername.Text = "Username:";
            // 
            // label_new_account
            // 
            this.label_new_account.AutoSize = true;
            this.label_new_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_new_account.Location = new System.Drawing.Point(12, 12);
            this.label_new_account.Name = "label_new_account";
            this.label_new_account.Size = new System.Drawing.Size(206, 17);
            this.label_new_account.TabIndex = 1;
            this.label_new_account.Text = "Create new employee account :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox_deleteUsername);
            this.panel1.Controls.Add(this.label_deleteUsername);
            this.panel1.Controls.Add(this.label_deleteAccount);
            this.panel1.Controls.Add(this.button_deleteAccount);
            this.panel1.Location = new System.Drawing.Point(382, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 157);
            this.panel1.TabIndex = 6;
            // 
            // textBox_deleteUsername
            // 
            this.textBox_deleteUsername.Location = new System.Drawing.Point(76, 66);
            this.textBox_deleteUsername.Name = "textBox_deleteUsername";
            this.textBox_deleteUsername.Size = new System.Drawing.Size(142, 20);
            this.textBox_deleteUsername.TabIndex = 4;
            // 
            // label_deleteUsername
            // 
            this.label_deleteUsername.AutoSize = true;
            this.label_deleteUsername.Location = new System.Drawing.Point(12, 69);
            this.label_deleteUsername.Name = "label_deleteUsername";
            this.label_deleteUsername.Size = new System.Drawing.Size(58, 13);
            this.label_deleteUsername.TabIndex = 3;
            this.label_deleteUsername.Text = "Username:";
            // 
            // label_deleteAccount
            // 
            this.label_deleteAccount.AutoSize = true;
            this.label_deleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deleteAccount.Location = new System.Drawing.Point(12, 14);
            this.label_deleteAccount.Name = "label_deleteAccount";
            this.label_deleteAccount.Size = new System.Drawing.Size(172, 17);
            this.label_deleteAccount.TabIndex = 2;
            this.label_deleteAccount.Text = "Delete employee account:";
            // 
            // panel_update
            // 
            this.panel_update.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_update.Controls.Add(this.button_displayUpdate);
            this.panel_update.Controls.Add(this.button_generateUpdatePass);
            this.panel_update.Controls.Add(this.button_updateAccount);
            this.panel_update.Controls.Add(this.textBox_updateRole);
            this.panel_update.Controls.Add(this.textBox_updateName);
            this.panel_update.Controls.Add(this.textBox_updatePassword);
            this.panel_update.Controls.Add(this.textBox_updateUsername);
            this.panel_update.Controls.Add(this.label_updateRole);
            this.panel_update.Controls.Add(this.label_updateName);
            this.panel_update.Controls.Add(this.label_updatePassword);
            this.panel_update.Controls.Add(this.label_updateUsername);
            this.panel_update.Controls.Add(this.label_update);
            this.panel_update.Location = new System.Drawing.Point(23, 269);
            this.panel_update.Name = "panel_update";
            this.panel_update.Size = new System.Drawing.Size(319, 186);
            this.panel_update.TabIndex = 7;
            // 
            // button_displayUpdate
            // 
            this.button_displayUpdate.Location = new System.Drawing.Point(223, 34);
            this.button_displayUpdate.Name = "button_displayUpdate";
            this.button_displayUpdate.Size = new System.Drawing.Size(75, 23);
            this.button_displayUpdate.TabIndex = 11;
            this.button_displayUpdate.Text = "Display";
            this.button_displayUpdate.UseVisualStyleBackColor = true;
            this.button_displayUpdate.Click += new System.EventHandler(this.button_displayUpdate_Click);
            // 
            // button_generateUpdatePass
            // 
            this.button_generateUpdatePass.Location = new System.Drawing.Point(223, 56);
            this.button_generateUpdatePass.Name = "button_generateUpdatePass";
            this.button_generateUpdatePass.Size = new System.Drawing.Size(75, 23);
            this.button_generateUpdatePass.TabIndex = 10;
            this.button_generateUpdatePass.Text = "Generate";
            this.button_generateUpdatePass.UseVisualStyleBackColor = true;
            this.button_generateUpdatePass.Click += new System.EventHandler(this.button_generateUpdatePass_Click);
            // 
            // button_updateAccount
            // 
            this.button_updateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateAccount.Location = new System.Drawing.Point(160, 143);
            this.button_updateAccount.Name = "button_updateAccount";
            this.button_updateAccount.Size = new System.Drawing.Size(130, 28);
            this.button_updateAccount.TabIndex = 9;
            this.button_updateAccount.Text = "Update Account";
            this.button_updateAccount.UseVisualStyleBackColor = true;
            this.button_updateAccount.Click += new System.EventHandler(this.button_updateAccount_Click);
            // 
            // textBox_updateRole
            // 
            this.textBox_updateRole.Location = new System.Drawing.Point(89, 104);
            this.textBox_updateRole.Name = "textBox_updateRole";
            this.textBox_updateRole.Size = new System.Drawing.Size(128, 20);
            this.textBox_updateRole.TabIndex = 8;
            // 
            // textBox_updateName
            // 
            this.textBox_updateName.Location = new System.Drawing.Point(89, 82);
            this.textBox_updateName.Name = "textBox_updateName";
            this.textBox_updateName.Size = new System.Drawing.Size(128, 20);
            this.textBox_updateName.TabIndex = 7;
            // 
            // textBox_updatePassword
            // 
            this.textBox_updatePassword.Location = new System.Drawing.Point(89, 59);
            this.textBox_updatePassword.Name = "textBox_updatePassword";
            this.textBox_updatePassword.Size = new System.Drawing.Size(128, 20);
            this.textBox_updatePassword.TabIndex = 6;
            // 
            // textBox_updateUsername
            // 
            this.textBox_updateUsername.Location = new System.Drawing.Point(89, 37);
            this.textBox_updateUsername.Name = "textBox_updateUsername";
            this.textBox_updateUsername.Size = new System.Drawing.Size(128, 20);
            this.textBox_updateUsername.TabIndex = 5;
            // 
            // label_updateRole
            // 
            this.label_updateRole.AutoSize = true;
            this.label_updateRole.Location = new System.Drawing.Point(15, 111);
            this.label_updateRole.Name = "label_updateRole";
            this.label_updateRole.Size = new System.Drawing.Size(32, 13);
            this.label_updateRole.TabIndex = 4;
            this.label_updateRole.Text = "Role:";
            // 
            // label_updateName
            // 
            this.label_updateName.AutoSize = true;
            this.label_updateName.Location = new System.Drawing.Point(15, 89);
            this.label_updateName.Name = "label_updateName";
            this.label_updateName.Size = new System.Drawing.Size(38, 13);
            this.label_updateName.TabIndex = 3;
            this.label_updateName.Text = "Name:";
            // 
            // label_updatePassword
            // 
            this.label_updatePassword.AutoSize = true;
            this.label_updatePassword.Location = new System.Drawing.Point(15, 66);
            this.label_updatePassword.Name = "label_updatePassword";
            this.label_updatePassword.Size = new System.Drawing.Size(56, 13);
            this.label_updatePassword.TabIndex = 2;
            this.label_updatePassword.Text = "Password:";
            // 
            // label_updateUsername
            // 
            this.label_updateUsername.AutoSize = true;
            this.label_updateUsername.Location = new System.Drawing.Point(15, 44);
            this.label_updateUsername.Name = "label_updateUsername";
            this.label_updateUsername.Size = new System.Drawing.Size(58, 13);
            this.label_updateUsername.TabIndex = 1;
            this.label_updateUsername.Text = "Username:";
            // 
            // label_update
            // 
            this.label_update.AutoSize = true;
            this.label_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_update.Location = new System.Drawing.Point(12, 13);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(177, 17);
            this.label_update.TabIndex = 0;
            this.label_update.Text = "Update employee account:";
            // 
            // panel_Raport
            // 
            this.panel_Raport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Raport.Controls.Add(this.panel_tabel);
            this.panel_Raport.Controls.Add(this.button_generateReport);
            this.panel_Raport.Location = new System.Drawing.Point(382, 269);
            this.panel_Raport.Name = "panel_Raport";
            this.panel_Raport.Size = new System.Drawing.Size(359, 186);
            this.panel_Raport.TabIndex = 8;
            // 
            // panel_tabel
            // 
            this.panel_tabel.AutoScroll = true;
            this.panel_tabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_tabel.Controls.Add(this.tableLayoutPanel_report);
            this.panel_tabel.Location = new System.Drawing.Point(3, 44);
            this.panel_tabel.Name = "panel_tabel";
            this.panel_tabel.Size = new System.Drawing.Size(349, 126);
            this.panel_tabel.TabIndex = 3;
            // 
            // tableLayoutPanel_report
            // 
            this.tableLayoutPanel_report.AutoScroll = true;
            this.tableLayoutPanel_report.AutoScrollMinSize = new System.Drawing.Size(0, 30);
            this.tableLayoutPanel_report.AutoSize = true;
            this.tableLayoutPanel_report.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel_report.ColumnCount = 3;
            this.tableLayoutPanel_report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_report.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel_report.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel_report.Name = "tableLayoutPanel_report";
            this.tableLayoutPanel_report.RowCount = 1;
            this.tableLayoutPanel_report.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.39535F));
            this.tableLayoutPanel_report.Size = new System.Drawing.Size(325, 26);
            this.tableLayoutPanel_report.TabIndex = 2;
            // 
            // button_generateReport
            // 
            this.button_generateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_generateReport.Location = new System.Drawing.Point(104, 9);
            this.button_generateReport.Name = "button_generateReport";
            this.button_generateReport.Size = new System.Drawing.Size(141, 25);
            this.button_generateReport.TabIndex = 0;
            this.button_generateReport.Text = "Generate Report";
            this.button_generateReport.UseVisualStyleBackColor = true;
            this.button_generateReport.Click += new System.EventHandler(this.button_generateReport_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 475);
            this.Controls.Add(this.panel_Raport);
            this.Controls.Add(this.panel_update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_newAccount);
            this.Controls.Add(this.label_employee);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_logged);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panel_newAccount.ResumeLayout(false);
            this.panel_newAccount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_update.ResumeLayout(false);
            this.panel_update.PerformLayout();
            this.panel_Raport.ResumeLayout(false);
            this.panel_tabel.ResumeLayout(false);
            this.panel_tabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addAccount;
        private System.Windows.Forms.Button button_deleteAccount;
        private System.Windows.Forms.Label label_logged;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_employee;
        private System.Windows.Forms.Panel panel_newAccount;
        private System.Windows.Forms.Label label_newName;
        private System.Windows.Forms.Label label_newPassword;
        private System.Windows.Forms.Label label_newUsername;
        private System.Windows.Forms.Label label_new_account;
        private System.Windows.Forms.Button button_generatePass;
        private System.Windows.Forms.TextBox textBox_newName;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.TextBox textBox_newUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_deleteUsername;
        private System.Windows.Forms.Label label_deleteUsername;
        private System.Windows.Forms.Label label_deleteAccount;
        private System.Windows.Forms.Panel panel_update;
        private System.Windows.Forms.Button button_generateUpdatePass;
        private System.Windows.Forms.Button button_updateAccount;
        private System.Windows.Forms.TextBox textBox_updateRole;
        private System.Windows.Forms.TextBox textBox_updateName;
        private System.Windows.Forms.TextBox textBox_updatePassword;
        private System.Windows.Forms.TextBox textBox_updateUsername;
        private System.Windows.Forms.Label label_updateRole;
        private System.Windows.Forms.Label label_updateName;
        private System.Windows.Forms.Label label_updatePassword;
        private System.Windows.Forms.Label label_updateUsername;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.Button button_displayUpdate;
        private System.Windows.Forms.Panel panel_Raport;
        private System.Windows.Forms.Button button_generateReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_report;
        private System.Windows.Forms.Panel panel_tabel;


    }
}