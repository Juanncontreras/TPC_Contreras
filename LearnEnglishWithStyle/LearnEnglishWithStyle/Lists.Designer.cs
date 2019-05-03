namespace LearnEnglishWithStyle
{
    partial class Lists
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
            this.dgvLists = new System.Windows.Forms.DataGridView();
            this.btIrregularsVerbs = new System.Windows.Forms.Button();
            this.btRegularVerbs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLists
            // 
            this.dgvLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLists.Location = new System.Drawing.Point(340, 22);
            this.dgvLists.Name = "dgvLists";
            this.dgvLists.Size = new System.Drawing.Size(434, 416);
            this.dgvLists.TabIndex = 0;
            // 
            // btIrregularsVerbs
            // 
            this.btIrregularsVerbs.Location = new System.Drawing.Point(70, 22);
            this.btIrregularsVerbs.Name = "btIrregularsVerbs";
            this.btIrregularsVerbs.Size = new System.Drawing.Size(164, 23);
            this.btIrregularsVerbs.TabIndex = 1;
            this.btIrregularsVerbs.Text = "Irregular Verbs";
            this.btIrregularsVerbs.UseVisualStyleBackColor = true;
            this.btIrregularsVerbs.Click += new System.EventHandler(this.btIrregularsVerbs_Click);
            // 
            // btRegularVerbs
            // 
            this.btRegularVerbs.Location = new System.Drawing.Point(70, 78);
            this.btRegularVerbs.Name = "btRegularVerbs";
            this.btRegularVerbs.Size = new System.Drawing.Size(164, 23);
            this.btRegularVerbs.TabIndex = 2;
            this.btRegularVerbs.Text = "Regular Verbs";
            this.btRegularVerbs.UseVisualStyleBackColor = true;
            this.btRegularVerbs.Click += new System.EventHandler(this.BtRegularVerbs_Click);
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRegularVerbs);
            this.Controls.Add(this.btIrregularsVerbs);
            this.Controls.Add(this.dgvLists);
            this.Name = "Lists";
            this.Text = "LearnEnglishWithStyle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLists;
        private System.Windows.Forms.Button btIrregularsVerbs;
        private System.Windows.Forms.Button btRegularVerbs;
    }
}