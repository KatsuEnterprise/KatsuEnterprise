using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PuntajesJueces.Gráfica.Loggin
{
   
    public partial class LogginJueces : Form
    {
        //Creo objeto ventanaPunt que tenga la ubicación de la clase a la que queremos ir.
        private Gráfica.Acciones.Puntuacion ventanaPunt;

      
        public LogginJueces()
        {
            InitializeComponent();
        }

        /*BOTONES*/

        private void btnIngresarAlPuntaje_Click(object sender, EventArgs e)
        {
          
            var Juez = new Dictionary<String, String>()
            {   //Key - Value
                {"1", "soyjuezuno" },
                {"2","soyjuezdos" },
                { "3", "soyjueztres"},
                {"4", "soyjuezcuatro" },
                { "5", "soyjuezcinco" },
                { "6", "soyjuezseis" },
                { "7", "soyjuezsiete" }
            };
           
            //Se recorre las contraseñas y users
            foreach (var x in Juez)
            {
                if (comBoxNumeroJuez.Text == x.Key)
                {
                    //se valida la contraseña
                    if (txtContraJuez.Text == x.Value)
                    {
                        //Se evita Multiples ventanas
                        if (ventanaPunt == null || ventanaPunt.IsDisposed)
                        {
                                ventanaPunt = new Acciones.Puntuacion();
                            //Mostramos la ventana que abrimos
                            ventanaPunt.Show();
                            //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                            //(y que la ventana quede delante siempre)
                            ventanaPunt.Focus();
                            this.Visible = false;
                        }

                    }
                    else { MessageBox.Show("¡Contraseña incorrecta!"); }
                }
            }
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
