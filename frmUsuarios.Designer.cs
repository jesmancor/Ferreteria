namespace Ferreteria
{
    partial class frmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.gbAñadirUsuario = new System.Windows.Forms.GroupBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmar = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAñadirUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(10, 64);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(91, 25);
            this.lblUsuarios.TabIndex = 7;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Nombre de usuario";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // gbAñadirUsuario
            // 
            this.gbAñadirUsuario.Controls.Add(this.btnAñadir);
            this.gbAñadirUsuario.Controls.Add(this.txtConfirmar);
            this.gbAñadirUsuario.Controls.Add(this.lblConfirmar);
            this.gbAñadirUsuario.Controls.Add(this.txtPassword);
            this.gbAñadirUsuario.Controls.Add(this.lblContraseña);
            this.gbAñadirUsuario.Controls.Add(this.lblUsername);
            this.gbAñadirUsuario.Controls.Add(this.txtUsername);
            this.gbAñadirUsuario.Location = new System.Drawing.Point(15, 112);
            this.gbAñadirUsuario.Name = "gbAñadirUsuario";
            this.gbAñadirUsuario.Size = new System.Drawing.Size(323, 143);
            this.gbAñadirUsuario.TabIndex = 10;
            this.gbAñadirUsuario.TabStop = false;
            this.gbAñadirUsuario.Text = "Añadir nuevo usuario";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(215, 107);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 15;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(118, 81);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(172, 20);
            this.txtConfirmar.TabIndex = 14;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(6, 84);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(107, 13);
            this.lblConfirmar.TabIndex = 13;
            this.lblConfirmar.Text = "Confirmar contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 20);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(51, 58);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña";
            // 
            // epUsername
            // 
            this.epUsername.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epUsername.ContainerControl = this;
            this.epUsername.Icon = ((System.Drawing.Icon)(resources.GetObject("epUsername.Icon")));
            // 
            // epPassword
            // 
            this.epPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPassword.ContainerControl = this;
            this.epPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("epPassword.Icon")));
            // 
            // epConfirmar
            // 
            this.epConfirmar.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epConfirmar.ContainerControl = this;
            this.epConfirmar.Icon = ((System.Drawing.Icon)(resources.GetObject("epConfirmar.Icon")));
            // 
            // frmUsuarios
            // 
            this.AcceptButton = this.btnAñadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 420);
            this.Controls.Add(this.gbAñadirUsuario);
            this.Controls.Add(this.lblUsuarios);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmUsuarios";
            this.Controls.SetChildIndex(this.lblUsuarios, 0);
            this.Controls.SetChildIndex(this.gbAñadirUsuario, 0);
            this.gbAñadirUsuario.ResumeLayout(false);
            this.gbAñadirUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox gbAñadirUsuario;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.ErrorProvider epConfirmar;
    }
}
