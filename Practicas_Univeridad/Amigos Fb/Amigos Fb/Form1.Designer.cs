namespace Amigos_Fb
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ptbfoto = new System.Windows.Forms.PictureBox();
            this.txturl = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtam = new System.Windows.Forms.TextBox();
            this.txtap = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(568, 67);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(101, 27);
            this.btnnuevo.TabIndex = 18;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(568, 21);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(101, 30);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ptbfoto);
            this.groupBox2.Controls.Add(this.txturl);
            this.groupBox2.Controls.Add(this.txtciudad);
            this.groupBox2.Controls.Add(this.txtedad);
            this.groupBox2.Controls.Add(this.txtmail);
            this.groupBox2.Controls.Add(this.txtam);
            this.groupBox2.Controls.Add(this.txtap);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 304);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(514, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Foto:";
            // 
            // ptbfoto
            // 
            this.ptbfoto.Location = new System.Drawing.Point(456, 73);
            this.ptbfoto.Name = "ptbfoto";
            this.ptbfoto.Size = new System.Drawing.Size(185, 185);
            this.ptbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbfoto.TabIndex = 14;
            this.ptbfoto.TabStop = false;
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(142, 261);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(238, 22);
            this.txturl.TabIndex = 13;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(142, 221);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(238, 22);
            this.txtciudad.TabIndex = 12;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(142, 183);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(238, 22);
            this.txtedad.TabIndex = 11;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(142, 145);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(238, 22);
            this.txtmail.TabIndex = 10;
            // 
            // txtam
            // 
            this.txtam.Location = new System.Drawing.Point(142, 108);
            this.txtam.Name = "txtam";
            this.txtam.Size = new System.Drawing.Size(238, 22);
            this.txtam.TabIndex = 9;
            // 
            // txtap
            // 
            this.txtap.Location = new System.Drawing.Point(142, 70);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(238, 22);
            this.txtap.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(142, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(238, 22);
            this.txtnombre.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Apellido Paterno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Url De Facebook:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido Materno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(255, 51);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(248, 22);
            this.txtbuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Amigo  A Buscar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Base De Datos Amigos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox ptbfoto;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtam;
        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

