using AdministradorKata.Lógica;
using System;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class Competidores : Form
    {
        public Competidores()
        {
            InitializeComponent();
        }

        //NO PERMITIR INGRESAR NUMEROS NI OTROS SIMBOLOS EN EL NOMBRE
        private void txtNombreCompetidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }

        //NO PERMITIR INGRESAR NUMEROS NI OTROS SIMBOLOS EN EL APELLIDO
        private void txtApellidoCompetidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\'' && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }


        //INGRESAR SOLO NÚMEROS EN EL TEXTBOX DE CEDULA
        private void txtCICompetidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);
            }
        }

        private void txtCICompetidor_TextChanged(object sender, EventArgs e)
        {
            if (txtCICompetidor.Text.Length > 8)
            {
                txtCICompetidor.Text = txtCICompetidor.Text.Substring(0, 8);
                txtCICompetidor.SelectionStart = 8;
            }
        }

        //NO NÚMEROS U OTROS SIMBOLOS EN EL TEXTBOX DE ESCUELA
        private void txtEscuelaCompetidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\'' && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }

        //NO PERMITIR INGRESAR NUMEROS NI OTROS SIMBOLOS EN EL NOMBRE DEL PROFESOR DEL COMPETIDOR

        private void txtProfesorCompetidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\'' && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }


        // *****METODOS******

        // Para verificar la edad mínima que puede tener un participante
        public bool Edad(DateTime nacimientoComp)
        {
            DateTime fechaActual = DateTime.Today;

            int edadMinima = 12;

            int fecha_nac = DTNacimientoComp.Value.Year;

            int edad = fechaActual.Year - fecha_nac;

            //Para que si alguien tiene 11 pero cumple 12 este año, no pueda ingresarlo  hasta que no tenga 12 años
            //-edad = -(numeroedadpersona)
            if (DTNacimientoComp.Value > fechaActual.AddYears(-edad))
            { edad--; }

            if (edad >= edadMinima)
                return true;
            else
                return false;
        }

        //Para qur la fecha del vencimiento no se acepte si el carnet esta vencido 
        public bool Vencimiento(DateTime vencimientoCarnetSalud)
        {
            DateTime fechaActual = DateTime.Today;

            //Si la fecha que se seleccionó es menor al día de hoy
            if (dateTimeIngresarVencimientoCarnetSalud.Value < fechaActual)
                //no es una fecha válida, el carnet esta vencido.
                return false;
            else
                return true;
        }


        // *********BOTONES*****************

        // Datos que se guardan en el boton

        private void btnGuardarDatosCompetidor_Click(object sender, EventArgs e)
        {
            string nombreComp = txtNombreCompetidor.Text;
            string apellidoComp = txtApellidoCompetidor.Text;
            int ciComp = int.Parse(txtCICompetidor.Text);
            DateTime nacimientoComp = DateTime.Parse(DTNacimientoComp.Text);
            DateTime vencimientoCarnetSaludComp = DateTime.Parse(dateTimeIngresarVencimientoCarnetSalud.Text);
            string sociedadComp = CBSociedadCompetidor.SelectedItem.ToString();
            string escuelaComp = txtEscuelaCompetidor.Text;
            string profeSupervisor = txtProfesorCompetidor.Text;


            Lógica.Competidor comp = new Competidor(nombreComp, apellidoComp, ciComp, nacimientoComp, vencimientoCarnetSaludComp, sociedadComp, escuelaComp, profeSupervisor);

            dgvCompetidoresIngresadosenBD.DataSource = comp.ListarDGVCompetidor();

            MessageBox.Show("Competidor creado");

        }

        private void cbNombreCompetidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Lógica.Competidor comp = new Lógica.Competidor();
            dgvCompetidoresIngresadosenBD.DataSource = comp.ListarDGVCompetidor();


            cbNombreCompetidor.DataSource = (new Lógica.Competidor()).ListarCBox();
            cbNombreCompetidor.ValueMember = "nombreComp, apellidoComp";
            cbNombreCompetidor.DisplayMember = "nombreComp, apellidoComp";

        }
                   
        // **CONFIGURAR LABEL AÑO

        //Para que el lbl que ahora dice "2023", cambie si estamos en otro año

    }

}
