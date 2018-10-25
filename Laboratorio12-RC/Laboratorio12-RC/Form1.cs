using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modeloo;

namespace Laboratorio12_RC
{
    public delegate void AgregarComidaDelegate(string nombre, int carbohidratos, int proteinas, int grasas);
    public delegate void EliminarComidaDelegate(Comida comida);
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate 
        public Form1()
        {
            InitializeComponent();
        }

        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                OnAgregarComida.Invoke(NombreBox.Text, Int32.Parse(ProteinasBox.Text), Int32.Parse(GrasasBox.Text), Int32.Parse(CarbohidratosBox.Text));
            }
        }

        public void AgregarComida(Comida comida)
        {
            if (Comida1.Items.Count == 0)
                Comida1.Items.Add(comida);
            else if (Comida2.Items.Count == 0)
                Comida2.Items.Add(comida);
            else if (Comida3.Items.Count == 0)
                Comida3.Items.Add(comida);
            else
                MessageBox.Show("Los cocineros de este Restaurante son masomenos, cocinan maximo 3 tipos de platos. Salu3");
        }

        private void Comida1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void eliminarComida(Comida comida)
        {
            //no alcance
        }
    }
}
