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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbtrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbtrans.Text=="Aereo")
            {
                Aereo aereo = new Aereo();
                aereo.Show();
            }
            if(cmbtrans.Text == "Terrestre")
            {
                Terrestre terrestre = new Terrestre();
                terrestre.Show();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbtrans.Text == "Marino")
            {
                TRANSPORTES marino = new TRANSPORTES("Marino",int.Parse(txtPasa.Text),int.Parse(txtKM.Text),txtMarca.Text,txtVel.Text);
                MessageBox.Show(marino.msj());
            }
            if (cmbtrans.Text == "Aereo")
            {
                clase_aereo aereo = new clase_aereo("Aereo", int.Parse(txtPasa.Text), int.Parse(txtKM.Text), txtMarca.Text, txtVel.Text);
                MessageBox.Show(aereo.msj());
            }
            if(cmbtrans.Text == "Terrestre")
            {
                if(TRANSPORTES.carro==1)
                {
                    Clase_terrestre_automovil auto = new Clase_terrestre_automovil("Terrrestre_Automovil", int.Parse(txtPasa.Text), int.Parse(txtKM.Text), txtMarca.Text, txtVel.Text);
                    MessageBox.Show(auto.msj());
                }
                else
                {
                    clase_terrestre terrestre = new clase_terrestre("Terrrestre", int.Parse(txtPasa.Text), int.Parse(txtKM.Text), txtMarca.Text, txtVel.Text);
                    MessageBox.Show(terrestre.msj());
                }
            }
        }
    }
}
