
namespace CapaPresentacion
{
    partial class formHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHorario));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnReporteHorarios = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnHorario_Insertar = new System.Windows.Forms.Button();
            this.txtHorario_horaFin = new System.Windows.Forms.TextBox();
            this.txtHorario_horaInicio = new System.Windows.Forms.TextBox();
            this.txtHorario_descripcion = new System.Windows.Forms.TextBox();
            this.lblHorario_horaFin = new System.Windows.Forms.Label();
            this.lblHora_Inicio = new System.Windows.Forms.Label();
            this.lblHorario_dia = new System.Windows.Forms.Label();
            this.lblHorario_descripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            this.btnReporteCursosHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(77, 405);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(133, 41);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(200, 132);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(128, 38);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Horario";
            // 
            // btnReporteHorarios
            // 
            this.btnReporteHorarios.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteHorarios.FlatAppearance.BorderSize = 0;
            this.btnReporteHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteHorarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteHorarios.Location = new System.Drawing.Point(711, 544);
            this.btnReporteHorarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteHorarios.Name = "btnReporteHorarios";
            this.btnReporteHorarios.Size = new System.Drawing.Size(168, 63);
            this.btnReporteHorarios.TabIndex = 41;
            this.btnReporteHorarios.Text = "Reporte Horarios";
            this.btnReporteHorarios.UseVisualStyleBackColor = false;
            this.btnReporteHorarios.Click += new System.EventHandler(this.btnReporteHorarioes_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(748, 136);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(131, 41);
            this.btnCargarDatos.TabIndex = 40;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(592, 150);
            this.cbxHorario.Margin = new System.Windows.Forms.Padding(2);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(152, 21);
            this.cbxHorario.TabIndex = 39;
            this.cbxHorario.SelectedIndexChanged += new System.EventHandler(this.cbxHorario_SelectedIndexChanged);
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(414, 189);
            this.dgvHorarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.RowHeadersWidth = 51;
            this.dgvHorarios.RowTemplate.Height = 24;
            this.dgvHorarios.Size = new System.Drawing.Size(466, 343);
            this.dgvHorarios.TabIndex = 38;
            this.dgvHorarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarioes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(77, 453);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 41);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnHorario_Insertar
            // 
            this.btnHorario_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHorario_Insertar.FlatAppearance.BorderSize = 0;
            this.btnHorario_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorario_Insertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorario_Insertar.Location = new System.Drawing.Point(77, 509);
            this.btnHorario_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnHorario_Insertar.Name = "btnHorario_Insertar";
            this.btnHorario_Insertar.Size = new System.Drawing.Size(133, 41);
            this.btnHorario_Insertar.TabIndex = 36;
            this.btnHorario_Insertar.Text = "Insertar";
            this.btnHorario_Insertar.UseVisualStyleBackColor = false;
            this.btnHorario_Insertar.Click += new System.EventHandler(this.btnHorario_Insertar_Click);
            // 
            // txtHorario_horaFin
            // 
            this.txtHorario_horaFin.Location = new System.Drawing.Point(184, 343);
            this.txtHorario_horaFin.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario_horaFin.Name = "txtHorario_horaFin";
            this.txtHorario_horaFin.Size = new System.Drawing.Size(201, 20);
            this.txtHorario_horaFin.TabIndex = 32;
            this.txtHorario_horaFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorario_horaFin_KeyPress);
            // 
            // txtHorario_horaInicio
            // 
            this.txtHorario_horaInicio.Location = new System.Drawing.Point(184, 317);
            this.txtHorario_horaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario_horaInicio.Name = "txtHorario_horaInicio";
            this.txtHorario_horaInicio.Size = new System.Drawing.Size(201, 20);
            this.txtHorario_horaInicio.TabIndex = 31;
            this.txtHorario_horaInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorario_horaInicio_KeyPress);
            // 
            // txtHorario_descripcion
            // 
            this.txtHorario_descripcion.Location = new System.Drawing.Point(184, 259);
            this.txtHorario_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario_descripcion.MaxLength = 20;
            this.txtHorario_descripcion.Name = "txtHorario_descripcion";
            this.txtHorario_descripcion.Size = new System.Drawing.Size(201, 20);
            this.txtHorario_descripcion.TabIndex = 29;
            this.txtHorario_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorario_descripcion_KeyPress);
            // 
            // lblHorario_horaFin
            // 
            this.lblHorario_horaFin.AutoSize = true;
            this.lblHorario_horaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_horaFin.Location = new System.Drawing.Point(74, 342);
            this.lblHorario_horaFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario_horaFin.Name = "lblHorario_horaFin";
            this.lblHorario_horaFin.Size = new System.Drawing.Size(74, 20);
            this.lblHorario_horaFin.TabIndex = 25;
            this.lblHorario_horaFin.Text = "Hora Fin:";
            // 
            // lblHora_Inicio
            // 
            this.lblHora_Inicio.AutoSize = true;
            this.lblHora_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora_Inicio.Location = new System.Drawing.Point(74, 315);
            this.lblHora_Inicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora_Inicio.Name = "lblHora_Inicio";
            this.lblHora_Inicio.Size = new System.Drawing.Size(89, 20);
            this.lblHora_Inicio.TabIndex = 24;
            this.lblHora_Inicio.Text = "Hora Inicio:";
            // 
            // lblHorario_dia
            // 
            this.lblHorario_dia.AutoSize = true;
            this.lblHorario_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_dia.Location = new System.Drawing.Point(74, 290);
            this.lblHorario_dia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario_dia.Name = "lblHorario_dia";
            this.lblHorario_dia.Size = new System.Drawing.Size(37, 20);
            this.lblHorario_dia.TabIndex = 23;
            this.lblHorario_dia.Text = "Dia:";
            // 
            // lblHorario_descripcion
            // 
            this.lblHorario_descripcion.AutoSize = true;
            this.lblHorario_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario_descripcion.Location = new System.Drawing.Point(74, 259);
            this.lblHorario_descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHorario_descripcion.Name = "lblHorario_descripcion";
            this.lblHorario_descripcion.Size = new System.Drawing.Size(88, 20);
            this.lblHorario_descripcion.TabIndex = 22;
            this.lblHorario_descripcion.Text = "Decripcion:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(77, 566);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 41);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Items.AddRange(new object[] {
            "L",
            "M",
            "I",
            "J",
            "V",
            "S",
            "D"});
            this.cbxDia.Location = new System.Drawing.Point(184, 292);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(201, 21);
            this.cbxDia.TabIndex = 46;
            this.cbxDia.SelectedIndexChanged += new System.EventHandler(this.cbxDia_SelectedIndexChanged);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(414, 146);
            this.chkbxMostrarEliminados.Name = "chkbxMostrarEliminados";
            this.chkbxMostrarEliminados.Size = new System.Drawing.Size(173, 25);
            this.chkbxMostrarEliminados.TabIndex = 47;
            this.chkbxMostrarEliminados.Text = "Mostrar Eliminados";
            this.chkbxMostrarEliminados.UseVisualStyleBackColor = true;
            this.chkbxMostrarEliminados.CheckedChanged += new System.EventHandler(this.chkbxMostrarEliminados_CheckedChanged);
            // 
            // btnActivarEliminado
            // 
            this.btnActivarEliminado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActivarEliminado.FlatAppearance.BorderSize = 0;
            this.btnActivarEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarEliminado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarEliminado.Location = new System.Drawing.Point(230, 540);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(155, 67);
            this.btnActivarEliminado.TabIndex = 48;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnReporteCursosHorario
            // 
            this.btnReporteCursosHorario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteCursosHorario.FlatAppearance.BorderSize = 0;
            this.btnReporteCursosHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCursosHorario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCursosHorario.Location = new System.Drawing.Point(441, 544);
            this.btnReporteCursosHorario.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteCursosHorario.Name = "btnReporteCursosHorario";
            this.btnReporteCursosHorario.Size = new System.Drawing.Size(231, 63);
            this.btnReporteCursosHorario.TabIndex = 49;
            this.btnReporteCursosHorario.Text = "Reporte \r\nCursos en Horario";
            this.btnReporteCursosHorario.UseVisualStyleBackColor = false;
            this.btnReporteCursosHorario.Click += new System.EventHandler(this.btnReporteCursosHorario_Click);
            // 
            // formHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 629);
            this.Controls.Add(this.btnReporteCursosHorario);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.cbxDia);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteHorarios);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.dgvHorarios);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnHorario_Insertar);
            this.Controls.Add(this.txtHorario_horaFin);
            this.Controls.Add(this.txtHorario_horaInicio);
            this.Controls.Add(this.txtHorario_descripcion);
            this.Controls.Add(this.lblHorario_horaFin);
            this.Controls.Add(this.lblHora_Inicio);
            this.Controls.Add(this.lblHorario_dia);
            this.Controls.Add(this.lblHorario_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formHorario";
            this.Text = "Sistema Matricula = Modulo Horario";
            this.Load += new System.EventHandler(this.formHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnReporteHorarios;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.DataGridView dgvHorarios;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnHorario_Insertar;
        private System.Windows.Forms.TextBox txtHorario_horaFin;
        private System.Windows.Forms.TextBox txtHorario_horaInicio;
        private System.Windows.Forms.TextBox txtHorario_descripcion;
        private System.Windows.Forms.Label lblHorario_horaFin;
        private System.Windows.Forms.Label lblHora_Inicio;
        private System.Windows.Forms.Label lblHorario_dia;
        private System.Windows.Forms.Label lblHorario_descripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxDia;
        private System.Windows.Forms.CheckBox chkbxMostrarEliminados;
        private System.Windows.Forms.Button btnActivarEliminado;
        private System.Windows.Forms.Button btnReporteCursosHorario;
    }
}