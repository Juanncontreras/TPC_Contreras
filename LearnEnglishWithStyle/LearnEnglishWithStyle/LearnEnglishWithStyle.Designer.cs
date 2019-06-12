namespace LearnEnglishWithStyle
{
    partial class LearnEnglishWithStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnEnglishWithStyle));
            this.gpMenuPrincipal = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.btExercises = new System.Windows.Forms.Button();
            this.btVocabulary = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpMenuPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMenuPrincipal
            // 
            this.gpMenuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpMenuPrincipal.BackgroundImage")));
            this.gpMenuPrincipal.Controls.Add(this.btExit);
            this.gpMenuPrincipal.Controls.Add(this.btHelp);
            this.gpMenuPrincipal.Controls.Add(this.btExercises);
            this.gpMenuPrincipal.Controls.Add(this.btVocabulary);
            this.gpMenuPrincipal.Location = new System.Drawing.Point(226, 46);
            this.gpMenuPrincipal.Name = "gpMenuPrincipal";
            this.gpMenuPrincipal.Size = new System.Drawing.Size(338, 339);
            this.gpMenuPrincipal.TabIndex = 1;
            this.gpMenuPrincipal.TabStop = false;
            this.gpMenuPrincipal.Enter += new System.EventHandler(this.gpMenuPrincipal_Enter);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(107, 279);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(140, 32);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(107, 210);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(140, 32);
            this.btHelp.TabIndex = 5;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = true;
            // 
            // btExercises
            // 
            this.btExercises.Location = new System.Drawing.Point(107, 131);
            this.btExercises.Name = "btExercises";
            this.btExercises.Size = new System.Drawing.Size(140, 32);
            this.btExercises.TabIndex = 4;
            this.btExercises.Text = "Excercises";
            this.btExercises.UseVisualStyleBackColor = true;
            // 
            // btVocabulary
            // 
            this.btVocabulary.Location = new System.Drawing.Point(107, 54);
            this.btVocabulary.Name = "btVocabulary";
            this.btVocabulary.Size = new System.Drawing.Size(140, 32);
            this.btVocabulary.TabIndex = 0;
            this.btVocabulary.Text = "Vocabulary";
            this.btVocabulary.UseVisualStyleBackColor = true;
            this.btVocabulary.Click += new System.EventHandler(this.btVocabulary_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarUsuarioToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.contraseñaToolStripMenuItem});
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar Usuario";
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            this.datosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.DatosPersonalesToolStripMenuItem_Click);
            // 
            // contraseñaToolStripMenuItem
            // 
            this.contraseñaToolStripMenuItem.Name = "contraseñaToolStripMenuItem";
            this.contraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contraseñaToolStripMenuItem.Text = "Contraseña";
            this.contraseñaToolStripMenuItem.Click += new System.EventHandler(this.ContraseñaToolStripMenuItem_Click);
            // 
            // LearnEnglishWithStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpMenuPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LearnEnglishWithStyle";
            this.Text = "LearnEnglishWithStyle";
            this.Load += new System.EventHandler(this.LearnEnglishWithStyle_Load);
            this.gpMenuPrincipal.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMenuPrincipal;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btExercises;
        private System.Windows.Forms.Button btVocabulary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraseñaToolStripMenuItem;
    }
}

