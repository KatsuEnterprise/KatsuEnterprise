using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Loggin
{
    public partial class MenuPrincipal : Form
    {
        private Loggin.LogginAdministrador ventanaAdmin;
        //private MenuPrincipal estaVentana;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        /*BOTONES*/

        //Boton para ingresar al loggin
        private void btnIngresarAlLoggin_Click(object sender, EventArgs e)
        {
            //Si la ventana no se abrió Ó esta no esta disponible
            if (ventanaAdmin == null || ventanaAdmin.IsDisposed)
                ventanaAdmin = new Loggin.LogginAdministrador();

            //Mostramos la ventana que abrimos
            ventanaAdmin.Show();

            //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
            //(y que la ventana quede delante siempre)
            ventanaAdmin.Focus();


            //Hacemos que esta ventana se oculte, no podemos cerrarla porque de lo contrario se cierra todo
            this.Visible = false;
        }

        //Botón cerrar Programa
        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        //Para que se pueda mover la ventana
        bool vai = false;

        private Point posicionMouse;

        private void PanelBarraAlta_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
            posicionMouse = e.Location;
        }

        private void PanelBarraAlta_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                Point nuevaPosicion = this.Location;
                nuevaPosicion.Offset(e.Location.X - posicionMouse.X, e.Location.Y - posicionMouse.Y);
                this.Location = nuevaPosicion;
            }
        }

        private void PanelBarraAlta_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }


    }
}
