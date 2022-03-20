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
    public partial class Alquiler : Form
    {
        public Alquiler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TextWriter writer = new StreamWriter(@"Alquileres.txt", true);
            writer.WriteLine(textBox1.Text);
            writer.WriteLine(textBox2.Text);
            writer.WriteLine(textBox3.Text);
            writer.WriteLine(dateTimePicker1.Text);
            writer.WriteLine(dateTimePicker2.Text);
            writer.Close();
            limpiarcajas();
            limpiarcajas();
        }
        public void limpiarcajas()
        {

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
           


        }
    }
}
