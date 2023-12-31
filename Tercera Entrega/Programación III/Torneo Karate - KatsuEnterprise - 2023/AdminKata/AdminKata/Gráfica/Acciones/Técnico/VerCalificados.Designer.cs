﻿
namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    partial class VerCalificados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCalificados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.KatsuEnterprise = new System.Windows.Forms.Label();
            this.PanelBarraAlta = new System.Windows.Forms.Panel();
            this.lblTituloCalificados = new System.Windows.Forms.Label();
            this.btnSortearCompetidores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblKatatabComp = new System.Windows.Forms.Label();
            this.lblCampAUK = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvCalificados = new System.Windows.Forms.DataGridView();
            this.cbSeleccionarTorneo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.PanelBarraAlta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KatsuEnterprise);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 30);
            this.panel1.TabIndex = 33;
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
            // PanelBarraAlta
            // 
            this.PanelBarraAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PanelBarraAlta.Controls.Add(this.lblTituloCalificados);
            this.PanelBarraAlta.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraAlta.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraAlta.Name = "PanelBarraAlta";
            this.PanelBarraAlta.Size = new System.Drawing.Size(1072, 27);
            this.PanelBarraAlta.TabIndex = 81;
            // 
            // lblTituloCalificados
            // 
            this.lblTituloCalificados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloCalificados.AutoSize = true;
            this.lblTituloCalificados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCalificados.ForeColor = System.Drawing.Color.White;
            this.lblTituloCalificados.Location = new System.Drawing.Point(445, 7);
            this.lblTituloCalificados.Name = "lblTituloCalificados";
            this.lblTituloCalificados.Size = new System.Drawing.Size(188, 16);
            this.lblTituloCalificados.TabIndex = 54;
            this.lblTituloCalificados.Text = "- ̗̀  Competidores Calificados  ̖́ -";
            // 
            // btnSortearCompetidores
            // 
            this.btnSortearCompetidores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSortearCompetidores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnSortearCompetidores.FlatAppearance.BorderSize = 0;
            this.btnSortearCompetidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortearCompetidores.ForeColor = System.Drawing.Color.White;
            this.btnSortearCompetidores.Location = new System.Drawing.Point(846, 250);
            this.btnSortearCompetidores.Name = "btnSortearCompetidores";
            this.btnSortearCompetidores.Size = new System.Drawing.Size(177, 46);
            this.btnSortearCompetidores.TabIndex = 83;
            this.btnSortearCompetidores.Text = "Sortear Copetidores";
            this.btnSortearCompetidores.UseVisualStyleBackColor = false;
            this.btnSortearCompetidores.Click += new System.EventHandler(this.btnSortearCompetidores_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAño);
            this.panel2.Controls.Add(this.lblKatatabComp);
            this.panel2.Controls.Add(this.lblCampAUK);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(123)))), ((int)(((byte)(92)))));
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 79);
            this.panel2.TabIndex = 86;
            // 
            // lblAño
            // 
            this.lblAño.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblAño.Location = new System.Drawing.Point(534, 19);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(93, 39);
            this.lblAño.TabIndex = 92;
            this.lblAño.Text = "2023";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblKatatabComp
            // 
            this.lblKatatabComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKatatabComp.AutoSize = true;
            this.lblKatatabComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKatatabComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(81)))), ((int)(((byte)(231)))));
            this.lblKatatabComp.Location = new System.Drawing.Point(440, 19);
            this.lblKatatabComp.Name = "lblKatatabComp";
            this.lblKatatabComp.Size = new System.Drawing.Size(107, 39);
            this.lblKatatabComp.TabIndex = 93;
            this.lblKatatabComp.Text = "KATA";
            this.lblKatatabComp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCampAUK
            // 
            this.lblCampAUK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCampAUK.AutoSize = true;
            this.lblCampAUK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampAUK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.lblCampAUK.Location = new System.Drawing.Point(130, 21);
            this.lblCampAUK.Name = "lblCampAUK";
            this.lblCampAUK.Size = new System.Drawing.Size(277, 37);
            this.lblCampAUK.TabIndex = 91;
            this.lblCampAUK.Text = "Campeonato CUK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // dgvCalificados
            // 
            this.dgvCalificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificados.Location = new System.Drawing.Point(21, 117);
            this.dgvCalificados.Name = "dgvCalificados";
            this.dgvCalificados.Size = new System.Drawing.Size(786, 356);
            this.dgvCalificados.TabIndex = 89;
            // 
            // cbSeleccionarTorneo
            // 
            this.cbSeleccionarTorneo.FormattingEnabled = true;
            this.cbSeleccionarTorneo.Location = new System.Drawing.Point(846, 205);
            this.cbSeleccionarTorneo.Name = "cbSeleccionarTorneo";
            this.cbSeleccionarTorneo.Size = new System.Drawing.Size(177, 21);
            this.cbSeleccionarTorneo.TabIndex = 90;
            // 
            // VerCalificados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1072, 524);
            this.Controls.Add(this.cbSeleccionarTorneo);
            this.Controls.Add(this.dgvCalificados);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSortearCompetidores);
            this.Controls.Add(this.PanelBarraAlta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerCalificados";
            this.Text = "VerCalificados";
            this.Load += new System.EventHandler(this.VerCalificados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelBarraAlta.ResumeLayout(false);
            this.PanelBarraAlta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label KatsuEnterprise;
        private System.Windows.Forms.Panel PanelBarraAlta;
        private System.Windows.Forms.Button btnSortearCompetidores;
        private System.Windows.Forms.Label lblTituloCalificados;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblKatatabComp;
        private System.Windows.Forms.Label lblCampAUK;
        private System.Windows.Forms.DataGridView dgvCalificados;
        private System.Windows.Forms.ComboBox cbSeleccionarTorneo;
    }
}