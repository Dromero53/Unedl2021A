using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Examen_Segundo_Parcial_Programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\juand\source\repos\Examen_Segundo_Parcial_Programacion\Archivo Txt Examen\Archivo_Texto.txt");
            string linea;
            try
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    txtTexto.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
        }
    }
}
