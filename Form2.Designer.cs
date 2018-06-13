namespace WindowsFormsApp2
{
    partial class Form2
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
            this.BSalir = new System.Windows.Forms.Button();
            this.BVolver = new System.Windows.Forms.Button();
            this.TComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.BEnviar = new System.Windows.Forms.Button();
            this.CC = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(713, 415);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 20;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(713, 386);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(75, 23);
            this.BVolver.TabIndex = 21;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // TComentario
            // 
            this.TComentario.Location = new System.Drawing.Point(240, 207);
            this.TComentario.Multiline = true;
            this.TComentario.Name = "TComentario";
            this.TComentario.Size = new System.Drawing.Size(322, 20);
            this.TComentario.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Comentario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(240, 169);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(322, 20);
            this.TNombre.TabIndex = 24;
            // 
            // BEnviar
            // 
            this.BEnviar.Location = new System.Drawing.Point(568, 207);
            this.BEnviar.Name = "BEnviar";
            this.BEnviar.Size = new System.Drawing.Size(75, 23);
            this.BEnviar.TabIndex = 26;
            this.BEnviar.Text = "Enviar";
            this.BEnviar.UseVisualStyleBackColor = true;
            this.BEnviar.Click += new System.EventHandler(this.BEnviar_Click);
            // 
            // CC
            // 
            this.CC.FormattingEnabled = true;
            this.CC.Location = new System.Drawing.Point(240, 129);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(322, 21);
            this.CC.TabIndex = 27;
            this.CC.SelectedIndexChanged += new System.EventHandler(this.CC_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pelicula:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.BEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TComentario);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.BSalir);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.TextBox TComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.Button BEnviar;
        private System.Windows.Forms.ComboBox CC;
        private System.Windows.Forms.Label label3;
    }
}