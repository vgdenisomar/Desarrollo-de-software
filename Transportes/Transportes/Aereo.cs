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
    public partial class Aereo : Form
    {
        public Aereo()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            clase_aereo.alas = int.Parse(txtalas.Text);
            clase_aereo.altura= int.Parse(txtaltura.Text);
            clase_aereo.elices = int.Parse(txtelices.Text);
            clase_aereo.llantas = int.Parse(txtllantas.Text);
            this.Close();

        }
    }
}
