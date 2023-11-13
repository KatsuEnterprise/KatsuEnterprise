using AdministradorKata.Gráfica.Pantalla;
using System;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class MostrarPantalla : Form
    {

        private Pantalla.VentanaCalificados ventanaCalificados;
        private Pantalla.VentanaPrincipal ventanaPrincipal;
        private Pantalla.VentanaPuntajes ventanaPuntajes;
        private Pantalla.VentanInfoParticipantes ventanaParticipantes;

        public MostrarPantalla()
        {
            InitializeComponent();
        }

        /*BOTONES*/

        private void btnPantallaPrincipal_Click(object sender, EventArgs e)
        {

            if (ventanaCalificados == null || ventanaCalificados.IsDisposed)
            {
                ventanaCalificados = new Pantalla.VentanaCalificados();

                //Mostramos la ventana que abrimos
                ventanaCalificados.Show();
                //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                //(y que la ventana quede delante siempre)
                ventanaCalificados.Focus();
                //Cerramos la pantalla en la que estamos
                this.Visible = false;
            }

        }

        private void btnPantallaParticipantes_Click(object sender, EventArgs e)
        {

            if (ventanaParticipantes == null || ventanaParticipantes.IsDisposed)
                ventanaParticipantes = new Pantalla.VentanInfoParticipantes();

            //Mostramos la ventana que abrimos
            ventanaParticipantes.Show();

            //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
            //(y que la ventana quede delante siempre)
            ventanaPrincipal.Focus();


            //Hacemos que esta ventana se oculte, no podemos cerrarla porque de lo contrario se cierra todo
            this.Visible = false;

        }

        private void btnPantallaCalificados_Click(object sender, EventArgs e)
        {

            if (ventanaCalificados == null || ventanaCalificados.IsDisposed)
                ventanaCalificados = new Pantalla.VentanaCalificados();

            //Mostramos la ventana que abrimos
            ventanaCalificados.Show();

            //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
            //(y que la ventana quede delante siempre)
            ventanaCalificados.Focus();


            //Hacemos que esta ventana se oculte, no podemos cerrarla porque de lo contrario se cierra todo
            this.Visible = false;

        }

        private void btnPantallaPuntajes_Click(object sender, EventArgs e)
        {

            if (ventanaPuntajes == null || ventanaPuntajes.IsDisposed)
                ventanaPuntajes = new Pantalla.VentanaPuntajes();

            //Mostramos la ventana que abrimos
            ventanaPuntajes.Show();

            //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
            //(y que la ventana quede delante siempre)
            ventanaPuntajes.Focus();


            //Hacemos que esta ventana se oculte, no podemos cerrarla porque de lo contrario se cierra todo
            this.Visible = false;

        }

        private void MostrarPantalla_Load(object sender, EventArgs e)
        {
            // **CONFIGURAR LABEL AÑO

            //Para que el lbl que ahora dice "2023", cambie si estamos en otro año

            int añoActual = DateTime.Now.Year;
            lblAño.Text = añoActual.ToString();
        }
    }
}