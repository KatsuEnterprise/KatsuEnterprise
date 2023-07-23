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

        private void radiobtnOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobtnOtro.Checked)
             richtxtExplicacionDescalificacion.Enabled = true;
            else richtxtExplicacionDescalificacion.Enabled = false;
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
