using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

namespace Lab01_02
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            String telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            DateTime fecha = dTPNac.Value;
            string depart = cBDepart.Text;

            dgvUsuarios.Rows.Add("", dni, nombre, apellido, direccion, email, telefono, fecha, depart);

        }
    }
}
