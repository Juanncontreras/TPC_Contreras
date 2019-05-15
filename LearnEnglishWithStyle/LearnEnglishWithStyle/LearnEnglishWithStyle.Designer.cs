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
            this.gpMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMenuPrincipal
            // 
            this.gpMenuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gpMenuPrincipal.BackgroundImage")));
            this.gpMenuPrincipal.Controls.Add(this.btExit);
            this.gpMenuPrincipal.Controls.Add(this.btHelp);
            this.gpMenuPrincipal.Controls.Add(this.btExercises);
            this.gpMenuPrincipal.Controls.Add(this.btVocabulary);
            this.gpMenuPrincipal.Location = new System.Drawing.Point(226, 47);
            this.gpMenuPrincipal.Name = "gpMenuPrincipal";
            this.gpMenuPrincipal.Size = new System.Drawing.Size(338, 338);
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
            // LearnEnglishWithStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpMenuPrincipal);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "LearnEnglishWithStyle";
            this.Text = "LearnEnglishWithStyle";
            this.Load += new System.EventHandler(this.LearnEnglishWithStyle_Load);
            this.gpMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMenuPrincipal;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Button btExercises;
        private System.Windows.Forms.Button btVocabulary;
    }
}

