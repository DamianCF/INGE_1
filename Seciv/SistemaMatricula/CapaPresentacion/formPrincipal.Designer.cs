﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
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
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnEstudiantes.Location = new System.Drawing.Point(0, 68);
            this.btnEstudiantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(451, 68);
            this.btnEstudiantes.TabIndex = 0;
            this.btnEstudiantes.Text = "Ventas";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.AutoSize = true;
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(120)))), ((int)(((byte)(147)))));
            this.pnlSuperior.Controls.Add(this.pctrMazimizar);
            this.pnlSuperior.Controls.Add(this.pctrCerrar);
            this.pnlSuperior.Controls.Add(this.pctrMinimizar);
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1867, 65);
            this.pnlSuperior.TabIndex = 7;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // pctrMazimizar
            // 
            this.pctrMazimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrMazimizar.Image = ((System.Drawing.Image)(resources.GetObject("pctrMazimizar.Image")));
            this.pctrMazimizar.Location = new System.Drawing.Point(1715, 9);
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
            this.pctrCerrar.Location = new System.Drawing.Point(1788, 9);
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
            this.pctrMinimizar.Location = new System.Drawing.Point(1639, 9);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECIV";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnProveedores);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnProfesores);
            this.panel2.Controls.Add(this.btnEstudiantes);
            this.panel2.Controls.Add(this.btnUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 920);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 68);
            this.button1.TabIndex = 13;
            this.button1.Text = "Contable";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(0, 272);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(451, 68);
            this.btnProveedores.TabIndex = 12;
            this.btnProveedores.Text = "Envios-Apartados";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(120)))), ((int)(((byte)(147)))));
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 852);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(451, 68);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(141)))), ((int)(((byte)(152)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 204);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(451, 68);
            this.btnProductos.TabIndex = 9;
            this.btnProductos.Text = "Inventario";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnAulas_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesores.FlatAppearance.BorderSize = 0;
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.ForeColor = System.Drawing.Color.White;
            this.btnProfesores.Location = new System.Drawing.Point(0, 136);
            this.btnProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(451, 68);
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
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(451, 68);
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
            this.pnlCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.pnlCentral.Controls.Add(this.pctrLogoCentral);
            this.pnlCentral.Location = new System.Drawing.Point(459, 64);
            this.pnlCentral.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(1707, 971);
            this.pnlCentral.TabIndex = 9;
            // 
            // pctrLogoCentral
            // 
            this.pctrLogoCentral.Image = ((System.Drawing.Image)(resources.GetObject("pctrLogoCentral.Image")));
            this.pctrLogoCentral.Location = new System.Drawing.Point(383, 255);
            this.pctrLogoCentral.Margin = new System.Windows.Forms.Padding(4);
            this.pctrLogoCentral.Name = "pctrLogoCentral";
            this.pctrLogoCentral.Size = new System.Drawing.Size(588, 431);
            this.pctrLogoCentral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrLogoCentral.TabIndex = 0;
            this.pctrLogoCentral.TabStop = false;
            this.pctrLogoCentral.Click += new System.EventHandler(this.pctrLogoCentral_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1867, 985);
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
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.PictureBox pctrLogoCentral;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button button1;
    }
}