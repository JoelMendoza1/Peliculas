namespace ProyectoPelicula
{
    partial class Form3
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
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbNombreUsu = new System.Windows.Forms.Label();
            this.btnMostrarFavoritos = new System.Windows.Forms.Button();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbPrueba = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.Location = new System.Drawing.Point(620, 446);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(130, 34);
            this.btnFavoritos.TabIndex = 2;
            this.btnFavoritos.Text = "Añadir a favoritos";
            this.btnFavoritos.UseVisualStyleBackColor = true;
            this.btnFavoritos.Click += new System.EventHandler(this.BtnFavoritos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(626, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(171, 27);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // lbNombreUsu
            // 
            this.lbNombreUsu.AutoSize = true;
            this.lbNombreUsu.BackColor = System.Drawing.Color.LightGray;
            this.lbNombreUsu.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreUsu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNombreUsu.Location = new System.Drawing.Point(25, 10);
            this.lbNombreUsu.Name = "lbNombreUsu";
            this.lbNombreUsu.Size = new System.Drawing.Size(187, 28);
            this.lbNombreUsu.TabIndex = 10;
            this.lbNombreUsu.Text = "Nombre Usuario";
            // 
            // btnMostrarFavoritos
            // 
            this.btnMostrarFavoritos.Location = new System.Drawing.Point(626, 27);
            this.btnMostrarFavoritos.Name = "btnMostrarFavoritos";
            this.btnMostrarFavoritos.Size = new System.Drawing.Size(171, 25);
            this.btnMostrarFavoritos.TabIndex = 18;
            this.btnMostrarFavoritos.Text = "Mostrar Favoritos";
            this.btnMostrarFavoritos.UseVisualStyleBackColor = true;
            this.btnMostrarFavoritos.Click += new System.EventHandler(this.BtnMostrarFavoritos_Click);
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(620, 206);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(130, 195);
            this.img1.TabIndex = 8;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.Img1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 51);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Location = new System.Drawing.Point(142, 228);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(35, 13);
            this.lbPrueba.TabIndex = 23;
            this.lbPrueba.Text = "label1";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(59, 72);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(691, 104);
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(445, 206);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(146, 21);
            this.cmbPelicula.TabIndex = 24;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(789, 647);
            this.Controls.Add(this.cmbPelicula);
            this.Controls.Add(this.lbPrueba);
            this.Controls.Add(this.btnMostrarFavoritos);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lbNombreUsu);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFavoritos);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFavoritos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.Label lbNombreUsu;
        private System.Windows.Forms.Button btnMostrarFavoritos;
        private System.Windows.Forms.Label lbPrueba;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ComboBox cmbPelicula;
    }
}