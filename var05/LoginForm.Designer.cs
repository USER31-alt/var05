
namespace var05
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordButton = new System.Windows.Forms.Button();
            this.userHame = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.CaptchaTextBox = new System.Windows.Forms.TextBox();
            this.CaptchaImage = new System.Windows.Forms.PictureBox();
            this.PasswordB = new System.Windows.Forms.Button();
            this.PasswordB33 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Autoproject  GOST Type A", 21.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Турфирма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Autoproject  GOST Type A", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Авторизация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Autoproject  GOST Type A", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Autoproject  GOST Type A", 15.75F);
            this.label4.Location = new System.Drawing.Point(44, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.passwordButton.Font = new System.Drawing.Font("Autoproject  GOST Type A", 15.75F);
            this.passwordButton.Location = new System.Drawing.Point(138, 327);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(90, 36);
            this.passwordButton.TabIndex = 4;
            this.passwordButton.Text = "Войти";
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // userHame
            // 
            this.userHame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userHame.Location = new System.Drawing.Point(116, 125);
            this.userHame.Name = "userHame";
            this.userHame.Size = new System.Drawing.Size(152, 31);
            this.userHame.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(116, 164);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(152, 31);
            this.Password.TabIndex = 6;
            // 
            // CaptchaTextBox
            // 
            this.CaptchaTextBox.Location = new System.Drawing.Point(128, 283);
            this.CaptchaTextBox.Name = "CaptchaTextBox";
            this.CaptchaTextBox.Size = new System.Drawing.Size(100, 20);
            this.CaptchaTextBox.TabIndex = 7;
            // 
            // CaptchaImage
            // 
            this.CaptchaImage.Location = new System.Drawing.Point(105, 217);
            this.CaptchaImage.Name = "CaptchaImage";
            this.CaptchaImage.Size = new System.Drawing.Size(172, 46);
            this.CaptchaImage.TabIndex = 8;
            this.CaptchaImage.TabStop = false;
            // 
            // PasswordB
            // 
            this.PasswordB.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PasswordB.Font = new System.Drawing.Font("Autoproject  GOST Type A", 15.75F);
            this.PasswordB.Location = new System.Drawing.Point(222, 166);
            this.PasswordB.Name = "PasswordB";
            this.PasswordB.Size = new System.Drawing.Size(43, 27);
            this.PasswordB.TabIndex = 9;
            this.PasswordB.UseVisualStyleBackColor = false;
            this.PasswordB.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // PasswordB33
            // 
            this.PasswordB33.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PasswordB33.Font = new System.Drawing.Font("Autoproject  GOST Type A", 15.75F);
            this.PasswordB33.Location = new System.Drawing.Point(234, 283);
            this.PasswordB33.Name = "PasswordB33";
            this.PasswordB33.Size = new System.Drawing.Size(34, 22);
            this.PasswordB33.TabIndex = 10;
            this.PasswordB33.Text = "*";
            this.PasswordB33.UseVisualStyleBackColor = false;
            this.PasswordB33.Click += new System.EventHandler(this.RefreshCaptchaButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(378, 384);
            this.Controls.Add(this.PasswordB33);
            this.Controls.Add(this.PasswordB);
            this.Controls.Add(this.CaptchaImage);
            this.Controls.Add(this.CaptchaTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.userHame);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.TextBox userHame;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox CaptchaTextBox;
        private System.Windows.Forms.PictureBox CaptchaImage;
        private System.Windows.Forms.Button PasswordB;
        private System.Windows.Forms.Button PasswordB33;
    }
}

