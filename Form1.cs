using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"Vehiculos.txt", true);
            writer.WriteLine(textBox1.Text);
            writer.WriteLine(textBox2.Text);
            writer.WriteLine(textBox3.Text);
            writer.WriteLine(textBox4.Text);
            writer.WriteLine(textBox5.Text);
            writer.Close();
            limpiarcajas();
        }
        public void limpiarcajas()
        {

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
               

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alquiler formClientes = new Alquiler();
            formClientes.Closed += (s, args) => this.Close();
            formClientes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosAlquiler formClientes = new DatosAlquiler();
            formClientes.Closed += (s, args) => this.Close();
            formClientes.ShowDialog();
        }
    }
}
