namespace CaesarBotNoSalad
{
    partial class Perexodnik
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncrBt = new System.Windows.Forms.Button();
            this.DecrBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EncrBt
            // 
            this.EncrBt.Location = new System.Drawing.Point(40, 151);
            this.EncrBt.Name = "EncrBt";
            this.EncrBt.Size = new System.Drawing.Size(94, 29);
            this.EncrBt.TabIndex = 0;
            this.EncrBt.Text = "encryption";
            this.EncrBt.UseVisualStyleBackColor = true;
            this.EncrBt.Click += new System.EventHandler(this.EncrBt_Click);
            // 
            // DecrBt
            // 
            this.DecrBt.Location = new System.Drawing.Point(303, 151);
            this.DecrBt.Name = "DecrBt";
            this.DecrBt.Size = new System.Drawing.Size(94, 29);
            this.DecrBt.TabIndex = 1;
            this.DecrBt.Text = "decryption";
            this.DecrBt.UseVisualStyleBackColor = true;
            this.DecrBt.Click += new System.EventHandler(this.DecrBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a mode";
            // 
            // Perexodnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecrBt);
            this.Controls.Add(this.EncrBt);
            this.Name = "Perexodnik";
            this.Text = "SelectWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EncrBt;
        private Button DecrBt;
        private Label label1;
    }
}