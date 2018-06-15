using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas_Simples
{
    public partial class Form1 : Form
    {
        Agenda contactos = new Agenda();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            int Telefono = Convert.ToInt32(txtTelefono.Text);
            string Email = txtCorreo.Text;
            string Edad = txtEdad.Text;
            int Codigo = Convert.ToInt32(txtCodigo.Text);

            contactos.Agregar(new Contacto(Nombre, Telefono, Email, Edad, Codigo));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = contactos.Buscar(Convert.ToInt32(txtTelefono.Text)).ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (contactos.Eliminar(Convert.ToInt32(txtTelefono.Text)))
            {
                txtDatos.Text = contactos.Listar();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtDatos.Text = contactos.Listar();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            if (contactos.EliminarPrimero())
            {
                txtDatos.Text = contactos.Listar();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            int Telefono = Convert.ToInt32(txtTelefono.Text);
            string Email = txtCorreo.Text;
            string Edad = txtEdad.Text;
            int Codigo = Convert.ToInt32(txtCodigo.Text);
            Contacto nuevo = new Contacto(Nombre, Telefono, Email, Edad, Codigo);
            int pos = Convert.ToInt32(txtNumPosicion.Text);
            contactos.Insertar(nuevo,pos);
        }
    }
}
