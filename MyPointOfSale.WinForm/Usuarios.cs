using MyPointOfSale.Controllers;
using MyPointOfSale.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyPointOfSale.WinForm
{
    public partial class frmUsuarios : Form
    {
        private IReadOnlyList<UserViewModel> _users;

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
                _users = _userController.GetUsers();
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

            ClearFields();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioUpdatedViewModel usuario = new UsuarioUpdatedViewModel
                {
                    UserId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    Username = txtUsuario.Text,
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    DocumentTypeId = cbbDocumentId.SelectedIndex + 1,
                    DocumentNumber = txtDocumentNumber.Text,
                    PositionId = cbbPosition.SelectedIndex + 1
                };

                _userController.ActualizarUsuario(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadUsers();
            }

            ClearFields();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                _userController.EliminarUsuario(userId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadUsers();
            }

            ClearFields();
        }

        private void ClearFields()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtDocumentNumber.Clear();
            cbbPosition.SelectedIndex = -1;
            cbbDocumentId.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClearFields();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCrear.Enabled = true;

        }

        private void FillWithDataGridView(DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            txtUserId.Text = selectedRow.Cells[0].Value.ToString();
            txtUsuario.Text = selectedRow.Cells[1].Value.ToString();
            txtPassword.Text = "------------";

            cbbPosition.SelectedText = selectedRow.Cells[2].Value.ToString();
            txtFirstName.Text = selectedRow.Cells[3].Value.ToString();
            txtLastName.Text = selectedRow.Cells[4].Value.ToString();

            cbbDocumentId.SelectedText = selectedRow.Cells[0].Value.ToString();
            txtDocumentNumber.Text = selectedRow.Cells[0].Value.ToString();

            txtEmail.Text = selectedRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillWithDataGridView(e);
        }
    }
}
