namespace LearnEnglishWithStyle
{
    partial class SelectExercise
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
            this.btCards = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCards
            // 
            this.btCards.BackColor = System.Drawing.SystemColors.Window;
            this.btCards.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCards.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btCards.Location = new System.Drawing.Point(67, 88);
            this.btCards.Name = "btCards";
            this.btCards.Size = new System.Drawing.Size(115, 40);
            this.btCards.TabIndex = 0;
            this.btCards.Text = "Cards";
            this.btCards.UseVisualStyleBackColor = false;
            this.btCards.Click += new System.EventHandler(this.BtCards_Click);
            // 
            // SelectExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCards);
            this.Name = "SelectExercise";
            this.Text = "LearnEnglishWithStyle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCards;
    }
}