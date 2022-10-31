namespace ClinicaSQL
{
    partial class frmCitas
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
            this.lblId = new System.Windows.Forms.Label();
            this.grpCita = new System.Windows.Forms.GroupBox();
            this.dtphora = new System.Windows.Forms.DateTimePicker();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.txtmedico = new System.Windows.Forms.TextBox();
            this.txtpaciente = new System.Windows.Forms.TextBox();
            this.txtnumeroConsulta = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblnumeroConsulta = new System.Windows.Forms.Label();
            this.lblmedico = new System.Windows.Forms.Label();
            this.lblpaciente = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.grpCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(47, 70);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // grpCita
            // 
            this.grpCita.Controls.Add(this.dtphora);
            this.grpCita.Controls.Add(this.dtpfecha);
            this.grpCita.Controls.Add(this.txtmedico);
            this.grpCita.Controls.Add(this.txtpaciente);
            this.grpCita.Controls.Add(this.txtnumeroConsulta);
            this.grpCita.Controls.Add(this.txtId);
            this.grpCita.Controls.Add(this.lblnumeroConsulta);
            this.grpCita.Controls.Add(this.lblmedico);
            this.grpCita.Controls.Add(this.lblpaciente);
            this.grpCita.Controls.Add(this.lblfecha);
            this.grpCita.Controls.Add(this.lblId);
            this.grpCita.Location = new System.Drawing.Point(51, 45);
            this.grpCita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCita.Name = "grpCita";
            this.grpCita.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCita.Size = new System.Drawing.Size(640, 355);
            this.grpCita.TabIndex = 1;
            this.grpCita.TabStop = false;
            this.grpCita.Text = "Cita:";
            // 
            // dtphora
            // 
            this.dtphora.CustomFormat = "HH:mm";
            this.dtphora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphora.Location = new System.Drawing.Point(405, 110);
            this.dtphora.Name = "dtphora";
            this.dtphora.ShowUpDown = true;
            this.dtphora.Size = new System.Drawing.Size(107, 31);
            this.dtphora.TabIndex = 10;
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(260, 110);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(126, 31);
            this.dtpfecha.TabIndex = 9;
            // 
            // txtmedico
            // 
            this.txtmedico.Location = new System.Drawing.Point(260, 210);
            this.txtmedico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmedico.Name = "txtmedico";
            this.txtmedico.Size = new System.Drawing.Size(221, 31);
            this.txtmedico.TabIndex = 8;
            // 
            // txtpaciente
            // 
            this.txtpaciente.Location = new System.Drawing.Point(260, 157);
            this.txtpaciente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpaciente.Name = "txtpaciente";
            this.txtpaciente.Size = new System.Drawing.Size(221, 31);
            this.txtpaciente.TabIndex = 7;
            // 
            // txtnumeroConsulta
            // 
            this.txtnumeroConsulta.Location = new System.Drawing.Point(260, 258);
            this.txtnumeroConsulta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnumeroConsulta.Name = "txtnumeroConsulta";
            this.txtnumeroConsulta.Size = new System.Drawing.Size(58, 31);
            this.txtnumeroConsulta.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(260, 57);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 31);
            this.txtId.TabIndex = 5;
            // 
            // lblnumeroConsulta
            // 
            this.lblnumeroConsulta.AutoSize = true;
            this.lblnumeroConsulta.Location = new System.Drawing.Point(47, 272);
            this.lblnumeroConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumeroConsulta.Name = "lblnumeroConsulta";
            this.lblnumeroConsulta.Size = new System.Drawing.Size(177, 25);
            this.lblnumeroConsulta.TabIndex = 4;
            this.lblnumeroConsulta.Text = "Numero de consulta:";
            // 
            // lblmedico
            // 
            this.lblmedico.AutoSize = true;
            this.lblmedico.Location = new System.Drawing.Point(47, 220);
            this.lblmedico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmedico.Name = "lblmedico";
            this.lblmedico.Size = new System.Drawing.Size(75, 25);
            this.lblmedico.TabIndex = 3;
            this.lblmedico.Text = "Medico:";
            // 
            // lblpaciente
            // 
            this.lblpaciente.AutoSize = true;
            this.lblpaciente.Location = new System.Drawing.Point(47, 170);
            this.lblpaciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaciente.Name = "lblpaciente";
            this.lblpaciente.Size = new System.Drawing.Size(80, 25);
            this.lblpaciente.TabIndex = 2;
            this.lblpaciente.Text = "Paciente:";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(47, 120);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(116, 25);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "Fecha y hora:";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(51, 410);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(107, 38);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(167, 410);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 38);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(283, 410);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(469, 410);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 38);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(584, 410);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(51, 527);
            this.dgvCitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 62;
            this.dgvCitas.RowTemplate.Height = 25;
            this.dgvCitas.Size = new System.Drawing.Size(675, 352);
            this.dgvCitas.TabIndex = 7;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            this.dgvCitas.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvCitas_RowStateChanged);
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 920);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.grpCita);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCitas";
            this.Text = "Lista de citas";
            this.Load += new System.EventHandler(this.frmCitas_Load);
            this.grpCita.ResumeLayout(false);
            this.grpCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblId;
        private GroupBox grpCita;
        private TextBox txtnumeroConsulta;
        private TextBox txtId;
        private Label lblnumeroConsulta;
        private Label lblmedico;
        private Label lblpaciente;
        private Label lblfecha;
        private DateTimePicker dtpfecha;
        private TextBox txtmedico;
        private TextBox txtpaciente;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridView dgvCitas;
        private DateTimePicker dtphora;
    }
}