using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploAbmDialogo1
{
    public partial class FABMPropietario : Form
    {
        public int SelectedDNI=-1;


        public FABMPropietario()
        {
            InitializeComponent();
        }

        private void dgvPropietarios_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvPropietarios_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbEdDNI.Text = "";
            tbEdNombre.Text = "";
            tbEdEdad.Text = "";
            SelectedDNI = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPropietarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            SelectedDNI = -1;
            if (row != -1)
            {
                DataGridViewRow r = dgvPropietarios.SelectedRows[0];
                SelectedDNI = Convert.ToInt32(r.Cells[0].Value);

                DialogResult = DialogResult.Yes;
            }
        }
    }
}
