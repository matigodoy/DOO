using DOO.Models;
using Microsoft.Extensions.DependencyInjection;
namespace DOO.Views
{
    public partial class PersonaForm : Form
    {
        private readonly PersonaDB _persona;
        public PersonaForm()
        {
            InitializeComponent();
            _persona = Program.ServiceProvider.GetRequiredService<PersonaDB>();
        }

        private void btnGetPersona_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(textBuscarPersona.Text))
            //{
            //    MessageBox.Show("Ingrese un id de persona");
            //    return;
            //}

            string nombre = textBuscarPersona.Text;
            var personas = _persona.GetPersonas(nombre);

            if (personas == null)
                MessageBox.Show("No hay resultados");

            //dataGridView1.DataSource = new List<Models.Persona> { persona};
            //var personas = _persona.GetPersonas(id.ToString());

            // Configurar el DataGridView para mostrar las propiedades de Persona y Direccion
            //var personaDisplayList = personas.Select(p => new
            //{
            //    p.PersonaId,
            //    p.Nombre,
            //    p.Apellido,
            //    p.NumeroDocumento,
            //    p.TipoDocumento,
            //    p.Telefono
            //}).ToList();

            dataGridView1.DataSource = personas;

        }

        private void btnInsertPersona_Click(object sender, EventArgs e)
        {
            var nuevoBarrio = new Barrio
            {
                Nombre = textDireccionPersona.Text,
            };
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
        }

        private void GetPersonas()
        {
            var personas = _persona.GetPersonas();

            // Configurar el DataGridView para mostrar las propiedades de Persona y Direccion
            //var personaDisplayList = personas.Select(p => new
            //{
            //    p.PersonaId,
            //    p.Nombre,
            //    p.Apellido,
            //    p.NumeroDocumento,
            //    p.TipoDocumento,
            //    p.Telefono,
            //}).ToList();

            dataGridView1.DataSource = personas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonaForm_Load_1(object sender, EventArgs e)
        {
            GetPersonas();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBuscarPersona_TextChanged(object sender, EventArgs e)
        {
            btnGetPersona_Click(sender, e);
        }
    }
}
