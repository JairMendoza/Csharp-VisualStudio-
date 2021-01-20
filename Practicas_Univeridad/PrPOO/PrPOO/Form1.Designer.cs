namespace PrPOO
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
            this.btnobj1 = new System.Windows.Forms.Button();
            this.btnobj2 = new System.Windows.Forms.Button();
            this.btnobj = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnobj1
            // 
            this.btnobj1.Location = new System.Drawing.Point(110, 46);
            this.btnobj1.Name = "btnobj1";
            this.btnobj1.Size = new System.Drawing.Size(243, 60);
            this.btnobj1.TabIndex = 0;
            this.btnobj1.Text = "Objeto 1";
            this.btnobj1.UseVisualStyleBackColor = true;
            this.btnobj1.Click += new System.EventHandler(this.btnobj1_Click);
            // 
            // btnobj2
            // 
            this.btnobj2.Location = new System.Drawing.Point(110, 121);
            this.btnobj2.Name = "btnobj2";
            this.btnobj2.Size = new System.Drawing.Size(243, 60);
            this.btnobj2.TabIndex = 1;
            this.btnobj2.Text = "Objeto 2";
            this.btnobj2.UseVisualStyleBackColor = true;
            this.btnobj2.Click += new System.EventHandler(this.btnobj2_Click);
            // 
            // btnobj
            // 
            this.btnobj.Location = new System.Drawing.Point(110, 197);
            this.btnobj.Name = "btnobj";
            this.btnobj.Size = new System.Drawing.Size(243, 60);
            this.btnobj.TabIndex = 2;
            this.btnobj.Text = "Objeto 3";
            this.btnobj.UseVisualStyleBackColor = true;
            this.btnobj.Click += new System.EventHandler(this.btnobj_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(59, 323);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(344, 22);
            this.txtresultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 424);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnobj);
            this.Controls.Add(this.btnobj2);
            this.Controls.Add(this.btnobj1);
            this.Name = "Form1";
            this.Text = "POO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnobj1;
        private System.Windows.Forms.Button btnobj2;
        private System.Windows.Forms.Button btnobj;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

