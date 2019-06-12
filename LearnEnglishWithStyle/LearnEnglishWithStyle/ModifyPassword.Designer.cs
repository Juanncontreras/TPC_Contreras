namespace LearnEnglishWithStyle
{
    partial class ModifyPassword
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbltitulo1 = new System.Windows.Forms.Label();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbConfirmNewPass = new System.Windows.Forms.TextBox();
            this.btAceppt = new System.Windows.Forms.Button();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblConfirmNewPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(72, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(121, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cambiar";
            // 
            // lbltitulo1
            // 
            this.lbltitulo1.AutoSize = true;
            this.lbltitulo1.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo1.Location = new System.Drawing.Point(57, 69);
            this.lbltitulo1.Name = "lbltitulo1";
            this.lbltitulo1.Size = new System.Drawing.Size(150, 43);
            this.lbltitulo1.TabIndex = 1;
            this.lbltitulo1.Text = "contraseña";
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(58, 161);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(149, 20);
            this.tbOldPass.TabIndex = 2;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(58, 225);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(149, 20);
            this.tbNewPass.TabIndex = 3;
            // 
            // tbConfirmNewPass
            // 
            this.tbConfirmNewPass.Location = new System.Drawing.Point(58, 287);
            this.tbConfirmNewPass.Name = "tbConfirmNewPass";
            this.tbConfirmNewPass.Size = new System.Drawing.Size(149, 20);
            this.tbConfirmNewPass.TabIndex = 4;
            // 
            // btAceppt
            // 
            this.btAceppt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAceppt.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceppt.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAceppt.Location = new System.Drawing.Point(58, 340);
            this.btAceppt.Name = "btAceppt";
            this.btAceppt.Size = new System.Drawing.Size(149, 52);
            this.btAceppt.TabIndex = 5;
            this.btAceppt.Text = "Aceptar";
            this.btAceppt.UseVisualStyleBackColor = false;
            this.btAceppt.Click += new System.EventHandler(this.BtAceppt_Click);
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(64, 135);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(129, 23);
            this.lblOldPass.TabIndex = 6;
            this.lblOldPass.Text = "contraseña actual";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.Location = new System.Drawing.Point(66, 199);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(127, 23);
            this.lblNewPass.TabIndex = 7;
            this.lblNewPass.Text = "contraseña nueva";
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.AutoSize = true;
            this.lblConfirmNewPass.Font = new System.Drawing.Font("Segoe Print", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPass.Location = new System.Drawing.Point(33, 261);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.Size = new System.Drawing.Size(204, 23);
            this.lblConfirmNewPass.TabIndex = 8;
            this.lblConfirmNewPass.Text = " confirmar contraseña nueva";
            // 
            // ModifyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(264, 450);
            this.Controls.Add(this.lblConfirmNewPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.btAceppt);
            this.Controls.Add(this.tbConfirmNewPass);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.lbltitulo1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ModifyPassword";
            this.Text = "LearnEnglishWithStyle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbltitulo1;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbConfirmNewPass;
        private System.Windows.Forms.Button btAceppt;
        private System.Windows.Forms.Label lblOldPass;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblConfirmNewPass;
    }
}