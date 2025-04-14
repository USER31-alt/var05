
namespace var05
{
    partial class MainForm
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
            this.passwordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Autoproject  GOST Type A", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Звездина Виктория Алексеевна";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Autoproject  GOST Type A", 36F);
            this.label2.Location = new System.Drawing.Point(229, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "ИС-21Б";
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.passwordButton.Font = new System.Drawing.Font("Autoproject  GOST Type A", 15.75F);
            this.passwordButton.Location = new System.Drawing.Point(510, 331);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(90, 36);
            this.passwordButton.TabIndex = 5;
            this.passwordButton.Text = "Назад";
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(623, 379);
            this.Controls.Add(this.passwordButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button passwordButton;
    }
}