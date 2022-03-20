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
    public partial class DatosAlquiler : Form
    {
        List<Vehiculos> vehiculo = new List<Vehiculos>();
        public DatosAlquiler()
        {
            InitializeComponent();
            llenar_Load();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.ShowDialog();
        }
        public void llenar_Load()
        {
            FileStream stream = new FileStream(@"Vehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                string placa = reader.ReadLine();
                string marca = reader.ReadLine();
                string modelo = reader.ReadLine();
                string color = reader.ReadLine();
                string precio = reader.ReadLine();

                dataGridView1.Rows.Add(placa, marca, modelo, color, precio);
            }
            reader.Close();
        }
    private void DatosAlquiler_Load(object sender, EventArgs e)
        {

        }
    }
}
