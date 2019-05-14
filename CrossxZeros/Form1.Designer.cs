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
            this.startMenu1 = new CrossxZeros.StartMenu();
            this.gameSettings1 = new CrossxZeros.GameSettings();
            this.gameScreen1 = new CrossxZeros.GameScreen();
            this.SuspendLayout();
            // 
            // startMenu1
            // 
            this.startMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startMenu1.Location = new System.Drawing.Point(0, 0);
            this.startMenu1.Name = "startMenu1";
            this.startMenu1.Size = new System.Drawing.Size(1064, 611);
            this.startMenu1.TabIndex = 0;
            this.startMenu1.Load += new System.EventHandler(this.startMenu1_Load);
            // 
            // gameSettings1
            // 
            this.gameSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSettings1.Location = new System.Drawing.Point(0, 0);
            this.gameSettings1.Name = "gameSettings1";
            this.gameSettings1.Size = new System.Drawing.Size(1064, 611);
            this.gameSettings1.TabIndex = 1;
            // 
            // gameScreen1
            // 
            this.gameScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameScreen1.Location = new System.Drawing.Point(0, 0);
            this.gameScreen1.Name = "gameScreen1";
            this.gameScreen1.Size = new System.Drawing.Size(1064, 611);
            this.gameScreen1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.gameSettings1);
            this.Controls.Add(this.gameScreen1);
            this.Controls.Add(this.startMenu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private StartMenu startMenu1;
        private GameSettings gameSettings1;
        private GameScreen gameScreen1;
    }
}

