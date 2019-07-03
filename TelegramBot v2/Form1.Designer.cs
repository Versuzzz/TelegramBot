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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.AddCategory = new System.Windows.Forms.Button();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.ConsoleRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ActiveCategory = new System.Windows.Forms.TextBox();
            this.AddChanells = new System.Windows.Forms.Button();
            this.ChanellName = new System.Windows.Forms.TextBox();
            this.None = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(412, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отправить картинку по ссылке";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Ссылка";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(307, 127);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Ид пользователя для отправки";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cornsilk;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(58, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "к";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cornsilk;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(30, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(22, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Н";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cornsilk;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(3, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Ж";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(307, 173);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(99, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Ссылка";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(416, 173);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Текст";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cornsilk;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(415, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 23);
            this.button7.TabIndex = 12;
            this.button7.Text = "Отправить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // AddCategory
            // 
            this.AddCategory.BackColor = System.Drawing.Color.Cornsilk;
            this.AddCategory.FlatAppearance.BorderSize = 0;
            this.AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategory.Location = new System.Drawing.Point(12, 67);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(76, 35);
            this.AddCategory.TabIndex = 13;
            this.AddCategory.Text = "Добавить категорию";
            this.AddCategory.UseVisualStyleBackColor = false;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // CategoryName
            // 
            this.CategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryName.Location = new System.Drawing.Point(94, 67);
            this.CategoryName.Multiline = true;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(97, 35);
            this.CategoryName.TabIndex = 14;
            this.CategoryName.Text = "Категория";
            // 
            // ConsoleRichTextBox
            // 
            this.ConsoleRichTextBox.BackColor = System.Drawing.Color.Black;
            this.ConsoleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleRichTextBox.BulletIndent = 1;
            this.ConsoleRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConsoleRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConsoleRichTextBox.Location = new System.Drawing.Point(197, 12);
            this.ConsoleRichTextBox.Name = "ConsoleRichTextBox";
            this.ConsoleRichTextBox.ReadOnly = true;
            this.ConsoleRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ConsoleRichTextBox.Size = new System.Drawing.Size(318, 107);
            this.ConsoleRichTextBox.TabIndex = 15;
            this.ConsoleRichTextBox.Text = "";
            // 
            // ActiveCategory
            // 
            this.ActiveCategory.BackColor = System.Drawing.Color.White;
            this.ActiveCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActiveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActiveCategory.ForeColor = System.Drawing.Color.Black;
            this.ActiveCategory.Location = new System.Drawing.Point(242, 219);
            this.ActiveCategory.Multiline = true;
            this.ActiveCategory.Name = "ActiveCategory";
            this.ActiveCategory.ReadOnly = true;
            this.ActiveCategory.Size = new System.Drawing.Size(97, 35);
            this.ActiveCategory.TabIndex = 16;
            this.ActiveCategory.Text = "Категория";
            this.ActiveCategory.TextChanged += new System.EventHandler(this.ActiveCategory_TextChanged);
            // 
            // AddChanells
            // 
            this.AddChanells.BackColor = System.Drawing.Color.White;
            this.AddChanells.FlatAppearance.BorderSize = 0;
            this.AddChanells.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddChanells.Location = new System.Drawing.Point(12, 178);
            this.AddChanells.Name = "AddChanells";
            this.AddChanells.Size = new System.Drawing.Size(75, 34);
            this.AddChanells.TabIndex = 18;
            this.AddChanells.Text = "Добавить канал";
            this.AddChanells.UseVisualStyleBackColor = false;
            this.AddChanells.Click += new System.EventHandler(this.AddChanells_Click);
            // 
            // ChanellName
            // 
            this.ChanellName.Location = new System.Drawing.Point(93, 178);
            this.ChanellName.Multiline = true;
            this.ChanellName.Name = "ChanellName";
            this.ChanellName.Size = new System.Drawing.Size(98, 34);
            this.ChanellName.TabIndex = 19;
            this.ChanellName.Text = "Название канала";
            this.ChanellName.TextChanged += new System.EventHandler(this.ChanellName_TextChanged);
            // 
            // None
            // 
            this.None.FormattingEnabled = true;
            this.None.Location = new System.Drawing.Point(12, 108);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(179, 64);
            this.None.TabIndex = 20;
            this.None.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(528, 304);
            this.Controls.Add(this.None);
            this.Controls.Add(this.ChanellName);
            this.Controls.Add(this.AddChanells);
            this.Controls.Add(this.ActiveCategory);
            this.Controls.Add(this.ConsoleRichTextBox);
            this.Controls.Add(this.CategoryName);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(544, 343);
            this.MinimumSize = new System.Drawing.Size(544, 343);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Control Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.RichTextBox ConsoleRichTextBox;
        private System.Windows.Forms.TextBox ActiveCategory;
        private System.Windows.Forms.Button AddChanells;
        private System.Windows.Forms.TextBox ChanellName;
        private System.Windows.Forms.CheckedListBox None;
    }
}

