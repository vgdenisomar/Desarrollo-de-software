using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermanas_nazario
{
    public partial class Registro_empleado : Form
    {
        public Registro_empleado()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtnom1.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtape1.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (rdf.Checked == false && rdm.Checked == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtid.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            Base_de_datos.registrar_empleado(txtnom1.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txtcorreo.Text, txtid.Text, sexo, txttel.Text);
            this.Close();
            menu a = new menu();
            a.Show();
        }
        string sexo;
        private void rdm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdm.Checked)
            {
                sexo = "M";
            }
        }

        private void rdf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdf.Checked)
            {
                sexo = "F";
            }
        }

        private void txtnom1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtnom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }
    }
}
