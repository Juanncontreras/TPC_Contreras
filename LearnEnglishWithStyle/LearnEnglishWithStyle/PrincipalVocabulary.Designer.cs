namespace LearnEnglishWithStyle
{
    partial class PrincipalVocabulary
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
            this.gpMenuVocabulary = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btWord = new System.Windows.Forms.Button();
            this.gpMenuVocabulary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpMenuVocabulary
            // 
            this.gpMenuVocabulary.Controls.Add(this.btExit);
            this.gpMenuVocabulary.Controls.Add(this.button2);
            this.gpMenuVocabulary.Controls.Add(this.btWord);
            this.gpMenuVocabulary.Location = new System.Drawing.Point(186, 65);
            this.gpMenuVocabulary.Name = "gpMenuVocabulary";
            this.gpMenuVocabulary.Size = new System.Drawing.Size(343, 238);
            this.gpMenuVocabulary.TabIndex = 0;
            this.gpMenuVocabulary.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(96, 172);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(151, 40);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lists";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btWord
            // 
            this.btWord.Location = new System.Drawing.Point(96, 30);
            this.btWord.Name = "btWord";
            this.btWord.Size = new System.Drawing.Size(151, 40);
            this.btWord.TabIndex = 0;
            this.btWord.Text = "Words";
            this.btWord.UseVisualStyleBackColor = true;
            // 
            // PrincipalVocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.gpMenuVocabulary);
            this.Name = "PrincipalVocabulary";
            this.Text = "LearnEnglishWithStyle";
            this.gpMenuVocabulary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpMenuVocabulary;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btWord;
    }
}