using MyPointOfSale.Controllers;
using MyPointOfSale.ViewModels;
using System;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class frmUsuarios : Form
    {
        private readonly UserController _userController;

        public frmUsuarios(UserController userController)
        {
            InitializeComponent();
            _userController = userController;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LoadPosition();
            LoadDocuments();
            LoadUsers();
        }

        private void LoadPosition()
        {
            try
            {
                cbbPosition.DataSource = _userController.GetPositions();
                cbbPosition.DisplayMember = "PositionName";
                cbbPosition.ValueMember = "PositionId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las posiciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDocuments()
        {
            try
            {
                cbbDocumentId.DataSource = _userController.GetDocumentTypes();
                cbbDocumentId.DisplayMember = "DocumentName";
                cbbDocumentId.ValueMember = "DocumentID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los tipos de documentos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUsers()
        {
            try
            {
                dataGridView1.DataSource = _userController.GetUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioCreateViewModel usuario = new UsuarioCreateViewModel()
                {
                    Username = txtUsuario.Text,
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    DocumentTypeId = cbbDocumentId.SelectedIndex + 1,
                    DocumentNumber = txtDocumentNumber.Text,
                    PositionId = cbbPosition.SelectedIndex + 1,
                };

                _userController.CrearUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadUsers();
            }
        }
    }
}
