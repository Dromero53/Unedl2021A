using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormaCaptura : Form
    {
        string[,] personas = new string[,]
        { { "Angel","Duran" },
          { "Christopher","Villalobos" },
          { "Daniel","Lopez" },
          { "Daniel","Vazquez" },
          { "Edgar","Banuelos" },
          { "Fernando","Hernandez" },
          { "Francisco","Garcia" },
          { "Ivan","Narvaez" },
          { "Joel","Juarez" },
          { "Juan","Romero" },
          { "Kevin","Gonzalez" },
          { "Luis","Gomez" },
          { "Manuel","Mariscal" },
          { "Mario","Mercado" },
          { "Marisol","Benitez" },
          { "Mauricio","Castaneda" },
          { "Oscar","Ochoa" },
          { "Yahayra","Rodriguez" },
          { "Cesar", "De la Cruz" }
        };

        public FormaCaptura()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (personas.Equals(txtBuscaNombre)&&personas.Equals(txtBuscaApellido))
            {
                MessageBox.Show("El nombre existe");
            } 
            else
            {
                MessageBox.Show("ERROR");
            }
            

          
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscaNombre.Text = "";
            txtBuscaApellido.Text = "";
        }

        private void txtBuscaNombre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
