namespace TelegramBot_v2
{
    partial class AddChanellsDialog
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
            this.AddChanell = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddChanell
            // 
            this.AddChanell.Location = new System.Drawing.Point(90, 77);
            this.AddChanell.Name = "AddChanell";
            this.AddChanell.Size = new System.Drawing.Size(94, 42);
            this.AddChanell.TabIndex = 0;
            this.AddChanell.Text = "Add";
            this.AddChanell.UseVisualStyleBackColor = true;
            this.AddChanell.Click += new System.EventHandler(this.AddChanell_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 1;
            // 
            // AddChanellsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 159);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddChanell);
            this.Name = "AddChanellsDialog";
            this.Text = "AddChanellsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddChanell;
        private System.Windows.Forms.TextBox textBox1;
    }
}