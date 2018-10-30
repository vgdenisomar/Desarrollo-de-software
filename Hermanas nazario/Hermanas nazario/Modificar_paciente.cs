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
    public partial class ModifcacionPaciente : Form
    {
        public ModifcacionPaciente()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtnom1.Clear();
            txtnom2.Clear();
            txtape1.Clear();
            txtape2.Clear();
            rdf.Checked = false;
            rdm.Checked = false;
            txtid.Clear();
            txtlugar.Clear();
            txtmadre.Clear();
            txtpadre.Clear();

            txtnom1.Enabled = true;
            txtnom2.Enabled = true;
            txtape1.Enabled = true;
            txtape2.Enabled = true;
            groupBox1.Enabled = true;
            txtid.Enabled = true;
            txtlugar.Enabled = true;
            txtfecha.Enabled = true;
            txtmadre.Enabled = true;
            txtpadre.Enabled = true;
            txtriesgo.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
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
            if (!string.IsNullOrEmpty(txtlugar.Text) == false)
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }
            if (!string.IsNullOrEmpty(txtfecha.Text) == false)
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
            if (txtriesgo.Text != "Alto" && txtriesgo.Text != "Medio" && txtriesgo.Text != "Bajo")
            {
                MessageBox.Show("Llene todos los campos obligatorios");
                return;
            }


            txtnom1.Enabled = false;
            txtnom2.Enabled = false;
            txtape1.Enabled = false;
            txtape2.Enabled = false;
            groupBox1.Enabled = false;
            txtid.Enabled = false;
            txtlugar.Enabled = false;
            txtfecha.Enabled = false;
            txtmadre.Enabled = false;
            txtpadre.Enabled = false;
            txtriesgo.Enabled = false;
            btnModificar.Enabled = false;

            MessageBox.Show("Expediente modificado.");

            
            //Validar.solonumeros(e);
        }

        private void txtnom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }



        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
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

        private void txtmadre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtpadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void ModifcacionPaciente_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }
    }
}
