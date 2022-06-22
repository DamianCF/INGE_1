
namespace CapaPresentacion
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pctrMazimizar = new System.Windows.Forms.PictureBox();
            this.pctrCerrar = new System.Windows.Forms.PictureBox();
            this.pctrMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnAulas = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pctrLogoCentral = new System.Windows.Forms.PictureBox();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMazimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMinimizar)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogoCentral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnEstudiantes.Location = new System.Drawing.Point(0, 68);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(450, 68);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Ventas";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.AutoSize = true;
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(81)))), ((int)(((byte)(97)))));
            this.pnlSuperior.Controls.Add(this.pctrMazimizar);
            this.pnlSuperior.Controls.Add(this.pctrCerrar);
            this.pnlSuperior.Controls.Add(this.pctrMinimizar);
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1685, 65);
            this.pnlSuperior.TabIndex = 7;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // pctrMazimizar
            // 
            this.pctrMazimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrMazimizar.Image = ((System.Drawing.Image)(resources.GetObject("pctrMazimizar.Image")));
            this.pctrMazimizar.Location = new System.Drawing.Point(1533, 9);
            this.pctrMazimizar.Margin = new System.Windows.Forms.Padding(4);
            this.pctrMazimizar.Name = "pctrMazimizar";
            this.pctrMazimizar.Size = new System.Drawing.Size(65, 49);
            this.pctrMazimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrMazimizar.TabIndex = 9;
            this.pctrMazimizar.TabStop = false;
            this.pctrMazimizar.Click += new System.EventHandler(this.pctrMazimizar_Click);
            // 
            // pctrCerrar
            // 
            this.pctrCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pctrCerrar.Image")));
            this.pctrCerrar.Location = new System.Drawing.Point(1607, 9);
            this.pctrCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.pctrCerrar.Name = "pctrCerrar";
            this.pctrCerrar.Size = new System.Drawing.Size(63, 49);
            this.pctrCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrCerrar.TabIndex = 1;
            this.pctrCerrar.TabStop = false;
            this.pctrCerrar.Click += new System.EventHandler(this.pctrCerrar_Click);
            // 
            // pctrMinimizar
            // 
            this.pctrMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pctrMinimizar.Image")));
            this.pctrMinimizar.Location = new System.Drawing.Point(1457, 9);
            this.pctrMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.pctrMinimizar.Name = "pctrMinimizar";
            this.pctrMinimizar.Size = new System.Drawing.Size(68, 52);
            this.pctrMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrMinimizar.TabIndex = 2;
            this.pctrMinimizar.TabStop = false;
            this.pctrMinimizar.Click += new System.EventHandler(this.pctrMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECIV";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnHorarios);
            this.panel2.Controls.Add(this.btnCursos);
            this.panel2.Controls.Add(this.btnAulas);
            this.panel2.Controls.Add(this.btnProfesores);
            this.panel2.Controls.Add(this.btnEstudiantes);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 773);
            this.panel2.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 705);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(450, 68);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Location = new System.Drawing.Point(0, 340);
            this.btnHorarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(450, 68);
            this.btnHorarios.TabIndex = 9;
            this.btnHorarios.Text = "Consultas Ventas";
            this.btnHorarios.UseVisualStyleBackColor = false;
            this.btnHorarios.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCursos.FlatAppearance.BorderSize = 0;
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.Location = new System.Drawing.Point(0, 272);
            this.btnCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(450, 68);
            this.btnCursos.TabIndex = 9;
            this.btnCursos.Text = "Consultas Compras";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnAulas
            // 
            this.btnAulas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAulas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAulas.FlatAppearance.BorderSize = 0;
            this.btnAulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAulas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAulas.ForeColor = System.Drawing.Color.White;
            this.btnAulas.Location = new System.Drawing.Point(0, 204);
            this.btnAulas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAulas.Name = "btnAulas";
            this.btnAulas.Size = new System.Drawing.Size(450, 68);
            this.btnAulas.TabIndex = 9;
            this.btnAulas.Text = "Inventario";
            this.btnAulas.UseVisualStyleBackColor = false;
            this.btnAulas.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesores.FlatAppearance.BorderSize = 0;
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.ForeColor = System.Drawing.Color.White;
            this.btnProfesores.Location = new System.Drawing.Point(0, 136);
            this.btnProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(450, 68);
            this.btnProfesores.TabIndex = 10;
            this.btnProfesores.Text = "Compras";
            this.btnProfesores.UseVisualStyleBackColor = false;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(450, 68);
            this.btnUsuario.TabIndex = 9;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pnlCentral
            // 
            this.pnlCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCentral.Controls.Add(this.pctrLogoCentral);
            this.pnlCentral.Location = new System.Drawing.Point(458, 64);
            this.pnlCentral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1227, 774);
            this.pnlCentral.TabIndex = 9;
            // 
            // pctrLogoCentral
            // 
            this.pctrLogoCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrLogoCentral.Image = ((System.Drawing.Image)(resources.GetObject("pctrLogoCentral.Image")));
            this.pctrLogoCentral.Location = new System.Drawing.Point(415, 187);
            this.pctrLogoCentral.Margin = new System.Windows.Forms.Padding(4);
            this.pctrLogoCentral.Name = "pctrLogoCentral";
            this.pctrLogoCentral.Size = new System.Drawing.Size(419, 417);
            this.pctrLogoCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrLogoCentral.TabIndex = 0;
            this.pctrLogoCentral.TabStop = false;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMazimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMinimizar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLogoCentral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pctrCerrar;
        private System.Windows.Forms.PictureBox pctrMazimizar;
        private System.Windows.Forms.PictureBox pctrMinimizar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnAulas;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.PictureBox pctrLogoCentral;
    }
}