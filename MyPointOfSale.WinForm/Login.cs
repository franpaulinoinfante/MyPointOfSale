using MyPointOfSale.Controllers;
using MyPointOfSale.ViewModels;
using MyPointOfSale.WinForm;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace MyPointOfSale
{

    public partial class Login : Form
    {
        private readonly UserController _userController;

        public Login(UserController user)
        {
            InitializeComponent();

            _userController = user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }

            try
            {
                bool isValidLogin = _userController.Login(new UserViewModel()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                });

                if (isValidLogin)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    dashboard.FormClosed += LogOut;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearTxtUsername();
                ClearTxtPassword();
                txtUsername.Focus();
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || (txtUsername.Text == "usuario"))
            {
                errorProvider1.SetError(txtUsername, "El campo usuario es obligatorio");
                txtUsername.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtPassword.Text) || (txtPassword.Text == "contraseña"))
            {
                errorProvider1.SetError(txtPassword, "El campo contraseña es obligatorio");
                txtPassword.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            ClearTxtUsername();
            ClearTxtPassword();
            lklRecurperContrasenia.Focus();

            this.Show();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "usuario")
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ClearTxtUsername();
            }
        }

        private void ClearTxtUsername()
        {
            txtUsername.Text = "usuario";
            txtUsername.ForeColor = Color.Gray;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "contraseña")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ClearTxtPassword();
            }
        }

        private void ClearTxtPassword()
        {
            txtPassword.Text = "contraseña";
            txtPassword.ForeColor = Color.Gray;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.PasswordChar = '\0';
        }
    }


}