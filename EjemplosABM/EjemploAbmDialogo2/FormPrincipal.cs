using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace EjemploAbmDialogo2
{
    public partial class FormPrincipal : Form
    {
        //nuestro contenedor/manejador.
        Agencia agencia = new Agencia();

        //
        public FormPrincipal()
        {
            InitializeComponent();

            //valores precargados
            agencia.AgregarUsuario(1, "juan",10);
            agencia.AgregarUsuario(2, "juan alberto", 101);
            agencia.AgregarUsuario(3, "juan alberto mateico", 30);
            agencia.AgregarUsuario(4, "mateico juan", 33);
            agencia.AgregarUsuario(5, "mateico juan alberto", 23);
            agencia.AgregarUsuario(6, "el alberto", 13);
            agencia.AgregarUsuario(7, "albertito querido", 10);
            agencia.AgregarUsuario(8, "querido albertito", 12);
            agencia.AgregarUsuario(9, "el tato", 10);
            agencia.AgregarUsuario(10, "TATO", 11);
        }

        /** ventana de alta/edición/modificar filtrar */

        FABMPropietario Fed;
        private void btnEditarPropietarios_Click(object sender, EventArgs e)
        {
            //creación del formulario.
            Fed = new FABMPropietario();
            
            Fed.btnEdNuevoAgregar.Click += new System.EventHandler(this.FABMPropietario_button1_Click);
            Fed.btnFiltroActualizar.Click += new System.EventHandler(this.FABMPropietario_button3_Click);
            Fed.btnEdLimpiar.Click += new System.EventHandler(this.FABMPropietario_button4_Click);
            Fed.dgvPropietarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FABMPropietario_dgvPropietarios_CellMouseClick);
            Fed.btnEdEliminar.Click += new System.EventHandler(this.FABMPropietario_button5_Click);

            //inicializar ventana
            Fed.ClearRegistro();
            actualizar(Fed);

            //lanzar ventana o dialogo
            Fed.ShowDialog();

            //liberando recursos.
            Fed.btnEdEliminar.Click -= new System.EventHandler(this.FABMPropietario_button5_Click);
            Fed.dgvPropietarios.CellMouseClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FABMPropietario_dgvPropietarios_CellMouseClick);
            Fed.btnEdLimpiar.Click -= new System.EventHandler(this.FABMPropietario_button4_Click);
            Fed.btnFiltroActualizar.Click -= new System.EventHandler(this.FABMPropietario_button3_Click);
            Fed.btnEdNuevoAgregar.Click -= new System.EventHandler(this.FABMPropietario_button1_Click);
            Fed.Dispose();
        }

        ///registro nuevo y edición 
        private void FABMPropietario_button1_Click(object sender, EventArgs e)
        {
            try
            {
                //captura la info del dialogo
                string nombre = Fed.tbEdNombre.Text;
                int dni = Convert.ToInt32(Fed.tbEdDNI.Text);
                int edad = Convert.ToInt32(Fed.tbEdEdad.Text);

                //gestionar el nuevo usuario
                if (Fed.SelectedDNI == -1)
                {
                    Propietario us = agencia.AgregarUsuario(dni, nombre, edad);
                }
                else
                {
                    Propietario usr = agencia.BuscarPorDNI(Fed.SelectedDNI);
                    usr.Nombre = nombre;
                    usr.Edad = edad;
                }

                Fed.ClearRegistro();

                actualizar(Fed);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);                
            }
        }

        ///registro nuevo y edición 
        private void FABMPropietario_button3_Click(object sender, EventArgs e)
        {
            actualizar(Fed); 
        }

        private void actualizar(FABMPropietario fed)
        {
            //sección del filtro
            //datps deñ foñtrp
            Int32 dni;
            Int32.TryParse(fed.tbFiltroDNI.Text, out dni);
            string nombre = fed.tbFiltroNombre.Text;

            List<Propietario> lista = agencia.BuscarTodos(dni, nombre);
            lista.Sort(new Propietario.DNIComparer());

            fed.dgvPropietarios.Rows.Clear();
            foreach (Propietario usr in lista)
            {
                fed.dgvPropietarios.Rows.Add(
                         new string[]{ 
                                        usr.DNI.ToString(),
                                        usr.Nombre,
                                        usr.Edad.ToString(),
                                    });
            }

        }

        private void FABMPropietario_button4_Click(object sender, EventArgs e)
        {
            Fed.ClearRegistro();
        }

        private void FABMPropietario_dgvPropietarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Fed.SelectedDNI = -1;
            if (Fed.dgvPropietarios.SelectedRows.Count > 0)
            {
                //saco el dni.
                DataGridViewRow r = Fed.dgvPropietarios.SelectedRows[0];
                Fed.SelectedDNI = Convert.ToInt32(r.Cells[0].Value);

                //mostrar los datos para editar.
                Propietario usr = agencia.BuscarPorDNI(Fed.SelectedDNI);
                if (usr != null)
                {
                    Fed.tbEdNombre.Text = usr.Nombre;
                    Fed.tbEdDNI.Text = usr.DNI.ToString();
                    Fed.tbEdEdad.Text = usr.Edad.ToString();
                }
            }
        }

        private void FABMPropietario_button5_Click(object sender, EventArgs e)
        {
            if (Fed.SelectedDNI > -1)
            {
                Propietario usr = agencia.BuscarPorDNI(Fed.SelectedDNI);

                if (usr != null)
                {
                    try
                    {
                        agencia.Eliminar(usr);
                        Fed.ClearRegistro();
                        actualizar(Fed);
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

        /*fin de ventana de edición de propietarios*/

        /*otra ventana*/
    }
}
