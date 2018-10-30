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
    public partial class Terrestre : Form
    {
        public Terrestre()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdsi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbAuto.Text=="SI")
            {
                Automovi_ auto = new Automovi_();
                auto.Show();
            }
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            clase_terrestre.llantas = int.Parse(txtllantas.Text);
            clase_terrestre.placas = txtpuertas.Text;
            if(rdauto.Checked)
            {
                clase_terrestre.transmision = "Automatico";
            }
            if(rdmanual.Checked)
            {
                clase_terrestre.transmision = "Manual";
            }
            this.Close();
        }
    }
}
