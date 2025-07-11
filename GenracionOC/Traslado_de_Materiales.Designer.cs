namespace GenracionOC
{
    partial class Traslado_de_Materiales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblTitulo = new Label();
            lblProyecto = new Label();
            cmbProyecto = new ComboBox();
            lblNTraslado = new Label();
            txtNTraslado = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblArea = new Label();
            cmbArea = new ComboBox();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblUnidad = new Label();
            txtUnidad = new TextBox();
            txtObservaciones = new TextBox();
            btnInsertar = new Button();
            btnBorrar = new Button();
            btnGuardarPDF = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(52, 73, 94);
            lblTitulo.Location = new Point(123, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(607, 45);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Responsable";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProyecto
            // 
            lblProyecto.Font = new Font("Segoe UI", 10F);
            lblProyecto.Location = new Point(40, 90);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(120, 25);
            lblProyecto.TabIndex = 1;
            lblProyecto.Text = "Proyecto";
            // 
            // cmbProyecto
            // 
            cmbProyecto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProyecto.Font = new Font("Segoe UI", 10F);
            cmbProyecto.Location = new Point(180, 88);
            cmbProyecto.Name = "cmbProyecto";
            cmbProyecto.Size = new Size(250, 31);
            cmbProyecto.TabIndex = 2;
            // 
            // lblNTraslado
            // 
            lblNTraslado.Font = new Font("Segoe UI", 10F);
            lblNTraslado.Location = new Point(496, 90);
            lblNTraslado.Name = "lblNTraslado";
            lblNTraslado.Size = new Size(100, 25);
            lblNTraslado.TabIndex = 3;
            lblNTraslado.Text = "N Traslado";
            // 
            // txtNTraslado
            // 
            txtNTraslado.Font = new Font("Segoe UI", 10F);
            txtNTraslado.Location = new Point(602, 90);
            txtNTraslado.Name = "txtNTraslado";
            txtNTraslado.Size = new Size(250, 30);
            txtNTraslado.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(40, 135);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(130, 25);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha de Registro";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Location = new Point(180, 133);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 30);
            dtpFecha.TabIndex = 6;
            // 
            // lblArea
            // 
            lblArea.Font = new Font("Segoe UI", 10F);
            lblArea.Location = new Point(40, 180);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(120, 25);
            lblArea.TabIndex = 7;
            lblArea.Text = "Área";
            // 
            // cmbArea
            // 
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.Font = new Font("Segoe UI", 10F);
            cmbArea.Location = new Point(180, 178);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(250, 31);
            cmbArea.TabIndex = 8;
            // 
            // lblCodigo
            // 
            lblCodigo.Font = new Font("Segoe UI", 10F);
            lblCodigo.Location = new Point(40, 225);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(120, 25);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.Location = new Point(180, 223);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(250, 30);
            txtCodigo.TabIndex = 10;
            // 
            // lblCantidad
            // 
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(496, 226);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(100, 25);
            lblCantidad.TabIndex = 11;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10F);
            txtCantidad.Location = new Point(602, 223);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(250, 30);
            txtCantidad.TabIndex = 12;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.Location = new Point(40, 270);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(120, 25);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(180, 268);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 30);
            txtDescripcion.TabIndex = 14;
            // 
            // lblUnidad
            // 
            lblUnidad.Font = new Font("Segoe UI", 10F);
            lblUnidad.Location = new Point(496, 273);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(156, 55);
            lblUnidad.TabIndex = 15;
            lblUnidad.Text = "Unidad de Medida";
            lblUnidad.Click += lblUnidad_Click;
            // 
            // txtUnidad
            // 
            txtUnidad.Font = new Font("Segoe UI", 10F);
            txtUnidad.Location = new Point(602, 267);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(250, 30);
            txtUnidad.TabIndex = 16;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 10F);
            txtObservaciones.Location = new Point(40, 320);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Observaciones adicionales...";
            txtObservaciones.Size = new Size(534, 177);
            txtObservaciones.TabIndex = 17;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(41, 128, 185);
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(646, 331);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(170, 40);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(231, 76, 60);
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(646, 377);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(170, 40);
            btnBorrar.TabIndex = 19;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardarPDF
            // 
            btnGuardarPDF.BackColor = Color.FromArgb(39, 174, 96);
            btnGuardarPDF.FlatAppearance.BorderSize = 0;
            btnGuardarPDF.FlatStyle = FlatStyle.Flat;
            btnGuardarPDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarPDF.ForeColor = Color.White;
            btnGuardarPDF.Location = new Point(646, 423);
            btnGuardarPDF.Name = "btnGuardarPDF";
            btnGuardarPDF.Size = new Size(170, 40);
            btnGuardarPDF.TabIndex = 20;
            btnGuardarPDF.Text = "Guardar y Generar PDF";
            btnGuardarPDF.UseVisualStyleBackColor = false;
            // 
            // Traslado_de_Materiales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(873, 520);
            Controls.Add(lblTitulo);
            Controls.Add(lblProyecto);
            Controls.Add(cmbProyecto);
            Controls.Add(lblNTraslado);
            Controls.Add(txtNTraslado);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblArea);
            Controls.Add(cmbArea);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblUnidad);
            Controls.Add(txtUnidad);
            Controls.Add(txtObservaciones);
            Controls.Add(btnInsertar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardarPDF);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Traslado_de_Materiales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Traslado de Materiales";
            Load += Traslado_de_Materiales_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Label lblNTraslado;
        private System.Windows.Forms.TextBox txtNTraslado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardarPDF;
    }
}