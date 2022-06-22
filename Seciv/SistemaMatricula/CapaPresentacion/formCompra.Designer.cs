
namespace CapaPresentacion
{
    partial class formCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCompra));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnReporteMatriculas = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxMatriculas = new System.Windows.Forms.ComboBox();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMatricula_Insertar = new System.Windows.Forms.Button();
            this.lblCurso_id = new System.Windows.Forms.Label();
            this.lblGrupo_id = new System.Windows.Forms.Label();
            this.lblEstudiante_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(67, 521);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(187, 50);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(231, 87);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(180, 47);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Compra";
            // 
            // btnReporteMatriculas
            // 
            this.btnReporteMatriculas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteMatriculas.FlatAppearance.BorderSize = 0;
            this.btnReporteMatriculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteMatriculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteMatriculas.Location = new System.Drawing.Point(887, 697);
            this.btnReporteMatriculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReporteMatriculas.Name = "btnReporteMatriculas";
            this.btnReporteMatriculas.Size = new System.Drawing.Size(343, 50);
            this.btnReporteMatriculas.TabIndex = 41;
            this.btnReporteMatriculas.Text = "Reporte Compras";
            this.btnReporteMatriculas.UseVisualStyleBackColor = false;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(953, 94);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(277, 50);
            this.btnCargarDatos.TabIndex = 40;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            // 
            // cbxMatriculas
            // 
            this.cbxMatriculas.FormattingEnabled = true;
            this.cbxMatriculas.Location = new System.Drawing.Point(729, 117);
            this.cbxMatriculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMatriculas.Name = "cbxMatriculas";
            this.cbxMatriculas.Size = new System.Drawing.Size(217, 24);
            this.cbxMatriculas.TabIndex = 39;
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(487, 158);
            this.dgvMatriculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.RowHeadersWidth = 51;
            this.dgvMatriculas.RowTemplate.Height = 24;
            this.dgvMatriculas.Size = new System.Drawing.Size(743, 519);
            this.dgvMatriculas.TabIndex = 38;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(279, 521);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(179, 50);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMatricula_Insertar
            // 
            this.btnMatricula_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMatricula_Insertar.FlatAppearance.BorderSize = 0;
            this.btnMatricula_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula_Insertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula_Insertar.Location = new System.Drawing.Point(67, 598);
            this.btnMatricula_Insertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMatricula_Insertar.Name = "btnMatricula_Insertar";
            this.btnMatricula_Insertar.Size = new System.Drawing.Size(187, 50);
            this.btnMatricula_Insertar.TabIndex = 36;
            this.btnMatricula_Insertar.Text = "Insertar";
            this.btnMatricula_Insertar.UseVisualStyleBackColor = false;
            this.btnMatricula_Insertar.Click += new System.EventHandler(this.btnMatricula_Insertar_Click);
            // 
            // lblCurso_id
            // 
            this.lblCurso_id.AutoSize = true;
            this.lblCurso_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_id.Location = new System.Drawing.Point(63, 287);
            this.lblCurso_id.Name = "lblCurso_id";
            this.lblCurso_id.Size = new System.Drawing.Size(78, 25);
            this.lblCurso_id.TabIndex = 24;
            this.lblCurso_id.Text = "Fecha :";
            // 
            // lblGrupo_id
            // 
            this.lblGrupo_id.AutoSize = true;
            this.lblGrupo_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo_id.Location = new System.Drawing.Point(61, 242);
            this.lblGrupo_id.Name = "lblGrupo_id";
            this.lblGrupo_id.Size = new System.Drawing.Size(78, 25);
            this.lblGrupo_id.TabIndex = 23;
            this.lblGrupo_id.Text = "Monto :";
            // 
            // lblEstudiante_id
            // 
            this.lblEstudiante_id.AutoSize = true;
            this.lblEstudiante_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_id.Location = new System.Drawing.Point(61, 197);
            this.lblEstudiante_id.Name = "lblEstudiante_id";
            this.lblEstudiante_id.Size = new System.Drawing.Size(156, 25);
            this.lblEstudiante_id.TabIndex = 22;
            this.lblEstudiante_id.Text = "Codigo Compra:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(67, 665);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(187, 50);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(487, 117);
            this.chkbxMostrarEliminados.Margin = new System.Windows.Forms.Padding(4);
            this.chkbxMostrarEliminados.Name = "chkbxMostrarEliminados";
            this.chkbxMostrarEliminados.Size = new System.Drawing.Size(211, 27);
            this.chkbxMostrarEliminados.TabIndex = 55;
            this.chkbxMostrarEliminados.Text = "Mostrar Eliminados";
            this.chkbxMostrarEliminados.UseVisualStyleBackColor = true;
            // 
            // btnActivarEliminado
            // 
            this.btnActivarEliminado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActivarEliminado.FlatAppearance.BorderSize = 0;
            this.btnActivarEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarEliminado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarEliminado.Location = new System.Drawing.Point(279, 576);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(179, 82);
            this.btnActivarEliminado.TabIndex = 54;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 200);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 245);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(303, 22);
            this.textBox2.TabIndex = 57;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 291);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(303, 22);
            this.textBox3.TabIndex = 58;
            // 
            // formCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 774);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteMatriculas);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxMatriculas);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMatricula_Insertar);
            this.Controls.Add(this.lblCurso_id);
            this.Controls.Add(this.lblGrupo_id);
            this.Controls.Add(this.lblEstudiante_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formCompra";
            this.Text = "Sistema Matricula = Modulo Matricula";
            this.Load += new System.EventHandler(this.formMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnReporteMatriculas;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxMatriculas;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMatricula_Insertar;
        private System.Windows.Forms.Label lblCurso_id;
        private System.Windows.Forms.Label lblGrupo_id;
        private System.Windows.Forms.Label lblEstudiante_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkbxMostrarEliminados;
        private System.Windows.Forms.Button btnActivarEliminado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}