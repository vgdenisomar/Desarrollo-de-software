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
    public partial class Busqueda_de_pacientes : Form
    {
        public Busqueda_de_pacientes()
        {
            InitializeComponent();
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtnom.Text) && (!string.IsNullOrEmpty(txtape.Text)))

                btnbuscar.Enabled = true;

            else

                btnbuscar.Enabled = false;
        }

        private void txtape_TextChanged(object sender, EventArgs e)
        {
           
            if ((!string.IsNullOrEmpty(txtnom.Text))&& (!string.IsNullOrEmpty(txtape.Text)))

                btnbuscar.Enabled = true;

            else

                btnbuscar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu a = new menu();
            a.Show();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void Busqueda_de_pacientes_Load(object sender, EventArgs e)
        {

        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }
        
}
