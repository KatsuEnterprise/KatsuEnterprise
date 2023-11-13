using System;
using System.Drawing;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace AdministradorKata.Gráfica.Loggin
{
    public partial class RecibirContraseña : Form
    {
        public RecibirContraseña()
        {
            InitializeComponent();
        }

        private void btnMazimizarPrograma_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Normal; }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizarPrograma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarPrograma_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnRecibirContrasenia_Click(object sender, EventArgs e)
        {
            var accountSid = "AC55eba905318c15d7d42f0d0ae104e5e3";
            var authToken = "fe5d1a48725f5073cf44c91bc4f99784";
            TwilioClient.Init(accountSid, authToken);

            string numero= msktxtIngresarCelularAdministrador.Text;

            var message = MessageResource.Create(
            from: new Twilio.Types.PhoneNumber("+18156058927"),
            body: "Contraseña: imtheadmin",
            to: new Twilio.Types.PhoneNumber("+59893646109"));

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

        private void RecibirContraseña_Load(object sender, EventArgs e)
        {
            // **CONFIGURAR LABEL AÑO

            //Para que el lbl que ahora dice "2023", cambie si estamos en otro año

            int añoActual = DateTime.Now.Year;
            lblAnio.Text = añoActual.ToString();
        }
    }
}
