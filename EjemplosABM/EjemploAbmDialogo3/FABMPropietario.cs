using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploAbmDialogo3
{
    public partial class FABMPropietario : Form
    {
        public int SelectedDNI=-1;

        //nuestro contenedor/manejador.
        public Agencia agencia;

        public FABMPropietario()
        {
            InitializeComponent();
        }

        private void dgvPropietarios_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        public void Init()
        {
            actualizar();
        }
       
        public void ClearRegistro()
        {
            tbEdDNI.Text = "";
            tbEdNombre.Text = "";
            tbEdEdad.Text = "";
            SelectedDNI = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEdNuevoEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //captura la info del dialogo
                string nombre = tbEdNombre.Text;
                int dni = Convert.ToInt32(tbEdDNI.Text);
                int edad = Convert.ToInt32(tbEdEdad.Text);

                //gestionar el nuevo usuario
                if (SelectedDNI == -1)
                {
                    Propietario us = agencia.AgregarUsuario(dni, nombre, edad);
                }
                else
                {
                    Propietario usr = agencia.BuscarPorDNI(SelectedDNI);
                    usr.Nombre = nombre;
                    usr.Edad = edad;
                }

                ClearRegistro();

                actualizar();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }

        private void actualizar()
        {
            //sección del filtro
            Int32 dni;
            Int32.TryParse(tbFiltroDNI.Text, out dni);
            string nombre = tbFiltroNombre.Text;

            List<Propietario> lista = agencia.BuscarTodos(dni, nombre);
            lista.Sort(new Propietario.DNIComparer());

            dgvPropietarios.Rows.Clear();
            foreach (Propietario usr in lista)
            {
                dgvPropietarios.Rows.Add(
                         new string[]{ 
                                        usr.DNI.ToString(),
                                        usr.Nombre,
                                        usr.Edad.ToString(),
                                    });
            }
        }

       

        private void btnFilterActualizar_Click(object sender, EventArgs e)
        {
            actualizar(); 
        }

        private void btnEdEliminar_Click(object sender, EventArgs e)
        {
            if (SelectedDNI > -1)
            {
                Propietario usr = agencia.BuscarPorDNI(SelectedDNI);

                if (usr != null)
                {
                    try
                    {
                        agencia.Eliminar(usr);
                        this.ClearRegistro();
                        actualizar();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdClear_Click(object sender, EventArgs e)
        {
            ClearRegistro();
        }

        private void dgvPropietarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPropietarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            SelectedDNI = -1;
            if (row != -1)
            {
                //saco el dni.
                DataGridViewRow r = dgvPropietarios.SelectedRows[0];
                SelectedDNI = Convert.ToInt32(r.Cells[0].Value);

                //mostrar los datos para editar.
                Propietario usr = agencia.BuscarPorDNI(SelectedDNI);
                if (usr != null)
                {
                    tbEdNombre.Text = usr.Nombre;
                    tbEdDNI.Text = usr.DNI.ToString();
                    tbEdEdad.Text = usr.Edad.ToString();
                }
            }
        }

        private void btnFilterLimpiar_Click(object sender, EventArgs e)
        {
            tbFiltroDNI.Text = "";
            tbFiltroNombre.Text = "";
        }
    }
}
