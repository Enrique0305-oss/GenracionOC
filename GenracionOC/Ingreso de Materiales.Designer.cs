namespace GenracionOC
{
    partial class Form1
    {
        /// <summary>
        ///  Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Limpiar los recursos que se estén usando.
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
        ///  Método necesario para admitir el Diseñador. No se puede modificar
        ///  el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblNIngreso = new Label();
            txtNIngreso = new TextBox();
            lblOC = new Label();
            cmbOC = new ComboBox();
            lblObs = new Label();
            lblProveedor = new Label();
            txtProveedor = new TextBox();
            lblGuia = new Label();
            txtGuia = new TextBox();
            lblFactura = new Label();
            txtFactura = new TextBox();
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
            btnPrecargar = new Button();
            lblObsFinal = new Label();
            btnGuardar = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(52, 73, 94);
            lblTitulo.Location = new Point(0, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(950, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ingreso de Materiales";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(60, 90);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(130, 25);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha de Registro";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Location = new Point(200, 88);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(180, 30);
            dtpFecha.TabIndex = 2;
            // 
            // lblNIngreso
            // 
            lblNIngreso.Font = new Font("Segoe UI", 10F);
            lblNIngreso.Location = new Point(500, 90);
            lblNIngreso.Name = "lblNIngreso";
            lblNIngreso.Size = new Size(100, 25);
            lblNIngreso.TabIndex = 3;
            lblNIngreso.Text = "N° Ingreso";
            // 
            // txtNIngreso
            // 
            txtNIngreso.Font = new Font("Segoe UI", 10F);
            txtNIngreso.Location = new Point(610, 88);
            txtNIngreso.Name = "txtNIngreso";
            txtNIngreso.Size = new Size(180, 30);
            txtNIngreso.TabIndex = 4;
            // 
            // lblOC
            // 
            lblOC.Font = new Font("Segoe UI", 10F);
            lblOC.Location = new Point(60, 130);
            lblOC.Name = "lblOC";
            lblOC.Size = new Size(130, 25);
            lblOC.TabIndex = 5;
            lblOC.Text = "N° OC / OS";
            // 
            // cmbOC
            // 
            cmbOC.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOC.Font = new Font("Segoe UI", 10F);
            cmbOC.Location = new Point(200, 131);
            cmbOC.Name = "cmbOC";
            cmbOC.Size = new Size(180, 31);
            cmbOC.TabIndex = 6;
            // 
            // lblObs
            // 
            lblObs.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblObs.ForeColor = Color.FromArgb(231, 76, 60);
            lblObs.Location = new Point(500, 121);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(391, 67);
            lblObs.TabIndex = 7;
            lblObs.Text = "OBSERVACIONES , LAS ORDENES DE INGRESO SE TIENEN QUE MANEJAR COMO SALDO ,DADO QUE PUEDEN SER PARCIALES O TOTALES";
            lblObs.Click += lblObs_Click;
            // 
            // lblProveedor
            // 
            lblProveedor.Font = new Font("Segoe UI", 10F);
            lblProveedor.Location = new Point(60, 170);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(130, 25);
            lblProveedor.TabIndex = 8;
            lblProveedor.Text = "Proveedor";
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 10F);
            txtProveedor.Location = new Point(200, 168);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(180, 30);
            txtProveedor.TabIndex = 9;
            // 
            // lblGuia
            // 
            lblGuia.Font = new Font("Segoe UI", 10F);
            lblGuia.Location = new Point(500, 194);
            lblGuia.Name = "lblGuia";
            lblGuia.Size = new Size(221, 25);
            lblGuia.TabIndex = 10;
            lblGuia.Text = "Guía Remisión- Proveedor";
            // 
            // txtGuia
            // 
            txtGuia.Font = new Font("Segoe UI", 10F);
            txtGuia.Location = new Point(727, 189);
            txtGuia.Name = "txtGuia";
            txtGuia.Size = new Size(180, 30);
            txtGuia.TabIndex = 11;
            // 
            // lblFactura
            // 
            lblFactura.Font = new Font("Segoe UI", 10F);
            lblFactura.Location = new Point(60, 210);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(96, 25);
            lblFactura.TabIndex = 12;
            lblFactura.Text = "Factura";
            // 
            // txtFactura
            // 
            txtFactura.Font = new Font("Segoe UI", 10F);
            txtFactura.Location = new Point(200, 208);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(180, 30);
            txtFactura.TabIndex = 13;
            // 
            // lblCodigo
            // 
            lblCodigo.Font = new Font("Segoe UI", 10F);
            lblCodigo.Location = new Point(60, 250);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(130, 25);
            lblCodigo.TabIndex = 14;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.Location = new Point(200, 248);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(180, 30);
            txtCodigo.TabIndex = 15;
            // 
            // lblCantidad
            // 
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(504, 230);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(100, 25);
            lblCantidad.TabIndex = 16;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10F);
            txtCantidad.Location = new Point(610, 225);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(180, 30);
            txtCantidad.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.Location = new Point(60, 290);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(130, 25);
            lblDescripcion.TabIndex = 18;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(200, 288);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(180, 30);
            txtDescripcion.TabIndex = 19;
            // 
            // lblUnidad
            // 
            lblUnidad.Font = new Font("Segoe UI", 10F);
            lblUnidad.Location = new Point(504, 271);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(100, 25);
            lblUnidad.TabIndex = 20;
            lblUnidad.Text = "Unidad";
            // 
            // txtUnidad
            // 
            txtUnidad.Font = new Font("Segoe UI", 10F);
            txtUnidad.Location = new Point(610, 271);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(180, 30);
            txtUnidad.TabIndex = 21;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 10F);
            txtObservaciones.Location = new Point(60, 340);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Observaciones adicionales...";
            txtObservaciones.Size = new Size(691, 80);
            txtObservaciones.TabIndex = 22;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(41, 128, 185);
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(757, 340);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(150, 40);
            btnInsertar.TabIndex = 23;
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
            btnBorrar.Location = new Point(757, 404);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(150, 40);
            btnBorrar.TabIndex = 24;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnPrecargar
            // 
            btnPrecargar.BackColor = Color.FromArgb(39, 174, 96);
            btnPrecargar.FlatAppearance.BorderSize = 0;
            btnPrecargar.FlatStyle = FlatStyle.Flat;
            btnPrecargar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrecargar.ForeColor = Color.White;
            btnPrecargar.Location = new Point(757, 465);
            btnPrecargar.Name = "btnPrecargar";
            btnPrecargar.Size = new Size(150, 40);
            btnPrecargar.TabIndex = 25;
            btnPrecargar.Text = "Precargar";
            btnPrecargar.UseVisualStyleBackColor = false;
            // 
            // lblObsFinal
            // 
            lblObsFinal.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblObsFinal.ForeColor = Color.FromArgb(231, 76, 60);
            lblObsFinal.Location = new Point(358, 440);
            lblObsFinal.Name = "lblObsFinal";
            lblObsFinal.Size = new Size(393, 132);
            lblObsFinal.TabIndex = 26;
            lblObsFinal.Text = resources.GetString("lblObsFinal.Text");
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Red;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(757, 531);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 59);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guargar y General PDF";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(26, 465);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 28;
            label1.Text = "Proyecto Almacen";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 464);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 28);
            comboBox1.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(942, 697);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblNIngreso);
            Controls.Add(txtNIngreso);
            Controls.Add(lblOC);
            Controls.Add(cmbOC);
            Controls.Add(lblObs);
            Controls.Add(lblProveedor);
            Controls.Add(txtProveedor);
            Controls.Add(lblGuia);
            Controls.Add(txtGuia);
            Controls.Add(lblFactura);
            Controls.Add(txtFactura);
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
            Controls.Add(btnPrecargar);
            Controls.Add(lblObsFinal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de Materiales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNIngreso;
        private System.Windows.Forms.TextBox txtNIngreso;
        private System.Windows.Forms.Label lblOC;
        private System.Windows.Forms.ComboBox cmbOC;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtGuia;
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
        private System.Windows.Forms.Button btnPrecargar;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblObsFinal;
        private Button btnGuardar;
        private Label label1;
        private ComboBox comboBox1;
    }
}
