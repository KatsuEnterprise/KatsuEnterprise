using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntajesJueces.Gráfica.Acciones
{
    public partial class Descalificacion : Form
    {
        public Descalificacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        /*BOTONES*/

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

        private void radiobtnOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnOtro.Checked)
             richtxtExplicacionDescalificacion.Enabled = true;
            else richtxtExplicacionDescalificacion.Enabled = false;
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
