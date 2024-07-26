using DOO.Models;
using DOO.Store.Data;
using DOO.Views;
using Microsoft.Extensions.DependencyInjection;

namespace DOO
{
    public partial class ProductosForm : Form
    {
        private int _productoId;
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
            var precio = 0.0;

            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre de producto");
                return;
            }

            if (String.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Ingrese un precio de producto");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Ingrese un precio válido");
                return;
            }

            bool isEdit = _productoId > 0;

            if (isEdit)
            {
                var producto = new Producto
                {
                    ProductoId = _productoId,
                    Nombre = txtNombre.Text,
                    Precio = precio
                };

                var result = _productosStore.UpdateProducto(producto);

                if (result > 0)
                {
                    MessageBox.Show("Producto actualizado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al actualizar producto");
                }
            }
            else
            {
                var producto = new Producto
                {
                    Nombre = txtNombre.Text,
                    Precio = precio
                };

                var result = _productosStore.InsertProducto(producto);

                if (result > 0)
                {
                    MessageBox.Show("Producto insertado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al insertar producto");
                }
            }

            GetProductos();
            CleanForm();
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

        private void CleanForm()
        {
            txtNombre.Text = "";
            _productoId = 0;
            txtPrecio.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Corroborar si se presionó el botón de eliminar
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index)
            {
                var productoId = (int)dataGridView1.Rows[e.RowIndex].Cells["ProductoId"].Value;
                var result = _productosStore.DeleteProducto(productoId);

                if (result > 0)
                {
                    MessageBox.Show("Producto eliminado exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al eliminar producto");
                }

                GetProductos();
            }

            // Corroborar si se presionó el botón de editar
            if (e.ColumnIndex == dataGridView1.Columns["Editar"].Index)
            {
                var productoId = (int)dataGridView1.Rows[e.RowIndex].Cells["ProductoId"].Value;
                var producto = _productosStore.GetProducto(productoId);

                _productoId = producto.ProductoId;
                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.Precio.ToString();
            }
        }
    }
}
