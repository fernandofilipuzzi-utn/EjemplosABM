using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace EjemploAbmDialogo1
{
    public partial class FormPrincipal : Form
    {
        Agencia agencia = new Agencia();

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

        private void button5_Click(object sender, EventArgs e)
        {
            //creaco+pm del formulario.
            FABMPropietario Fed = new FABMPropietario();

            bool ok=true;
            bool error = false;

            while (ok == true)
            {
                //inicialización de la ventana
                //inicializar el area de edición
                if (error == false && Fed.SelectedDNI==-1)
                {
                    Fed.tbEdNombre.Text = "";
                    Fed.tbEdDNI.Text = "";
                    Fed.tbEdEdad.Text = "";
                }
                //inicializar la grilla
                actualizar(Fed);  
                //fin de inicialización.

                DialogResult dr = Fed.ShowDialog();

                if (dr == DialogResult.OK) //agregar el registro
                {
                    try
                    {
                        //captura la info del dialogo
                        string nombre = Fed.tbEdNombre.Text;
                        int dni = Convert.ToInt32(Fed.tbEdDNI.Text);
                        int edad = Convert.ToInt32(Fed.tbEdEdad.Text);

                        //gestiona el nuevo usuario
                        if (Fed.SelectedDNI == -1)
                        {
                            Propietario us = agencia.AgregarUsuario(dni, nombre, edad);
                        }
                        else
                        {
                            Propietario usr = agencia.BuscarPorID(Fed.SelectedDNI);
                            usr.Nombre = nombre;
                            usr.Edad = edad;
                        }
                        error = false;
                        Fed.SelectedDNI = -1;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error",
                                           MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                        error = true;
                    }
                }
                else if (dr == DialogResult.Yes) //agregar el registro
                {
                    Propietario usr = agencia.BuscarPorID(Fed.SelectedDNI);

                    if (usr != null)
                    {
                        Fed.tbEdNombre.Text = usr.Nombre;
                        Fed.tbEdDNI.Text = usr.DNI.ToString();
                        Fed.tbEdEdad.Text = usr.Edad.ToString();
                    }
                }

                ok = (dr == DialogResult.OK || dr == DialogResult.Retry || dr == DialogResult.Yes);
            }
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



            /*

            //List<Usuario> lista = agencia.BuscarTodosAlternativa(dni, nombre);
            List<Usuario> lista = agencia.BuscarTodos(dni, nombre);
            lista.Sort(comparer);

            dataGridView2.Rows.Clear();
            foreach (Usuario usr in lista)
            {
                dataGridView2.Rows.Add(
                        new string[]{ usr.DNI.ToString(),usr.Nombre,
                                      usr.Edad.ToString(),
                                    });
            }



            fed.dgvPropietarios.Rows.Clear();
            foreach (Usuario usr in agencia.BuscarTodos())
            {
                fed.dgvPropietarios.Rows.Add(
                        new string[]{
                                        usr.DNI.ToString(),
                                        usr.Nombre,
                                        usr.Edad.ToString(),
                                    });
            }
             * */
        }
    }
}
