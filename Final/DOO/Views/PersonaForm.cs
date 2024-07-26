using DOO.Models;
using DOO.Store.Data;
using Microsoft.Extensions.DependencyInjection;
namespace DOO.Views
{
    public partial class PersonaForm : Form
    {
        private readonly PersonaDB _persona;
        private readonly ClienteDB _cliente;
        private readonly DireccionDB _direccion;
        public PersonaForm()
        {
            InitializeComponent();
            _persona = Program.ServiceProvider.GetRequiredService<PersonaDB>();
            _cliente = Program.ServiceProvider.GetRequiredService<ClienteDB>();
            _direccion = Program.ServiceProvider.GetRequiredService<DireccionDB>();
        }

        private void btnGetPersona_Click(object sender, EventArgs e)
        {
            string nombre = textBuscarPersona.Text;
            var personas = _cliente.GetClientes(nombre);

            if (personas == null)
                MessageBox.Show("No hay resultados");

            dataGridView1.DataSource = personas;

        }

        private void btnInsertPersona_Click(object sender, EventArgs e)
        {

            var nuevaDireccion = new Direccion
            {
                DireccionTexto = textCallePersona.Text
            };
            var nuevaPersona = new Persona
            {
                Nombre = textNombrePersona.Text,
                Apellido = textApellidoPersona.Text,
                NumeroDocumento = textDocumentoPersona.Text,
                TipoDocumento = textTipoDocumentoPersona.Text,
                Telefono = textTelefonoPersona.Text,
                DireccionId = _direccion.InsertDireccion(nuevaDireccion),
            };

            int result = _persona.InsertPersona(nuevaPersona);

            if (result > 0)
            {
                MessageBox.Show("Persona creada con éxito");
                GetPersonas();
            }
            else
            {
                MessageBox.Show("Error al crear persona");
            }
        }

        private async void PersonaForm_Load(object sender, EventArgs e)
        {
            GetPersonas();
            textBuscarPersona.Focus();
        }

        private void GetPersonas()
        {
            var personas = _cliente.GetClientes();
            dataGridView1.DataSource = personas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonaForm_Load_1(object sender, EventArgs e)
        {
            GetPersonas();
            textBuscarPersona.Focus();
            LoadComboBoxBarrios();
            LoadComboBoxZonas();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            btnGetPersona_Click(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxBarrios()
        {
            var barrios = _direccion.GetBarrios();
            cbBarrios.DataSource = barrios;
            cbBarrios.DisplayMember = "Nombre";
            cbBarrios.ValueMember = "BarrioId";
        }

        private void LoadComboBoxZonas()
        {
            var zonas = _direccion.GetZonas();
            cbZona.DataSource = zonas;
            cbZona.DisplayMember = "Nombre";
            cbZona.ValueMember = "ZonaId";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Regresar al home
            this.Hide();
            HomeForm form = new HomeForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
