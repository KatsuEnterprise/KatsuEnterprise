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





    }
}
