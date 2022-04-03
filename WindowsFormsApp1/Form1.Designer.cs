namespace WindowsFormsApp1
{
    partial class FirstForm
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
            this.PlayerName = new System.Windows.Forms.Label();
            this.PlayerName_TextBox = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(44, 51);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(84, 16);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "Имя игрока:";
            // 
            // PlayerName_TextBox
            // 
            this.PlayerName_TextBox.Location = new System.Drawing.Point(134, 48);
            this.PlayerName_TextBox.Name = "PlayerName_TextBox";
            this.PlayerName_TextBox.Size = new System.Drawing.Size(226, 22);
            this.PlayerName_TextBox.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(285, 119);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 2;
            this.Start.Text = "Старт";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 177);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.PlayerName_TextBox);
            this.Controls.Add(this.PlayerName);
            this.MaximizeBox = false;
            this.Name = "FirstForm";
            this.Text = "Игра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.TextBox PlayerName_TextBox;
        private System.Windows.Forms.Button Start;
    }
}

