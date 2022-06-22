
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    partial class formVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVenta));
            this.lblProfesor_cedula = new System.Windows.Forms.Label();
            this.lblProfesor_nombre = new System.Windows.Forms.Label();
            this.lblProfesor_primerApellido = new System.Windows.Forms.Label();
            this.lblProfesor_segundoApellido = new System.Windows.Forms.Label();
            this.txtProfesor_cedula = new System.Windows.Forms.TextBox();
            this.txtProfesor_nombre = new System.Windows.Forms.TextBox();
            this.txtProfesor_segundoApellido = new System.Windows.Forms.TextBox();
            this.txtProfesor_primerApellido = new System.Windows.Forms.TextBox();
            this.btnProfesor_Insertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.cbxProfesor = new System.Windows.Forms.ComboBox();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnReporteProfesores = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporteCursosProfesor = new System.Windows.Forms.Button();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfesor_cedula
            // 
            this.lblProfesor_cedula.AutoSize = true;
            this.lblProfesor_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_cedula.Location = new System.Drawing.Point(20, 132);
            this.lblProfesor_cedula.Name = "lblProfesor_cedula";
            this.lblProfesor_cedula.Size = new System.Drawing.Size(152, 25);
            this.lblProfesor_cedula.TabIndex = 0;
            this.lblProfesor_cedula.Text = "Codigo Factura:";
            // 
            // lblProfesor_nombre
            // 
            this.lblProfesor_nombre.AutoSize = true;
            this.lblProfesor_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_nombre.Location = new System.Drawing.Point(20, 175);
            this.lblProfesor_nombre.Name = "lblProfesor_nombre";
            this.lblProfesor_nombre.Size = new System.Drawing.Size(119, 25);
            this.lblProfesor_nombre.TabIndex = 1;
            this.lblProfesor_nombre.Text = "Total Venta:";
            // 
            // lblProfesor_primerApellido
            // 
            this.lblProfesor_primerApellido.AutoSize = true;
            this.lblProfesor_primerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_primerApellido.Location = new System.Drawing.Point(20, 218);
            this.lblProfesor_primerApellido.Name = "lblProfesor_primerApellido";
            this.lblProfesor_primerApellido.Size = new System.Drawing.Size(130, 25);
            this.lblProfesor_primerApellido.TabIndex = 2;
            this.lblProfesor_primerApellido.Text = "Fecha Venta:";
            // 
            // lblProfesor_segundoApellido
            // 
            this.lblProfesor_segundoApellido.AutoSize = true;
            this.lblProfesor_segundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor_segundoApellido.Location = new System.Drawing.Point(20, 287);
            this.lblProfesor_segundoApellido.Name = "lblProfesor_segundoApellido";
            this.lblProfesor_segundoApellido.Size = new System.Drawing.Size(141, 25);
            this.lblProfesor_segundoApellido.TabIndex = 3;
            this.lblProfesor_segundoApellido.Text = "Factura Venta:";
            // 
            // txtProfesor_cedula
            // 
            this.txtProfesor_cedula.Location = new System.Drawing.Point(172, 132);
            this.txtProfesor_cedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_cedula.MaxLength = 50;
            this.txtProfesor_cedula.Name = "txtProfesor_cedula";
            this.txtProfesor_cedula.Size = new System.Drawing.Size(193, 22);
            this.txtProfesor_cedula.TabIndex = 7;
            this.txtProfesor_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_cedula_KeyPress);
            // 
            // txtProfesor_nombre
            // 
            this.txtProfesor_nombre.Location = new System.Drawing.Point(142, 178);
            this.txtProfesor_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_nombre.MaxLength = 50;
            this.txtProfesor_nombre.Name = "txtProfesor_nombre";
            this.txtProfesor_nombre.Size = new System.Drawing.Size(223, 22);
            this.txtProfesor_nombre.TabIndex = 8;
            this.txtProfesor_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_nombre_KeyPress);
            // 
            // txtProfesor_segundoApellido
            // 
            this.txtProfesor_segundoApellido.Location = new System.Drawing.Point(25, 319);
            this.txtProfesor_segundoApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_segundoApellido.MaxLength = 50;
            this.txtProfesor_segundoApellido.Name = "txtProfesor_segundoApellido";
            this.txtProfesor_segundoApellido.Size = new System.Drawing.Size(340, 22);
            this.txtProfesor_segundoApellido.TabIndex = 10;
            this.txtProfesor_segundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_segundoApellido_KeyPress);
            // 
            // txtProfesor_primerApellido
            // 
            this.txtProfesor_primerApellido.Location = new System.Drawing.Point(25, 249);
            this.txtProfesor_primerApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor_primerApellido.MaxLength = 50;
            this.txtProfesor_primerApellido.Name = "txtProfesor_primerApellido";
            this.txtProfesor_primerApellido.Size = new System.Drawing.Size(340, 22);
            this.txtProfesor_primerApellido.TabIndex = 9;
            this.txtProfesor_primerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProfesor_primerApellido_KeyPress);
            // 
            // btnProfesor_Insertar
            // 
            this.btnProfesor_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProfesor_Insertar.FlatAppearance.BorderSize = 0;
            this.btnProfesor_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor_Insertar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor_Insertar.Location = new System.Drawing.Point(23, 619);
            this.btnProfesor_Insertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfesor_Insertar.Name = "btnProfesor_Insertar";
            this.btnProfesor_Insertar.Size = new System.Drawing.Size(325, 62);
            this.btnProfesor_Insertar.TabIndex = 14;
            this.btnProfesor_Insertar.Text = "Insertar";
            this.btnProfesor_Insertar.UseVisualStyleBackColor = false;
            this.btnProfesor_Insertar.Click += new System.EventHandler(this.btnProfesor_Insertar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(196, 537);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(152, 60);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Location = new System.Drawing.Point(392, 112);
            this.dgvProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.RowHeadersWidth = 51;
            this.dgvProfesores.RowTemplate.Height = 24;
            this.dgvProfesores.Size = new System.Drawing.Size(872, 553);
            this.dgvProfesores.TabIndex = 16;
            this.dgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            this.dgvProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellContentClick);
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.FormattingEnabled = true;
            this.cbxProfesor.Location = new System.Drawing.Point(683, 73);
            this.cbxProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(275, 24);
            this.cbxProfesor.TabIndex = 17;
            this.cbxProfesor.SelectedIndexChanged += new System.EventHandler(this.cbxProfesor_SelectedIndexChanged);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(964, 38);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(300, 62);
            this.btnCargarDatos.TabIndex = 18;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnReporteProfesores
            // 
            this.btnReporteProfesores.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteProfesores.FlatAppearance.BorderSize = 0;
            this.btnReporteProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteProfesores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProfesores.Location = new System.Drawing.Point(996, 681);
            this.btnReporteProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteProfesores.Name = "btnReporteProfesores";
            this.btnReporteProfesores.Size = new System.Drawing.Size(268, 80);
            this.btnReporteProfesores.TabIndex = 19;
            this.btnReporteProfesores.Text = "Reporte Ventas";
            this.btnReporteProfesores.UseVisualStyleBackColor = false;
            this.btnReporteProfesores.Click += new System.EventHandler(this.btnReporteProfesores_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(164, 26);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(154, 47);
            this.Titulo.TabIndex = 20;
            this.Titulo.Text = "Ventas";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(25, 537);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 62);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(23, 700);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(325, 63);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporteCursosProfesor
            // 
            this.btnReporteCursosProfesor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteCursosProfesor.FlatAppearance.BorderSize = 0;
            this.btnReporteCursosProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCursosProfesor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCursosProfesor.Location = new System.Drawing.Point(651, 681);
            this.btnReporteCursosProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteCursosProfesor.Name = "btnReporteCursosProfesor";
            this.btnReporteCursosProfesor.Size = new System.Drawing.Size(308, 82);
            this.btnReporteCursosProfesor.TabIndex = 24;
            this.btnReporteCursosProfesor.Text = "Reporte Ventas Diarias";
            this.btnReporteCursosProfesor.UseVisualStyleBackColor = false;
            this.btnReporteCursosProfesor.Click += new System.EventHandler(this.btnReporteCursosProfesor_Click);
            // 
            // btnActivarEliminado
            // 
            this.btnActivarEliminado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActivarEliminado.FlatAppearance.BorderSize = 0;
            this.btnActivarEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarEliminado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarEliminado.Location = new System.Drawing.Point(392, 681);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(207, 82);
            this.btnActivarEliminado.TabIndex = 25;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(392, 73);
            this.chkbxMostrarEliminados.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxMostrarEliminados.Name = "chkbxMostrarEliminados";
            this.chkbxMostrarEliminados.Size = new System.Drawing.Size(211, 27);
            this.chkbxMostrarEliminados.TabIndex = 26;
            this.chkbxMostrarEliminados.Text = "Mostrar Eliminados";
            this.chkbxMostrarEliminados.UseVisualStyleBackColor = true;
            this.chkbxMostrarEliminados.CheckedChanged += new System.EventHandler(this.chkbxMostrarEliminados_CheckedChanged);
            // 
            // formVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 774);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.btnReporteCursosProfesor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteProfesores);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxProfesor);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnProfesor_Insertar);
            this.Controls.Add(this.txtProfesor_segundoApellido);
            this.Controls.Add(this.txtProfesor_primerApellido);
            this.Controls.Add(this.txtProfesor_nombre);
            this.Controls.Add(this.txtProfesor_cedula);
            this.Controls.Add(this.lblProfesor_segundoApellido);
            this.Controls.Add(this.lblProfesor_primerApellido);
            this.Controls.Add(this.lblProfesor_nombre);
            this.Controls.Add(this.lblProfesor_cedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formVenta";
            this.Text = "Sistema Matricula = Modulo Profesor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label lblProfesor_cedula;
        private System.Windows.Forms.Label lblProfesor_nombre;
        private System.Windows.Forms.Label lblProfesor_primerApellido;
        private System.Windows.Forms.Label lblProfesor_segundoApellido;
        private System.Windows.Forms.TextBox txtProfesor_cedula;
        private System.Windows.Forms.TextBox txtProfesor_nombre;
        private System.Windows.Forms.TextBox txtProfesor_segundoApellido;
        private System.Windows.Forms.TextBox txtProfesor_primerApellido;
        private System.Windows.Forms.Button btnProfesor_Insertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.ComboBox cbxProfesor;
        private System.Windows.Forms.Button btnCargarDatos;
        private Button btnReporteProfesores;
        private Label Titulo;
        private Button btnLimpiar;
        private PictureBox pictureBox1;
        private Button btnEliminar;
        private Button btnReporteCursosProfesor;
        private Button btnActivarEliminado;
        private CheckBox chkbxMostrarEliminados;
    }
}

