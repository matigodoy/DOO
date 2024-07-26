using DOO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (String.IsNullOrEmpty(textBuscarPersona.Text))
            {
                MessageBox.Show("Ingrese un id de persona");
                return;
            }

            int id = int.Parse(textBuscarPersona.Text);
            var persona = _persona.GetPersona(id);

            if (persona == null)
                MessageBox.Show("Persona no encontrada");

            //dataGridView1.DataSource = new List<Models.Persona> { persona};
            var personas = _persona.GetPersonas(id.ToString());

            // Configurar el DataGridView para mostrar las propiedades de Persona y Direccion
            var personaDisplayList = personas.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Apellido,
                p.Documento,
                p.TipoDocumento,
                p.Telefono,
                Direccion_Barrio = p.Direccion.Barrio.Nombre,
                Direccion_Calle = p.Direccion.Calle
            }).ToList();

            dataGridView1.DataSource = personaDisplayList;

        }

        private void btnInsertPersona_Click(object sender, EventArgs e)
        {
            var nuevoBarrio = new Barrio
            {
                Nombre = textDireccionPersona.Text,
            };
            var nuevaDireccion = new Direccion
            {
                Barrio = nuevoBarrio,
                Calle = textCallePersona.Text
            };
            var nuevaPersona = new Models.Persona
            {
                Nombre = textNombrePersona.Text,
                Apellido = textApellidoPersona.Text,
                Documento = textDocumentoPersona.Text,
                TipoDocumento = textTipoDocumentoPersona.Text,
                Telefono = textTelefonoPersona.Text,
                Direccion = nuevaDireccion
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
            var personaDisplayList = personas.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Apellido,
                p.Documento,
                p.TipoDocumento,
                p.Telefono,
                Direccion_Barrio = p.Direccion.Barrio.Nombre,
                Direccion_Calle = p.Direccion.Calle,
                Direccion_Zona = "XD",
            }).ToList();

            dataGridView1.DataSource = personaDisplayList;
        }



    }
}
