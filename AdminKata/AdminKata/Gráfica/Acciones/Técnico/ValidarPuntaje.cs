using System;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class ValidarPuntaje : Form
    {
        public ValidarPuntaje()
        {
            InitializeComponent();
        }

        /*BOTONES*/

        //Botón cerrar Programa
        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botón maximizar programa

        private void btnMaximizarPrograma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //Botón minimizar programa
        private void btnMinimizarPrograma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Boton guardar puntaje a base de datos
        private void btnGuardarPuntajeEnBD_Click(object sender, EventArgs e)
        {

        }

        //Boton enviar puntaje a la pantalla
        private void btnEnviarPuntajePantalla_Click(object sender, EventArgs e)
        {

        }

        private void txtPuntajes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }
    }
}
