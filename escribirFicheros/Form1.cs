
using System;
using System.IO;
using System.Windows.Forms;
namespace escribirFicheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.CreateText("tecleado.txt").Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;

            if (string.IsNullOrEmpty(texto))
            {
                return;
            }

            if (texto.Equals("off", StringComparison.OrdinalIgnoreCase))
            {
                Close();
                return;
            }

            using (StreamWriter writer = new StreamWriter("tecleado.txt", true))
            {
                writer.WriteLine(texto);
            }

            textBox1.Clear();
        }


    }
}