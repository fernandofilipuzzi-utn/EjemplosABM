﻿namespace AbmDialogo2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEditarPropietarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditarPropietarios
            // 
            this.btnEditarPropietarios.Location = new System.Drawing.Point(57, 26);
            this.btnEditarPropietarios.Name = "btnEditarPropietarios";
            this.btnEditarPropietarios.Size = new System.Drawing.Size(257, 23);
            this.btnEditarPropietarios.TabIndex = 8;
            this.btnEditarPropietarios.Text = "Editar Propietarios";
            this.btnEditarPropietarios.UseVisualStyleBackColor = true;
            this.btnEditarPropietarios.Click += new System.EventHandler(this.btnEditarPropietarios_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 71);
            this.Controls.Add(this.btnEditarPropietarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo dialogo de alta-baja-modificación";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditarPropietarios;
    }
}

