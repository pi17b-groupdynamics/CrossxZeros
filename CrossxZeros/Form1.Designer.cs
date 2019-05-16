namespace CrossxZeros
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
            this.startMenu = new System.Windows.Forms.Panel();
            this.startMenu1 = new CrossxZeros.StartMenu();
            this.gameSettings = new System.Windows.Forms.Panel();
            this.gameSettings1 = new CrossxZeros.GameSettings();
            this.gameScreen = new System.Windows.Forms.Panel();
            this.gameScreen1 = new CrossxZeros.GameScreen();
            this.startMenu.SuspendLayout();
            this.gameSettings.SuspendLayout();
            this.gameScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // startMenu
            // 
            this.startMenu.Controls.Add(this.startMenu1);
            this.startMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startMenu.Location = new System.Drawing.Point(0, 0);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(1064, 611);
            this.startMenu.TabIndex = 0;
            // 
            // startMenu1
            // 
            this.startMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startMenu1.Location = new System.Drawing.Point(0, 0);
            this.startMenu1.Name = "startMenu1";
            this.startMenu1.Size = new System.Drawing.Size(1064, 611);
            this.startMenu1.TabIndex = 2;
            this.startMenu1.Load += new System.EventHandler(this.startMenu1_Load_1);
            // 
            // gameSettings
            // 
            this.gameSettings.Controls.Add(this.gameSettings1);
            this.gameSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSettings.Location = new System.Drawing.Point(0, 0);
            this.gameSettings.Name = "gameSettings";
            this.gameSettings.Size = new System.Drawing.Size(1064, 611);
            this.gameSettings.TabIndex = 3;
            // 
            // gameSettings1
            // 
            this.gameSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSettings1.Location = new System.Drawing.Point(0, 0);
            this.gameSettings1.Name = "gameSettings1";
            this.gameSettings1.Size = new System.Drawing.Size(1064, 611);
            this.gameSettings1.TabIndex = 0;
            // 
            // gameScreen
            // 
            this.gameScreen.Controls.Add(this.gameScreen1);
            this.gameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1064, 611);
            this.gameScreen.TabIndex = 1;
            // 
            // gameScreen1
            // 
            this.gameScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameScreen1.Location = new System.Drawing.Point(0, 0);
            this.gameScreen1.Name = "gameScreen1";
            this.gameScreen1.Size = new System.Drawing.Size(1064, 611);
            this.gameScreen1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.gameSettings);
            this.Controls.Add(this.startMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.startMenu.ResumeLayout(false);
            this.gameSettings.ResumeLayout(false);
            this.gameScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel startMenu;
        private StartMenu startMenu1;
        public System.Windows.Forms.Panel gameSettings;
        private GameSettings gameSettings1;
        public System.Windows.Forms.Panel gameScreen;
        private GameScreen gameScreen1;
    }
}

