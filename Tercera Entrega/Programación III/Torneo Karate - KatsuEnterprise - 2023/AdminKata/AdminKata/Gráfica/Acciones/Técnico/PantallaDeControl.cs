using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{

    public partial class PantallaDeControl : Form
    {
        MostrarPantalla formMostrarPantalla = new MostrarPantalla();
        ValidarPuntaje formPuntajes = new ValidarPuntaje();
        Competidores formDatosCompetidores = new Competidores();
        VerCalificados formCalificados = new VerCalificados();
        CasoEmpate formEmpate = new CasoEmpate();
        IngresarDatosTorneo formTorneo = new IngresarDatosTorneo();
        DatosTabletsJueces formJueces = new DatosTabletsJueces();



        public PantallaDeControl()
        {
            InitializeComponent();
        }

        /*METODO PARA LOS BOTONES*/

        //el metodo trabaja con los formularios (Form) a los que llamarwemos form
        private void NewTab(Form form)
        {
            //Si el panel que muestra las pantallas tiene una respuesta positiva (1), representa que ghay algo en el panel
            if (PanelVentanas.Controls.Count == 1)
                //Se limpia el panel
                PanelVentanas.Controls.Clear();


            form.TopLevel = false;

            //añadimos el formulario que queremos mostrar al panel
            PanelVentanas.Controls.Add(form);
            // y lo traemos
            form.Show();
        }

        /*BOTONES*/



        private void btnPantalla_Click(object sender, EventArgs e)
        {
            NewTab(formMostrarPantalla);
        }

        private void btnPuntuacion_Click(object sender, EventArgs e)
        {
            NewTab(formPuntajes);
        }

        private void btnDatosCompetidores_Click(object sender, EventArgs e)
        {
            NewTab(formDatosCompetidores);
        }

        private void btnCalificados_Click(object sender, EventArgs e)
        {
            NewTab(formCalificados);
        }

        private void btnEmpate_Click(object sender, EventArgs e)
        {
            NewTab(formEmpate);
        }

        private void btnDatosJueces_Click(object sender, EventArgs e)
        {
            NewTab(formJueces);
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            NewTab(formTorneo);
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

        private void PantallaDeControl_Load(object sender, EventArgs e)
        {
            // **CONFIGURAR LABEL AÑO

            //Para que el lbl que ahora dice "2023", cambie si estamos en otro año

            int añoActual = DateTime.Now.Year;
            lblAño.Text = añoActual.ToString();
        }

        private void PanelVentanas_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
