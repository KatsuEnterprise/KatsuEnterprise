using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntajesJueces.Gráfica.Loggin
{
    public partial class MenuPrincipal : Form
    {
        private Loggin.LogginJueces ventanaJuez;


        public MenuPrincipal()
        {
            InitializeComponent();
        }

        /*BOTONES*/

        private void btnIngresarAlLoggin_Click(object sender, EventArgs e)
        {
            //Si la ventana no se abrió Ó esta no esta disponible
            if (ventanaJuez == null || ventanaJuez.IsDisposed)
                ventanaJuez = new Loggin.LogginJueces();

            //Mostramos la ventana que abrimos
            ventanaJuez.Show();
            //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
            //(y que la ventana quede delante siempre)
            ventanaJuez.Focus();

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
