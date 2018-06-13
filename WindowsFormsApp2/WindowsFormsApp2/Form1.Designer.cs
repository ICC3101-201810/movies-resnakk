namespace WindowsFormsApp2
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
            this.LBienvenido1 = new System.Windows.Forms.Label();
            this.LBienvenido2 = new System.Windows.Forms.Label();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBienvenido1
            // 
            this.LBienvenido1.AutoSize = true;
            this.LBienvenido1.BackColor = System.Drawing.SystemColors.Control;
            this.LBienvenido1.Font = new System.Drawing.Font("Proxy 9", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(3)));
            this.LBienvenido1.Location = new System.Drawing.Point(159, 184);
            this.LBienvenido1.Name = "LBienvenido1";
            this.LBienvenido1.Size = new System.Drawing.Size(463, 73);
            this.LBienvenido1.TabIndex = 2;
            this.LBienvenido1.Text = "BIENVENIDO!";
            // 
            // LBienvenido2
            // 
            this.LBienvenido2.AutoSize = true;
            this.LBienvenido2.BackColor = System.Drawing.SystemColors.Control;
            this.LBienvenido2.Font = new System.Drawing.Font("Proxy 9", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(3)));
            this.LBienvenido2.Location = new System.Drawing.Point(159, 295);
            this.LBienvenido2.Name = "LBienvenido2";
            this.LBienvenido2.Size = new System.Drawing.Size(463, 73);
            this.LBienvenido2.TabIndex = 3;
            this.LBienvenido2.Text = "BIENVENIDO!";
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.BackColor = System.Drawing.SystemColors.Control;
            this.LBienvenido.Font = new System.Drawing.Font("Proxy 9", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(3)));
            this.LBienvenido.Location = new System.Drawing.Point(159, 68);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(463, 73);
            this.LBienvenido.TabIndex = 1;
            this.LBienvenido.Text = "BIENVENIDO!";
            this.LBienvenido.Click += new System.EventHandler(this.LBienvenido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBienvenido2);
            this.Controls.Add(this.LBienvenido1);
            this.Controls.Add(this.LBienvenido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBienvenido1;
        private System.Windows.Forms.Label LBienvenido2;
        private System.Windows.Forms.Label LBienvenido;
    }
}

