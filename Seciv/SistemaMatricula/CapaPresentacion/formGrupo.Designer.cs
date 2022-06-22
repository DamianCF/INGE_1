
namespace CapaPresentacion
{
    partial class formGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGrupo));
            this.Titulo = new System.Windows.Forms.Label();
            this.btnReporteGrupos = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGrupo_Insertar = new System.Windows.Forms.Button();
            this.txtGrupo_descripcion = new System.Windows.Forms.TextBox();
            this.lblGrupo_descripcion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(215, 130);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(114, 38);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Grupo";
            // 
            // btnReporteGrupos
            // 
            this.btnReporteGrupos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteGrupos.FlatAppearance.BorderSize = 0;
            this.btnReporteGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteGrupos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGrupos.Location = new System.Drawing.Point(664, 549);
            this.btnReporteGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteGrupos.Name = "btnReporteGrupos";
            this.btnReporteGrupos.Size = new System.Drawing.Size(196, 41);
            this.btnReporteGrupos.TabIndex = 41;
            this.btnReporteGrupos.Text = "Reporte Grupos";
            this.btnReporteGrupos.UseVisualStyleBackColor = false;
            this.btnReporteGrupos.Click += new System.EventHandler(this.btnReporteGrupoes_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(712, 121);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(149, 41);
            this.btnCargarDatos.TabIndex = 40;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(579, 141);
            this.cbxGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(129, 21);
            this.cbxGrupo.TabIndex = 39;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(395, 169);
            this.dgvGrupos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.RowHeadersWidth = 51;
            this.dgvGrupos.RowTemplate.Height = 24;
            this.dgvGrupos.Size = new System.Drawing.Size(466, 366);
            this.dgvGrupos.TabIndex = 38;
            this.dgvGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupoes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(100, 332);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(162, 38);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGrupo_Insertar
            // 
            this.btnGrupo_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGrupo_Insertar.FlatAppearance.BorderSize = 0;
            this.btnGrupo_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupo_Insertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupo_Insertar.Location = new System.Drawing.Point(100, 395);
            this.btnGrupo_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrupo_Insertar.Name = "btnGrupo_Insertar";
            this.btnGrupo_Insertar.Size = new System.Drawing.Size(162, 41);
            this.btnGrupo_Insertar.TabIndex = 36;
            this.btnGrupo_Insertar.Text = "Insertar";
            this.btnGrupo_Insertar.UseVisualStyleBackColor = false;
            this.btnGrupo_Insertar.Click += new System.EventHandler(this.btnGrupo_Insertar_Click);
            // 
            // txtGrupo_descripcion
            // 
            this.txtGrupo_descripcion.Location = new System.Drawing.Point(191, 227);
            this.txtGrupo_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrupo_descripcion.MaxLength = 20;
            this.txtGrupo_descripcion.Name = "txtGrupo_descripcion";
            this.txtGrupo_descripcion.Size = new System.Drawing.Size(187, 20);
            this.txtGrupo_descripcion.TabIndex = 29;
            this.txtGrupo_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupo_descripcion_KeyPress);
            // 
            // lblGrupo_descripcion
            // 
            this.lblGrupo_descripcion.AutoSize = true;
            this.lblGrupo_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo_descripcion.Location = new System.Drawing.Point(97, 223);
            this.lblGrupo_descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupo_descripcion.Name = "lblGrupo_descripcion";
            this.lblGrupo_descripcion.Size = new System.Drawing.Size(96, 20);
            this.lblGrupo_descripcion.TabIndex = 22;
            this.lblGrupo_descripcion.Text = "Descripcion:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(100, 268);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 41);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 92);
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
            this.btnEliminar.Location = new System.Drawing.Point(100, 459);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 50);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(395, 137);
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
            this.btnActivarEliminado.Location = new System.Drawing.Point(100, 536);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(162, 67);
            this.btnActivarEliminado.TabIndex = 47;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // formGrupo
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
            this.Controls.Add(this.btnReporteGrupos);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGrupo_Insertar);
            this.Controls.Add(this.txtGrupo_descripcion);
            this.Controls.Add(this.lblGrupo_descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formGrupo";
            this.Text = "Sistema Matricula = Modulo Grupo";
            this.Load += new System.EventHandler(this.formGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnReporteGrupos;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGrupo_Insertar;
        private System.Windows.Forms.TextBox txtGrupo_descripcion;
        private System.Windows.Forms.Label lblGrupo_descripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkbxMostrarEliminados;
        private System.Windows.Forms.Button btnActivarEliminado;
    }
}