using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Loggin
{

    public partial class LogginAdministrador : Form
    {

        private Acciones.Técnico.PantallaDeControl ventanaControl;
        private RecibirContraseña ventanaContrasenia;

        public LogginAdministrador()
        {
            InitializeComponent();
        }

        /*CONFIGURACION TEXTBOXS*/

        //Para que no se puedan ingresar numeros o simbolos
        private void txtIngresarNombreAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }

        //Para que no se puedan ingresar numeros o simbolos
        private void txtIngresarApellidoAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\'' && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }


        /*BOTONES*/

        //Impide que se ingrese al sistema si el usuario puso en el txt de contraseña, una cotraseña incorrecta
        private void btnIngresarComoAdmin_Click(object sender, EventArgs e)
        {

            if (txtIngresarContraAdmin.Text == "imtheadmin")
            {
                //Si la ventana no se abrió Ó esta no esta disponible
                if (ventanaControl == null || ventanaControl.IsDisposed)
                {
                    ventanaControl = new Acciones.Técnico.PantallaDeControl();

                    //Mostramos la ventana que abrimos
                    ventanaControl.Show();
                    //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                    //(y que la ventana quede delante siempre)
                    ventanaControl.Focus();
                    //Cerramos la pantalla en la que estamos
                    this.Visible = false;
                }
            }
            else { MessageBox.Show("¡Contraseña incorrecta!"); }
        }


        //Boton que te lleva a otra ventana para recibir la contraseña
        private void btnOlvideContrasenia_Click(object sender, EventArgs e)
        {
            //Si la ventana no se abrió Ó esta no esta disponible
            if (ventanaContrasenia == null || ventanaContrasenia.IsDisposed)
            {
                ventanaContrasenia = new RecibirContraseña();

                //Mostramos la ventana que abrimos
                ventanaContrasenia.Show();

                //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                //(y que la ventana quede delante siempre)
                ventanaContrasenia.Focus();

                //Cerramos la pantalla en la que estamos

            }
        }

        //Botón cerrar Programa
        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Botón maximizar programa

        private void btnMaximizarPrograma_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Normal; }
            else this.WindowState = FormWindowState.Maximized;
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
