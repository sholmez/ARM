
namespace kurs
{
    partial class Authorization
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            loginTextBox = new System.Windows.Forms.TextBox();
            passwordTextBox = new System.Windows.Forms.TextBox();
            loginButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(594, 214);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 25);
            label1.TabIndex = 10;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(585, 293);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 25);
            label2.TabIndex = 10;
            label2.Text = "Пароль";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            loginTextBox.Location = new System.Drawing.Point(395, 241);
            loginTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new System.Drawing.Size(464, 32);
            loginTextBox.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            passwordTextBox.Location = new System.Drawing.Point(395, 320);
            passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new System.Drawing.Size(464, 32);
            passwordTextBox.TabIndex = 10;
            // 
            // loginButton
            // 
            loginButton.Location = new System.Drawing.Point(533, 391);
            loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(187, 33);
            loginButton.TabIndex = 11;
            loginButton.Text = "Авторизуватись";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Authorization";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Авторизація";
            FormClosing += Authorization_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}