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
    public partial class Registro_pacientes : Form
    {

        public Registro_pacientes()
        {

            InitializeComponent();

        }
 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        string sexo;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(rdm.Checked)
            {
                sexo = "M";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void txtape1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);

        }

        private void txtape2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.solonumeros(e);
        }

        private void txtmadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtpadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
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

            Base_de_datos.Registro(txtnom1.Text, txtnom2.Text, txtape1.Text, txtape2.Text, txtlugar.Text, txtfecha.Value.ToString("MM/dd/yyyy"), txtpadre.Text, txtmadre.Text, txtid.Text, sexo, riesgo);

            Base_de_datos.expediente(txtid.Text);
            this.Close();
            menu a = new menu();
            a.Show();



        }

        int riesgo=0;
        private void txtriesgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtriesgo.Text=="Alto")
            {
                riesgo = 1;
            }
            if (txtriesgo.Text == "Medio")
            {
                riesgo = 2;
            }
            if (txtriesgo.Text == "Bajo")
            {
                riesgo = 3;
            }


        }

        private void txtnom1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdf_CheckedChanged(object sender, EventArgs e)
        {
            if (rdf.Checked)
            {
                sexo = "F";
            }
        }
    }
}
