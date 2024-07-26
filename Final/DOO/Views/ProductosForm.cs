using DOO.Models;
using DOO.Store.Data;
using DOO.Views;
using Microsoft.Extensions.DependencyInjection;

namespace DOO
{
    public partial class ProductosForm : Form
    {
        private readonly ProductosStore _productosStore;

        public ProductosForm()
        {
            InitializeComponent();
            _productosStore = Program.ServiceProvider.GetRequiredService<ProductosStore>();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            GetProductos();
        }

        private void GetProductos()
        {
            var productos = _productosStore.GetProductos();

            dataGridView1.DataSource = productos;
        }

        private void btnGetProducto_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductoId.Text))
            {
                MessageBox.Show("Ingrese un id de producto");
                return;
            }

            int id = int.Parse(txtProductoId.Text);
            var producto = _productosStore.GetProducto(id);

            if (producto == null)
                MessageBox.Show("Producto no encontrado");

            dataGridView1.DataSource = new List<Producto> { producto };
        }

        private void btnInsertProducto_Click(object sender, EventArgs e)
        {
            var nuevoProducto = new Producto
            {
                Nombre = txtNombre.Text,
                // Asignar otros campos según sea necesario
            };

            int result = _productosStore.InsertProducto(nuevoProducto);

            if (result > 0)
            {
                MessageBox.Show("Producto insertado exitosamente");
            }
            else
            {
                MessageBox.Show("Error al insertar producto");
            }

            GetProductos();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
