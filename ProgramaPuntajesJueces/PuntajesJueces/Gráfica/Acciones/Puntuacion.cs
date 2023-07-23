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
    public partial class Puntuacion : Form

    {

        private Descalificacion ventanaDescalificacion;


        public Puntuacion()
        {
            InitializeComponent();
        }


        //Creamos variables que nos servirán para darle un valor base a los decimales y enteros.
        
        int Decimal = 0; 
        int Entero = 5;
      

        /*BOTONES*/

        private void btnSumarDecimal_Click(object sender, EventArgs e)
        {
            //Si pulsamos el boton sumar decimal
            // Decimal++ = Decimal +1 
            // Decimal vale 0, decimal++/decimal+1= 1
            Decimal++;

            //El label de decimal va a cambiar por el valor qeu ahora tiene el decimal (es decir, decimal+1)
                (lblDecimal.Text) = Decimal.ToString();

            //Decimal ya deja de valer 0, y vale 1, así sucesivamente, es decir, si le damos de nuevo a sumar decimal, decimal, 
            //que valía ahora 1, al apretar el botón, ahora vale 2.
            Decimal = Decimal++;

            //Si el decimal es mayor a nueve
            if ( Decimal > 9 )
            {
                //cuando el decimal valga 10, ese 10 no se va a guardar y va a ser remplazado por un 0
                // no pueden habaer puntuaciones de 5.10 , tiene que ser o 6.0 o 5.9
                Decimal = 0;
                lblDecimal.Text = 0.ToString();

                //el numero entero se suma, es decir, el entero de base vale 5, pues pasa a seis
                //6.0
                Entero++;
                lblEntero.Text = Entero.ToString();
                
            }

            //Si el entero es mayor o igual a 10
            if (Entero >= 10)

                //El decimal pasa a valer 0, pues no pueden haber 10.1
            { lblDecimal.Text = 0.ToString();
                Decimal = 0;
            }

        }

        //Configuracion boton restar decimal
        private void btnRestarDecimal_Click(object sender, EventArgs e)
        {
            Decimal--;
                (lblDecimal.Text) = Decimal.ToString();
            Decimal = Decimal--;
           
            if (Decimal < 0)
            {Decimal = 0;
                lblDecimal.Text = 0.ToString();
            }
        }

        //Configuracion sumar entero
        private void btnSumarEntero_Click(object sender, EventArgs e)
        {
            Entero++;
            (lblEntero.Text) = Entero.ToString();


            if (Entero > 9)
            {
                lblDecimal.Text = 0.ToString();
                Decimal = 0;
                lblEntero.Text = 10.ToString();
                Entero = 10;
            }
        }

        //Configuracion restar entero
        private void btnRestarEntero_Click(object sender, EventArgs e)
        {
            Entero--;
            (lblEntero.Text) = Entero.ToString();

            if (Entero <= 4)
            {
                lblDecimal.Text = 0.ToString();
                lblEntero.Text = 5.ToString();
                Entero = 5;
                Decimal = 0;
        
            }
        }

        //Configuración boton enviar puntaje
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //El puntaje final tiene que ser double (numero con coma)
            // El puntaje final es la "suma" de el entero y el decimal dividido 10
            //Ej;
            //entero= 7
            //decimal= 5
            //suma= 75 (no sería suma, quiza sirva decirle union?)
            //75/10= 7.5
          
            double puntajefinal = (Entero + (double) (Decimal / (10)));

            //Si el decimal es 0
            //ej: 10.0
            if (Decimal == 0)
                //el puntaje final va a ser el entero, es decir, 10
            { puntajefinal = Entero; }

            //Menssaje de confirmacion de que se envió el mensaje
            //puntajefinal.ToString("F1"), el "F1" hace que al enviarse un entero como resultado final, se le agregue un .0
            //ej sin F1; El puntaje que ha enviado es de: 10
            // Ej con F1= El puntaje que ha enviado es de: 10
            MessageBox.Show("¡Puntaje enviado con éxito!" + "\n El puntaje que ha enviado es de: " + puntajefinal.ToString("F1"));
        }


        private void btnDescalificar_Click(object sender, EventArgs e)
        {
            //Se evita Multiples ventanas
            if (ventanaDescalificacion == null || ventanaDescalificacion.IsDisposed)
            {
                ventanaDescalificacion = new Descalificacion();
                //Mostramos la ventana que abrimos
                ventanaDescalificacion.Show();
                //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                //(y que la ventana quede delante siempre)
                ventanaDescalificacion.Focus();
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
