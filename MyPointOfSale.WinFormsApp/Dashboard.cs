using MyPointOfSale.Common.Cache;
using MyPointOfSale.Controllers;

namespace MyPointOfSale;

public partial class Dashboard : Form
{
    private readonly ProductController _productController;
    public Dashboard()
    {
        InitializeComponent();

        _productController = new ProductController();
    }

    private void Dashboard_Load(object sender, EventArgs e)
    {
        LoadUserData();
        LoadProducts();
    }

    private void LoadProducts()
    {
        dataGridView1.DataSource = _productController.GetProducts();
    }

    private void LoadUserData()
    {
        lblUserName.Text = $"{UserLoginCache.FirstName} {UserLoginCache.LastName}";
        lblPosition.Text = UserLoginCache.Position;
        lblUserEmail.Text = UserLoginCache.Email;
    }

    private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
    {
        Application.Exit();
    }

    private void btnLogOut_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Estas seguro que desea cerrar sección?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            this.Close();
        }
    }
}
