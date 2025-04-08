using MyPointOfSale.Controllers;
using MyPointOfSale.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class frmUsuarios : Form
    {
        private UserController _userController;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public frmUsuarios(UserController userController)
        {
            _userController = userController;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            UsuarioCreateViewModel usuario = new UsuarioCreateViewModel();
            usuario.FirstName = txtFirstName.Text;
            //usuario.Position = txtPosition.Text;(PARA CAMBIAR)
            usuario.LastName = txtLastName.Text;
            usuario.Username = txtUsuario.Text;
            usuario.Email = txtEmail.Text;
            usuario.DocumentTypeId = cbbDocumentId.SelectedIndex + 1;
            usuario.DocumentNumber = txtDocumentNumber.Text;

            _userController.CrearUsuario(usuario);
        }
    }
}
