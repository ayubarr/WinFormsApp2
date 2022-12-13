namespace WinFormsApp2
{
    partial class Form1
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
            this.MainMenuLabel = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PlayersCountPlus = new System.Windows.Forms.Button();
            this.PlayersCountMinus = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SettingsMenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainMenuLabel
            // 
            this.MainMenuLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuLabel.Location = new System.Drawing.Point(12, 13);
            this.MainMenuLabel.Name = "MainMenuLabel";
            this.MainMenuLabel.Size = new System.Drawing.Size(308, 80);
            this.MainMenuLabel.TabIndex = 0;
            this.MainMenuLabel.Text = "Главное Меню";
            this.MainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(12, 162);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(200, 60);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Начать Распределение";
            this.StartGameButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 228);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(200, 60);
            this.SettingsButton.TabIndex = 3;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 481);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(200, 60);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PlayersCountPlus
            // 
            this.PlayersCountPlus.Location = new System.Drawing.Point(12, 162);
            this.PlayersCountPlus.Name = "PlayersCountPlus";
            this.PlayersCountPlus.Size = new System.Drawing.Size(200, 60);
            this.PlayersCountPlus.TabIndex = 5;
            this.PlayersCountPlus.Text = "Добавить Игрока";
            this.PlayersCountPlus.UseVisualStyleBackColor = true;
            this.PlayersCountPlus.Visible = false;
            // 
            // PlayersCountMinus
            // 
            this.PlayersCountMinus.Location = new System.Drawing.Point(12, 228);
            this.PlayersCountMinus.Name = "PlayersCountMinus";
            this.PlayersCountMinus.Size = new System.Drawing.Size(200, 60);
            this.PlayersCountMinus.TabIndex = 6;
            this.PlayersCountMinus.Text = "Удалить Игрока";
            this.PlayersCountMinus.UseVisualStyleBackColor = true;
            this.PlayersCountMinus.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 483);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(200, 60);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Вернуться в Меню";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SettingsMenuLabel
            // 
            this.SettingsMenuLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsMenuLabel.Location = new System.Drawing.Point(12, 13);
            this.SettingsMenuLabel.Name = "SettingsMenuLabel";
            this.SettingsMenuLabel.Size = new System.Drawing.Size(329, 80);
            this.SettingsMenuLabel.TabIndex = 8;
            this.SettingsMenuLabel.Text = "Меню Настроек";
            this.SettingsMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsMenuLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.MainMenuLabel);
            this.Controls.Add(this.PlayersCountPlus);
            this.Controls.Add(this.PlayersCountMinus);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SettingsMenuLabel);
            this.Name = "Form1";
            this.Text = "Secret Santa";
            this.ResumeLayout(false);

        }

        #endregion

        private Label MainMenuLabel;
        private Button StartGameButton;
        private Button SettingsButton;
        private Button ExitButton;
        private Button PlayersCountPlus;
        private Button PlayersCountMinus;
        private Button BackButton;
        private Label SettingsMenuLabel;
    }
}