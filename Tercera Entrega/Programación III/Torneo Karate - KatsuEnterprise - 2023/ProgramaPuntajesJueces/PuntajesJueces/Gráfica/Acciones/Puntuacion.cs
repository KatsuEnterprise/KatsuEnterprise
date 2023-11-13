using MySql.Data.MySqlClient;
using PuntajesJueces.Lógica;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PuntajesJueces.Gráfica.Acciones
{
    public partial class Puntuacion : Form

    {

       
    
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
            if (Decimal > 9)
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
            {
                lblDecimal.Text = 0.ToString();
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
            {
                Decimal = 0;
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

            double puntajefinal = Entero + (Decimal / 10.0);

            if (Decimal == 0)
            {
                puntajefinal = Entero;
            }


            string CI = ((DataRowView)comboBox3.SelectedItem)["CI"].ToString();
            string IDTorneo = ((DataRowView)comboBox1.SelectedItem)["IDTorneo"].ToString();
            string NumJuez = comboBox4.SelectedIndex+1.ToString();
            string IDRound = comboBox2.SelectedIndex.ToString();

           
            string sentencia = $"INSERT INTO Califica VALUES({CI},{IDTorneo}, NumKata, {NumJuez}, {puntajefinal}, {IDRound})";
            MySqlCommand mmm = new MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            mmm.ExecuteNonQuery();


            MessageBox.Show($"¡Puntaje enviado con éxito!\nEl puntaje que ha enviado es de: {puntajefinal:F1}");
            Conexion.GetInstancia().Desconectar();

        }

        private void btnDescalificar_Click(object sender, EventArgs e)
        {
            double puntajefinal =0.0;

            string CI = ((DataRowView)comboBox3.SelectedItem)["CI"].ToString();
            string IDTorneo = ((DataRowView)comboBox1.SelectedItem)["IDTorneo"].ToString();
            string NumJuez = comboBox4.SelectedIndex + 1.ToString();
            string IDRound = comboBox2.SelectedIndex+1.ToString();


            string sentencia = $"INSERT INTO Califica VALUES({CI},{IDTorneo}, NumKata, {NumJuez}, {puntajefinal}, {IDRound})";
            MySqlCommand mmm = new MySqlCommand(sentencia, Conexion.GetInstancia().Conectar());

            mmm.ExecuteNonQuery();


            MessageBox.Show($"¡Puntaje enviado con éxito!\nEl puntaje que ha enviado es de: {puntajefinal:F1}");
            Conexion.GetInstancia().Desconectar();
        }

        //Botón cerrar Programa
        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
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

        private void Puntuacion_Load(object sender, EventArgs e)
        {
            //AÑO 
            int añoActual = DateTime.Now.Year;
            lblAño.Text = añoActual.ToString();

            comboBox1.DataSource = new Torneo().ListarComboBox();
            comboBox1.ValueMember = "IDTorneo";
            comboBox1.DisplayMember = "IDtorneo";

            comboBox3.DataSource = new Competidor().ListarCBox();
            comboBox3.ValueMember = "CI";
            comboBox3.DisplayMember = "Nombre";



        }
    }

    
}

