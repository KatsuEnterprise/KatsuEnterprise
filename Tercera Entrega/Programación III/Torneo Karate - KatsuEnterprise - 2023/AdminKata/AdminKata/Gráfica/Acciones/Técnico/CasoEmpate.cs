using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdministradorKata.Gráfica.Acciones.Técnico
{
    public partial class CasoEmpate : Form
    {
        public CasoEmpate()
        {
            InitializeComponent();
        }

        /*BOTONES*/
        private void btnRealizarSorteo_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int color = random.Next(2);

            if (color == 1)
            {
                PanelColor.BackColor = Color.Red;
            }
            else PanelColor.BackColor = Color.Blue;
        }

        private void CasoEmpate_Load(object sender, EventArgs e)
        {
            // **CONFIGURAR LABEL AÑO

            //Para que el lbl que ahora dice "2023", cambie si estamos en otro año

            int añoActual = DateTime.Now.Year;
            lblAño.Text = añoActual.ToString();
        }
    }
}
