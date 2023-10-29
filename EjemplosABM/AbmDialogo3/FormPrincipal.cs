using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using AbmDialogo3.Models;

namespace AbmDialogo3
{
    public partial class FormPrincipal : Form
    {
        //nuestro contenedor/manejador.
        Agencia agencia = new Agencia();

        //
        public FormPrincipal()
        {
            InitializeComponent();

            #region valores precargados
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
            #endregion
        }

        /** ventana de alta/edición/modificar filtrar */
                
        private void btnEditarPropietarios_Click(object sender, EventArgs e)
        {
            FABMPropietario Fed;

            //creación del formulario.
            Fed = new FABMPropietario();
            Fed.agencia = this.agencia;

            //inicializar ventana
            Fed.Init();

            //lanzar ventana o dialogo
            Fed.ShowDialog();

            Fed.Dispose();
        }

        /*fin de ventana de edición de propietarios*/
    }
}
