namespace GenracionOC
{
    partial class Ordenes_de_Compra
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
            lblRazon = new Label();
            cmbRazon = new ComboBox();
            txtNumero = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            lblMoneda = new Label();
            cmbMoneda = new ComboBox();
            txtObservaciones = new TextBox();
            rbCompra = new RadioButton();
            rbServicio = new RadioButton();
            lblLatitud = new Label();
            txtLatitud = new TextBox();
            lblLongitud = new Label();
            txtLongitud = new TextBox();
            lblDestino = new Label();
            txtDestino = new TextBox();
            lblFechaReq = new Label();
            dtpFechaReq = new DateTimePicker();
            lblCodigo = new Label();
            cmbCodigo = new ComboBox();
            lblUMedida = new Label();
            txtUMedida = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecioU = new Label();
            txtPrecioU = new TextBox();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblSubTotal = new Label();
            txtSubTotal = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnInsertar = new Button();
            btnBorrar = new Button();
            btnGuardar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(52, 73, 94);
            lblTitulo.Location = new Point(0, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1260, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ÓRDENES DE COMPRA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRazon
            // 
            lblRazon.Font = new Font("Segoe UI", 10F);
            lblRazon.Location = new Point(30, 55);
            lblRazon.Name = "lblRazon";
            lblRazon.Size = new Size(134, 25);
            lblRazon.TabIndex = 2;
            lblRazon.Text = "RAZÓN SOCIAL";
            // 
            // cmbRazon
            // 
            cmbRazon.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRazon.Font = new Font("Segoe UI", 10F);
            cmbRazon.Location = new Point(180, 58);
            cmbRazon.Name = "cmbRazon";
            cmbRazon.Size = new Size(350, 31);
            cmbRazon.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 10F);
            txtNumero.Location = new Point(719, 59);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(91, 30);
            txtNumero.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 10F);
            lblFecha.Location = new Point(30, 96);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 25);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 10F);
            dtpFecha.Location = new Point(180, 96);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 30);
            dtpFecha.TabIndex = 6;
            // 
            // lblProveedor
            // 
            lblProveedor.Font = new Font("Segoe UI", 10F);
            lblProveedor.Location = new Point(30, 131);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(120, 25);
            lblProveedor.TabIndex = 7;
            lblProveedor.Text = "PROVEEDOR";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Font = new Font("Segoe UI", 10F);
            cmbProveedor.Location = new Point(180, 132);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(350, 31);
            cmbProveedor.TabIndex = 8;
            // 
            // lblMoneda
            // 
            lblMoneda.Font = new Font("Segoe UI", 10F);
            lblMoneda.Location = new Point(30, 169);
            lblMoneda.Name = "lblMoneda";
            lblMoneda.Size = new Size(120, 25);
            lblMoneda.TabIndex = 9;
            lblMoneda.Text = "MONEDA";
            // 
            // cmbMoneda
            // 
            cmbMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMoneda.Font = new Font("Segoe UI", 10F);
            cmbMoneda.Location = new Point(180, 169);
            cmbMoneda.Name = "cmbMoneda";
            cmbMoneda.Size = new Size(200, 31);
            cmbMoneda.TabIndex = 10;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Font = new Font("Segoe UI", 10F);
            txtObservaciones.Location = new Point(30, 206);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.PlaceholderText = "Observaciones...";
            txtObservaciones.Size = new Size(780, 105);
            txtObservaciones.TabIndex = 11;
            txtObservaciones.TextChanged += txtObservaciones_TextChanged;
            // 
            // rbCompra
            // 
            rbCompra.Font = new Font("Segoe UI", 10F);
            rbCompra.Location = new Point(30, 317);
            rbCompra.Name = "rbCompra";
            rbCompra.Size = new Size(120, 25);
            rbCompra.TabIndex = 12;
            rbCompra.Text = "COMPRA";
            // 
            // rbServicio
            // 
            rbServicio.Font = new Font("Segoe UI", 10F);
            rbServicio.Location = new Point(180, 317);
            rbServicio.Name = "rbServicio";
            rbServicio.Size = new Size(128, 25);
            rbServicio.TabIndex = 13;
            rbServicio.Text = "SERVICIO";
            // 
            // lblLatitud
            // 
            lblLatitud.Font = new Font("Segoe UI", 10F);
            lblLatitud.Location = new Point(30, 359);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(80, 25);
            lblLatitud.TabIndex = 14;
            lblLatitud.Text = "LATITUD";
            // 
            // txtLatitud
            // 
            txtLatitud.Font = new Font("Segoe UI", 10F);
            txtLatitud.Location = new Point(120, 356);
            txtLatitud.Name = "txtLatitud";
            txtLatitud.Size = new Size(150, 30);
            txtLatitud.TabIndex = 15;
            // 
            // lblLongitud
            // 
            lblLongitud.Font = new Font("Segoe UI", 10F);
            lblLongitud.Location = new Point(289, 361);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(103, 25);
            lblLongitud.TabIndex = 16;
            lblLongitud.Text = "LONGITUD";
            // 
            // txtLongitud
            // 
            txtLongitud.Font = new Font("Segoe UI", 10F);
            txtLongitud.Location = new Point(390, 356);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(150, 30);
            txtLongitud.TabIndex = 17;
            // 
            // lblDestino
            // 
            lblDestino.Font = new Font("Segoe UI", 10F);
            lblDestino.Location = new Point(570, 364);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(80, 25);
            lblDestino.TabIndex = 18;
            lblDestino.Text = "DESTINO";
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 10F);
            txtDestino.Location = new Point(660, 361);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(150, 30);
            txtDestino.TabIndex = 19;
            // 
            // lblFechaReq
            // 
            lblFechaReq.Font = new Font("Segoe UI", 10F);
            lblFechaReq.Location = new Point(30, 400);
            lblFechaReq.Name = "lblFechaReq";
            lblFechaReq.Size = new Size(80, 25);
            lblFechaReq.TabIndex = 20;
            lblFechaReq.Text = "FECHA REQUERIDA";
            // 
            // dtpFechaReq
            // 
            dtpFechaReq.Font = new Font("Segoe UI", 10F);
            dtpFechaReq.Location = new Point(120, 395);
            dtpFechaReq.Name = "dtpFechaReq";
            dtpFechaReq.Size = new Size(200, 30);
            dtpFechaReq.TabIndex = 21;
            // 
            // lblCodigo
            // 
            lblCodigo.Font = new Font("Segoe UI", 10F);
            lblCodigo.Location = new Point(30, 440);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(80, 25);
            lblCodigo.TabIndex = 22;
            lblCodigo.Text = "CÓDIGO";
            // 
            // cmbCodigo
            // 
            cmbCodigo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCodigo.Font = new Font("Segoe UI", 10F);
            cmbCodigo.Location = new Point(120, 434);
            cmbCodigo.Name = "cmbCodigo";
            cmbCodigo.Size = new Size(150, 31);
            cmbCodigo.TabIndex = 23;
            // 
            // lblUMedida
            // 
            lblUMedida.Font = new Font("Segoe UI", 10F);
            lblUMedida.Location = new Point(540, 440);
            lblUMedida.Name = "lblUMedida";
            lblUMedida.Size = new Size(110, 25);
            lblUMedida.TabIndex = 24;
            lblUMedida.Text = "U. MEDIDA";
            lblUMedida.Click += lblUMedida_Click;
            // 
            // txtUMedida
            // 
            txtUMedida.Font = new Font("Segoe UI", 10F);
            txtUMedida.Location = new Point(660, 434);
            txtUMedida.Name = "txtUMedida";
            txtUMedida.Size = new Size(150, 30);
            txtUMedida.TabIndex = 25;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.Location = new Point(30, 480);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(120, 25);
            lblDescripcion.TabIndex = 26;
            lblDescripcion.Text = "DESCRIPCIÓN";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(156, 480);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(262, 30);
            txtDescripcion.TabIndex = 27;
            // 
            // lblPrecioU
            // 
            lblPrecioU.Font = new Font("Segoe UI", 10F);
            lblPrecioU.Location = new Point(549, 480);
            lblPrecioU.Name = "lblPrecioU";
            lblPrecioU.Size = new Size(80, 25);
            lblPrecioU.TabIndex = 28;
            lblPrecioU.Text = "PRECIO U.";
            // 
            // txtPrecioU
            // 
            txtPrecioU.Font = new Font("Segoe UI", 10F);
            txtPrecioU.Location = new Point(660, 480);
            txtPrecioU.Name = "txtPrecioU";
            txtPrecioU.Size = new Size(150, 30);
            txtPrecioU.TabIndex = 29;
            // 
            // lblCantidad
            // 
            lblCantidad.Font = new Font("Segoe UI", 10F);
            lblCantidad.Location = new Point(30, 518);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(100, 25);
            lblCantidad.TabIndex = 30;
            lblCantidad.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 10F);
            txtCantidad.Location = new Point(158, 518);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 30);
            txtCantidad.TabIndex = 31;
            // 
            // lblSubTotal
            // 
            lblSubTotal.Font = new Font("Segoe UI", 10F);
            lblSubTotal.Location = new Point(549, 518);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(80, 25);
            lblSubTotal.TabIndex = 32;
            lblSubTotal.Text = "SUB TOTAL";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 10F);
            txtSubTotal.Location = new Point(660, 516);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(150, 30);
            txtSubTotal.TabIndex = 33;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 10F);
            lblTotal.Location = new Point(540, 553);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(80, 25);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 10F);
            txtTotal.Location = new Point(660, 558);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(150, 30);
            txtTotal.TabIndex = 35;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(41, 128, 185);
            btnInsertar.FlatAppearance.BorderSize = 0;
            btnInsertar.FlatStyle = FlatStyle.Flat;
            btnInsertar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInsertar.ForeColor = Color.White;
            btnInsertar.Location = new Point(1100, 350);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(120, 40);
            btnInsertar.TabIndex = 36;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(231, 76, 60);
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorrar.ForeColor = Color.White;
            btnBorrar.Location = new Point(1100, 400);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(120, 40);
            btnBorrar.TabIndex = 37;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(39, 174, 96);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1100, 450);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 40);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(30, 581);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(780, 105);
            textBox1.TabIndex = 39;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(30, 700);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 40;
            label1.Text = "IGV";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(500, 700);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 41;
            label2.Text = "TOTAL";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(158, 700);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 42;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(592, 700);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 43;
            label4.Click += label4_Click;
            // 
            // Ordenes_de_Compra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1262, 795);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lblTitulo);
            Controls.Add(lblRazon);
            Controls.Add(cmbRazon);
            Controls.Add(txtNumero);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblProveedor);
            Controls.Add(cmbProveedor);
            Controls.Add(lblMoneda);
            Controls.Add(cmbMoneda);
            Controls.Add(txtObservaciones);
            Controls.Add(rbCompra);
            Controls.Add(rbServicio);
            Controls.Add(lblLatitud);
            Controls.Add(txtLatitud);
            Controls.Add(lblLongitud);
            Controls.Add(txtLongitud);
            Controls.Add(lblDestino);
            Controls.Add(txtDestino);
            Controls.Add(lblFechaReq);
            Controls.Add(dtpFechaReq);
            Controls.Add(lblCodigo);
            Controls.Add(cmbCodigo);
            Controls.Add(lblUMedida);
            Controls.Add(txtUMedida);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblPrecioU);
            Controls.Add(txtPrecioU);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblSubTotal);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(btnInsertar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Ordenes_de_Compra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Órdenes de Compra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.ComboBox cmbRazon;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.RadioButton rbCompra;
        private System.Windows.Forms.RadioButton rbServicio;
        private System.Windows.Forms.Label lblLatitud;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblFechaReq;
        private System.Windows.Forms.DateTimePicker dtpFechaReq;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblUMedida;
        private System.Windows.Forms.TextBox txtUMedida;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecioU;
        private System.Windows.Forms.TextBox txtPrecioU;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}