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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void registrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_pacientes a = new Registro_pacientes();
            a.Show();
        }

        private void burcarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Busqueda_de_pacientes a = new Busqueda_de_pacientes();
            a.Show();
        }

        private void modificarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifcacionPaciente a = new ModifcacionPaciente();
            a.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_usuario a = new Registro_de_usuario();
            a.Show();
        }

        private void registarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_empleado a = new Registro_empleado();
            a.Show();
        }
    }
}
