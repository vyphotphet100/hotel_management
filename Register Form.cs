using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Hotel_Manager
{
    public partial class formRegister : Form
    {

        public formRegister()
        {
            InitializeComponent();

        }
        string username, password, passwordConfirm;
        MY_DB myDB = new MY_DB();
        STUDENT student = new STUDENT();
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmPassword.PasswordChar = '•';
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxUsername.Focus();
        }

        private void formRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }

        private void labelBackToLogIn_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
        }      
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool usernameCheck = false, passwordCheck = false;
            bool passwordTyped = false, passwordConfirmed = false;
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            passwordConfirm = textBoxConfirmPassword.Text;
            if (username == "")
            {
                labelErrorUsername.Visible = true;
                labelErrorUsername.Text = ("Please enter valid username");
                usernameCheck = false;
            }
            else
            {
                if (student.existUsername(username))
                {
                    labelErrorUsername.Text = ("Existed Username");
                    usernameCheck = false;
                }
                else
                {
                    usernameCheck = true;
                    labelErrorUsername.Text = string.Empty;
                }

            }
            if (password == "")
            {
                labelErrorPassword.Text = ("Please Enter Password");
                passwordCheck = false;
                passwordTyped = false;
            }
            else
            {
                labelErrorPassword.Text = string.Empty;
                passwordTyped = true;
            }

            if (passwordConfirm == "")
            {
                labelErrorPasswordConfirm.Visible = true;
                labelErrorPasswordConfirm.Text = ("Please Confirm Your Password");
                passwordCheck = false;
                passwordConfirmed = false;
            }
            else
            {
                labelErrorPasswordConfirm.Text = string.Empty;
                passwordConfirmed = true;
            }
            if (password == passwordConfirm && password.Length != 0 && passwordConfirm.Length != 0)
            {
                passwordCheck = true;

            }
            else
            {
                if (passwordTyped && passwordConfirmed)
                {
                    labelErrorPasswordConfirm.Visible = true;
                    labelErrorPasswordConfirm.Text = ("Passwords are not the same");
                    passwordCheck = false;
                }
            }
            if (passwordCheck == true && usernameCheck == true)
            {
                labelErrorPassword.Text = string.Empty;

                SqlCommand command = new SqlCommand("INSERT INTO login (id, username, password)"
                + " VALUES ((SELECT MAX(id) FROM login) + 1, @username, @password)", myDB.getConnection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                myDB.openConnection();
                try
                {
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        myDB.closeConnection();
                    }
                    else
                    {
                        myDB.closeConnection();
                    }
                }
                catch
                {

                }
                this.Close();

            }
        }
    }
}

