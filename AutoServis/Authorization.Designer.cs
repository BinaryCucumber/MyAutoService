
namespace AutoServis
{
    partial class Authorization
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
            this.buttonEnter = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.TextBox_Login = new System.Windows.Forms.TextBox();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox_not_eye = new System.Windows.Forms.PictureBox();
            this.pictureBox_eye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_not_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(201, 189);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 25);
            this.buttonEnter.TabIndex = 0;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(100, 84);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // TextBox_Login
            // 
            this.TextBox_Login.Location = new System.Drawing.Point(172, 81);
            this.TextBox_Login.Name = "TextBox_Login";
            this.TextBox_Login.Size = new System.Drawing.Size(146, 20);
            this.TextBox_Login.TabIndex = 2;
            this.TextBox_Login.TextChanged += new System.EventHandler(this.textBox_Login);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Location = new System.Drawing.Point(172, 131);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(146, 20);
            this.TextBox_Password.TabIndex = 3;
            this.TextBox_Password.TextChanged += new System.EventHandler(this.textBox_Password);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(100, 134);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // pictureBox_not_eye
            // 
            this.pictureBox_not_eye.Image = global::AutoServis.Properties.Resources.free_icon_hide_2767146__1_;
            this.pictureBox_not_eye.Location = new System.Drawing.Point(325, 131);
            this.pictureBox_not_eye.Name = "pictureBox_not_eye";
            this.pictureBox_not_eye.Size = new System.Drawing.Size(21, 20);
            this.pictureBox_not_eye.TabIndex = 6;
            this.pictureBox_not_eye.TabStop = false;
            this.pictureBox_not_eye.Click += new System.EventHandler(this.pictureBox_not_eye_Click);
            // 
            // pictureBox_eye
            // 
            this.pictureBox_eye.Image = global::AutoServis.Properties.Resources.free_icon_eye_1587461;
            this.pictureBox_eye.Location = new System.Drawing.Point(325, 131);
            this.pictureBox_eye.Name = "pictureBox_eye";
            this.pictureBox_eye.Size = new System.Drawing.Size(22, 20);
            this.pictureBox_eye.TabIndex = 5;
            this.pictureBox_eye.TabStop = false;
            this.pictureBox_eye.Click += new System.EventHandler(this.pictureBox_eye_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 284);
            this.Controls.Add(this.pictureBox_eye);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.TextBox_Password);
            this.Controls.Add(this.TextBox_Login);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.pictureBox_not_eye);
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_not_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox TextBox_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox pictureBox_eye;
        private System.Windows.Forms.PictureBox pictureBox_not_eye;
    }
}

