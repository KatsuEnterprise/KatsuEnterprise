using AdministradorKata.Lógica;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class Competidores : Form
    {
        public Competidores()
        {
            InitializeComponent();
        }

        private string[] kataArray = new string[] {
            "Placeholder", // Index 0 (not used)
            "Anan",
            "Anan Dai",
            "Ananko",
            "Aoyagi",
            "Bassai",
            "Bassai Dai",
            "Bassai Sho",
            "Chatanyara Kusanku",
            "Chibana No Kushanku",
            "Chinte",
            "Chinto",
            "Enpi",
            "Fukyugata Ichi",
            "Fukyugata Ni",
            "Gankaku",
            "Garyu",
            "Gekisai (Geksai) 1",
            "Gekisai (Geksai) 2",
            "Gojushiho",
            "Gojushiho Dai",
            "Gojushiho Sho",
            "Hakusho",
            "Hangetsu",
            "Haufa (Haffa)",
            "Heian Shodan",
            "Heian Nidan",
            "Heian Sandan",
            "Heian Yondan",
            "Heian Godan",
            "Heiku",
            "Ishimine Bassai",
            "Itosu Rohai Shodan",
            "Itosu Rohai Nidan",
            "Itosu Rohai Sandan",
            "Jiin",
            "Jion",
            "Jitte",
            "Juroku",
            "Kanchin",
            "Kanku Dai",
            "Kanku Sho",
            "Kanshu",
            "Kishimono No Kushanku",
            "Kousoukun",
            "Kousoukun Dai",
            "Kousoukun Sho",
            "Kururunfa",
            "Kusanku",
            "Kyan No Chinto",
            "Kyan No Wanshu",
            "Matsukaze",
            "Matsumura Bassai",
            "Matsumura Rohai",
            "Meikyo",
            "Myojo",
            "Naifanchin Shodan",
            "Naifanchin Nidan",
            "Naifanchin Sandan",
            "Naihanchi",
            "Nijushiho",
            "Nipaipo",
            "Niseishi",
            "Ohan",
            "Ohan Dai",
            "Oyadomari No Passai",
            "Pachu",
            "Paiku",
            "Papuren",
            "Passai",
            "Pinan Shodan",
            "Pinan Nidan",
            "Pinan Sandan",
            "Pinan Yondan",
            "Pinan Godan",
            "Rohai",
            "Saifa",
            "Sanchin",
            "Sansai",
            "Sanseiru",
            "Sanseru",
            "Seichin",
            "Seienchin",
            "Seipai",
            "Seiryu",
            "Seishan",
            "Seisan (Sesan)",
            "Shiho Kousouku",
            "Shinpa",
            "Shinsei",
            "Shisochin",
            "Sochin",
            "Suparinpei",
            "Tekki Shodan",
            "Tekki Nidan",
            "Tekki Sandan",
            "Tensho",
            "Tomari Bassai",
            "Unshu",
            "Unsu",
            "Useishi",
            "Wankan",
            "Wanshu"
        };


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
                MessageBox.Show("El competidor no tiene la edad mínima para competir");
            return false;

        }

        //Para qur la fecha del vencimiento no se acepte si el carnet esta vencido 
        public bool Vencimiento(DateTime vencimientoCarnetSalud)
        {
            DateTime fechaActual = DateTime.Today;

            //Si la fecha que se seleccionó es menor al día de hoy
            if (dateTimeIngresarVencimientoCarnetSalud.Value < fechaActual)
            { //no es una fecha válida, el carnet esta vencido.
                MessageBox.Show("Carnet de salud vencido, por favor, renueve su carnet de salud y vuelva a intentarlo.");
                return false;
            }
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
            string EscuelaComp = txtEscuelaCompetidor.Text;
            string Profe = txtProfesorCompetidor.Text;


            Lógica.Competidor comp = new Competidor(nombreComp, apellidoComp, ciComp, nacimientoComp, vencimientoCarnetSaludComp, sociedadComp, EscuelaComp, Profe);

            // Verifica si el competidor ya existe
            if (comp.CompetidorExiste())
            {
                MessageBox.Show("El competidor ya existe.");
            }
            else
            {
                // Si no existe, lo agregamos
                dgvCompetidoresIngresadosenBD.DataSource = comp.ListarDGVCompetidor();
                comp.AltaCompetidor();
                MessageBox.Show("Competidor creado.");
            }

        }

        private void Competidores_Load(object sender, EventArgs e)
        {

            // Poner en ComboBox los torneos existentes
            cbTorneo.DataSource = new Lógica.Torneo().ListarComboBox();
            cbTorneo.ValueMember = "IDTorneo";
            cbTorneo.DisplayMember = "IDTorneo"; // Cambiar a un nombre diferente

            comboBox1.DataSource = new Torneo().ListarComboBox();
            comboBox1.ValueMember = "IDTorneo";
            comboBox1.DisplayMember = "IDTorneo"; // Cambiar a un nombre diferente


            //Poner en DGV los competidores existentes
            Lógica.Competidor comp = new Lógica.Competidor();
            this.dgvCompetidoresIngresadosenBD.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvCompetidoresIngresadosenBD.DefaultCellStyle.BackColor = Color.White;

            //Al sortear los competidores, que los mismos se muestren en el pool al que van a ir
           

            // Poner en combobox los competidores existentes
            cbNombreCompetidor.DataSource = (new Lógica.Competidor()).ListarCBox();
            cbNombreCompetidor.ValueMember = "CI"; // Elegir una columna como ValueMember
            cbNombreCompetidor.DisplayMember = "Nombre"; // Elegir otra columna como DisplayMember



           

            // Por defecto (en el diseñador del formulario) debe estar habilitada la edición para luego deshabilitar las columnas que no se quieran permitir el
            for (int i = 0; i < dgvCompetidoresIngresadosenBD.Columns.Count - 1; i++)
                dgvCompetidoresIngresadosenBD.Columns[i].ReadOnly = true;

            for (int i = 0; i < dgvPoolAka.Columns.Count - 1; i++)
                dgvPoolAka.Columns[i].ReadOnly = true;

            for (int i = 0; i < dgvPoolAo.Columns.Count - 1; i++)
                dgvPoolAo.Columns[i].ReadOnly = true;

            // CONFIGURAR LABEL AÑO
            //Para que el lbl que ahora dice "2023", cambie si estamos en otro año
            int añoActual = DateTime.Now.Year;
            lblAnio.Text = añoActual.ToString();
            lblAño.Text = añoActual.ToString();
            lblAno.Text = añoActual.ToString();
            label4.Text = añoActual.ToString();

        }



        private void btnSortearCompetidores_Click(object sender, EventArgs e)
        {
            Competidor competidor = new Competidor();

            string IDTorneo = ((DataRowView)comboBox1.SelectedItem)["IDTorneo"].ToString();

            competidor.CantidadCompetidores(IDTorneo.ToString());

            competidor.SortearPrimerRound(IDTorneo.ToString());

     
        }


        private void btnGuardarCompATorneo_Click(object sender, EventArgs e)
        {
            
                string cedulaCompetidor = ((DataRowView)cbNombreCompetidor.SelectedItem)["CI"].ToString();
                string IDTorneo = ((DataRowView)cbTorneo.SelectedItem)["IDTorneo"].ToString();
            string IDRound = cbRoundParaKata.SelectedIndex.ToString();
            string NumKata = cbKatas.SelectedIndex.ToString();
            bool competidorActivo = false;


            Esta esta = new Esta();
               Poseen poseen = new Poseen();
            Competidor comp = new Competidor();

                esta.GuardarCompetidorEnTorneo(cedulaCompetidor, IDTorneo);
                poseen.IngresarKataComp(cedulaCompetidor, IDRound, NumKata, IDTorneo);
            comp.CompetidorCompitiendo(cedulaCompetidor, IDTorneo, IDRound, competidorActivo);
                MessageBox.Show("Operaciones completadas exitosamente!");

             
                Conexion.GetInstancia().Desconectar(); // Mover esta línea al final


            

            
        }



    }
}



