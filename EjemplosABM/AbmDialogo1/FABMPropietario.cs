﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbmDialogo1
{
    public partial class FABMPropietario : Form
    {
        public int SelectedDNI=-1;

        public FABMPropietario()
        {
            InitializeComponent();
        }

        private void btnEdLimpiar_Click(object sender, EventArgs e)
        {
            tbEdDNI.Clear();
            tbEdNombre.Clear();
            tbEdEdad.Clear();
            SelectedDNI = -1;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
