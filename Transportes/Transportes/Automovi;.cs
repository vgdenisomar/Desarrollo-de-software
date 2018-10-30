using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportes
{
    public partial class Automovi_ : Form
    {
        public Automovi_()
        {
            InitializeComponent();
        }

        private void Automovi__Load(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            if(rdpick.Checked)
            {
                Clase_terrestre_automovil.tipo = "Pick Up";
            }
            if (rdcamion.Checked)
            {
                Clase_terrestre_automovil.tipo = "Camioneta";
            }
            if (rdconver.Checked)
            {
                Clase_terrestre_automovil.tipo = "Convertible";
            }
            if (rdturismo.Checked)
            {
                Clase_terrestre_automovil.tipo = "Turismo";
            }
            this.Close();
        }
    }
}
