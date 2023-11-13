using System;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class VerCalificados : Form
    {
        public VerCalificados()
        {
            InitializeComponent();
        }

        /*BOTONES*/

        private void btnSortearCompetidores_Click(object sender, EventArgs e)
        {
            dgvCalificados.DataSource = (new Lógica.Competidor().SortearCalificados(cbSeleccionarTorneo.SelectedIndex));
        }

        private void VerCalificados_Load(object sender, EventArgs e)
        {
            // **CONFIGURAR LABEL AÑO

            //Para que el lbl que ahora dice "2023", cambie si estamos en otro año

            int añoActual = DateTime.Now.Year;
            lblAño.Text = añoActual.ToString();
        }

    }

}
