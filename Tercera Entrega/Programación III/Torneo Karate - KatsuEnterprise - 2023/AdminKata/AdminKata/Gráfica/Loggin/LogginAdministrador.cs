using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Loggin
{

    public partial class LogInAdministrador : Form
    {

        private Acciones.Técnico.PantallaDeControl ventanaControl;
        private Button button1;
        private Panel PanelBarraAlta;
        private Label lblTituloVentanaLogIn;
        private Button btnMaximizarPrograma;
        private Button btnMinimizarPrograma;
        private Button btnCerrarPrograma;
        private Panel panel1;
        private Label KatsuEnterprise;
        private Label lblLinea2;
        private Label lblLinea1;
        private Label lblAnio;
        private Label lblKata;
        private Panel panel2;
        private Label lblTituloCampeonato;
        private Label lblCUK;
        private PictureBox picBoxCUK;
        private Button btnIngresarComoAdmin;
        private TextBox txtIngresarContraAdmin;
        private Label lblContraseña;
        private Button button2;
        private Label lblJuez;
        private RecibirContraseña ventanaContrasenia;

        public LogInAdministrador()
        {
            InitializeComponent();
        }

        /*CONFIGURACION TEXTBOXS*/

        //Para que no se puedan ingresar numeros o simbolos
        private void txtIngresarNombreAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }

        //Para que no se puedan ingresar numeros o simbolos
        private void txtIngresarApellidoAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\'' && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                Console.Beep(1100, 1000);

            }
            else
                e.Handled = false;
        }


        /*BOTONES*/

        //Impide que se ingrese al sistema si el usuario puso en el txt de contraseña, una cotraseña incorrecta
        private void btnIngresarComoAdmin_Click(object sender, EventArgs e)
        {

            if (txtIngresarContraAdmin.Text == "imtheadmin")
            {
                //Si la ventana no se abrió Ó esta no esta disponible
                if (ventanaControl == null || ventanaControl.IsDisposed)
                {
                    ventanaControl = new Acciones.Técnico.PantallaDeControl();

                    //Mostramos la ventana que abrimos
                    ventanaControl.Show();
                    //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                    //(y que la ventana quede delante siempre)
                    ventanaControl.Focus();
                    //Cerramos la pantalla en la que estamos
                    this.Visible = false;
                }
            }
            else { MessageBox.Show("¡Contraseña incorrecta!"); }
        }


        //Boton que te lleva a otra ventana para recibir la contraseña
        private void btnOlvideContrasenia_Click(object sender, EventArgs e)
        {
            //Si la ventana no se abrió Ó esta no esta disponible
            if (ventanaContrasenia == null || ventanaContrasenia.IsDisposed)
            {
                ventanaContrasenia = new RecibirContraseña();

                //Mostramos la ventana que abrimos
                ventanaContrasenia.Show();

                //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                //(y que la ventana quede delante siempre)
                ventanaContrasenia.Focus();

                //Cerramos la pantalla en la que estamos

            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInAdministrador));
            this.PanelBarraAlta = new System.Windows.Forms.Panel();
            this.lblTituloVentanaLogIn = new System.Windows.Forms.Label();
            this.btnMaximizarPrograma = new System.Windows.Forms.Button();
            this.btnMinimizarPrograma = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KatsuEnterprise = new System.Windows.Forms.Label();
            this.lblLinea2 = new System.Windows.Forms.Label();
            this.lblLinea1 = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblKata = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTituloCampeonato = new System.Windows.Forms.Label();
            this.lblCUK = new System.Windows.Forms.Label();
            this.picBoxCUK = new System.Windows.Forms.PictureBox();
            this.btnIngresarComoAdmin = new System.Windows.Forms.Button();
            this.txtIngresarContraAdmin = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblJuez = new System.Windows.Forms.Label();
            this.PanelBarraAlta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCUK)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBarraAlta
            // 
            this.PanelBarraAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PanelBarraAlta.Controls.Add(this.lblTituloVentanaLogIn);
            this.PanelBarraAlta.Controls.Add(this.btnMaximizarPrograma);
            this.PanelBarraAlta.Controls.Add(this.btnMinimizarPrograma);
            this.PanelBarraAlta.Controls.Add(this.btnCerrarPrograma);
            this.PanelBarraAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraAlta.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraAlta.Name = "PanelBarraAlta";
            this.PanelBarraAlta.Size = new System.Drawing.Size(1235, 27);
            this.PanelBarraAlta.TabIndex = 77;
            this.PanelBarraAlta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraAlta_MouseDown_1);
            this.PanelBarraAlta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBarraAlta_MouseMove_1);
            // 
            // lblTituloVentanaLogIn
            // 
            this.lblTituloVentanaLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloVentanaLogIn.AutoSize = true;
            this.lblTituloVentanaLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentanaLogIn.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentanaLogIn.Location = new System.Drawing.Point(569, 5);
            this.lblTituloVentanaLogIn.Name = "lblTituloVentanaLogIn";
            this.lblTituloVentanaLogIn.Size = new System.Drawing.Size(69, 16);
            this.lblTituloVentanaLogIn.TabIndex = 54;
            this.lblTituloVentanaLogIn.Text = "- ̗̀  Log in  ̖́ -";
            // 
            // btnMaximizarPrograma
            // 
            this.btnMaximizarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarPrograma.Location = new System.Drawing.Point(1135, 3);
            this.btnMaximizarPrograma.Name = "btnMaximizarPrograma";
            this.btnMaximizarPrograma.Size = new System.Drawing.Size(43, 21);
            this.btnMaximizarPrograma.TabIndex = 51;
            this.btnMaximizarPrograma.Text = "⛶";
            this.btnMaximizarPrograma.UseVisualStyleBackColor = true;
            this.btnMaximizarPrograma.Click += new System.EventHandler(this.btnMaximizarPrograma_Click_1);
            // 
            // btnMinimizarPrograma
            // 
            this.btnMinimizarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPrograma.Location = new System.Drawing.Point(1086, 3);
            this.btnMinimizarPrograma.Name = "btnMinimizarPrograma";
            this.btnMinimizarPrograma.Size = new System.Drawing.Size(43, 21);
            this.btnMinimizarPrograma.TabIndex = 50;
            this.btnMinimizarPrograma.Text = "⎯";
            this.btnMinimizarPrograma.UseVisualStyleBackColor = true;
            this.btnMinimizarPrograma.Click += new System.EventHandler(this.btnMinimizarPrograma_Click_1);
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPrograma.Location = new System.Drawing.Point(1184, 3);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(43, 21);
            this.btnCerrarPrograma.TabIndex = 49;
            this.btnCerrarPrograma.Text = "✘";
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KatsuEnterprise);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 30);
            this.panel1.TabIndex = 95;
            // 
            // KatsuEnterprise
            // 
            this.KatsuEnterprise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.KatsuEnterprise.AutoSize = true;
            this.KatsuEnterprise.ForeColor = System.Drawing.Color.White;
            this.KatsuEnterprise.Location = new System.Drawing.Point(2, 7);
            this.KatsuEnterprise.Name = "KatsuEnterprise";
            this.KatsuEnterprise.Size = new System.Drawing.Size(96, 13);
            this.KatsuEnterprise.TabIndex = 0;
            this.KatsuEnterprise.Text = "Katsu Enterprise ©";
            // 
            // lblLinea2
            // 
            this.lblLinea2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinea2.AutoSize = true;
            this.lblLinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblLinea2.Location = new System.Drawing.Point(355, 350);
            this.lblLinea2.Name = "lblLinea2";
            this.lblLinea2.Size = new System.Drawing.Size(38, 39);
            this.lblLinea2.TabIndex = 94;
            this.lblLinea2.Text = "—";
            // 
            // lblLinea1
            // 
            this.lblLinea1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinea1.AutoSize = true;
            this.lblLinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblLinea1.Location = new System.Drawing.Point(102, 350);
            this.lblLinea1.Name = "lblLinea1";
            this.lblLinea1.Size = new System.Drawing.Size(38, 39);
            this.lblLinea1.TabIndex = 93;
            this.lblLinea1.Text = "—";
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblAnio.Location = new System.Drawing.Point(261, 350);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(93, 39);
            this.lblAnio.TabIndex = 91;
            this.lblAnio.Text = "2023";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKata
            // 
            this.lblKata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKata.AutoSize = true;
            this.lblKata.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblKata.Location = new System.Drawing.Point(153, 350);
            this.lblKata.Name = "lblKata";
            this.lblKata.Size = new System.Drawing.Size(107, 39);
            this.lblKata.TabIndex = 92;
            this.lblKata.Text = "KATA";
            this.lblKata.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(530, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 571);
            this.panel2.TabIndex = 87;
            // 
            // lblTituloCampeonato
            // 
            this.lblTituloCampeonato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCampeonato.AutoSize = true;
            this.lblTituloCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCampeonato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.lblTituloCampeonato.Location = new System.Drawing.Point(65, 297);
            this.lblTituloCampeonato.Name = "lblTituloCampeonato";
            this.lblTituloCampeonato.Size = new System.Drawing.Size(359, 42);
            this.lblTituloCampeonato.TabIndex = 90;
            this.lblTituloCampeonato.Text = "【Campeonato CUK】";
            // 
            // lblCUK
            // 
            this.lblCUK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCUK.AutoSize = true;
            this.lblCUK.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCUK.Location = new System.Drawing.Point(7, 255);
            this.lblCUK.Name = "lblCUK";
            this.lblCUK.Size = new System.Drawing.Size(506, 30);
            this.lblCUK.TabIndex = 89;
            this.lblCUK.Text = "• | ⊱ Confederación Uruguaya de Karate ⊰ | •";
            // 
            // picBoxCUK
            // 
            this.picBoxCUK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxCUK.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCUK.Image")));
            this.picBoxCUK.Location = new System.Drawing.Point(222, 159);
            this.picBoxCUK.Name = "picBoxCUK";
            this.picBoxCUK.Size = new System.Drawing.Size(104, 93);
            this.picBoxCUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCUK.TabIndex = 88;
            this.picBoxCUK.TabStop = false;
            // 
            // btnIngresarComoAdmin
            // 
            this.btnIngresarComoAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresarComoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnIngresarComoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarComoAdmin.FlatAppearance.BorderSize = 0;
            this.btnIngresarComoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarComoAdmin.ForeColor = System.Drawing.Color.White;
            this.btnIngresarComoAdmin.Location = new System.Drawing.Point(755, 335);
            this.btnIngresarComoAdmin.Name = "btnIngresarComoAdmin";
            this.btnIngresarComoAdmin.Size = new System.Drawing.Size(272, 54);
            this.btnIngresarComoAdmin.TabIndex = 98;
            this.btnIngresarComoAdmin.Text = "Ingresar";
            this.btnIngresarComoAdmin.UseVisualStyleBackColor = false;
            this.btnIngresarComoAdmin.Click += new System.EventHandler(this.btnIngresarComoAdmin_Click_1);
            // 
            // txtIngresarContraAdmin
            // 
            this.txtIngresarContraAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIngresarContraAdmin.Location = new System.Drawing.Point(849, 292);
            this.txtIngresarContraAdmin.Name = "txtIngresarContraAdmin";
            this.txtIngresarContraAdmin.Size = new System.Drawing.Size(195, 20);
            this.txtIngresarContraAdmin.TabIndex = 97;
            this.txtIngresarContraAdmin.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(719, 292);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(123, 16);
            this.lblContraseña.TabIndex = 96;
            this.lblContraseña.Text = "╰───⌲‧ Contraseña";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(755, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 51);
            this.button2.TabIndex = 99;
            this.button2.Text = "Olvidé mi contraseña";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblJuez
            // 
            this.lblJuez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJuez.AutoSize = true;
            this.lblJuez.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblJuez.ForeColor = System.Drawing.Color.White;
            this.lblJuez.Location = new System.Drawing.Point(775, 213);
            this.lblJuez.Name = "lblJuez";
            this.lblJuez.Size = new System.Drawing.Size(233, 39);
            this.lblJuez.TabIndex = 100;
            this.lblJuez.Text = "Administrador";
            // 
            // LogInAdministrador
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1235, 605);
            this.Controls.Add(this.lblJuez);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIngresarComoAdmin);
            this.Controls.Add(this.txtIngresarContraAdmin);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLinea2);
            this.Controls.Add(this.lblLinea1);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblKata);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTituloCampeonato);
            this.Controls.Add(this.lblCUK);
            this.Controls.Add(this.picBoxCUK);
            this.Controls.Add(this.PanelBarraAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInAdministrador";
            this.PanelBarraAlta.ResumeLayout(false);
            this.PanelBarraAlta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCUK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnIngresarComoAdmin_Click_1(object sender, EventArgs e)
        {
            if (txtIngresarContraAdmin.Text == "imtheadmin")
            {
                //Si la ventana no se abrió Ó esta no esta disponible
                if (ventanaControl == null || ventanaControl.IsDisposed)
                {
                    ventanaControl = new Acciones.Técnico.PantallaDeControl();

                    //Mostramos la ventana que abrimos
                    ventanaControl.Show();
                    //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                    //(y que la ventana quede delante siempre)
                    ventanaControl.Focus();
                    //Cerramos la pantalla en la que estamos
                    this.Visible = false;
                }
            }
            else { MessageBox.Show("¡Contraseña incorrecta!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Si la ventana no se abrió Ó esta no esta disponible
            if (ventanaContrasenia == null || ventanaContrasenia.IsDisposed)
            {
                ventanaContrasenia = new RecibirContraseña();

                //Mostramos la ventana que abrimos
                ventanaContrasenia.Show();

                //Focalizamos para evitar de que se abran muchas ventanas si se apreta el botón muchas veces
                //(y que la ventana quede delante siempre)
                ventanaContrasenia.Focus();

                //Cerramos la pantalla en la que estamos
            }
        }

        private void btnCerrarPrograma_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnMinimizarPrograma_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnMaximizarPrograma_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        //Para que se pueda mover la ventana
        bool vai = false;

        private Point posicionMouse;

        private void PanelBarraAlta_MouseDown_1(object sender, MouseEventArgs e)
        {
            vai = true;
            posicionMouse = e.Location;
        }

        private void PanelBarraAlta_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (vai == true)
            {
                Point nuevaPosicion = this.Location;
                nuevaPosicion.Offset(e.Location.X - posicionMouse.X, e.Location.Y - posicionMouse.Y);
                this.Location = nuevaPosicion;
            }
        }
    }
}
