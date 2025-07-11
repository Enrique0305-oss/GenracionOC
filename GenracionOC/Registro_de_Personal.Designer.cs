namespace GenracionOC
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.cmbProyecto = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "Registro de Personal";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTitulo.Location = new System.Drawing.Point(0, 20);
            this.lblTitulo.Size = new System.Drawing.Size(900, 45);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblProyecto
            // 
            this.lblProyecto.Text = "Proyecto";
            this.lblProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProyecto.Location = new System.Drawing.Point(120, 90);
            this.lblProyecto.Size = new System.Drawing.Size(120, 25);

            // 
            // cmbProyecto
            // 
            this.cmbProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyecto.Location = new System.Drawing.Point(260, 88);
            this.cmbProyecto.Size = new System.Drawing.Size(250, 30);

            // 
            // lblCiudad
            // 
            this.lblCiudad.Text = "Ciudad";
            this.lblCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCiudad.Location = new System.Drawing.Point(120, 135);
            this.lblCiudad.Size = new System.Drawing.Size(120, 25);

            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCiudad.Location = new System.Drawing.Point(260, 133);
            this.txtCiudad.Size = new System.Drawing.Size(250, 30);

            // 
            // lblNombre
            // 
            this.lblNombre.Text = "Nombre y Apellido";
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombre.Location = new System.Drawing.Point(120, 180);
            this.lblNombre.Size = new System.Drawing.Size(120, 25);

            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(260, 178);
            this.txtNombre.Size = new System.Drawing.Size(250, 30);

            // 
            // lblArea
            // 
            this.lblArea.Text = "Área";
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblArea.Location = new System.Drawing.Point(120, 225);
            this.lblArea.Size = new System.Drawing.Size(120, 25);

            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArea.Location = new System.Drawing.Point(260, 223);
            this.txtArea.Size = new System.Drawing.Size(250, 30);

            // 
            // lblDni
            // 
            this.lblDni.Text = "DNI";
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDni.Location = new System.Drawing.Point(120, 270);
            this.lblDni.Size = new System.Drawing.Size(120, 25);

            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDni.Location = new System.Drawing.Point(260, 268);
            this.txtDni.Size = new System.Drawing.Size(250, 30);

            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtObservaciones.Location = new System.Drawing.Point(120, 320);
            this.txtObservaciones.Size = new System.Drawing.Size(390, 80);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.PlaceholderText = "Observaciones adicionales...";

            // 
            // btnInsertar
            // 
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.btnInsertar.ForeColor = System.Drawing.Color.White;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.Location = new System.Drawing.Point(600, 120);
            this.btnInsertar.Size = new System.Drawing.Size(170, 40);

            // 
            // btnBorrar
            // 
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.Location = new System.Drawing.Point(600, 180);
            this.btnBorrar.Size = new System.Drawing.Size(170, 40);

            // 
            // btnCrear
            // 
            this.btnCrear.Text = "Crear Registro";
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.Location = new System.Drawing.Point(600, 240);
            this.btnCrear.Size = new System.Drawing.Size(170, 40);

            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.cmbProyecto);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Personal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox cmbProyecto;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCrear;
    }
}