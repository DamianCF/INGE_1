
namespace CapaPresentacion
{
    partial class formUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUsuario));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtUsuario_direccion = new System.Windows.Forms.TextBox();
            this.txtUsuario_correoElectronico = new System.Windows.Forms.TextBox();
            this.txtUsuario_telefono = new System.Windows.Forms.TextBox();
            this.txtUsuario_segundoApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario_primerApellido = new System.Windows.Forms.TextBox();
            this.txtUsuario_nombre = new System.Windows.Forms.TextBox();
            this.txtUsuario_cedula = new System.Windows.Forms.TextBox();
            this.lblUsuario_direccion = new System.Windows.Forms.Label();
            this.lblUsuario_correoElectronico = new System.Windows.Forms.Label();
            this.lblUsuario_telefono = new System.Windows.Forms.Label();
            this.lblUsuario_segundoApellido = new System.Windows.Forms.Label();
            this.lblUsuario_primerApellido = new System.Windows.Forms.Label();
            this.lblUsuario_nombre = new System.Windows.Forms.Label();
            this.lblUsuario_cedula = new System.Windows.Forms.Label();
            this.chkbxAdministrador = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContreseña = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(666, 380);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(244, 51);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar Usuario";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Titulo.Location = new System.Drawing.Point(394, 35);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(129, 38);
            this.Titulo.TabIndex = 40;
            this.Titulo.Text = "Usuario";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(666, 307);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(244, 49);
            this.btnModificar.TabIndex = 39;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(332, 451);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(256, 50);
            this.btnRegistrar.TabIndex = 38;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtUsuario_direccion
            // 
            this.txtUsuario_direccion.Location = new System.Drawing.Point(332, 403);
            this.txtUsuario_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_direccion.MaxLength = 50;
            this.txtUsuario_direccion.Name = "txtUsuario_direccion";
            this.txtUsuario_direccion.Size = new System.Drawing.Size(256, 20);
            this.txtUsuario_direccion.TabIndex = 37;
            this.txtUsuario_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_direccion_KeyPress);
            // 
            // txtUsuario_correoElectronico
            // 
            this.txtUsuario_correoElectronico.Location = new System.Drawing.Point(332, 358);
            this.txtUsuario_correoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_correoElectronico.MaxLength = 50;
            this.txtUsuario_correoElectronico.Name = "txtUsuario_correoElectronico";
            this.txtUsuario_correoElectronico.Size = new System.Drawing.Size(256, 20);
            this.txtUsuario_correoElectronico.TabIndex = 36;
            this.txtUsuario_correoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_correoElectronico_KeyPress);
            // 
            // txtUsuario_telefono
            // 
            this.txtUsuario_telefono.Location = new System.Drawing.Point(401, 300);
            this.txtUsuario_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_telefono.MaxLength = 20;
            this.txtUsuario_telefono.Name = "txtUsuario_telefono";
            this.txtUsuario_telefono.Size = new System.Drawing.Size(187, 20);
            this.txtUsuario_telefono.TabIndex = 35;
            this.txtUsuario_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_telefono_KeyPress);
            // 
            // txtUsuario_segundoApellido
            // 
            this.txtUsuario_segundoApellido.Location = new System.Drawing.Point(332, 258);
            this.txtUsuario_segundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_segundoApellido.MaxLength = 50;
            this.txtUsuario_segundoApellido.Name = "txtUsuario_segundoApellido";
            this.txtUsuario_segundoApellido.Size = new System.Drawing.Size(256, 20);
            this.txtUsuario_segundoApellido.TabIndex = 34;
            this.txtUsuario_segundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_segundoApellido_KeyPress);
            // 
            // txtUsuario_primerApellido
            // 
            this.txtUsuario_primerApellido.Location = new System.Drawing.Point(332, 201);
            this.txtUsuario_primerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_primerApellido.MaxLength = 50;
            this.txtUsuario_primerApellido.Name = "txtUsuario_primerApellido";
            this.txtUsuario_primerApellido.Size = new System.Drawing.Size(256, 20);
            this.txtUsuario_primerApellido.TabIndex = 33;
            this.txtUsuario_primerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_primerApellido_KeyPress);
            // 
            // txtUsuario_nombre
            // 
            this.txtUsuario_nombre.Location = new System.Drawing.Point(401, 148);
            this.txtUsuario_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_nombre.MaxLength = 50;
            this.txtUsuario_nombre.Name = "txtUsuario_nombre";
            this.txtUsuario_nombre.Size = new System.Drawing.Size(187, 20);
            this.txtUsuario_nombre.TabIndex = 32;
            this.txtUsuario_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_nombre_KeyPress);
            // 
            // txtUsuario_cedula
            // 
            this.txtUsuario_cedula.Location = new System.Drawing.Point(401, 110);
            this.txtUsuario_cedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario_cedula.MaxLength = 50;
            this.txtUsuario_cedula.Name = "txtUsuario_cedula";
            this.txtUsuario_cedula.Size = new System.Drawing.Size(187, 20);
            this.txtUsuario_cedula.TabIndex = 31;
            this.txtUsuario_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_cedula_KeyPress);
            // 
            // lblUsuario_direccion
            // 
            this.lblUsuario_direccion.AutoSize = true;
            this.lblUsuario_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_direccion.Location = new System.Drawing.Point(328, 380);
            this.lblUsuario_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario_direccion.Name = "lblUsuario_direccion";
            this.lblUsuario_direccion.Size = new System.Drawing.Size(79, 20);
            this.lblUsuario_direccion.TabIndex = 30;
            this.lblUsuario_direccion.Text = "Direccion:";
            // 
            // lblUsuario_correoElectronico
            // 
            this.lblUsuario_correoElectronico.AutoSize = true;
            this.lblUsuario_correoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_correoElectronico.Location = new System.Drawing.Point(328, 336);
            this.lblUsuario_correoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario_correoElectronico.Name = "lblUsuario_correoElectronico";
            this.lblUsuario_correoElectronico.Size = new System.Drawing.Size(144, 20);
            this.lblUsuario_correoElectronico.TabIndex = 29;
            this.lblUsuario_correoElectronico.Text = "Correo Electronico:";
            // 
            // lblUsuario_telefono
            // 
            this.lblUsuario_telefono.AutoSize = true;
            this.lblUsuario_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_telefono.Location = new System.Drawing.Point(328, 297);
            this.lblUsuario_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario_telefono.Name = "lblUsuario_telefono";
            this.lblUsuario_telefono.Size = new System.Drawing.Size(75, 20);
            this.lblUsuario_telefono.TabIndex = 28;
            this.lblUsuario_telefono.Text = "Telefono:";
            // 
            // lblUsuario_segundoApellido
            // 
            this.lblUsuario_segundoApellido.AutoSize = true;
            this.lblUsuario_segundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_segundoApellido.Location = new System.Drawing.Point(328, 232);
            this.lblUsuario_segundoApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario_segundoApellido.Name = "lblUsuario_segundoApellido";
            this.lblUsuario_segundoApellido.Size = new System.Drawing.Size(138, 20);
            this.lblUsuario_segundoApellido.TabIndex = 27;
            this.lblUsuario_segundoApellido.Text = "Segundo Apellido:";
            // 
            // lblUsuario_primerApellido
            // 
            this.lblUsuario_primerApellido.AutoSize = true;
            this.lblUsuario_primerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_primerApellido.Location = new System.Drawing.Point(328, 176);
            this.lblUsuario_primerApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario_primerApellido.Name = "lblUsuario_primerApellido";
            this.lblUsuario_primerApellido.Size = new System.Drawing.Size(118, 20);
            this.lblUsuario_primerApellido.TabIndex = 26;
            this.lblUsuario_primerApellido.Text = "Primer Apellido:";
            // 
            // lblUsuario_nombre
            // 
            this.lblUsuario_nombre.AutoSize = true;
            this.lblUsuario_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_nombre.Location = new System.Drawing.Point(328, 145);
            this.lblUsuario_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario_nombre.Name = "lblUsuario_nombre";
            this.lblUsuario_nombre.Size = new System.Drawing.Size(69, 20);
            this.lblUsuario_nombre.TabIndex = 25;
            this.lblUsuario_nombre.Text = "Nombre:";
            // 
            // lblUsuario_cedula
            // 
            this.lblUsuario_cedula.AutoSize = true;
            this.lblUsuario_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_cedula.Location = new System.Drawing.Point(328, 110);
            this.lblUsuario_cedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario_cedula.Name = "lblUsuario_cedula";
            this.lblUsuario_cedula.Size = new System.Drawing.Size(63, 20);
            this.lblUsuario_cedula.TabIndex = 24;
            this.lblUsuario_cedula.Text = "Cédula:";
            // 
            // chkbxAdministrador
            // 
            this.chkbxAdministrador.AutoSize = true;
            this.chkbxAdministrador.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxAdministrador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkbxAdministrador.Location = new System.Drawing.Point(666, 138);
            this.chkbxAdministrador.Name = "chkbxAdministrador";
            this.chkbxAdministrador.Size = new System.Drawing.Size(159, 27);
            this.chkbxAdministrador.TabIndex = 44;
            this.chkbxAdministrador.Text = "Administrador";
            this.chkbxAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(32, 451);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(256, 50);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(666, 258);
            this.txtConfirmarContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmarContraseña.MaxLength = 50;
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(256, 20);
            this.txtConfirmarContraseña.TabIndex = 49;
            this.txtConfirmarContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContraseña_KeyPress);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(666, 201);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(256, 20);
            this.txtContraseña.TabIndex = 48;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // lblConfirmarContreseña
            // 
            this.lblConfirmarContreseña.AutoSize = true;
            this.lblConfirmarContreseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContreseña.Location = new System.Drawing.Point(662, 232);
            this.lblConfirmarContreseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmarContreseña.Name = "lblConfirmarContreseña";
            this.lblConfirmarContreseña.Size = new System.Drawing.Size(169, 20);
            this.lblConfirmarContreseña.TabIndex = 47;
            this.lblConfirmarContreseña.Text = "Confirmar Contraseña:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(662, 176);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblContraseña.TabIndex = 46;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // formUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 590);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblConfirmarContreseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chkbxAdministrador);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtUsuario_direccion);
            this.Controls.Add(this.txtUsuario_correoElectronico);
            this.Controls.Add(this.txtUsuario_telefono);
            this.Controls.Add(this.txtUsuario_segundoApellido);
            this.Controls.Add(this.txtUsuario_primerApellido);
            this.Controls.Add(this.txtUsuario_nombre);
            this.Controls.Add(this.txtUsuario_cedula);
            this.Controls.Add(this.lblUsuario_direccion);
            this.Controls.Add(this.lblUsuario_correoElectronico);
            this.Controls.Add(this.lblUsuario_telefono);
            this.Controls.Add(this.lblUsuario_segundoApellido);
            this.Controls.Add(this.lblUsuario_primerApellido);
            this.Controls.Add(this.lblUsuario_nombre);
            this.Controls.Add(this.lblUsuario_cedula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.formUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtUsuario_direccion;
        private System.Windows.Forms.TextBox txtUsuario_correoElectronico;
        private System.Windows.Forms.TextBox txtUsuario_telefono;
        private System.Windows.Forms.TextBox txtUsuario_segundoApellido;
        private System.Windows.Forms.TextBox txtUsuario_primerApellido;
        private System.Windows.Forms.TextBox txtUsuario_nombre;
        private System.Windows.Forms.TextBox txtUsuario_cedula;
        private System.Windows.Forms.Label lblUsuario_direccion;
        private System.Windows.Forms.Label lblUsuario_correoElectronico;
        private System.Windows.Forms.Label lblUsuario_telefono;
        private System.Windows.Forms.Label lblUsuario_segundoApellido;
        private System.Windows.Forms.Label lblUsuario_primerApellido;
        private System.Windows.Forms.Label lblUsuario_nombre;
        private System.Windows.Forms.Label lblUsuario_cedula;
        private System.Windows.Forms.CheckBox chkbxAdministrador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblConfirmarContreseña;
        private System.Windows.Forms.Label lblContraseña;
    }
}