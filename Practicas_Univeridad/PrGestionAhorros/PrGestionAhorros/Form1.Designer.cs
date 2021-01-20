namespace PrGestionAhorros
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
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnretiro = new System.Windows.Forms.Button();
            this.btndeposito = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstretiros = new System.Windows.Forms.ListBox();
            this.lstdepositos = new System.Windows.Forms.ListBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmonto);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.btnabrir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingre Los Datos";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(130, 93);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(215, 22);
            this.txtmonto.TabIndex = 4;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(130, 45);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(215, 22);
            this.txtCliente.TabIndex = 3;
            // 
            // btnabrir
            // 
            this.btnabrir.Location = new System.Drawing.Point(392, 48);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(123, 46);
            this.btnabrir.TabIndex = 2;
            this.btnabrir.Text = "Abrir Cuenta";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnretiro);
            this.groupBox2.Controls.Add(this.btndeposito);
            this.groupBox2.Location = new System.Drawing.Point(16, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transacciones";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnretiro
            // 
            this.btnretiro.Location = new System.Drawing.Point(260, 49);
            this.btnretiro.Name = "btnretiro";
            this.btnretiro.Size = new System.Drawing.Size(108, 41);
            this.btnretiro.TabIndex = 4;
            this.btnretiro.Text = "Retiro";
            this.btnretiro.UseVisualStyleBackColor = true;
            this.btnretiro.Click += new System.EventHandler(this.btnretiro_Click);
            // 
            // btndeposito
            // 
            this.btndeposito.Location = new System.Drawing.Point(53, 49);
            this.btndeposito.Name = "btndeposito";
            this.btndeposito.Size = new System.Drawing.Size(95, 41);
            this.btndeposito.TabIndex = 3;
            this.btndeposito.Text = "Deposito";
            this.btndeposito.UseVisualStyleBackColor = true;
            this.btndeposito.Click += new System.EventHandler(this.btndeposito_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstretiros);
            this.groupBox3.Controls.Add(this.lstdepositos);
            this.groupBox3.Controls.Add(this.txtsaldo);
            this.groupBox3.Controls.Add(this.btnnuevo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(16, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(531, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historial";
            // 
            // lstretiros
            // 
            this.lstretiros.FormattingEnabled = true;
            this.lstretiros.ItemHeight = 16;
            this.lstretiros.Location = new System.Drawing.Point(181, 71);
            this.lstretiros.Name = "lstretiros";
            this.lstretiros.Size = new System.Drawing.Size(120, 116);
            this.lstretiros.TabIndex = 7;
            // 
            // lstdepositos
            // 
            this.lstdepositos.FormattingEnabled = true;
            this.lstdepositos.ItemHeight = 16;
            this.lstdepositos.Location = new System.Drawing.Point(34, 71);
            this.lstdepositos.Name = "lstdepositos";
            this.lstdepositos.Size = new System.Drawing.Size(120, 116);
            this.lstdepositos.TabIndex = 6;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(434, 129);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(91, 22);
            this.txtsaldo.TabIndex = 5;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(434, 160);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Retiros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Depositos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gestion de Cuentas de Ahorros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnretiro;
        private System.Windows.Forms.Button btndeposito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstretiros;
        private System.Windows.Forms.ListBox lstdepositos;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

