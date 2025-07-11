namespace GenracionOC
{
    partial class Registro_De_Proveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxProveedor;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelRUC;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombreContacto;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.Label labelServicios;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.TextBox textBoxRUC;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombreContacto;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxFormaPago;
        private System.Windows.Forms.TextBox textBoxServicios;
        private System.Windows.Forms.Button buttonRegistrar;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise.</param>
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxProveedor = new GroupBox();
            labelTitulo = new Label();
            labelProveedor = new Label();
            labelRUC = new Label();
            labelDireccion = new Label();
            labelNombreContacto = new Label();
            labelTelefono = new Label();
            labelMail = new Label();
            labelFormaPago = new Label();
            labelServicios = new Label();
            textBoxProveedor = new TextBox();
            textBoxRUC = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNombreContacto = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxMail = new TextBox();
            textBoxFormaPago = new TextBox();
            textBoxServicios = new TextBox();
            buttonRegistrar = new Button();
            SuspendLayout();
            // 
            // groupBoxProveedor
            // 
            groupBoxProveedor.BackColor = Color.Transparent;
            groupBoxProveedor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProveedor.ForeColor = Color.DodgerBlue;
            groupBoxProveedor.Location = new Point(36, 71);
            groupBoxProveedor.Name = "groupBoxProveedor";
            groupBoxProveedor.Size = new Size(208, 37);
            groupBoxProveedor.TabIndex = 0;
            groupBoxProveedor.TabStop = false;
            groupBoxProveedor.Text = "Datos del Proveedor";
            groupBoxProveedor.Enter += groupBoxProveedor_Enter;
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(66, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(447, 43);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "REGISTRO DE PROVEEDORES";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProveedor
            // 
            labelProveedor.Location = new Point(66, 111);
            labelProveedor.Name = "labelProveedor";
            labelProveedor.Size = new Size(150, 23);
            labelProveedor.TabIndex = 2;
            labelProveedor.Text = "PROVEEDOR";
            // 
            // labelRUC
            // 
            labelRUC.Location = new Point(66, 149);
            labelRUC.Name = "labelRUC";
            labelRUC.Size = new Size(150, 23);
            labelRUC.TabIndex = 4;
            labelRUC.Text = "RUC";
            // 
            // labelDireccion
            // 
            labelDireccion.Location = new Point(66, 187);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(150, 23);
            labelDireccion.TabIndex = 6;
            labelDireccion.Text = "DIRECCIÓN";
            // 
            // labelNombreContacto
            // 
            labelNombreContacto.Location = new Point(66, 225);
            labelNombreContacto.Name = "labelNombreContacto";
            labelNombreContacto.Size = new Size(150, 23);
            labelNombreContacto.TabIndex = 8;
            labelNombreContacto.Text = "NOMBRE CONTACTO";
            // 
            // labelTelefono
            // 
            labelTelefono.Location = new Point(66, 263);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(150, 23);
            labelTelefono.TabIndex = 10;
            labelTelefono.Text = "TELÉFONO";
            // 
            // labelMail
            // 
            labelMail.Location = new Point(66, 301);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(150, 23);
            labelMail.TabIndex = 12;
            labelMail.Text = "MAIL";
            // 
            // labelFormaPago
            // 
            labelFormaPago.Location = new Point(66, 339);
            labelFormaPago.Name = "labelFormaPago";
            labelFormaPago.Size = new Size(150, 23);
            labelFormaPago.TabIndex = 14;
            labelFormaPago.Text = "FORMA DE PAGO";
            // 
            // labelServicios
            // 
            labelServicios.Location = new Point(66, 377);
            labelServicios.Name = "labelServicios";
            labelServicios.Size = new Size(150, 23);
            labelServicios.TabIndex = 16;
            labelServicios.Text = "SERVICIOS";
            // 
            // textBoxProveedor
            // 
            textBoxProveedor.Location = new Point(236, 111);
            textBoxProveedor.Name = "textBoxProveedor";
            textBoxProveedor.Size = new Size(300, 23);
            textBoxProveedor.TabIndex = 3;
            // 
            // textBoxRUC
            // 
            textBoxRUC.Location = new Point(236, 149);
            textBoxRUC.Name = "textBoxRUC";
            textBoxRUC.Size = new Size(300, 23);
            textBoxRUC.TabIndex = 5;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(236, 187);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(300, 23);
            textBoxDireccion.TabIndex = 7;
            // 
            // textBoxNombreContacto
            // 
            textBoxNombreContacto.Location = new Point(236, 225);
            textBoxNombreContacto.Name = "textBoxNombreContacto";
            textBoxNombreContacto.Size = new Size(300, 23);
            textBoxNombreContacto.TabIndex = 9;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(236, 263);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(300, 23);
            textBoxTelefono.TabIndex = 11;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(236, 301);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(300, 23);
            textBoxMail.TabIndex = 13;
            // 
            // textBoxFormaPago
            // 
            textBoxFormaPago.Location = new Point(236, 339);
            textBoxFormaPago.Name = "textBoxFormaPago";
            textBoxFormaPago.Size = new Size(300, 23);
            textBoxFormaPago.TabIndex = 15;
            // 
            // textBoxServicios
            // 
            textBoxServicios.Location = new Point(236, 377);
            textBoxServicios.Name = "textBoxServicios";
            textBoxServicios.Size = new Size(300, 23);
            textBoxServicios.TabIndex = 17;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.MediumSeaGreen;
            buttonRegistrar.FlatStyle = FlatStyle.Flat;
            buttonRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonRegistrar.ForeColor = Color.White;
            buttonRegistrar.Location = new Point(312, 422);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(150, 40);
            buttonRegistrar.TabIndex = 18;
            buttonRegistrar.Text = "REGISTRAR";
            buttonRegistrar.UseVisualStyleBackColor = false;
            // 
            // Registro_De_Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 255);
            ClientSize = new Size(588, 500);
            Controls.Add(groupBoxProveedor);
            Controls.Add(labelTitulo);
            Controls.Add(labelProveedor);
            Controls.Add(textBoxProveedor);
            Controls.Add(labelRUC);
            Controls.Add(textBoxRUC);
            Controls.Add(labelDireccion);
            Controls.Add(textBoxDireccion);
            Controls.Add(labelNombreContacto);
            Controls.Add(textBoxNombreContacto);
            Controls.Add(labelTelefono);
            Controls.Add(textBoxTelefono);
            Controls.Add(labelMail);
            Controls.Add(textBoxMail);
            Controls.Add(labelFormaPago);
            Controls.Add(textBoxFormaPago);
            Controls.Add(labelServicios);
            Controls.Add(textBoxServicios);
            Controls.Add(buttonRegistrar);
            Name = "Registro_De_Proveedores";
            Text = "Registro de Proveedores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}