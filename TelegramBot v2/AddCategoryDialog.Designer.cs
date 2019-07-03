namespace TelegramBot_v2
{
    partial class AddCategoryDialog
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAddCategory = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonAddCategory
            // 
            this.ButtonAddCategory.Location = new System.Drawing.Point(128, 97);
            this.ButtonAddCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAddCategory.Name = "ButtonAddCategory";
            this.ButtonAddCategory.Size = new System.Drawing.Size(87, 43);
            this.ButtonAddCategory.TabIndex = 0;
            this.ButtonAddCategory.Text = "Add";
            this.ButtonAddCategory.UseVisualStyleBackColor = true;
            this.ButtonAddCategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(106, 41);
            this.Textbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(128, 20);
            this.Textbox.TabIndex = 1;
            // 
            // AddCategoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 172);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.ButtonAddCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCategoryDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddCategory;
        private System.Windows.Forms.TextBox Textbox;
    }
}
