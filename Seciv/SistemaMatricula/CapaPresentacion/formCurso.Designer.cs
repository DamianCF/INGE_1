
namespace CapaPresentacion
{
    partial class formCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCurso));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnReporteCursos = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCurso_Insertar = new System.Windows.Forms.Button();
            this.txtCurso_cupo = new System.Windows.Forms.TextBox();
            this.txtCurso_creditos = new System.Windows.Forms.TextBox();
            this.txtCurso_nombre = new System.Windows.Forms.TextBox();
            this.lblCurso_cupo = new System.Windows.Forms.Label();
            this.lblCurso_creditos = new System.Windows.Forms.Label();
            this.lblCurso_nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            this.btnReporteEstCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(44, 453);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(142, 41);
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
            this.Titulo.Location = new System.Drawing.Point(179, 81);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(105, 38);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Curso";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // btnReporteCursos
            // 
            this.btnReporteCursos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteCursos.FlatAppearance.BorderSize = 0;
            this.btnReporteCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCursos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCursos.Location = new System.Drawing.Point(689, 537);
            this.btnReporteCursos.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteCursos.Name = "btnReporteCursos";
            this.btnReporteCursos.Size = new System.Drawing.Size(230, 63);
            this.btnReporteCursos.TabIndex = 41;
            this.btnReporteCursos.Text = "Reporte Cursos";
            this.btnReporteCursos.UseVisualStyleBackColor = false;
            this.btnReporteCursos.Click += new System.EventHandler(this.btnReporteCursoes_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(752, 86);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(167, 50);
            this.btnCargarDatos.TabIndex = 40;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxCurso
            // 
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(614, 114);
            this.cbxCurso.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(134, 21);
            this.cbxCurso.TabIndex = 39;
            this.cbxCurso.SelectedIndexChanged += new System.EventHandler(this.cbxCurso_SelectedIndexChanged);
            // 
            // dgvCursos
            // 
            this.dgvCursos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(412, 139);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.RowHeadersWidth = 51;
            this.dgvCursos.RowTemplate.Height = 24;
            this.dgvCursos.Size = new System.Drawing.Size(507, 394);
            this.dgvCursos.TabIndex = 38;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursoes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(44, 400);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(142, 41);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCurso_Insertar
            // 
            this.btnCurso_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCurso_Insertar.FlatAppearance.BorderSize = 0;
            this.btnCurso_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso_Insertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso_Insertar.Location = new System.Drawing.Point(44, 508);
            this.btnCurso_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCurso_Insertar.Name = "btnCurso_Insertar";
            this.btnCurso_Insertar.Size = new System.Drawing.Size(142, 41);
            this.btnCurso_Insertar.TabIndex = 36;
            this.btnCurso_Insertar.Text = "Insertar";
            this.btnCurso_Insertar.UseVisualStyleBackColor = false;
            this.btnCurso_Insertar.Click += new System.EventHandler(this.btnCurso_Insertar_Click);
            // 
            // txtCurso_cupo
            // 
            this.txtCurso_cupo.Location = new System.Drawing.Point(205, 303);
            this.txtCurso_cupo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurso_cupo.MaxLength = 5;
            this.txtCurso_cupo.Name = "txtCurso_cupo";
            this.txtCurso_cupo.Size = new System.Drawing.Size(192, 20);
            this.txtCurso_cupo.TabIndex = 32;
            this.txtCurso_cupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurso_cupo_KeyPress);
            // 
            // txtCurso_creditos
            // 
            this.txtCurso_creditos.Location = new System.Drawing.Point(205, 276);
            this.txtCurso_creditos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurso_creditos.MaxLength = 4;
            this.txtCurso_creditos.Name = "txtCurso_creditos";
            this.txtCurso_creditos.Size = new System.Drawing.Size(192, 20);
            this.txtCurso_creditos.TabIndex = 31;
            this.txtCurso_creditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurso_creditos_KeyPress);
            // 
            // txtCurso_nombre
            // 
            this.txtCurso_nombre.Location = new System.Drawing.Point(205, 251);
            this.txtCurso_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurso_nombre.MaxLength = 50;
            this.txtCurso_nombre.Name = "txtCurso_nombre";
            this.txtCurso_nombre.Size = new System.Drawing.Size(192, 20);
            this.txtCurso_nombre.TabIndex = 30;
            this.txtCurso_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurso_nombre_KeyPress);
            // 
            // lblCurso_cupo
            // 
            this.lblCurso_cupo.AutoSize = true;
            this.lblCurso_cupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_cupo.Location = new System.Drawing.Point(79, 305);
            this.lblCurso_cupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso_cupo.Name = "lblCurso_cupo";
            this.lblCurso_cupo.Size = new System.Drawing.Size(51, 20);
            this.lblCurso_cupo.TabIndex = 25;
            this.lblCurso_cupo.Text = "Cupo:";
            // 
            // lblCurso_creditos
            // 
            this.lblCurso_creditos.AutoSize = true;
            this.lblCurso_creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_creditos.Location = new System.Drawing.Point(79, 278);
            this.lblCurso_creditos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso_creditos.Name = "lblCurso_creditos";
            this.lblCurso_creditos.Size = new System.Drawing.Size(72, 20);
            this.lblCurso_creditos.TabIndex = 24;
            this.lblCurso_creditos.Text = "Creditos:";
            // 
            // lblCurso_nombre
            // 
            this.lblCurso_nombre.AutoSize = true;
            this.lblCurso_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_nombre.Location = new System.Drawing.Point(79, 253);
            this.lblCurso_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso_nombre.Name = "lblCurso_nombre";
            this.lblCurso_nombre.Size = new System.Drawing.Size(69, 20);
            this.lblCurso_nombre.TabIndex = 23;
            this.lblCurso_nombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 107);
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
            this.btnEliminar.Location = new System.Drawing.Point(44, 568);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(142, 41);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(412, 111);
            this.chkbxMostrarEliminados.Name = "chkbxMostrarEliminados";
            this.chkbxMostrarEliminados.Size = new System.Drawing.Size(173, 25);
            this.chkbxMostrarEliminados.TabIndex = 46;
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
            this.btnActivarEliminado.Location = new System.Drawing.Point(232, 537);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(142, 72);
            this.btnActivarEliminado.TabIndex = 47;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnReporteEstCurso
            // 
            this.btnReporteEstCurso.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteEstCurso.FlatAppearance.BorderSize = 0;
            this.btnReporteEstCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteEstCurso.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEstCurso.Location = new System.Drawing.Point(412, 537);
            this.btnReporteEstCurso.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteEstCurso.Name = "btnReporteEstCurso";
            this.btnReporteEstCurso.Size = new System.Drawing.Size(231, 63);
            this.btnReporteEstCurso.TabIndex = 48;
            this.btnReporteEstCurso.Text = "Reporte \r\nLista Estudiantes";
            this.btnReporteEstCurso.UseVisualStyleBackColor = false;
            this.btnReporteEstCurso.Click += new System.EventHandler(this.btnReporteEstCurso_Click);
            // 
            // formCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 629);
            this.Controls.Add(this.btnReporteEstCurso);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteCursos);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCurso_Insertar);
            this.Controls.Add(this.txtCurso_cupo);
            this.Controls.Add(this.txtCurso_creditos);
            this.Controls.Add(this.txtCurso_nombre);
            this.Controls.Add(this.lblCurso_cupo);
            this.Controls.Add(this.lblCurso_creditos);
            this.Controls.Add(this.lblCurso_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCurso";
            this.Text = "Sistema Matricula = Modulo Curso";
            this.Load += new System.EventHandler(this.formCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnReporteCursos;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCurso_Insertar;
        private System.Windows.Forms.TextBox txtCurso_cupo;
        private System.Windows.Forms.TextBox txtCurso_creditos;
        private System.Windows.Forms.TextBox txtCurso_nombre;
        private System.Windows.Forms.Label lblCurso_cupo;
        private System.Windows.Forms.Label lblCurso_creditos;
        private System.Windows.Forms.Label lblCurso_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkbxMostrarEliminados;
        private System.Windows.Forms.Button btnActivarEliminado;
        private System.Windows.Forms.Button btnReporteEstCurso;
    }
}