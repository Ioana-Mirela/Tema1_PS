using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _piataAZ.BL;
using System.Collections;
using _piataAZ.Entities;

namespace app1
{
    public partial class FormAdmin : Form
    {
        private UserService userService;
        private AdService adService;
        private Form _login;

        public FormAdmin(String username, Form login)
        {
            InitializeComponent();
            label_logged.Text = "Logged in as Admin: " + username; 
            userService = new UserService();
            adService = new AdService();
            _login = login;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _login.Visible = true;
        }

        private void button_generatePass_Click(object sender, EventArgs e)
        {
            textBox_newPassword.Text = userService.generatePassword();
        }

        private void button_addAccount_Click(object sender, EventArgs e)
        {
            userService.create(textBox_newUserName.Text, textBox_newPassword.Text, textBox_newName.Text, "user");
        }

        private void button_deleteAccount_Click(object sender, EventArgs e)
        {
            userService.delete(textBox_deleteUsername.Text);
        }

        private void button_generateUpdatePass_Click(object sender, EventArgs e)
        {
            textBox_updatePassword.Text = userService.generatePassword();
        }

        private void button_displayUpdate_Click(object sender, EventArgs e)
        {
            textBox_updateName.Text = userService.getName(textBox_updateUsername.Text);
            textBox_updateRole.Text = userService.getRole(textBox_updateUsername.Text);
        }

        private void button_updateAccount_Click(object sender, EventArgs e)
        {
            userService.updateAccount(textBox_updateUsername.Text, textBox_updatePassword.Text, textBox_updateName.Text, textBox_updateRole.Text);
        }

        private void generateTabelHeader()
        {
            tableLayoutPanel_report.RowCount = 1;
            tableLayoutPanel_report.RowStyles.Clear();
            tableLayoutPanel_report.ColumnCount = 3;
            tableLayoutPanel_report.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel_report.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_report.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_report.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel_report.Controls.Add(new Label() { Text = "Employee" }, 0, 0);
            tableLayoutPanel_report.Controls.Add(new Label() { Text = "Name" }, 1, 0);
            tableLayoutPanel_report.Controls.Add(new Label() { Text = "Nb. Ads" }, 2, 0); 
        }

        private void button_generateReport_Click(object sender, EventArgs e)
        {
            ArrayList reports = new ArrayList();
            reports = adService.getAllReports(userService.getAllEmployees());
            tableLayoutPanel_report.Controls.Clear();
            this.generateTabelHeader();
            foreach (Report i in reports)
            {
                tableLayoutPanel_report.RowCount = tableLayoutPanel_report.RowCount + 1;
                tableLayoutPanel_report.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tableLayoutPanel_report.Controls.Add(new Label() { Text = i.getEmployee().getUserName() }, 0, tableLayoutPanel_report.RowCount - 1);
                tableLayoutPanel_report.Controls.Add(new Label() { Text = i.getEmployee().getName() }, 1, tableLayoutPanel_report.RowCount - 1);
                tableLayoutPanel_report.Controls.Add(new Label() { Text = i.getNbAds() +"" }, 2, tableLayoutPanel_report.RowCount - 1);
            }
            
        }

        
    }
}
