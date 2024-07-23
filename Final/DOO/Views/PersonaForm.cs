using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOO.Models;
using Microsoft.Extensions.DependencyInjection;
using DOO.Dao;
using Microsoft.EntityFrameworkCore;

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

            dataGridView1.DataSource = new List<Models.Persona> { persona };

        }

        private void btnInsertPersona_Click(object sender, EventArgs e)
        {
            var nuevaPersona = new Models.Persona
            {
                Nombre = textNombrePersona.Text,
                Apellido = textApellidoPersona.Text,
                Documento = textDocumentoPersona.Text,
                TipoDocumento = textTipoDocumentoPersona.Text,
                Telefono = textTelefonoPersona.Text,
                Direccion = textDireccionPersona.Text
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

            dataGridView1.DataSource = personas;
        }


    }
}
