namespace PRControl_timer
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
            this.components = new System.ComponentModel.Container();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblb = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(493, 127);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(151, 64);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(493, 231);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(151, 64);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(476, 47);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(46, 17);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.ForeColor = System.Drawing.Color.Red;
            this.lblb.Location = new System.Drawing.Point(69, 163);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(343, 63);
            this.lblb.TabIndex = 3;
            this.lblb.Text = "Jair Mendoza";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.ForeColor = System.Drawing.Color.Black;
            this.lbla.Location = new System.Drawing.Point(69, 161);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(357, 65);
            this.lbla.TabIndex = 4;
            this.lbla.Text = "Jair Mendoza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lbla);
            this.Name = "Form1";
            this.Text = ".:.Control Timer.:.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lbla;
    }
}

