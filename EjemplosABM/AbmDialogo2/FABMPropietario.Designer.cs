namespace AbmDialogo2
{
    partial class FABMPropietario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltroLimpiar = new System.Windows.Forms.Button();
            this.tbFiltroDNI = new System.Windows.Forms.TextBox();
            this.tbFiltroNombre = new System.Windows.Forms.TextBox();
            this.btnFiltroActualizar = new System.Windows.Forms.Button();
            this.dgvPropietarios = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEdEdad = new System.Windows.Forms.TextBox();
            this.tbEdDNI = new System.Windows.Forms.TextBox();
            this.tbEdNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdNuevoAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdEliminar = new System.Windows.Forms.Button();
            this.btnEdLimpiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltroLimpiar);
            this.groupBox2.Controls.Add(this.tbFiltroDNI);
            this.groupBox2.Controls.Add(this.tbFiltroNombre);
            this.groupBox2.Controls.Add(this.btnFiltroActualizar);
            this.groupBox2.Controls.Add(this.dgvPropietarios);
            this.groupBox2.Location = new System.Drawing.Point(314, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Búsqueda/Selección";
            // 
            // btnFiltroLimpiar
            // 
            this.btnFiltroLimpiar.Location = new System.Drawing.Point(250, 16);
            this.btnFiltroLimpiar.Name = "btnFiltroLimpiar";
            this.btnFiltroLimpiar.Size = new System.Drawing.Size(57, 23);
            this.btnFiltroLimpiar.TabIndex = 18;
            this.btnFiltroLimpiar.Text = "Limpiar";
            this.btnFiltroLimpiar.UseVisualStyleBackColor = true;
            this.btnFiltroLimpiar.Click += new System.EventHandler(this.btnFiltroLimpiar_Click);
            // 
            // tbFiltroDNI
            // 
            this.tbFiltroDNI.Location = new System.Drawing.Point(6, 19);
            this.tbFiltroDNI.Name = "tbFiltroDNI";
            this.tbFiltroDNI.Size = new System.Drawing.Size(100, 20);
            this.tbFiltroDNI.TabIndex = 3;
            // 
            // tbFiltroNombre
            // 
            this.tbFiltroNombre.Location = new System.Drawing.Point(112, 19);
            this.tbFiltroNombre.Name = "tbFiltroNombre";
            this.tbFiltroNombre.Size = new System.Drawing.Size(117, 20);
            this.tbFiltroNombre.TabIndex = 4;
            this.tbFiltroNombre.Text = "(?i)tato";
            // 
            // btnFiltroActualizar
            // 
            this.btnFiltroActualizar.Location = new System.Drawing.Point(313, 16);
            this.btnFiltroActualizar.Name = "btnFiltroActualizar";
            this.btnFiltroActualizar.Size = new System.Drawing.Size(64, 23);
            this.btnFiltroActualizar.TabIndex = 5;
            this.btnFiltroActualizar.Text = "Filtrar";
            this.btnFiltroActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvPropietarios
            // 
            this.dgvPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropietarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.Nombre,
            this.dataGridViewTextBoxColumn3});
            this.dgvPropietarios.Location = new System.Drawing.Point(7, 45);
            this.dgvPropietarios.Name = "dgvPropietarios";
            this.dgvPropietarios.RowHeadersVisible = false;
            this.dgvPropietarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropietarios.Size = new System.Drawing.Size(376, 135);
            this.dgvPropietarios.TabIndex = 0;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Edad";
            // 
            // tbEdEdad
            // 
            this.tbEdEdad.Location = new System.Drawing.Point(114, 84);
            this.tbEdEdad.Name = "tbEdEdad";
            this.tbEdEdad.Size = new System.Drawing.Size(100, 20);
            this.tbEdEdad.TabIndex = 14;
            // 
            // tbEdDNI
            // 
            this.tbEdDNI.Location = new System.Drawing.Point(114, 58);
            this.tbEdDNI.Name = "tbEdDNI";
            this.tbEdDNI.Size = new System.Drawing.Size(100, 20);
            this.tbEdDNI.TabIndex = 13;
            // 
            // tbEdNombre
            // 
            this.tbEdNombre.Location = new System.Drawing.Point(114, 32);
            this.tbEdNombre.Name = "tbEdNombre";
            this.tbEdNombre.Size = new System.Drawing.Size(100, 20);
            this.tbEdNombre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // btnEdNuevoAgregar
            // 
            this.btnEdNuevoAgregar.Location = new System.Drawing.Point(181, 159);
            this.btnEdNuevoAgregar.Name = "btnEdNuevoAgregar";
            this.btnEdNuevoAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnEdNuevoAgregar.TabIndex = 9;
            this.btnEdNuevoAgregar.Text = "Aceptar";
            this.btnEdNuevoAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdEliminar);
            this.groupBox1.Controls.Add(this.btnEdLimpiar);
            this.groupBox1.Controls.Add(this.tbEdNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEdNuevoAgregar);
            this.groupBox1.Controls.Add(this.tbEdEdad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbEdDNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta/Eliminar/Edicion";
            // 
            // btnEdEliminar
            // 
            this.btnEdEliminar.Location = new System.Drawing.Point(100, 159);
            this.btnEdEliminar.Name = "btnEdEliminar";
            this.btnEdEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEdEliminar.TabIndex = 17;
            this.btnEdEliminar.Text = "Eliminar";
            this.btnEdEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEdLimpiar
            // 
            this.btnEdLimpiar.Location = new System.Drawing.Point(6, 159);
            this.btnEdLimpiar.Name = "btnEdLimpiar";
            this.btnEdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnEdLimpiar.TabIndex = 16;
            this.btnEdLimpiar.Text = "Limpiar";
            this.btnEdLimpiar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(592, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FABMPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FABMPropietario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta/Modificar/Eliminar seleccion Propietario";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbEdEdad;
        public System.Windows.Forms.TextBox tbEdDNI;
        public System.Windows.Forms.TextBox tbEdNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgvPropietarios;
        public System.Windows.Forms.TextBox tbFiltroDNI;
        public System.Windows.Forms.TextBox tbFiltroNombre;
        public System.Windows.Forms.Button btnEdNuevoAgregar;
        public System.Windows.Forms.Button btnFiltroActualizar;
        public System.Windows.Forms.Button btnEdLimpiar;
        public System.Windows.Forms.Button btnEdEliminar;
        public System.Windows.Forms.Button btnFiltroLimpiar;
    }
}