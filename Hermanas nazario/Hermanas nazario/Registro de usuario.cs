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
    public partial class Registro_de_usuario : Form
    {
        public Registro_de_usuario()
        {
            InitializeComponent();
        }

        private void txtemp_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtusu.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtcontra.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtemp.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }

            Base_de_datos.registrar_usuario(txtusu.Text, txtcontra.Text, int.Parse(txtemp.Text));
            this.Close();
            menu a = new menu();
            a.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            menu a = new menu();
            a.Show();
        }

        private void txtemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }
    }
}
