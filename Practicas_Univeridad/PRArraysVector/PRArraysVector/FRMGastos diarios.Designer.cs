namespace PRArraysVector
{
    partial class FRMGastos_diarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbogastos = new System.Windows.Forms.ComboBox();
            this.txtgastomayor = new System.Windows.Forms.TextBox();
            this.txtdiamayor = new System.Windows.Forms.TextBox();
            this.txttotalgastos = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdias);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(159, 60);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(100, 22);
            this.txtdias.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Dias:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbogastos);
            this.groupBox2.Controls.Add(this.txtgastomayor);
            this.groupBox2.Controls.Add(this.txtdiamayor);
            this.groupBox2.Controls.Add(this.txttotalgastos);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cbogastos
            // 
            this.cbogastos.FormattingEnabled = true;
            this.cbogastos.Location = new System.Drawing.Point(159, 33);
            this.cbogastos.Name = "cbogastos";
            this.cbogastos.Size = new System.Drawing.Size(121, 24);
            this.cbogastos.TabIndex = 6;
            // 
            // txtgastomayor
            // 
            this.txtgastomayor.Location = new System.Drawing.Point(271, 152);
            this.txtgastomayor.Name = "txtgastomayor";
            this.txtgastomayor.Size = new System.Drawing.Size(124, 22);
            this.txtgastomayor.TabIndex = 5;
            // 
            // txtdiamayor
            // 
            this.txtdiamayor.Location = new System.Drawing.Point(159, 152);
            this.txtdiamayor.Name = "txtdiamayor";
            this.txtdiamayor.Size = new System.Drawing.Size(100, 22);
            this.txtdiamayor.TabIndex = 4;
            // 
            // txttotalgastos
            // 
            this.txttotalgastos.Location = new System.Drawing.Point(159, 93);
            this.txttotalgastos.Name = "txttotalgastos";
            this.txttotalgastos.Size = new System.Drawing.Size(146, 22);
            this.txttotalgastos.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Gastos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gastos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mayor Gasto:";
            // 
            // FRMGastos_diarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMGastos_diarios";
            this.Text = "Gastos Diarios";
            this.Load += new System.EventHandler(this.FRMGastos_diarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbogastos;
        private System.Windows.Forms.TextBox txtgastomayor;
        private System.Windows.Forms.TextBox txtdiamayor;
        private System.Windows.Forms.TextBox txttotalgastos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}