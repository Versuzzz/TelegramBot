namespace TelegramBot_v2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendTextButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendImageButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CodeFormatTextButton = new System.Windows.Forms.Button();
            this.ItalicFormatTextButton = new System.Windows.Forms.Button();
            this.BoldFormatTextButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.ConsoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.controlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chanellsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendTextButton
            // 
            this.SendTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SendTextButton.FlatAppearance.BorderSize = 0;
            this.SendTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendTextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SendTextButton.Location = new System.Drawing.Point(779, 497);
            this.SendTextButton.Name = "SendTextButton";
            this.SendTextButton.Size = new System.Drawing.Size(97, 20);
            this.SendTextButton.TabIndex = 0;
            this.SendTextButton.Text = "Отправить";
            this.SendTextButton.UseVisualStyleBackColor = false;
            this.SendTextButton.Click += new System.EventHandler(this.SendTextButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(468, 497);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 1;
            // 
            // SendImageButton
            // 
            this.SendImageButton.BackColor = System.Drawing.Color.Silver;
            this.SendImageButton.FlatAppearance.BorderSize = 0;
            this.SendImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendImageButton.Location = new System.Drawing.Point(779, 204);
            this.SendImageButton.Name = "SendImageButton";
            this.SendImageButton.Size = new System.Drawing.Size(103, 20);
            this.SendImageButton.TabIndex = 4;
            this.SendImageButton.Text = "Отправить картинку по ссылке";
            this.SendImageButton.UseVisualStyleBackColor = false;
            this.SendImageButton.Click += new System.EventHandler(this.SendImageButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(561, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Ссылка";
            // 
            // CodeFormatTextButton
            // 
            this.CodeFormatTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CodeFormatTextButton.FlatAppearance.BorderSize = 0;
            this.CodeFormatTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CodeFormatTextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CodeFormatTextButton.Location = new System.Drawing.Point(522, 468);
            this.CodeFormatTextButton.Name = "CodeFormatTextButton";
            this.CodeFormatTextButton.Size = new System.Drawing.Size(21, 23);
            this.CodeFormatTextButton.TabIndex = 7;
            this.CodeFormatTextButton.Text = "к";
            this.CodeFormatTextButton.UseVisualStyleBackColor = false;
            this.CodeFormatTextButton.Click += new System.EventHandler(this.CodeFormatTextButton_Click);
            // 
            // ItalicFormatTextButton
            // 
            this.ItalicFormatTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ItalicFormatTextButton.FlatAppearance.BorderSize = 0;
            this.ItalicFormatTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItalicFormatTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItalicFormatTextButton.Location = new System.Drawing.Point(494, 468);
            this.ItalicFormatTextButton.Name = "ItalicFormatTextButton";
            this.ItalicFormatTextButton.Size = new System.Drawing.Size(22, 23);
            this.ItalicFormatTextButton.TabIndex = 8;
            this.ItalicFormatTextButton.Text = "Н";
            this.ItalicFormatTextButton.UseVisualStyleBackColor = false;
            this.ItalicFormatTextButton.Click += new System.EventHandler(this.ItalicFormatTextButton_Click);
            // 
            // BoldFormatTextButton
            // 
            this.BoldFormatTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BoldFormatTextButton.FlatAppearance.BorderSize = 0;
            this.BoldFormatTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoldFormatTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoldFormatTextButton.Location = new System.Drawing.Point(468, 468);
            this.BoldFormatTextButton.Name = "BoldFormatTextButton";
            this.BoldFormatTextButton.Size = new System.Drawing.Size(21, 23);
            this.BoldFormatTextButton.TabIndex = 9;
            this.BoldFormatTextButton.Text = "Ж";
            this.BoldFormatTextButton.UseVisualStyleBackColor = false;
            this.BoldFormatTextButton.Click += new System.EventHandler(this.BoldFormatTextButton_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(561, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Ссылка";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(561, 124);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(318, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Текст";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(779, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 20);
            this.button7.TabIndex = 12;
            this.button7.Text = "Отправить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ConsoleRichTextBox
            // 
            this.ConsoleRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ConsoleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleRichTextBox.BulletIndent = 1;
            this.ConsoleRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsoleRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConsoleRichTextBox.Location = new System.Drawing.Point(561, 11);
            this.ConsoleRichTextBox.Name = "ConsoleRichTextBox";
            this.ConsoleRichTextBox.ReadOnly = true;
            this.ConsoleRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ConsoleRichTextBox.Size = new System.Drawing.Size(318, 107);
            this.ConsoleRichTextBox.TabIndex = 15;
            this.ConsoleRichTextBox.Text = "";
            // 
            // controlPanel
            // 
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(225, 489);
            this.controlPanel.TabIndex = 16;
            // 
            // chanellsPanel
            // 
            this.chanellsPanel.Location = new System.Drawing.Point(230, 0);
            this.chanellsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.chanellsPanel.Name = "chanellsPanel";
            this.chanellsPanel.Size = new System.Drawing.Size(225, 489);
            this.chanellsPanel.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(561, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(888, 520);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.chanellsPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.ConsoleRichTextBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.BoldFormatTextButton);
            this.Controls.Add(this.ItalicFormatTextButton);
            this.Controls.Add(this.CodeFormatTextButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.SendImageButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SendTextButton);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Control Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendTextButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SendImageButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CodeFormatTextButton;
        private System.Windows.Forms.Button ItalicFormatTextButton;
        private System.Windows.Forms.Button BoldFormatTextButton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox ConsoleRichTextBox;
        private System.Windows.Forms.FlowLayoutPanel controlPanel;
        private System.Windows.Forms.FlowLayoutPanel chanellsPanel;
        private System.Windows.Forms.TextBox textBox2;
    }
}

