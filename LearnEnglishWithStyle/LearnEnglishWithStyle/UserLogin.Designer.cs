namespace LearnEnglishWithStyle
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.pbUserLogin = new System.Windows.Forms.PictureBox();
            this.plUserLogin = new System.Windows.Forms.Panel();
            this.cbAlumnoProfesor = new System.Windows.Forms.ComboBox();
            this.lblAlumnoProfesor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.lblNoRegistrado = new System.Windows.Forms.Label();
            this.btRegistrate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogin)).BeginInit();
            this.plUserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbUserLogin
            // 
            this.pbUserLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbUserLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUserLogin.BackgroundImage")));
            this.pbUserLogin.Location = new System.Drawing.Point(21, 77);
            this.pbUserLogin.Name = "pbUserLogin";
            this.pbUserLogin.Size = new System.Drawing.Size(260, 259);
            this.pbUserLogin.TabIndex = 3;
            this.pbUserLogin.TabStop = false;
            // 
            // plUserLogin
            // 
            this.plUserLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plUserLogin.Controls.Add(this.btAceptar);
            this.plUserLogin.Controls.Add(this.tbContraseña);
            this.plUserLogin.Controls.Add(this.tbEmail);
            this.plUserLogin.Controls.Add(this.lblContraseña);
            this.plUserLogin.Controls.Add(this.lblEmail);
            this.plUserLogin.Controls.Add(this.lblAlumnoProfesor);
            this.plUserLogin.Controls.Add(this.cbAlumnoProfesor);
            this.plUserLogin.Location = new System.Drawing.Point(278, 77);
            this.plUserLogin.Name = "plUserLogin";
            this.plUserLogin.Size = new System.Drawing.Size(503, 259);
            this.plUserLogin.TabIndex = 4;
            // 
            // cbAlumnoProfesor
            // 
            this.cbAlumnoProfesor.FormattingEnabled = true;
            this.cbAlumnoProfesor.Location = new System.Drawing.Point(111, 48);
            this.cbAlumnoProfesor.Name = "cbAlumnoProfesor";
            this.cbAlumnoProfesor.Size = new System.Drawing.Size(287, 21);
            this.cbAlumnoProfesor.TabIndex = 0;
            // 
            // lblAlumnoProfesor
            // 
            this.lblAlumnoProfesor.AutoSize = true;
            this.lblAlumnoProfesor.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnoProfesor.Location = new System.Drawing.Point(107, 12);
            this.lblAlumnoProfesor.Name = "lblAlumnoProfesor";
            this.lblAlumnoProfesor.Size = new System.Drawing.Size(291, 24);
            this.lblAlumnoProfesor.TabIndex = 1;
            this.lblAlumnoProfesor.Text = "Eres Alumno o Profesor ?";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(211, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(183, 132);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(143, 24);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(111, 109);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(287, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(111, 159);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(287, 20);
            this.tbContraseña.TabIndex = 5;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(322, 22);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(408, 36);
            this.lblIniciarSesion.TabIndex = 5;
            this.lblIniciarSesion.Text = "Inicia sesion o registraté";
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAceptar.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(145, 201);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(215, 30);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // lblNoRegistrado
            // 
            this.lblNoRegistrado.AutoSize = true;
            this.lblNoRegistrado.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRegistrado.Location = new System.Drawing.Point(405, 369);
            this.lblNoRegistrado.Name = "lblNoRegistrado";
            this.lblNoRegistrado.Size = new System.Drawing.Size(252, 24);
            this.lblNoRegistrado.TabIndex = 6;
            this.lblNoRegistrado.Text = "¿No estas registrado ?";
            // 
            // btRegistrate
            // 
            this.btRegistrate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btRegistrate.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrate.Location = new System.Drawing.Point(434, 408);
            this.btRegistrate.Name = "btRegistrate";
            this.btRegistrate.Size = new System.Drawing.Size(192, 30);
            this.btRegistrate.TabIndex = 7;
            this.btRegistrate.Text = "Registrate";
            this.btRegistrate.UseVisualStyleBackColor = false;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegistrate);
            this.Controls.Add(this.lblNoRegistrado);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.plUserLogin);
            this.Controls.Add(this.pbUserLogin);
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.Text = "LearnEnglishWithStyle";
            ((System.ComponentModel.ISupportInitialize)(this.pbUserLogin)).EndInit();
            this.plUserLogin.ResumeLayout(false);
            this.plUserLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserLogin;
        private System.Windows.Forms.Panel plUserLogin;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlumnoProfesor;
        private System.Windows.Forms.ComboBox cbAlumnoProfesor;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Label lblNoRegistrado;
        private System.Windows.Forms.Button btRegistrate;
    }
}