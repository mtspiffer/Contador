using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    public partial class Form1 : Form
    
    {
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = contador.ToString();
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            contador--;
            lblContador.Text = contador.ToString();
        }
    }
}
