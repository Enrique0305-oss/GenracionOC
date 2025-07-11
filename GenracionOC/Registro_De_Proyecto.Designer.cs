namespace GenracionOC
{
    partial class Registro_De_Proyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label labelNombreProyecto;
        private System.Windows.Forms.Label labelBodega;
        private System.Windows.Forms.TextBox textBoxNombreProyecto;
        private System.Windows.Forms.TextBox textBoxBodega;
        private System.Windows.Forms.ListBox listBoxProyectos;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonCrearRegistro;

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
            groupBoxDatos = new GroupBox();
            labelNombreProyecto = new Label();
            labelBodega = new Label();
            textBoxNombreProyecto = new TextBox();
            textBoxBodega = new TextBox();
            listBoxProyectos = new ListBox();
            buttonInsertar = new Button();
            buttonBorrar = new Button();
            buttonCrearRegistro = new Button();
            SuspendLayout();
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.WhiteSmoke;
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.DodgerBlue;
            groupBoxDatos.Location = new Point(30, 30);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(151, 27);
            groupBoxDatos.TabIndex = 0;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos del Proyecto";
            // 
            // labelNombreProyecto
            // 
            labelNombreProyecto.Location = new Point(50, 60);
            labelNombreProyecto.Name = "labelNombreProyecto";
            labelNombreProyecto.Size = new Size(160, 23);
            labelNombreProyecto.TabIndex = 1;
            labelNombreProyecto.Text = "NOMBRE DEL PROYECTO";
            // 
            // labelBodega
            // 
            labelBodega.Location = new Point(50, 90);
            labelBodega.Name = "labelBodega";
            labelBodega.Size = new Size(160, 23);
            labelBodega.TabIndex = 3;
            labelBodega.Text = "BODEGA";
            // 
            // textBoxNombreProyecto
            // 
            textBoxNombreProyecto.Location = new Point(220, 60);
            textBoxNombreProyecto.Name = "textBoxNombreProyecto";
            textBoxNombreProyecto.Size = new Size(250, 23);
            textBoxNombreProyecto.TabIndex = 2;
            // 
            // textBoxBodega
            // 
            textBoxBodega.Location = new Point(220, 90);
            textBoxBodega.Name = "textBoxBodega";
            textBoxBodega.Size = new Size(250, 23);
            textBoxBodega.TabIndex = 4;
            // 
            // listBoxProyectos
            // 
            listBoxProyectos.ItemHeight = 15;
            listBoxProyectos.Location = new Point(30, 150);
            listBoxProyectos.Name = "listBoxProyectos";
            listBoxProyectos.Size = new Size(500, 169);
            listBoxProyectos.TabIndex = 5;
            // 
            // buttonInsertar
            // 
            buttonInsertar.BackColor = Color.DodgerBlue;
            buttonInsertar.FlatStyle = FlatStyle.Flat;
            buttonInsertar.ForeColor = Color.White;
            buttonInsertar.Location = new Point(600, 150);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(180, 35);
            buttonInsertar.TabIndex = 6;
            buttonInsertar.Text = "INSERTAR";
            buttonInsertar.UseVisualStyleBackColor = false;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = Color.LightGray;
            buttonBorrar.FlatStyle = FlatStyle.Flat;
            buttonBorrar.ForeColor = Color.Black;
            buttonBorrar.Location = new Point(600, 200);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(180, 35);
            buttonBorrar.TabIndex = 7;
            buttonBorrar.Text = "BORRAR";
            buttonBorrar.UseVisualStyleBackColor = false;
            // 
            // buttonCrearRegistro
            // 
            buttonCrearRegistro.BackColor = Color.MediumSeaGreen;
            buttonCrearRegistro.FlatStyle = FlatStyle.Flat;
            buttonCrearRegistro.ForeColor = Color.White;
            buttonCrearRegistro.Location = new Point(600, 250);
            buttonCrearRegistro.Name = "buttonCrearRegistro";
            buttonCrearRegistro.Size = new Size(180, 35);
            buttonCrearRegistro.TabIndex = 8;
            buttonCrearRegistro.Text = "CREAR REGISTRO";
            buttonCrearRegistro.UseVisualStyleBackColor = false;
            // 
            // Registro_De_Proyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 400);
            Controls.Add(groupBoxDatos);
            Controls.Add(labelNombreProyecto);
            Controls.Add(textBoxNombreProyecto);
            Controls.Add(labelBodega);
            Controls.Add(textBoxBodega);
            Controls.Add(listBoxProyectos);
            Controls.Add(buttonInsertar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonCrearRegistro);
            Name = "Registro_De_Proyecto";
            Text = "Registro de Proyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}