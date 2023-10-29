using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbmDialogo2
{
    public partial class FABMPropietario : Form
    {
        public int SelectedDNI=-1;

        public FABMPropietario()
        {
            InitializeComponent();
        }
       
        public void ClearRegistro()
        {
            tbEdDNI.Text = "";
            tbEdNombre.Text = "";
            tbEdEdad.Text = "";
            SelectedDNI = -1;
        }

        private void btnFiltroLimpiar_Click(object sender, EventArgs e)
        {
            tbFiltroDNI.Text = "";
            tbFiltroNombre.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
