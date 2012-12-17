namespace WindowsFormsApplication1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.btIngresar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(34, 42);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // lbContrasena
            // 
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.Location = new System.Drawing.Point(34, 78);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(61, 13);
            this.lbContrasena.TabIndex = 1;
            this.lbContrasena.Text = "Contraseña";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(136, 34);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(170, 20);
            this.tbLogin.TabIndex = 2;
            // 
            // tbContrasena
            // 
            this.tbContrasena.Location = new System.Drawing.Point(136, 70);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(170, 20);
            this.tbContrasena.TabIndex = 3;
            this.tbContrasena.UseSystemPasswordChar = true;
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(67, 132);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(75, 23);
            this.btIngresar.TabIndex = 4;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(177, 131);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 177);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbContrasena);
            this.Controls.Add(this.lbLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Button btSalir;
    }
}