namespace BibliotecaMetodos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnCrearDataTable = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfigurarDataAdapter = new System.Windows.Forms.Button();
            this.btnCargarGrilla = new System.Windows.Forms.Button();
            this.btnCheckRowState = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnDeshacerCambios = new System.Windows.Forms.Button();
            this.btnGuardarXml = new System.Windows.Forms.Button();
            this.btnCargarXml = new System.Windows.Forms.Button();
            this.ofdCargarXml = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(437, 12);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(351, 297);
            this.dgvGrilla.TabIndex = 0;
            // 
            // btnCrearDataTable
            // 
            this.btnCrearDataTable.Location = new System.Drawing.Point(11, 13);
            this.btnCrearDataTable.Name = "btnCrearDataTable";
            this.btnCrearDataTable.Size = new System.Drawing.Size(127, 25);
            this.btnCrearDataTable.TabIndex = 1;
            this.btnCrearDataTable.Text = "Crear DataTable";
            this.btnCrearDataTable.UseVisualStyleBackColor = true;
            this.btnCrearDataTable.Click += new System.EventHandler(this.btnCrearDataTable_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Configurar Grilla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnConfigurarGrilla_Click);
            // 
            // btnConfigurarDataAdapter
            // 
            this.btnConfigurarDataAdapter.Location = new System.Drawing.Point(304, 13);
            this.btnConfigurarDataAdapter.Name = "btnConfigurarDataAdapter";
            this.btnConfigurarDataAdapter.Size = new System.Drawing.Size(127, 25);
            this.btnConfigurarDataAdapter.TabIndex = 3;
            this.btnConfigurarDataAdapter.Text = "Configurar DA";
            this.btnConfigurarDataAdapter.UseVisualStyleBackColor = true;
            this.btnConfigurarDataAdapter.Click += new System.EventHandler(this.btnConfigurarDataAdapter_Click);
            // 
            // btnCargarGrilla
            // 
            this.btnCargarGrilla.Location = new System.Drawing.Point(11, 68);
            this.btnCargarGrilla.Name = "btnCargarGrilla";
            this.btnCargarGrilla.Size = new System.Drawing.Size(127, 25);
            this.btnCargarGrilla.TabIndex = 6;
            this.btnCargarGrilla.Text = "Cargar Grilla";
            this.btnCargarGrilla.UseVisualStyleBackColor = true;
            this.btnCargarGrilla.Click += new System.EventHandler(this.btnCargarGrilla_Click);
            // 
            // btnCheckRowState
            // 
            this.btnCheckRowState.Location = new System.Drawing.Point(157, 68);
            this.btnCheckRowState.Name = "btnCheckRowState";
            this.btnCheckRowState.Size = new System.Drawing.Size(127, 25);
            this.btnCheckRowState.TabIndex = 5;
            this.btnCheckRowState.Text = "Check RowState";
            this.btnCheckRowState.UseVisualStyleBackColor = true;
            this.btnCheckRowState.Click += new System.EventHandler(this.btnCheckRowState_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(304, 68);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(127, 25);
            this.btnGuardarCambios.TabIndex = 4;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(11, 177);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 25);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Yellow;
            this.btnModificar.Location = new System.Drawing.Point(157, 177);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(127, 25);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Location = new System.Drawing.Point(304, 177);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(127, 25);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnDeshacerCambios
            // 
            this.btnDeshacerCambios.Location = new System.Drawing.Point(11, 123);
            this.btnDeshacerCambios.Name = "btnDeshacerCambios";
            this.btnDeshacerCambios.Size = new System.Drawing.Size(127, 23);
            this.btnDeshacerCambios.TabIndex = 10;
            this.btnDeshacerCambios.Text = "Deshacer Cambios";
            this.btnDeshacerCambios.UseVisualStyleBackColor = true;
            this.btnDeshacerCambios.Click += new System.EventHandler(this.btnDeshacerCambios_Click);
            // 
            // btnGuardarXml
            // 
            this.btnGuardarXml.Location = new System.Drawing.Point(157, 123);
            this.btnGuardarXml.Name = "btnGuardarXml";
            this.btnGuardarXml.Size = new System.Drawing.Size(127, 23);
            this.btnGuardarXml.TabIndex = 11;
            this.btnGuardarXml.Text = "Guardar Xml";
            this.btnGuardarXml.UseVisualStyleBackColor = true;
            this.btnGuardarXml.Click += new System.EventHandler(this.btnGuardarXml_Click);
            // 
            // btnCargarXml
            // 
            this.btnCargarXml.Location = new System.Drawing.Point(304, 123);
            this.btnCargarXml.Name = "btnCargarXml";
            this.btnCargarXml.Size = new System.Drawing.Size(127, 23);
            this.btnCargarXml.TabIndex = 12;
            this.btnCargarXml.Text = "Cargar Xml";
            this.btnCargarXml.UseVisualStyleBackColor = true;
            this.btnCargarXml.Click += new System.EventHandler(this.btnCargarXml_Click);
            // 
            // ofdCargarXml
            // 
            this.ofdCargarXml.DefaultExt = "xml";
            this.ofdCargarXml.FileName = "Seleccionar Archivo";
            this.ofdCargarXml.Filter = "Xml|*.xml";
            this.ofdCargarXml.InitialDirectory = "C:\\archivos";
            this.ofdCargarXml.Title = "Seleccionar archivo xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.btnCargarXml);
            this.Controls.Add(this.btnGuardarXml);
            this.Controls.Add(this.btnDeshacerCambios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargarGrilla);
            this.Controls.Add(this.btnCheckRowState);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnConfigurarDataAdapter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCrearDataTable);
            this.Controls.Add(this.dgvGrilla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnCrearDataTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnConfigurarDataAdapter;
        private System.Windows.Forms.Button btnCargarGrilla;
        private System.Windows.Forms.Button btnCheckRowState;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnDeshacerCambios;
        private System.Windows.Forms.Button btnGuardarXml;
        private System.Windows.Forms.Button btnCargarXml;
        private System.Windows.Forms.OpenFileDialog ofdCargarXml;
    }
}

