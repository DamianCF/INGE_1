
namespace CapaPresentacion
{
    partial class formAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAula));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnReporteAulas = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.dgvAulas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAula_Insertar = new System.Windows.Forms.Button();
            this.txtAula_capacidad = new System.Windows.Forms.TextBox();
            this.txtAula_descripcion = new System.Windows.Forms.TextBox();
            this.lblAula_capacidad = new System.Windows.Forms.Label();
            this.lblAula_descricion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(26, 300);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 50);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(151, 80);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(89, 38);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Aula";
            // 
            // btnReporteAulas
            // 
            this.btnReporteAulas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteAulas.FlatAppearance.BorderSize = 0;
            this.btnReporteAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAulas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteAulas.Location = new System.Drawing.Point(760, 544);
            this.btnReporteAulas.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteAulas.Name = "btnReporteAulas";
            this.btnReporteAulas.Size = new System.Drawing.Size(175, 63);
            this.btnReporteAulas.TabIndex = 41;
            this.btnReporteAulas.Text = "Reporte Aulas";
            this.btnReporteAulas.UseVisualStyleBackColor = false;
            this.btnReporteAulas.Click += new System.EventHandler(this.btnReporteAulas_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(760, 38);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(175, 50);
            this.btnCargarDatos.TabIndex = 40;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click_1);
            // 
            // cbxAula
            // 
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(537, 67);
            this.cbxAula.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(208, 21);
            this.cbxAula.TabIndex = 39;
            this.cbxAula.SelectedIndexChanged += new System.EventHandler(this.cbxAula_SelectedIndexChanged);
            // 
            // dgvAulas
            // 
            this.dgvAulas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAulas.Location = new System.Drawing.Point(334, 101);
            this.dgvAulas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAulas.Name = "dgvAulas";
            this.dgvAulas.RowHeadersWidth = 51;
            this.dgvAulas.RowTemplate.Height = 24;
            this.dgvAulas.Size = new System.Drawing.Size(601, 439);
            this.dgvAulas.TabIndex = 38;
            this.dgvAulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAulaes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(26, 369);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(151, 50);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAula_Insertar
            // 
            this.btnAula_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAula_Insertar.FlatAppearance.BorderSize = 0;
            this.btnAula_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAula_Insertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAula_Insertar.Location = new System.Drawing.Point(26, 437);
            this.btnAula_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAula_Insertar.Name = "btnAula_Insertar";
            this.btnAula_Insertar.Size = new System.Drawing.Size(151, 50);
            this.btnAula_Insertar.TabIndex = 36;
            this.btnAula_Insertar.Text = "Insertar";
            this.btnAula_Insertar.UseVisualStyleBackColor = false;
            this.btnAula_Insertar.Click += new System.EventHandler(this.btnAula_Insertar_Click_1);
            // 
            // txtAula_capacidad
            // 
            this.txtAula_capacidad.Location = new System.Drawing.Point(26, 265);
            this.txtAula_capacidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtAula_capacidad.MaxLength = 10;
            this.txtAula_capacidad.Name = "txtAula_capacidad";
            this.txtAula_capacidad.Size = new System.Drawing.Size(294, 20);
            this.txtAula_capacidad.TabIndex = 30;
            this.txtAula_capacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAula_capacidad_KeyPress);
            // 
            // txtAula_descripcion
            // 
            this.txtAula_descripcion.Location = new System.Drawing.Point(26, 211);
            this.txtAula_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtAula_descripcion.MaxLength = 20;
            this.txtAula_descripcion.Name = "txtAula_descripcion";
            this.txtAula_descripcion.Size = new System.Drawing.Size(294, 20);
            this.txtAula_descripcion.TabIndex = 29;
            this.txtAula_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAula_descripcion_KeyPress);
            // 
            // lblAula_capacidad
            // 
            this.lblAula_capacidad.AutoSize = true;
            this.lblAula_capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula_capacidad.Location = new System.Drawing.Point(22, 243);
            this.lblAula_capacidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAula_capacidad.Name = "lblAula_capacidad";
            this.lblAula_capacidad.Size = new System.Drawing.Size(188, 20);
            this.lblAula_capacidad.TabIndex = 23;
            this.lblAula_capacidad.Text = "Cantidad de Estudiantes:";
            // 
            // lblAula_descricion
            // 
            this.lblAula_descricion.AutoSize = true;
            this.lblAula_descricion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAula_descricion.Location = new System.Drawing.Point(22, 186);
            this.lblAula_descricion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAula_descricion.Name = "lblAula_descricion";
            this.lblAula_descricion.Size = new System.Drawing.Size(96, 20);
            this.lblAula_descricion.TabIndex = 22;
            this.lblAula_descricion.Text = "Descripcion:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 82);
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
            this.btnEliminar.Location = new System.Drawing.Point(26, 507);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 50);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(334, 63);
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
            this.btnActivarEliminado.Location = new System.Drawing.Point(26, 565);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(151, 53);
            this.btnActivarEliminado.TabIndex = 48;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // formAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 629);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteAulas);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.dgvAulas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAula_Insertar);
            this.Controls.Add(this.txtAula_capacidad);
            this.Controls.Add(this.txtAula_descripcion);
            this.Controls.Add(this.lblAula_capacidad);
            this.Controls.Add(this.lblAula_descricion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAula";
            this.Text = "Sistema Matricula = Modulo Profesor";
            this.Load += new System.EventHandler(this.formAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnReporteAulas;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.DataGridView dgvAulas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAula_Insertar;
        private System.Windows.Forms.TextBox txtAula_capacidad;
        private System.Windows.Forms.TextBox txtAula_descripcion;
        private System.Windows.Forms.Label lblAula_capacidad;
        private System.Windows.Forms.Label lblAula_descricion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkbxMostrarEliminados;
        private System.Windows.Forms.Button btnActivarEliminado;
    }
}