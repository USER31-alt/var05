using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using var05;

namespace var05
{
    public partial class LoginForm : Form
    {
        private const string DefaultUsername = "user";
        private const string DefaultPassword = "user";
        private string _captchaText;
        public LoginForm()
        {
            InitializeComponent();
            RefreshCaptcha();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = userHame.Text.Trim();
            string password = Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == DefaultUsername && password == DefaultPassword)
            {
                OpenMainForm();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userHame.Clear();
                Password.Clear();
                Password.UseSystemPasswordChar = true;
                passwordButton.Text = "👁";
                RefreshCaptcha();
            }
        }

        private void OpenMainForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void RefreshCaptchaButton_Click(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }

        private void RefreshCaptcha()
        {
            _captchaText = GenerateCaptchaText(4);
            CaptchaImage.Image = GenerateCaptchaImage(_captchaText);
            CaptchaTextBox.Text = "";
        }

        private string GenerateCaptchaText(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += chars[random.Next(chars.Length)];
            }
            return result;
        }

        private Bitmap GenerateCaptchaImage(string captchaText)
        {
            Random rand = new Random();
            int width = 150;
            int height = 50;

            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);

            g.Clear(Color.White);

            Font font = new Font("Arial", 24);
            float x = 10;
            float yOffset = 0;

            for (int i = 0; i < captchaText.Length; i++)
            {
                yOffset = rand.Next(-5, 6);
                float rotationAngle = rand.Next(-10, 11);

                Matrix matrix = new Matrix();
                matrix.RotateAt(rotationAngle, new PointF(x, height / 2 + yOffset));
                g.Transform = matrix;

                g.DrawString(captchaText[i].ToString(), font, Brushes.Black, x, (height - font.GetHeight()) / 2 + yOffset);

                g.ResetTransform();

                x += g.MeasureString(captchaText[i].ToString(), font).Width + 5;

                if (rand.Next(0, 2) == 0)
                {
                    g.DrawLine(Pens.Red, x - g.MeasureString(captchaText[i].ToString(), font).Width - 5, height / 2, x - 5, height / 2);
                }
            }

            g.Dispose();
            return bmp;
        }
        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = !Password.UseSystemPasswordChar;
            PasswordB.Text = Password.UseSystemPasswordChar ? "👁" : "👁‍🗨";
        }
    }
}