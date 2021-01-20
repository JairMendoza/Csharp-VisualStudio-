namespace WindowsFormsApp1
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
            this.pmayor_tbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pmenor_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.conclucion_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.figura_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmayor_tbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tmenor_tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tmedio_tbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.modo_tbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pmayor_tbox
            // 
            this.pmayor_tbox.Location = new System.Drawing.Point(77, 109);
            this.pmayor_tbox.Name = "pmayor_tbox";
            this.pmayor_tbox.Size = new System.Drawing.Size(452, 22);
            this.pmayor_tbox.TabIndex = 0;
            this.pmayor_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pm";
            // 
            // pmenor_tbox
            // 
            this.pmenor_tbox.Location = new System.Drawing.Point(77, 184);
            this.pmenor_tbox.Name = "pmenor_tbox";
            this.pmenor_tbox.Size = new System.Drawing.Size(452, 22);
            this.pmenor_tbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "C";
            // 
            // conclucion_tbox
            // 
            this.conclucion_tbox.Enabled = false;
            this.conclucion_tbox.Location = new System.Drawing.Point(77, 259);
            this.conclucion_tbox.Name = "conclucion_tbox";
            this.conclucion_tbox.Size = new System.Drawing.Size(452, 22);
            this.conclucion_tbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "F";
            // 
            // figura_tbox
            // 
            this.figura_tbox.Enabled = false;
            this.figura_tbox.Location = new System.Drawing.Point(172, 354);
            this.figura_tbox.Name = "figura_tbox";
            this.figura_tbox.Size = new System.Drawing.Size(145, 22);
            this.figura_tbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "TM";
            // 
            // tmayor_tbox
            // 
            this.tmayor_tbox.Enabled = false;
            this.tmayor_tbox.Location = new System.Drawing.Point(553, 109);
            this.tmayor_tbox.Name = "tmayor_tbox";
            this.tmayor_tbox.Size = new System.Drawing.Size(119, 22);
            this.tmayor_tbox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tm";
            // 
            // tmenor_tbox
            // 
            this.tmenor_tbox.Enabled = false;
            this.tmenor_tbox.Location = new System.Drawing.Point(553, 184);
            this.tmenor_tbox.Name = "tmenor_tbox";
            this.tmenor_tbox.Size = new System.Drawing.Size(119, 22);
            this.tmenor_tbox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "T 1/2";
            // 
            // tmedio_tbox
            // 
            this.tmedio_tbox.Enabled = false;
            this.tmedio_tbox.Location = new System.Drawing.Point(553, 259);
            this.tmedio_tbox.Name = "tmedio_tbox";
            this.tmedio_tbox.ReadOnly = true;
            this.tmedio_tbox.Size = new System.Drawing.Size(119, 22);
            this.tmedio_tbox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ingrese Datos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Modo";
            // 
            // modo_tbox
            // 
            this.modo_tbox.Enabled = false;
            this.modo_tbox.Location = new System.Drawing.Point(332, 354);
            this.modo_tbox.Name = "modo_tbox";
            this.modo_tbox.Size = new System.Drawing.Size(145, 22);
            this.modo_tbox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.modo_tbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tmedio_tbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tmenor_tbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tmayor_tbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.figura_tbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.conclucion_tbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pmenor_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pmayor_tbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pmayor_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pmenor_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox conclucion_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox figura_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tmayor_tbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tmenor_tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tmedio_tbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox modo_tbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

