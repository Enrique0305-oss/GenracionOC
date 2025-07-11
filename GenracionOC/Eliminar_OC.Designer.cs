namespace GenracionOC
{
    partial class Eliminar_OC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.RadioButton radioOCCompra;
        private System.Windows.Forms.RadioButton radioOSServicio;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.Label labelCorrelativo;
        private System.Windows.Forms.ComboBox comboBoxRazonSocial;
        private System.Windows.Forms.ComboBox comboBoxCorrelativo;
        private System.Windows.Forms.ListBox listBoxDetalle;
        private System.Windows.Forms.Button buttonEliminar;

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
            groupBoxEliminar = new GroupBox();
            labelTitulo = new Label();
            radioOCCompra = new RadioButton();
            radioOSServicio = new RadioButton();
            labelRazonSocial = new Label();
            labelCorrelativo = new Label();
            comboBoxRazonSocial = new ComboBox();
            comboBoxCorrelativo = new ComboBox();
            listBoxDetalle = new ListBox();
            buttonEliminar = new Button();
            SuspendLayout();
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.BackColor = Color.Transparent;
            groupBoxEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxEliminar.ForeColor = Color.DodgerBlue;
            groupBoxEliminar.Location = new Point(12, 79);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(255, 24);
            groupBoxEliminar.TabIndex = 0;
            groupBoxEliminar.TabStop = false;
            groupBoxEliminar.Text = "Opciones de Eliminación";
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.Black;
            labelTitulo.Location = new Point(13, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(613, 60);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "ELIMINAR OC";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioOCCompra
            // 
            radioOCCompra.Location = new Point(52, 109);
            radioOCCompra.Name = "radioOCCompra";
            radioOCCompra.Size = new Size(200, 23);
            radioOCCompra.TabIndex = 2;
            radioOCCompra.Text = "Seleccionar OC (COMPRA)";
            // 
            // radioOSServicio
            // 
            radioOSServicio.Location = new Point(302, 109);
            radioOSServicio.Name = "radioOSServicio";
            radioOSServicio.Size = new Size(220, 23);
            radioOSServicio.TabIndex = 3;
            radioOSServicio.Text = "Seleccionar OS (SERVICIO)";
            // 
            // labelRazonSocial
            // 
            labelRazonSocial.Location = new Point(52, 149);
            labelRazonSocial.Name = "labelRazonSocial";
            labelRazonSocial.Size = new Size(120, 23);
            labelRazonSocial.TabIndex = 4;
            labelRazonSocial.Text = "RAZÓN SOCIAL";
            // 
            // labelCorrelativo
            // 
            labelCorrelativo.Location = new Point(52, 189);
            labelCorrelativo.Name = "labelCorrelativo";
            labelCorrelativo.Size = new Size(120, 23);
            labelCorrelativo.TabIndex = 6;
            labelCorrelativo.Text = "CORRELATIVO";
            // 
            // comboBoxRazonSocial
            // 
            comboBoxRazonSocial.Location = new Point(202, 149);
            comboBoxRazonSocial.Name = "comboBoxRazonSocial";
            comboBoxRazonSocial.Size = new Size(300, 23);
            comboBoxRazonSocial.TabIndex = 5;
            // 
            // comboBoxCorrelativo
            // 
            comboBoxCorrelativo.Location = new Point(202, 189);
            comboBoxCorrelativo.Name = "comboBoxCorrelativo";
            comboBoxCorrelativo.Size = new Size(300, 23);
            comboBoxCorrelativo.TabIndex = 7;
            // 
            // listBoxDetalle
            // 
            listBoxDetalle.ItemHeight = 15;
            listBoxDetalle.Location = new Point(52, 255);
            listBoxDetalle.Name = "listBoxDetalle";
            listBoxDetalle.Size = new Size(574, 94);
            listBoxDetalle.TabIndex = 8;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Crimson;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonEliminar.ForeColor = Color.White;
            buttonEliminar.Location = new Point(270, 369);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(150, 40);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // Eliminar_OC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 255);
            ClientSize = new Size(659, 450);
            Controls.Add(groupBoxEliminar);
            Controls.Add(labelTitulo);
            Controls.Add(radioOCCompra);
            Controls.Add(radioOSServicio);
            Controls.Add(labelRazonSocial);
            Controls.Add(comboBoxRazonSocial);
            Controls.Add(labelCorrelativo);
            Controls.Add(comboBoxCorrelativo);
            Controls.Add(listBoxDetalle);
            Controls.Add(buttonEliminar);
            Name = "Eliminar_OC";
            Text = "Eliminar OC";
            ResumeLayout(false);
        }

        #endregion
    }
}