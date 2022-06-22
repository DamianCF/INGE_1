
namespace CapaPresentacion
{
    partial class formEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEstudiante));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.btnReporteEstudiantes = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEstudiante_Insertar = new System.Windows.Forms.Button();
            this.txtEstudiante_direccion = new System.Windows.Forms.TextBox();
            this.txtEstudiante_correoElectronico = new System.Windows.Forms.TextBox();
            this.txtEstudiante_telefono = new System.Windows.Forms.TextBox();
            this.txtEstudiante_segundoApellido = new System.Windows.Forms.TextBox();
            this.txtEstudiante_primerApellido = new System.Windows.Forms.TextBox();
            this.txtEstudiante_nombre = new System.Windows.Forms.TextBox();
            this.txtEstudiante_cedula = new System.Windows.Forms.TextBox();
            this.lblEstudiante_direccion = new System.Windows.Forms.Label();
            this.lblEstudiante_correoElectronico = new System.Windows.Forms.Label();
            this.lblEstudiante_telefono = new System.Windows.Forms.Label();
            this.lblEstudiante_segundoApellido = new System.Windows.Forms.Label();
            this.lblEstudiante_primerApellido = new System.Windows.Forms.Label();
            this.lblEstudiante_nombre = new System.Windows.Forms.Label();
            this.lblEstudiante_cedula = new System.Windows.Forms.Label();
            this.lblEstudiante_IDgrupo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbxGrupo = new System.Windows.Forms.ComboBox();
            this.chkbxMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.btnActivarEliminado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(59, 440);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 41);
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
            this.Titulo.Location = new System.Drawing.Point(142, 46);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(176, 38);
            this.Titulo.TabIndex = 42;
            this.Titulo.Text = "Estudiante";
            // 
            // btnReporteEstudiantes
            // 
            this.btnReporteEstudiantes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReporteEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnReporteEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteEstudiantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEstudiantes.Location = new System.Drawing.Point(683, 569);
            this.btnReporteEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteEstudiantes.Name = "btnReporteEstudiantes";
            this.btnReporteEstudiantes.Size = new System.Drawing.Size(253, 41);
            this.btnReporteEstudiantes.TabIndex = 41;
            this.btnReporteEstudiantes.Text = "Reporte Estudiantes";
            this.btnReporteEstudiantes.UseVisualStyleBackColor = false;
            this.btnReporteEstudiantes.Click += new System.EventHandler(this.btnReporteEstudiantees_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(772, 62);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(164, 41);
            this.btnCargarDatos.TabIndex = 40;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(567, 83);
            this.cbxEstudiante.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(186, 21);
            this.cbxEstudiante.TabIndex = 39;
            this.cbxEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbxEstudiante_SelectedIndexChanged);
            // 
            // dgvEstudiantes
            // 
            this.dgvEstudiantes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiantes.Location = new System.Drawing.Point(344, 116);
            this.dgvEstudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEstudiantes.Name = "dgvEstudiantes";
            this.dgvEstudiantes.RowHeadersWidth = 51;
            this.dgvEstudiantes.RowTemplate.Height = 24;
            this.dgvEstudiantes.Size = new System.Drawing.Size(592, 436);
            this.dgvEstudiantes.TabIndex = 38;
            this.dgvEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantees_CellClick);
            this.dgvEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudiantes_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(203, 440);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 41);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEstudiante_Insertar
            // 
            this.btnEstudiante_Insertar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEstudiante_Insertar.FlatAppearance.BorderSize = 0;
            this.btnEstudiante_Insertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante_Insertar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante_Insertar.Location = new System.Drawing.Point(59, 497);
            this.btnEstudiante_Insertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstudiante_Insertar.Name = "btnEstudiante_Insertar";
            this.btnEstudiante_Insertar.Size = new System.Drawing.Size(266, 41);
            this.btnEstudiante_Insertar.TabIndex = 36;
            this.btnEstudiante_Insertar.Text = "Insertar";
            this.btnEstudiante_Insertar.UseVisualStyleBackColor = false;
            this.btnEstudiante_Insertar.Click += new System.EventHandler(this.btnEstudiante_Insertar_Click);
            // 
            // txtEstudiante_direccion
            // 
            this.txtEstudiante_direccion.Location = new System.Drawing.Point(56, 360);
            this.txtEstudiante_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstudiante_direccion.MaxLength = 50;
            this.txtEstudiante_direccion.Name = "txtEstudiante_direccion";
            this.txtEstudiante_direccion.Size = new System.Drawing.Size(270, 20);
            this.txtEstudiante_direccion.TabIndex = 35;
            // 
            // txtEstudiante_correoElectronico
            // 
            this.txtEstudiante_correoElectronico.Location = new System.Drawing.Point(56, 313);
            this.txtEstudiante_correoElectronico.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstudiante_correoElectronico.MaxLength = 50;
            this.txtEstudiante_correoElectronico.Name = "txtEstudiante_correoElectronico";
            this.txtEstudiante_correoElectronico.Size = new System.Drawing.Size(270, 20);
            this.txtEstudiante_correoElectronico.TabIndex = 34;
            // 
            // txtEstudiante_telefono
            // 
            this.txtEstudiante_telefono.Location = new System.Drawing.Point(129, 258);
            this.txtEstudiante_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstudiante_telefono.MaxLength = 20;
            this.txtEstudiante_telefono.Name = "txtEstudiante_telefono";
            this.txtEstudiante_telefono.Size = new System.Drawing.Size(197, 20);
            this.txtEstudiante_telefono.TabIndex = 33;
            this.txtEstudiante_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstudiante_telefono_KeyPress);
            // 
            // txtEstudiante_segundoApellido
            // 
            this.txtEstudiante_segundoApellido.Location = new System.Drawing.Point(56, 230);
            this.txtEstudiante_segundoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstudiante_segundoApellido.MaxLength = 50;
            this.txtEstudiante_segundoApellido.Name = "txtEstudiante_segundoApellido";
            this.txtEstudiante_segundoApellido.Size = new System.Drawing.Size(270, 20);
            this.txtEstudiante_segundoApellido.TabIndex = 32;
            this.txtEstudiante_segundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstudiante_segundoApellido_KeyPress);
            // 
            // txtEstudiante_primerApellido
            // 
            this.txtEstudiante_primerApellido.Location = new System.Drawing.Point(56, 180);
            this.txtEstudiante_primerApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstudiante_primerApellido.MaxLength = 50;
            this.txtEstudiante_primerApellido.Name = "txtEstudiante_primerApellido";
            this.txtEstudiante_primerApellido.Size = new System.Drawing.Size(270, 20);
            this.txtEstudiante_primerApellido.TabIndex = 31;
            this.txtEstudiante_primerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstudiante_primerApellido_KeyPress);
            // 
            // txtEstudiante_nombre
            // 
            this.txtEstudiante_nombre.Location = new System.Drawing.Point(129, 136);
            this.txtEstudiante_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstudiante_nombre.MaxLength = 50;
            this.txtEstudiante_nombre.Name = "txtEstudiante_nombre";
            this.txtEstudiante_nombre.Size = new System.Drawing.Size(197, 20);
            this.txtEstudiante_nombre.TabIndex = 30;
            this.txtEstudiante_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstudiante_nombre_KeyPress);
            // 
            // txtEstudiante_cedula
            // 
            this.txtEstudiante_cedula.Location = new System.Drawing.Point(126, 106);
            this.txtEstudiante_cedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstudiante_cedula.MaxLength = 50;
            this.txtEstudiante_cedula.Name = "txtEstudiante_cedula";
            this.txtEstudiante_cedula.Size = new System.Drawing.Size(200, 20);
            this.txtEstudiante_cedula.TabIndex = 29;
            this.txtEstudiante_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstudiante_cedula_KeyPress);
            // 
            // lblEstudiante_direccion
            // 
            this.lblEstudiante_direccion.AutoSize = true;
            this.lblEstudiante_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_direccion.Location = new System.Drawing.Point(52, 338);
            this.lblEstudiante_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_direccion.Name = "lblEstudiante_direccion";
            this.lblEstudiante_direccion.Size = new System.Drawing.Size(79, 20);
            this.lblEstudiante_direccion.TabIndex = 28;
            this.lblEstudiante_direccion.Text = "Direccion:";
            // 
            // lblEstudiante_correoElectronico
            // 
            this.lblEstudiante_correoElectronico.AutoSize = true;
            this.lblEstudiante_correoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_correoElectronico.Location = new System.Drawing.Point(52, 288);
            this.lblEstudiante_correoElectronico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_correoElectronico.Name = "lblEstudiante_correoElectronico";
            this.lblEstudiante_correoElectronico.Size = new System.Drawing.Size(144, 20);
            this.lblEstudiante_correoElectronico.TabIndex = 27;
            this.lblEstudiante_correoElectronico.Text = "Correo Electronico:";
            // 
            // lblEstudiante_telefono
            // 
            this.lblEstudiante_telefono.AutoSize = true;
            this.lblEstudiante_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_telefono.Location = new System.Drawing.Point(52, 258);
            this.lblEstudiante_telefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_telefono.Name = "lblEstudiante_telefono";
            this.lblEstudiante_telefono.Size = new System.Drawing.Size(75, 20);
            this.lblEstudiante_telefono.TabIndex = 26;
            this.lblEstudiante_telefono.Text = "Telefono:";
            // 
            // lblEstudiante_segundoApellido
            // 
            this.lblEstudiante_segundoApellido.AutoSize = true;
            this.lblEstudiante_segundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_segundoApellido.Location = new System.Drawing.Point(52, 208);
            this.lblEstudiante_segundoApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_segundoApellido.Name = "lblEstudiante_segundoApellido";
            this.lblEstudiante_segundoApellido.Size = new System.Drawing.Size(138, 20);
            this.lblEstudiante_segundoApellido.TabIndex = 25;
            this.lblEstudiante_segundoApellido.Text = "Segundo Apellido:";
            // 
            // lblEstudiante_primerApellido
            // 
            this.lblEstudiante_primerApellido.AutoSize = true;
            this.lblEstudiante_primerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_primerApellido.Location = new System.Drawing.Point(52, 158);
            this.lblEstudiante_primerApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_primerApellido.Name = "lblEstudiante_primerApellido";
            this.lblEstudiante_primerApellido.Size = new System.Drawing.Size(118, 20);
            this.lblEstudiante_primerApellido.TabIndex = 24;
            this.lblEstudiante_primerApellido.Text = "Primer Apellido:";
            // 
            // lblEstudiante_nombre
            // 
            this.lblEstudiante_nombre.AutoSize = true;
            this.lblEstudiante_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_nombre.Location = new System.Drawing.Point(52, 133);
            this.lblEstudiante_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_nombre.Name = "lblEstudiante_nombre";
            this.lblEstudiante_nombre.Size = new System.Drawing.Size(69, 20);
            this.lblEstudiante_nombre.TabIndex = 23;
            this.lblEstudiante_nombre.Text = "Nombre:";
            // 
            // lblEstudiante_cedula
            // 
            this.lblEstudiante_cedula.AutoSize = true;
            this.lblEstudiante_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_cedula.Location = new System.Drawing.Point(52, 102);
            this.lblEstudiante_cedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_cedula.Name = "lblEstudiante_cedula";
            this.lblEstudiante_cedula.Size = new System.Drawing.Size(63, 20);
            this.lblEstudiante_cedula.TabIndex = 22;
            this.lblEstudiante_cedula.Text = "Cédula:";
            // 
            // lblEstudiante_IDgrupo
            // 
            this.lblEstudiante_IDgrupo.AutoSize = true;
            this.lblEstudiante_IDgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante_IDgrupo.Location = new System.Drawing.Point(55, 384);
            this.lblEstudiante_IDgrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstudiante_IDgrupo.Name = "lblEstudiante_IDgrupo";
            this.lblEstudiante_IDgrupo.Size = new System.Drawing.Size(58, 20);
            this.lblEstudiante_IDgrupo.TabIndex = 44;
            this.lblEstudiante_IDgrupo.Text = "Grupo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 78);
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
            this.btnEliminar.Location = new System.Drawing.Point(59, 557);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(266, 41);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.FormattingEnabled = true;
            this.cbxGrupo.Location = new System.Drawing.Point(113, 388);
            this.cbxGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Size = new System.Drawing.Size(212, 21);
            this.cbxGrupo.TabIndex = 48;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // chkbxMostrarEliminados
            // 
            this.chkbxMostrarEliminados.AutoSize = true;
            this.chkbxMostrarEliminados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbxMostrarEliminados.Location = new System.Drawing.Point(344, 79);
            this.chkbxMostrarEliminados.Name = "chkbxMostrarEliminados";
            this.chkbxMostrarEliminados.Size = new System.Drawing.Size(173, 25);
            this.chkbxMostrarEliminados.TabIndex = 49;
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
            this.btnActivarEliminado.Location = new System.Drawing.Point(344, 556);
            this.btnActivarEliminado.Margin = new System.Windows.Forms.Padding(2);
            this.btnActivarEliminado.Name = "btnActivarEliminado";
            this.btnActivarEliminado.Size = new System.Drawing.Size(155, 67);
            this.btnActivarEliminado.TabIndex = 50;
            this.btnActivarEliminado.Text = "Activar \r\nEliminado";
            this.btnActivarEliminado.UseVisualStyleBackColor = false;
            this.btnActivarEliminado.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // formEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 629);
            this.Controls.Add(this.btnActivarEliminado);
            this.Controls.Add(this.chkbxMostrarEliminados);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEstudiante_IDgrupo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btnReporteEstudiantes);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cbxEstudiante);
            this.Controls.Add(this.dgvEstudiantes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEstudiante_Insertar);
            this.Controls.Add(this.txtEstudiante_direccion);
            this.Controls.Add(this.txtEstudiante_correoElectronico);
            this.Controls.Add(this.txtEstudiante_telefono);
            this.Controls.Add(this.txtEstudiante_segundoApellido);
            this.Controls.Add(this.txtEstudiante_primerApellido);
            this.Controls.Add(this.txtEstudiante_nombre);
            this.Controls.Add(this.txtEstudiante_cedula);
            this.Controls.Add(this.lblEstudiante_direccion);
            this.Controls.Add(this.lblEstudiante_correoElectronico);
            this.Controls.Add(this.lblEstudiante_telefono);
            this.Controls.Add(this.lblEstudiante_segundoApellido);
            this.Controls.Add(this.lblEstudiante_primerApellido);
            this.Controls.Add(this.lblEstudiante_nombre);
            this.Controls.Add(this.lblEstudiante_cedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formEstudiante";
            this.Text = "Sistema Matricula = Modulo Estudiante";
            this.Load += new System.EventHandler(this.formEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button btnReporteEstudiantes;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEstudiante_Insertar;
        private System.Windows.Forms.TextBox txtEstudiante_direccion;
        private System.Windows.Forms.TextBox txtEstudiante_correoElectronico;
        private System.Windows.Forms.TextBox txtEstudiante_telefono;
        private System.Windows.Forms.TextBox txtEstudiante_segundoApellido;
        private System.Windows.Forms.TextBox txtEstudiante_primerApellido;
        private System.Windows.Forms.TextBox txtEstudiante_nombre;
        private System.Windows.Forms.TextBox txtEstudiante_cedula;
        private System.Windows.Forms.Label lblEstudiante_direccion;
        private System.Windows.Forms.Label lblEstudiante_correoElectronico;
        private System.Windows.Forms.Label lblEstudiante_telefono;
        private System.Windows.Forms.Label lblEstudiante_segundoApellido;
        private System.Windows.Forms.Label lblEstudiante_primerApellido;
        private System.Windows.Forms.Label lblEstudiante_nombre;
        private System.Windows.Forms.Label lblEstudiante_cedula;
        private System.Windows.Forms.Label lblEstudiante_IDgrupo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbxGrupo;
        private System.Windows.Forms.CheckBox chkbxMostrarEliminados;
        private System.Windows.Forms.Button btnActivarEliminado;
    }
}