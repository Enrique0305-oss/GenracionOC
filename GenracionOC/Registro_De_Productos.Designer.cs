namespace GenracionOC
{
    partial class Registro_De_Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelTipoProducto;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelCodigoGenerado;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Label labelObservacion;
        private System.Windows.Forms.ComboBox comboBoxTipoProducto;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxCodigoGenerado;
        private System.Windows.Forms.TextBox textBoxUnidad;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.Button buttonRegistro;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxProducto = new GroupBox();
            labelTitulo = new Label();
            labelTipoProducto = new Label();
            labelDescripcion = new Label();
            labelCodigoGenerado = new Label();
            labelUnidad = new Label();
            labelObservacion = new Label();
            comboBoxTipoProducto = new ComboBox();
            textBoxDescripcion = new TextBox();
            textBoxCodigoGenerado = new TextBox();
            textBoxUnidad = new TextBox();
            textBoxObservacion = new TextBox();
            buttonRegistro = new Button();
            SuspendLayout();
            // 
            // groupBoxProducto
            // 
            groupBoxProducto.BackColor = Color.Transparent;
            groupBoxProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProducto.ForeColor = Color.DodgerBlue;
            groupBoxProducto.Location = new Point(12, 75);
            groupBoxProducto.Name = "groupBoxProducto";
            groupBoxProducto.Size = new Size(200, 27);
            groupBoxProducto.TabIndex = 0;
            groupBoxProducto.TabStop = false;
            groupBoxProducto.Text = "Datos del Producto";
            groupBoxProducto.Enter += groupBoxProducto_Enter;
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(66, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(455, 45);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "REGISTRO DE PRODUCTOS";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTipoProducto
            // 
            labelTipoProducto.Location = new Point(31, 115);
            labelTipoProducto.Name = "labelTipoProducto";
            labelTipoProducto.Size = new Size(150, 23);
            labelTipoProducto.TabIndex = 2;
            labelTipoProducto.Text = "TIPO DE PRODUCTO";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Location = new Point(31, 155);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(150, 23);
            labelDescripcion.TabIndex = 4;
            labelDescripcion.Text = "DESCRIPCIÓN";
            // 
            // labelCodigoGenerado
            // 
            labelCodigoGenerado.Location = new Point(31, 195);
            labelCodigoGenerado.Name = "labelCodigoGenerado";
            labelCodigoGenerado.Size = new Size(150, 23);
            labelCodigoGenerado.TabIndex = 6;
            labelCodigoGenerado.Text = "CÓDIGO GENERADO";
            // 
            // labelUnidad
            // 
            labelUnidad.Location = new Point(31, 235);
            labelUnidad.Name = "labelUnidad";
            labelUnidad.Size = new Size(150, 23);
            labelUnidad.TabIndex = 8;
            labelUnidad.Text = "UNIDAD";
            // 
            // labelObservacion
            // 
            labelObservacion.Location = new Point(31, 275);
            labelObservacion.Name = "labelObservacion";
            labelObservacion.Size = new Size(150, 23);
            labelObservacion.TabIndex = 10;
            labelObservacion.Text = "OBSERVACIÓN";
            // 
            // comboBoxTipoProducto
            // 
            comboBoxTipoProducto.Location = new Point(221, 115);
            comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            comboBoxTipoProducto.Size = new Size(300, 23);
            comboBoxTipoProducto.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(221, 155);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(300, 23);
            textBoxDescripcion.TabIndex = 5;
            // 
            // textBoxCodigoGenerado
            // 
            textBoxCodigoGenerado.Location = new Point(221, 195);
            textBoxCodigoGenerado.Name = "textBoxCodigoGenerado";
            textBoxCodigoGenerado.Size = new Size(300, 23);
            textBoxCodigoGenerado.TabIndex = 7;
            // 
            // textBoxUnidad
            // 
            textBoxUnidad.Location = new Point(221, 235);
            textBoxUnidad.Name = "textBoxUnidad";
            textBoxUnidad.Size = new Size(300, 23);
            textBoxUnidad.TabIndex = 9;
            // 
            // textBoxObservacion
            // 
            textBoxObservacion.Location = new Point(221, 275);
            textBoxObservacion.Name = "textBoxObservacion";
            textBoxObservacion.Size = new Size(300, 23);
            textBoxObservacion.TabIndex = 11;
            // 
            // buttonRegistro
            // 
            buttonRegistro.BackColor = Color.MediumSeaGreen;
            buttonRegistro.FlatStyle = FlatStyle.Flat;
            buttonRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonRegistro.ForeColor = Color.White;
            buttonRegistro.Location = new Point(294, 325);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Size = new Size(150, 40);
            buttonRegistro.TabIndex = 12;
            buttonRegistro.Text = "REGISTRO";
            buttonRegistro.UseVisualStyleBackColor = false;
            // 
            // Registro_De_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 255);
            ClientSize = new Size(577, 400);
            Controls.Add(groupBoxProducto);
            Controls.Add(labelTitulo);
            Controls.Add(labelTipoProducto);
            Controls.Add(comboBoxTipoProducto);
            Controls.Add(labelDescripcion);
            Controls.Add(textBoxDescripcion);
            Controls.Add(labelCodigoGenerado);
            Controls.Add(textBoxCodigoGenerado);
            Controls.Add(labelUnidad);
            Controls.Add(textBoxUnidad);
            Controls.Add(labelObservacion);
            Controls.Add(textBoxObservacion);
            Controls.Add(buttonRegistro);
            Name = "Registro_De_Productos";
            Text = "Registro de Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}