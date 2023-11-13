
namespace PuntajesJueces.Gráfica.Loggin
{
    partial class LogginJueces
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogginJueces));
            this.btnIngresarAlPuntaje = new System.Windows.Forms.Button();
            this.txtContraJuez = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblJuezNumero = new System.Windows.Forms.Label();
            this.comBoxNumeroJuez = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelBarraAlta = new System.Windows.Forms.Panel();
            this.lblTituloVentanaLogIn = new System.Windows.Forms.Label();
            this.btnMaximizarPrograma = new System.Windows.Forms.Button();
            this.btnMinimizarPrograma = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.lblJuez = new System.Windows.Forms.Label();
            this.lblLinea2 = new System.Windows.Forms.Label();
            this.lblLinea1 = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblKata = new System.Windows.Forms.Label();
            this.lblTituloCampeonato = new System.Windows.Forms.Label();
            this.lblCUK = new System.Windows.Forms.Label();
            this.picBoxCUK = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KatsuEnterprise = new System.Windows.Forms.Label();
            this.PanelBarraAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCUK)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresarAlPuntaje
            // 
            this.btnIngresarAlPuntaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresarAlPuntaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnIngresarAlPuntaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarAlPuntaje.FlatAppearance.BorderSize = 0;
            this.btnIngresarAlPuntaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarAlPuntaje.ForeColor = System.Drawing.Color.White;
            this.btnIngresarAlPuntaje.Location = new System.Drawing.Point(774, 369);
            this.btnIngresarAlPuntaje.Name = "btnIngresarAlPuntaje";
            this.btnIngresarAlPuntaje.Size = new System.Drawing.Size(272, 54);
            this.btnIngresarAlPuntaje.TabIndex = 26;
            this.btnIngresarAlPuntaje.Text = "Ingresar";
            this.btnIngresarAlPuntaje.UseVisualStyleBackColor = false;
            this.btnIngresarAlPuntaje.Click += new System.EventHandler(this.btnIngresarAlPuntaje_Click);
            // 
            // txtContraJuez
            // 
            this.txtContraJuez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraJuez.Location = new System.Drawing.Point(868, 326);
            this.txtContraJuez.Name = "txtContraJuez";
            this.txtContraJuez.Size = new System.Drawing.Size(195, 20);
            this.txtContraJuez.TabIndex = 25;
            this.txtContraJuez.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(738, 326);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(123, 16);
            this.lblContraseña.TabIndex = 22;
            this.lblContraseña.Text = "╰───⌲‧ Contraseña";
            // 
            // lblJuezNumero
            // 
            this.lblJuezNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJuezNumero.AutoSize = true;
            this.lblJuezNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuezNumero.ForeColor = System.Drawing.Color.White;
            this.lblJuezNumero.Location = new System.Drawing.Point(713, 288);
            this.lblJuezNumero.Name = "lblJuezNumero";
            this.lblJuezNumero.Size = new System.Drawing.Size(148, 16);
            this.lblJuezNumero.TabIndex = 28;
            this.lblJuezNumero.Text = "╰───⌲‧ Número de juez";
            // 
            // comBoxNumeroJuez
            // 
            this.comBoxNumeroJuez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comBoxNumeroJuez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxNumeroJuez.FormattingEnabled = true;
            this.comBoxNumeroJuez.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comBoxNumeroJuez.Location = new System.Drawing.Point(868, 287);
            this.comBoxNumeroJuez.Name = "comBoxNumeroJuez";
            this.comBoxNumeroJuez.Size = new System.Drawing.Size(195, 21);
            this.comBoxNumeroJuez.TabIndex = 29;
            this.comBoxNumeroJuez.TextChanged += new System.EventHandler(this.comBoxNumeroJuez_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(530, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 590);
            this.panel2.TabIndex = 75;
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
            this.PanelBarraAlta.Size = new System.Drawing.Size(1285, 27);
            this.PanelBarraAlta.TabIndex = 76;
            this.PanelBarraAlta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraAlta_MouseDown);
            this.PanelBarraAlta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBarraAlta_MouseMove);
            this.PanelBarraAlta.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelBarraAlta_MouseUp);
            // 
            // lblTituloVentanaLogIn
            // 
            this.lblTituloVentanaLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloVentanaLogIn.AutoSize = true;
            this.lblTituloVentanaLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentanaLogIn.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentanaLogIn.Location = new System.Drawing.Point(594, 5);
            this.lblTituloVentanaLogIn.Name = "lblTituloVentanaLogIn";
            this.lblTituloVentanaLogIn.Size = new System.Drawing.Size(69, 16);
            this.lblTituloVentanaLogIn.TabIndex = 54;
            this.lblTituloVentanaLogIn.Text = "- ̗̀  Log in  ̖́ -";
            // 
            // btnMaximizarPrograma
            // 
            this.btnMaximizarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarPrograma.Location = new System.Drawing.Point(1185, 3);
            this.btnMaximizarPrograma.Name = "btnMaximizarPrograma";
            this.btnMaximizarPrograma.Size = new System.Drawing.Size(43, 21);
            this.btnMaximizarPrograma.TabIndex = 51;
            this.btnMaximizarPrograma.Text = "⛶";
            this.btnMaximizarPrograma.UseVisualStyleBackColor = true;
            this.btnMaximizarPrograma.Click += new System.EventHandler(this.btnMaximizarPrograma_Click);
            // 
            // btnMinimizarPrograma
            // 
            this.btnMinimizarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPrograma.Location = new System.Drawing.Point(1136, 3);
            this.btnMinimizarPrograma.Name = "btnMinimizarPrograma";
            this.btnMinimizarPrograma.Size = new System.Drawing.Size(43, 21);
            this.btnMinimizarPrograma.TabIndex = 50;
            this.btnMinimizarPrograma.Text = "⎯";
            this.btnMinimizarPrograma.UseVisualStyleBackColor = true;
            this.btnMinimizarPrograma.Click += new System.EventHandler(this.btnMinimizarPrograma_Click);
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPrograma.Location = new System.Drawing.Point(1234, 3);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(43, 21);
            this.btnCerrarPrograma.TabIndex = 49;
            this.btnCerrarPrograma.Text = "✘";
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // lblJuez
            // 
            this.lblJuez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJuez.AutoSize = true;
            this.lblJuez.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblJuez.ForeColor = System.Drawing.Color.White;
            this.lblJuez.Location = new System.Drawing.Point(861, 222);
            this.lblJuez.Name = "lblJuez";
            this.lblJuez.Size = new System.Drawing.Size(91, 39);
            this.lblJuez.TabIndex = 78;
            this.lblJuez.Text = "Juez";
            // 
            // lblLinea2
            // 
            this.lblLinea2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinea2.AutoSize = true;
            this.lblLinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblLinea2.Location = new System.Drawing.Point(355, 369);
            this.lblLinea2.Name = "lblLinea2";
            this.lblLinea2.Size = new System.Drawing.Size(38, 39);
            this.lblLinea2.TabIndex = 85;
            this.lblLinea2.Text = "—";
            // 
            // lblLinea1
            // 
            this.lblLinea1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinea1.AutoSize = true;
            this.lblLinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblLinea1.Location = new System.Drawing.Point(102, 369);
            this.lblLinea1.Name = "lblLinea1";
            this.lblLinea1.Size = new System.Drawing.Size(38, 39);
            this.lblLinea1.TabIndex = 84;
            this.lblLinea1.Text = "—";
            // 
            // lblAnio
            // 
            this.lblAnio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblAnio.Location = new System.Drawing.Point(261, 369);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(93, 39);
            this.lblAnio.TabIndex = 82;
            this.lblAnio.Text = "2023";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKata
            // 
            this.lblKata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKata.AutoSize = true;
            this.lblKata.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblKata.Location = new System.Drawing.Point(153, 369);
            this.lblKata.Name = "lblKata";
            this.lblKata.Size = new System.Drawing.Size(107, 39);
            this.lblKata.TabIndex = 83;
            this.lblKata.Text = "KATA";
            this.lblKata.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTituloCampeonato
            // 
            this.lblTituloCampeonato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCampeonato.AutoSize = true;
            this.lblTituloCampeonato.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCampeonato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.lblTituloCampeonato.Location = new System.Drawing.Point(65, 316);
            this.lblTituloCampeonato.Name = "lblTituloCampeonato";
            this.lblTituloCampeonato.Size = new System.Drawing.Size(359, 42);
            this.lblTituloCampeonato.TabIndex = 81;
            this.lblTituloCampeonato.Text = "【Campeonato CUK】";
            // 
            // lblCUK
            // 
            this.lblCUK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCUK.AutoSize = true;
            this.lblCUK.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCUK.Location = new System.Drawing.Point(7, 274);
            this.lblCUK.Name = "lblCUK";
            this.lblCUK.Size = new System.Drawing.Size(506, 30);
            this.lblCUK.TabIndex = 80;
            this.lblCUK.Text = "• | ⊱ Confederación Uruguaya de Karate ⊰ | •";
            // 
            // picBoxCUK
            // 
            this.picBoxCUK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBoxCUK.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCUK.Image")));
            this.picBoxCUK.Location = new System.Drawing.Point(222, 178);
            this.picBoxCUK.Name = "picBoxCUK";
            this.picBoxCUK.Size = new System.Drawing.Size(104, 93);
            this.picBoxCUK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCUK.TabIndex = 79;
            this.picBoxCUK.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KatsuEnterprise);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 30);
            this.panel1.TabIndex = 86;
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
            // LogginJueces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1285, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLinea2);
            this.Controls.Add(this.lblLinea1);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblKata);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTituloCampeonato);
            this.Controls.Add(this.lblCUK);
            this.Controls.Add(this.picBoxCUK);
            this.Controls.Add(this.lblJuez);
            this.Controls.Add(this.PanelBarraAlta);
            this.Controls.Add(this.comBoxNumeroJuez);
            this.Controls.Add(this.lblJuezNumero);
            this.Controls.Add(this.btnIngresarAlPuntaje);
            this.Controls.Add(this.txtContraJuez);
            this.Controls.Add(this.lblContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogginJueces";
            this.Load += new System.EventHandler(this.LogginJueces_Load);
            this.PanelBarraAlta.ResumeLayout(false);
            this.PanelBarraAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCUK)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIngresarAlPuntaje;
        private System.Windows.Forms.TextBox txtContraJuez;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblJuezNumero;
        private System.Windows.Forms.ComboBox comBoxNumeroJuez;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelBarraAlta;
        private System.Windows.Forms.Label lblTituloVentanaLogIn;
        private System.Windows.Forms.Button btnMaximizarPrograma;
        private System.Windows.Forms.Button btnMinimizarPrograma;
        private System.Windows.Forms.Button btnCerrarPrograma;
        private System.Windows.Forms.Label lblJuez;
        private System.Windows.Forms.Label lblLinea2;
        private System.Windows.Forms.Label lblLinea1;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblKata;
        private System.Windows.Forms.Label lblTituloCampeonato;
        private System.Windows.Forms.Label lblCUK;
        private System.Windows.Forms.PictureBox picBoxCUK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KatsuEnterprise;
    }
}