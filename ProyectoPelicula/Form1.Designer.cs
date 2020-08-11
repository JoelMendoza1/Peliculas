namespace ProyectoPelicula
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.bntIniciar = new System.Windows.Forms.Button();
            this.linkLbRegistrarse = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbExito = new System.Windows.Forms.Label();
            this.lbPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(139, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(194, 161);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "";
            this.txtPassword.Location = new System.Drawing.Point(194, 198);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(92, 164);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(102, 13);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Nombre de usuario: ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(127, 205);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 13);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Contraseña: ";
            this.lbPassword.Click += new System.EventHandler(this.LbPassword_Click);
            // 
            // bntIniciar
            // 
            this.bntIniciar.Location = new System.Drawing.Point(259, 237);
            this.bntIniciar.Name = "bntIniciar";
            this.bntIniciar.Size = new System.Drawing.Size(102, 23);
            this.bntIniciar.TabIndex = 8;
            this.bntIniciar.Text = "Iniciar Sesión";
            this.bntIniciar.UseVisualStyleBackColor = true;
            this.bntIniciar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // linkLbRegistrarse
            // 
            this.linkLbRegistrarse.AutoSize = true;
            this.linkLbRegistrarse.Location = new System.Drawing.Point(277, 269);
            this.linkLbRegistrarse.Name = "linkLbRegistrarse";
            this.linkLbRegistrarse.Size = new System.Drawing.Size(84, 13);
            this.linkLbRegistrarse.TabIndex = 9;
            this.linkLbRegistrarse.TabStop = true;
            this.linkLbRegistrarse.Text = "Registrate AQUI";
            this.linkLbRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "No tienes cuenta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(76, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(409, 294);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbExito
            // 
            this.lbExito.AutoSize = true;
            this.lbExito.Location = new System.Drawing.Point(368, 246);
            this.lbExito.Name = "lbExito";
            this.lbExito.Size = new System.Drawing.Size(0, 13);
            this.lbExito.TabIndex = 11;
            // 
            // lbPrueba
            // 
            this.lbPrueba.AutoSize = true;
            this.lbPrueba.Location = new System.Drawing.Point(396, 246);
            this.lbPrueba.Name = "lbPrueba";
            this.lbPrueba.Size = new System.Drawing.Size(35, 13);
            this.lbPrueba.TabIndex = 12;
            this.lbPrueba.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.lbPrueba);
            this.Controls.Add(this.lbExito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLbRegistrarse);
            this.Controls.Add(this.bntIniciar);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button bntIniciar;
        private System.Windows.Forms.LinkLabel linkLbRegistrarse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbExito;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbPrueba;
    }
}

