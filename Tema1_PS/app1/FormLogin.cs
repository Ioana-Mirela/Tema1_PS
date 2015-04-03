using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _piataAZ.BL;
using _piataAZ.Entities;

namespace app1
{
    public partial class FormLogin : Form
    {
        private UserService userService;

        public FormLogin()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_user.Text == "")
                {
                    MessageBox.Show("Please enter a valid user name!");
                    textBox_user.Focus();
                }
                else if (textBox_password.Text == "")
                {
                    MessageBox.Show("Please enter a valid password!");
                    textBox_password.Focus();
                }
                else
                {
                    String role = userService.login(textBox_user.Text, textBox_password.Text);
                    if (role != null)
                    {
                        if (role.Equals("admin"))
                        {
                            FormAdmin fa = new FormAdmin(textBox_user.Text, this);
                            this.Visible = false;
                            fa.Show();
                        }
                        else if (role.Equals("user"))
                        {
                            FormEmployee fe = new FormEmployee(textBox_user.Text, this);
                            this.Visible = false;
                            fe.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This account doesn't exist");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bad input !");
            }
          }

        private void forgot_pass_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_user.Text == "")
                {
                    MessageBox.Show("Please enter a valid user name!");
                    textBox_user.Focus();
                }
                else
                {
                    String newPass = userService.update(textBox_user.Text);
                    if (newPass != null)
                    {
                        MessageBox.Show("Your new password is: " + newPass);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error in generating a new password !");
            }
        }
    }
}
