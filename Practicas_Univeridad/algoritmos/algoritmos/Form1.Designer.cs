namespace algoritmos
{
    partial class Form1
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
            this.cbo_n_procesos = new System.Windows.Forms.ComboBox();
            this.cbo_algoritmo = new System.Windows.Forms.ComboBox();
            this.btn_ver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Procesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Procesos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cbocuantum = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_n_procesos
            // 
            this.cbo_n_procesos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_n_procesos.FormattingEnabled = true;
            this.cbo_n_procesos.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbo_n_procesos.Location = new System.Drawing.Point(737, 39);
            this.cbo_n_procesos.Name = "cbo_n_procesos";
            this.cbo_n_procesos.Size = new System.Drawing.Size(192, 24);
            this.cbo_n_procesos.TabIndex = 0;
            this.cbo_n_procesos.SelectedIndexChanged += new System.EventHandler(this.cbo_n_procesos_SelectedIndexChanged);
            // 
            // cbo_algoritmo
            // 
            this.cbo_algoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_algoritmo.FormattingEnabled = true;
            this.cbo_algoritmo.Items.AddRange(new object[] {
            "FCFS (First come first serve)",
            "SJF (shortest-job-first)",
            "HRRN (Highest Response Ratio Next)",
            "RR (Round Robin)",
            "Colas multiples"});
            this.cbo_algoritmo.Location = new System.Drawing.Point(185, 39);
            this.cbo_algoritmo.Name = "cbo_algoritmo";
            this.cbo_algoritmo.Size = new System.Drawing.Size(166, 24);
            this.cbo_algoritmo.TabIndex = 1;
            this.cbo_algoritmo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_ver
            // 
            this.btn_ver.AutoSize = true;
            this.btn_ver.Enabled = false;
            this.btn_ver.Location = new System.Drawing.Point(1019, 40);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(109, 27);
            this.btn_ver.TabIndex = 2;
            this.btn_ver.Text = "Ver Grafica";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Procesos,
            this.Tiempo_llegada,
            this.Tiempo_Servicio});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Procesos
            // 
            this.Procesos.HeaderText = "Procesos";
            this.Procesos.Name = "Procesos";
            this.Procesos.ReadOnly = true;
            // 
            // Tiempo_llegada
            // 
            this.Tiempo_llegada.HeaderText = "Tiempo_llegada";
            this.Tiempo_llegada.Name = "Tiempo_llegada";
            // 
            // Tiempo_Servicio
            // 
            this.Tiempo_Servicio.HeaderText = "Tiempo_Servicio";
            this.Tiempo_Servicio.Name = "Tiempo_Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un algoritmo.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione No. Procesos.";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Procesos2});
            this.dataGridView2.Location = new System.Drawing.Point(475, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(733, 386);
            this.dataGridView2.TabIndex = 6;
            // 
            // Procesos2
            // 
            this.Procesos2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Procesos2.HeaderText = "Procesos";
            this.Procesos2.MinimumWidth = 2;
            this.Procesos2.Name = "Procesos2";
            this.Procesos2.ReadOnly = true;
            this.Procesos2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Procesos2.Width = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cuantium";
            // 
            // cbocuantum
            // 
            this.cbocuantum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocuantum.Enabled = false;
            this.cbocuantum.FormattingEnabled = true;
            this.cbocuantum.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbocuantum.Location = new System.Drawing.Point(439, 39);
            this.cbocuantum.Name = "cbocuantum";
            this.cbocuantum.Size = new System.Drawing.Size(121, 24);
            this.cbocuantum.TabIndex = 9;
            this.cbocuantum.SelectedIndexChanged += new System.EventHandler(this.cbocuantum_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 489);
            this.Controls.Add(this.cbocuantum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.cbo_algoritmo);
            this.Controls.Add(this.cbo_n_procesos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_n_procesos;
        private System.Windows.Forms.ComboBox cbo_algoritmo;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procesos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Procesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo_Servicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbocuantum;
    }
}

