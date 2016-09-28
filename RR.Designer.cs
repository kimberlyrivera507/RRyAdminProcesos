namespace Round_Robin
{
    partial class RR
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbProcesos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReq = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dgvProcesos = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRequeriminetos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbQuantom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dgvEjec = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProcesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjec)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProcesos
            // 
            this.gbProcesos.Controls.Add(this.btnAgregar);
            this.gbProcesos.Controls.Add(this.label2);
            this.gbProcesos.Controls.Add(this.label1);
            this.gbProcesos.Controls.Add(this.tbReq);
            this.gbProcesos.Controls.Add(this.tbNombre);
            this.gbProcesos.Controls.Add(this.dgvProcesos);
            this.gbProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProcesos.Location = new System.Drawing.Point(12, 12);
            this.gbProcesos.Name = "gbProcesos";
            this.gbProcesos.Size = new System.Drawing.Size(359, 424);
            this.gbProcesos.TabIndex = 0;
            this.gbProcesos.TabStop = false;
            this.gbProcesos.Text = "Cola de Procesos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(278, 57);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Requerimientos de Ejecucion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Proceso:";
            // 
            // tbReq
            // 
            this.tbReq.Location = new System.Drawing.Point(139, 43);
            this.tbReq.Name = "tbReq";
            this.tbReq.Size = new System.Drawing.Size(100, 20);
            this.tbReq.TabIndex = 2;
            this.tbReq.TextChanged += new System.EventHandler(this.tbReq_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(9, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // dgvProcesos
            // 
            this.dgvProcesos.AllowUserToAddRows = false;
            this.dgvProcesos.AllowUserToDeleteRows = false;
            this.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cRequeriminetos,
            this.cColor});
            this.dgvProcesos.Location = new System.Drawing.Point(6, 86);
            this.dgvProcesos.Name = "dgvProcesos";
            this.dgvProcesos.ReadOnly = true;
            this.dgvProcesos.Size = new System.Drawing.Size(343, 328);
            this.dgvProcesos.TabIndex = 0;
            this.dgvProcesos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcesos_CellContentClick);
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cRequeriminetos
            // 
            this.cRequeriminetos.HeaderText = "Requerimientos";
            this.cRequeriminetos.Name = "cRequeriminetos";
            this.cRequeriminetos.ReadOnly = true;
            // 
            // cColor
            // 
            this.cColor.HeaderText = "Color";
            this.cColor.Name = "cColor";
            this.cColor.ReadOnly = true;
            // 
            // tbQuantom
            // 
            this.tbQuantom.Location = new System.Drawing.Point(130, 465);
            this.tbQuantom.Name = "tbQuantom";
            this.tbQuantom.Size = new System.Drawing.Size(88, 20);
            this.tbQuantom.TabIndex = 8;
            this.tbQuantom.TextChanged += new System.EventHandler(this.tbQuantom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantum:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(266, 442);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(95, 43);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dgvEjec
            // 
            this.dgvEjec.AllowUserToAddRows = false;
            this.dgvEjec.AllowUserToDeleteRows = false;
            this.dgvEjec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvEjec.Location = new System.Drawing.Point(377, 69);
            this.dgvEjec.Name = "dgvEjec";
            this.dgvEjec.ReadOnly = true;
            this.dgvEjec.Size = new System.Drawing.Size(836, 416);
            this.dgvEjec.TabIndex = 1;
            this.dgvEjec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjec_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "MAPA DE MEMORIA COMPARTIDA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "PLANIFICADOR  ROUND ROBIN";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "1 Quatum";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2 Quatum";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3 Quatum";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "4 Quatum";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "5 Quatum";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "6 Quatum";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "7 Quatum";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8 Quatum";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // RR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1225, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuantom);
            this.Controls.Add(this.dgvEjec);
            this.Controls.Add(this.gbProcesos);
            this.Name = "RR";
            this.Text = "Werner Round Robin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbProcesos.ResumeLayout(false);
            this.gbProcesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProcesos;
        private System.Windows.Forms.DataGridView dgvProcesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReq;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbQuantom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRequeriminetos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor;
        private System.Windows.Forms.DataGridView dgvEjec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

