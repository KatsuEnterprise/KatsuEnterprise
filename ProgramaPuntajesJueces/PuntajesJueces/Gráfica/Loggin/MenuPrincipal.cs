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

        //Para que se pueda mover la ventana
        bool vai = false;
        private void PanelBarraAlta_MouseDown(object sender, MouseEventArgs e)
        {
            vai = true;
        }

        private void PanelBarraAlta_MouseMove(object sender, MouseEventArgs e)
        {
            if (vai == true)
            { this.Location = Cursor.Position; }
        }

        private void PanelBarraAlta_MouseUp(object sender, MouseEventArgs e)
        {
            vai = false;
        }
    }
}
