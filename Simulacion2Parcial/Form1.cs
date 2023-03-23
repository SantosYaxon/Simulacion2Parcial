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
using System.IO;

namespace Simulacion2Parcial
{
    public partial class Form1 : Form
    {
        List<Departamentos> listaDep = new List<Departamentos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MOSTRAR Lista de Departamentos
            LeerDepartamentos("..\\..\\ListadoDepartamentos.txt");
            //mostrar datos
            dataGridDepartamentos.DataSource = null;
            dataGridDepartamentos.DataSource = listaDep;
            dataGridDepartamentos.Refresh();
        }
        
        private void LeerDepartamentos(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Departamentos dep = new Departamentos();
                dep.Numero = Convert.ToInt32(reader.ReadLine());
                dep.Nombre = reader.ReadLine();

                listaDep.Add(dep);
            }
            reader.Close();

            comboDepartamentos.DisplayMember = "nombre";
            comboDepartamentos.DataSource = listaDep;
        }

        private void Guardar(string fileName, string texto1, string texto2, string texto3)
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(texto1);
            writer.WriteLine(texto2);
            writer.WriteLine(texto3);
            writer.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = "..\\..\\TemperaturaDiaria.txt";
            //Guarda Datos
            Guardar(ruta,comboDepartamentos.Text, txtTemperatura.Text + "º", dateTimePicker1.Text.ToString());          
        }
    }
}
