
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMatricula_Insertar = new System.Windows.Forms.Button();
            this.lblCurso_id = new System.Windows.Forms.Label();
            this.lblGrupo_id = new System.Windows.Forms.Label();
            this.lblEstudiante_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodCompra = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(50, 423);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 41);
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
            this.Titulo.Location = new System.Drawing.Point(173, 71);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(144, 38);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Compra";
            // 
            // dgvCompras
            // 
            this.dgvCompras.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(365, 128);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(557, 461);
            this.dgvCompras.TabIndex = 38;
            this.dgvCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(51, 362);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 41);
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
            this.btnMatricula_Insertar.Location = new System.Drawing.Point(50, 486);
            this.btnMatricula_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMatricula_Insertar.Name = "btnMatricula_Insertar";
            this.btnMatricula_Insertar.Size = new System.Drawing.Size(140, 41);
            this.btnMatricula_Insertar.TabIndex = 36;
            this.btnMatricula_Insertar.Text = "Insertar";
            this.btnMatricula_Insertar.UseVisualStyleBackColor = false;
            this.btnMatricula_Insertar.Click += new System.EventHandler(this.btnMatricula_Insertar_Click);
            // 
            // lblCurso_id
            // 
            this.lblCurso_id.AutoSize = true;
            this.lblCurso_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso_id.Location = new System.Drawing.Point(47, 233);
            this.lblCurso_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurso_id.Name = "lblCurso_id";
            this.lblCurso_id.Size = new System.Drawing.Size(62, 20);
            this.lblCurso_id.TabIndex = 24;
            this.lblCurso_id.Text = "Fecha :";
            // 
            // lblGrupo_id
            // 
            this.lblGrupo_id.AutoSize = true;
            this.lblGrupo_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo_id.Location = new System.Drawing.Point(46, 197);
            this.lblGrupo_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrupo_id.Name = "lblGrupo_id";
            this.lblGrupo_id.Size = new System.Drawing.Size(62, 20);
            this.lblGrupo_id.TabIndex = 23;
            this.lblGrupo_id.Text = "Monto :";
            // 
            // lblEstudiante_id
            // 
            this.lblEstudiante_id.AutoSize = true;
            this.lblEstudiante_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_id.Location = new System.Drawing.Point(46, 160);
            this.lblEstudiante_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_id.Name = "lblEstudiante_id";
            this.lblEstudiante_id.Size = new System.Drawing.Size(123, 20);
            this.lblEstudiante_id.TabIndex = 22;
            this.lblEstudiante_id.Text = "Codigo Compra:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 83);
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
            this.btnEliminar.Location = new System.Drawing.Point(50, 540);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 41);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCodCompra
            // 
            this.txtCodCompra.Location = new System.Drawing.Point(164, 162);
            this.txtCodCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCompra.MaxLength = 100;
            this.txtCodCompra.Name = "txtCodCompra";
            this.txtCodCompra.Size = new System.Drawing.Size(179, 20);
            this.txtCodCompra.TabIndex = 56;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(115, 199);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.MaxLength = 100;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(228, 20);
            this.txtMonto.TabIndex = 57;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(115, 236);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.MaxLength = 100;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(228, 20);
            this.txtFecha.TabIndex = 58;
            // 
            // formCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCodCompra);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMatricula_Insertar);
            this.Controls.Add(this.lblCurso_id);
            this.Controls.Add(this.lblGrupo_id);
            this.Controls.Add(this.lblEstudiante_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema Matricula = Modulo Matricula";
            this.Load += new System.EventHandler(this.formMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMatricula_Insertar;
        private System.Windows.Forms.Label lblCurso_id;
        private System.Windows.Forms.Label lblGrupo_id;
        private System.Windows.Forms.Label lblEstudiante_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCodCompra;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtFecha;
    }
}