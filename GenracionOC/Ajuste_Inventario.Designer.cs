namespace GenracionOC
{
    partial class Ajuste_Inventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxDatos = new GroupBox();
            groupBoxDetalle = new GroupBox();
            labelProyecto = new Label();
            labelFecha = new Label();
            labelAutoriza = new Label();
            labelCodigo = new Label();
            labelDescripcion = new Label();
            labelNAjuste = new Label();
            labelArea = new Label();
            labelCantidad = new Label();
            labelUnidad = new Label();
            labelObservacion = new Label();
            comboBoxProyecto = new ComboBox();
            comboBoxAutoriza = new ComboBox();
            comboBoxArea = new ComboBox();
            textBoxCodigo = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxNAjuste = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxUnidad = new TextBox();
            textBoxObservacion = new TextBox();
            dateTimePickerFecha = new DateTimePicker();
            listBoxDetalle = new ListBox();
            buttonInsertar = new Button();
            buttonBorrar = new Button();
            buttonGenerarPDF = new Button();
            SuspendLayout();
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.Transparent;
            groupBoxDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDatos.ForeColor = Color.DodgerBlue;
            groupBoxDatos.Location = new Point(20, 20);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(141, 24);
            groupBoxDatos.TabIndex = 0;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Text = "Datos Generales";
            // 
            // groupBoxDetalle
            // 
            groupBoxDetalle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBoxDetalle.BackColor = Color.Transparent;
            groupBoxDetalle.BackgroundImageLayout = ImageLayout.None;
            groupBoxDetalle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxDetalle.ForeColor = Color.DodgerBlue;
            groupBoxDetalle.Location = new Point(20, 190);
            groupBoxDetalle.Name = "groupBoxDetalle";
            groupBoxDetalle.Size = new Size(120, 23);
            groupBoxDetalle.TabIndex = 1;
            groupBoxDetalle.TabStop = false;
            groupBoxDetalle.Text = "Detalle";
            groupBoxDetalle.Enter += groupBoxDetalle_Enter;
            // 
            // labelProyecto
            // 
            labelProyecto.Location = new Point(40, 50);
            labelProyecto.Name = "labelProyecto";
            labelProyecto.Size = new Size(100, 23);
            labelProyecto.TabIndex = 2;
            labelProyecto.Text = "PROYECTO";
            // 
            // labelFecha
            // 
            labelFecha.Location = new Point(40, 90);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(125, 23);
            labelFecha.TabIndex = 6;
            labelFecha.Text = "FECHA DE REGISTRO";
            // 
            // labelAutoriza
            // 
            labelAutoriza.Location = new Point(400, 90);
            labelAutoriza.Name = "labelAutoriza";
            labelAutoriza.Size = new Size(100, 23);
            labelAutoriza.TabIndex = 8;
            labelAutoriza.Text = "QUIEN AUTORIZA";
            // 
            // labelCodigo
            // 
            labelCodigo.Location = new Point(400, 130);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(100, 23);
            labelCodigo.TabIndex = 12;
            labelCodigo.Text = "CÓDIGO";
            // 
            // labelDescripcion
            // 
            labelDescripcion.Location = new Point(40, 230);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(100, 23);
            labelDescripcion.TabIndex = 14;
            labelDescripcion.Text = "DESCRIPCIÓN";
            // 
            // labelNAjuste
            // 
            labelNAjuste.Location = new Point(400, 50);
            labelNAjuste.Name = "labelNAjuste";
            labelNAjuste.Size = new Size(100, 23);
            labelNAjuste.TabIndex = 4;
            labelNAjuste.Text = "N° AJUSTE";
            // 
            // labelArea
            // 
            labelArea.Location = new Point(40, 130);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(100, 23);
            labelArea.TabIndex = 10;
            labelArea.Text = "ÁREA";
            // 
            // labelCantidad
            // 
            labelCantidad.Location = new Point(40, 270);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(100, 23);
            labelCantidad.TabIndex = 16;
            labelCantidad.Text = "CANTIDAD";
            // 
            // labelUnidad
            // 
            labelUnidad.Location = new Point(400, 270);
            labelUnidad.Name = "labelUnidad";
            labelUnidad.Size = new Size(120, 23);
            labelUnidad.TabIndex = 18;
            labelUnidad.Text = "UNIDAD DE MEDIDA";
            // 
            // labelObservacion
            // 
            labelObservacion.Location = new Point(40, 400);
            labelObservacion.Name = "labelObservacion";
            labelObservacion.Size = new Size(180, 23);
            labelObservacion.TabIndex = 24;
            labelObservacion.Text = "OBSERVACIÓN GENERAL";
            // 
            // comboBoxProyecto
            // 
            comboBoxProyecto.Location = new Point(171, 50);
            comboBoxProyecto.Name = "comboBoxProyecto";
            comboBoxProyecto.Size = new Size(180, 23);
            comboBoxProyecto.TabIndex = 3;
            // 
            // comboBoxAutoriza
            // 
            comboBoxAutoriza.Location = new Point(510, 90);
            comboBoxAutoriza.Name = "comboBoxAutoriza";
            comboBoxAutoriza.Size = new Size(180, 23);
            comboBoxAutoriza.TabIndex = 9;
            // 
            // comboBoxArea
            // 
            comboBoxArea.Location = new Point(171, 130);
            comboBoxArea.Name = "comboBoxArea";
            comboBoxArea.Size = new Size(180, 23);
            comboBoxArea.TabIndex = 11;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(510, 130);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(180, 23);
            textBoxCodigo.TabIndex = 13;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(150, 230);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(540, 23);
            textBoxDescripcion.TabIndex = 15;
            // 
            // textBoxNAjuste
            // 
            textBoxNAjuste.Location = new Point(510, 50);
            textBoxNAjuste.Name = "textBoxNAjuste";
            textBoxNAjuste.Size = new Size(180, 23);
            textBoxNAjuste.TabIndex = 5;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(150, 270);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(180, 23);
            textBoxCantidad.TabIndex = 17;
            // 
            // textBoxUnidad
            // 
            textBoxUnidad.Location = new Point(530, 270);
            textBoxUnidad.Name = "textBoxUnidad";
            textBoxUnidad.Size = new Size(160, 23);
            textBoxUnidad.TabIndex = 19;
            // 
            // textBoxObservacion
            // 
            textBoxObservacion.Location = new Point(230, 400);
            textBoxObservacion.Name = "textBoxObservacion";
            textBoxObservacion.Size = new Size(280, 23);
            textBoxObservacion.TabIndex = 25;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(171, 90);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(180, 23);
            dateTimePickerFecha.TabIndex = 7;
            // 
            // listBoxDetalle
            // 
            listBoxDetalle.ItemHeight = 15;
            listBoxDetalle.Location = new Point(40, 310);
            listBoxDetalle.Name = "listBoxDetalle";
            listBoxDetalle.Size = new Size(650, 79);
            listBoxDetalle.TabIndex = 20;
            listBoxDetalle.SelectedIndexChanged += listBoxDetalle_SelectedIndexChanged;
            // 
            // buttonInsertar
            // 
            buttonInsertar.BackColor = Color.DodgerBlue;
            buttonInsertar.FlatStyle = FlatStyle.Flat;
            buttonInsertar.ForeColor = Color.White;
            buttonInsertar.Location = new Point(700, 310);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(80, 30);
            buttonInsertar.TabIndex = 21;
            buttonInsertar.Text = "INSERTAR";
            buttonInsertar.UseVisualStyleBackColor = false;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = Color.LightGray;
            buttonBorrar.FlatStyle = FlatStyle.Flat;
            buttonBorrar.ForeColor = Color.Black;
            buttonBorrar.Location = new Point(700, 350);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(80, 30);
            buttonBorrar.TabIndex = 22;
            buttonBorrar.Text = "BORRAR";
            buttonBorrar.UseVisualStyleBackColor = false;
            // 
            // buttonGenerarPDF
            // 
            buttonGenerarPDF.BackColor = Color.MediumSeaGreen;
            buttonGenerarPDF.FlatStyle = FlatStyle.Flat;
            buttonGenerarPDF.ForeColor = Color.White;
            buttonGenerarPDF.Location = new Point(530, 400);
            buttonGenerarPDF.Name = "buttonGenerarPDF";
            buttonGenerarPDF.Size = new Size(250, 35);
            buttonGenerarPDF.TabIndex = 23;
            buttonGenerarPDF.Text = "GUARDAR Y GENERAR PDF";
            buttonGenerarPDF.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 460);
            Controls.Add(groupBoxDatos);
            Controls.Add(groupBoxDetalle);
            Controls.Add(labelProyecto);
            Controls.Add(comboBoxProyecto);
            Controls.Add(labelNAjuste);
            Controls.Add(textBoxNAjuste);
            Controls.Add(labelFecha);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(labelAutoriza);
            Controls.Add(comboBoxAutoriza);
            Controls.Add(labelArea);
            Controls.Add(comboBoxArea);
            Controls.Add(labelCodigo);
            Controls.Add(textBoxCodigo);
            Controls.Add(labelDescripcion);
            Controls.Add(textBoxDescripcion);
            Controls.Add(labelCantidad);
            Controls.Add(textBoxCantidad);
            Controls.Add(labelUnidad);
            Controls.Add(textBoxUnidad);
            Controls.Add(listBoxDetalle);
            Controls.Add(buttonInsertar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonGenerarPDF);
            Controls.Add(labelObservacion);
            Controls.Add(textBoxObservacion);
            Name = "Form1";
            Text = "Generación de OC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.GroupBox groupBoxDetalle;
        private System.Windows.Forms.Label labelProyecto;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelAutoriza;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNAjuste;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelUnidad;
        private System.Windows.Forms.Label labelObservacion;
        private System.Windows.Forms.ComboBox comboBoxProyecto;
        private System.Windows.Forms.ComboBox comboBoxAutoriza;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNAjuste;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxUnidad;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.ListBox listBoxDetalle;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonGenerarPDF;
    }
}
