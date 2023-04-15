using System;
using System.Windows.Forms;

namespace ConsultaDatos
{
    public partial class FormConsultaFactura : Form
    {
        public FormConsultaFactura()
        {
            InitializeComponent();
        }

        private void FormConsultaFactura_Load(object sender, EventArgs e)
        {
            // Obtener los argumentos de línea de comandos
            string[] args = Environment.GetCommandLineArgs();

            // Verificar si se proporcionó el argumento de la cédula del cliente
            if (args.Length >= 2)
            {
                // Obtener la cédula del cliente del primer argumento
                string cedulaCliente = args[1];

                // Cargar la cédula del cliente en el campo del formulario
                txtCedulaCliente.Text = cedulaCliente;

                // Realizar la consulta de la imagen de la factura relacionada
                // con la cédula del cliente y mostrarla en el formulario
                // (código de consulta y visualización de imagen de factura)
            }
            else
            {
                MessageBox.Show("No se proporcionó el argumento de la cédula del cliente.");
            }
        }
    }
}