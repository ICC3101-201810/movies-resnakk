namespace WindowsFormsApp2
{
    partial class Menu
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
            this.LSearch = new System.Windows.Forms.Label();
            this.BActores = new System.Windows.Forms.Button();
            this.BDirectores = new System.Windows.Forms.Button();
            this.BEstudios = new System.Windows.Forms.Button();
            this.BProductores = new System.Windows.Forms.Button();
            this.BPeliculas = new System.Windows.Forms.Button();
            this.BTodo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TSearch = new System.Windows.Forms.TextBox();
            this.CC = new System.Windows.Forms.ComboBox();
            this.BVer = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.BCritica = new System.Windows.Forms.Button();
            this.BVC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LSearch
            // 
            this.LSearch.AutoSize = true;
            this.LSearch.Location = new System.Drawing.Point(179, 166);
            this.LSearch.Name = "LSearch";
            this.LSearch.Size = new System.Drawing.Size(44, 13);
            this.LSearch.TabIndex = 13;
            this.LSearch.Text = "Search:";
            // 
            // BActores
            // 
            this.BActores.Location = new System.Drawing.Point(341, 212);
            this.BActores.Name = "BActores";
            this.BActores.Size = new System.Drawing.Size(75, 23);
            this.BActores.TabIndex = 11;
            this.BActores.Text = "Actores";
            this.BActores.UseVisualStyleBackColor = true;
            this.BActores.Click += new System.EventHandler(this.BActores_Click);
            // 
            // BDirectores
            // 
            this.BDirectores.Location = new System.Drawing.Point(422, 212);
            this.BDirectores.Name = "BDirectores";
            this.BDirectores.Size = new System.Drawing.Size(75, 23);
            this.BDirectores.TabIndex = 10;
            this.BDirectores.Text = "Directores";
            this.BDirectores.UseVisualStyleBackColor = true;
            this.BDirectores.Click += new System.EventHandler(this.BDirectores_Click);
            // 
            // BEstudios
            // 
            this.BEstudios.Location = new System.Drawing.Point(584, 212);
            this.BEstudios.Name = "BEstudios";
            this.BEstudios.Size = new System.Drawing.Size(75, 23);
            this.BEstudios.TabIndex = 9;
            this.BEstudios.Text = "Estudios";
            this.BEstudios.UseVisualStyleBackColor = true;
            this.BEstudios.Click += new System.EventHandler(this.BEstudios_Click);
            // 
            // BProductores
            // 
            this.BProductores.Location = new System.Drawing.Point(503, 212);
            this.BProductores.Name = "BProductores";
            this.BProductores.Size = new System.Drawing.Size(75, 23);
            this.BProductores.TabIndex = 8;
            this.BProductores.Text = "Productores";
            this.BProductores.UseVisualStyleBackColor = true;
            this.BProductores.Click += new System.EventHandler(this.BProductores_Click);
            // 
            // BPeliculas
            // 
            this.BPeliculas.Location = new System.Drawing.Point(260, 212);
            this.BPeliculas.Name = "BPeliculas";
            this.BPeliculas.Size = new System.Drawing.Size(75, 23);
            this.BPeliculas.TabIndex = 7;
            this.BPeliculas.Text = "Peliculas";
            this.BPeliculas.UseVisualStyleBackColor = true;
            this.BPeliculas.Click += new System.EventHandler(this.BPeliculas_Click);
            // 
            // BTodo
            // 
            this.BTodo.Location = new System.Drawing.Point(179, 212);
            this.BTodo.Name = "BTodo";
            this.BTodo.Size = new System.Drawing.Size(75, 23);
            this.BTodo.TabIndex = 14;
            this.BTodo.Text = "Search";
            this.BTodo.UseVisualStyleBackColor = true;
            this.BTodo.Click += new System.EventHandler(this.BTodo_Click);
            // 
            // TSearch
            // 
            this.TSearch.Location = new System.Drawing.Point(179, 186);
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(480, 20);
            this.TSearch.TabIndex = 16;
            // 
            // CC
            // 
            this.CC.FormattingEnabled = true;
            this.CC.Location = new System.Drawing.Point(182, 242);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(480, 21);
            this.CC.TabIndex = 17;
            // 
            // BVer
            // 
            this.BVer.Location = new System.Drawing.Point(182, 270);
            this.BVer.Name = "BVer";
            this.BVer.Size = new System.Drawing.Size(75, 23);
            this.BVer.TabIndex = 18;
            this.BVer.Text = "Ver";
            this.BVer.UseVisualStyleBackColor = true;
            this.BVer.Click += new System.EventHandler(this.BVer_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(713, 415);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(75, 23);
            this.BSalir.TabIndex = 19;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BCritica
            // 
            this.BCritica.Location = new System.Drawing.Point(569, 270);
            this.BCritica.Name = "BCritica";
            this.BCritica.Size = new System.Drawing.Size(93, 23);
            this.BCritica.TabIndex = 20;
            this.BCritica.Text = "Añadir Critica";
            this.BCritica.UseVisualStyleBackColor = true;
            this.BCritica.Click += new System.EventHandler(this.button1_Click);
            // 
            // BVC
            // 
            this.BVC.Location = new System.Drawing.Point(569, 300);
            this.BVC.Name = "BVC";
            this.BVC.Size = new System.Drawing.Size(93, 23);
            this.BVC.TabIndex = 21;
            this.BVC.Text = "Ver Criticas";
            this.BVC.UseVisualStyleBackColor = true;
            this.BVC.Click += new System.EventHandler(this.BVC_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BVC);
            this.Controls.Add(this.BCritica);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BVer);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.TSearch);
            this.Controls.Add(this.BTodo);
            this.Controls.Add(this.LSearch);
            this.Controls.Add(this.BActores);
            this.Controls.Add(this.BDirectores);
            this.Controls.Add(this.BEstudios);
            this.Controls.Add(this.BProductores);
            this.Controls.Add(this.BPeliculas);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LSearch;
        private System.Windows.Forms.Button BActores;
        private System.Windows.Forms.Button BDirectores;
        private System.Windows.Forms.Button BEstudios;
        private System.Windows.Forms.Button BProductores;
        private System.Windows.Forms.Button BPeliculas;
        private System.Windows.Forms.Button BTodo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TSearch;
        private System.Windows.Forms.ComboBox CC;
        private System.Windows.Forms.Button BVer;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BCritica;
        private System.Windows.Forms.Button BVC;
    }
}