using DOO.Models;
using DOO.Store.Data;
using DOO.Views;
using Microsoft.Extensions.DependencyInjection;

namespace DOO.Views
{
    public partial class Pedidos : Form
    {
        private readonly ProductosStore _productosStore;
        private readonly ClienteDB _clienteDB;
        private readonly PedidoDB _pedidosDB;
        private int _clienteId = 0;
        private List<Producto> _products = new List<Producto>();
        public Pedidos()
        {
            InitializeComponent();
            _productosStore = Program.ServiceProvider.GetRequiredService<ProductosStore>();
            _clienteDB = Program.ServiceProvider.GetRequiredService<ClienteDB>();
            _pedidosDB = Program.ServiceProvider.GetRequiredService<PedidoDB>();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            SetClientesComboBox();
            SetProductosComboBox();
        }

        private void SetClientesComboBox()
        {
            var clientes = _clienteDB.GetClientes();
            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "ClienteId";
        }

        private void SetProductosComboBox()
        {
            var productos = _productosStore.GetProductos();
            cbProducto.DataSource = productos;
            cbProducto.DisplayMember = "Nombre";
            cbProducto.ValueMember = "ProductoId";
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            _clienteId = (int)cbCliente.SelectedValue;
            cbCliente.Enabled = false;
        }

        private void ActualizarTablaProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _products;
            dgvProductos.Update();
            dgvProductos.Refresh();
        }

        private void btnInsertProducto_Click(object sender, EventArgs e)
        {
            // Agregamos productos a la lista de productos del pedido
            var producto = (Producto)cbProducto.SelectedItem;
            _products.Add(producto);
            ActualizarTablaProductos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<DetallePedido> detalles = new List<DetallePedido>();
            foreach (var producto in _products)
            {
                detalles.Add(new DetallePedido
                {
                    ProductoId = producto.ProductoId,
                    Producto = producto,
                    Cantidad = 1,
                    PrecioUnitario = producto.Precio,
                });
            }

            var cliente = _clienteDB.GetCliente(_clienteId);

            cliente.PersonaId = 3847858;

            // Guardamos el pedido
            var pedido = new Pedido
            {
                ClienteId = _clienteId,
                Cliente = cliente,
                Fecha = DateTime.Now.ToString(),
                Detalles = detalles,
                Estado = "En preparación",
                Total = _products.Sum(p => p.Precio),
                PedidoId = 34234234,
                FechaHoraEntregaEstimada = DateTime.Now.AddDays(1).ToString(),
                FechaHoraEntregaReal = DateTime.Now.AddDays(1).ToString()
            };

            _pedidosDB.InsertPedido(pedido);

            CleanForm();
        }

        private void CleanForm()
        {
            _clienteId = 0;
            cbCliente.Enabled = true;
            _products = new List<Producto>();
            ActualizarTablaProductos();
        }
    }
}
