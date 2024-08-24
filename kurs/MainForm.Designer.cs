
namespace kurs
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
            panel1 = new System.Windows.Forms.Panel();
            ClientButton = new System.Windows.Forms.Button();
            CategotyButton = new System.Windows.Forms.Button();
            ItemButton = new System.Windows.Forms.Button();
            OrderButton = new System.Windows.Forms.Button();
            returnButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            exitButton = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(ClientButton);
            panel1.Controls.Add(CategotyButton);
            panel1.Controls.Add(ItemButton);
            panel1.Controls.Add(OrderButton);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1280, 90);
            panel1.TabIndex = 0;
            // 
            // ClientButton
            // 
            ClientButton.Location = new System.Drawing.Point(267, 12);
            ClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new System.Drawing.Size(250, 65);
            ClientButton.TabIndex = 4;
            ClientButton.Text = "КЛІЄНТИ";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // CategotyButton
            // 
            CategotyButton.Location = new System.Drawing.Point(779, 12);
            CategotyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            CategotyButton.Name = "CategotyButton";
            CategotyButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CategotyButton.Size = new System.Drawing.Size(250, 65);
            CategotyButton.TabIndex = 2;
            CategotyButton.Text = "КАТЕГОРІЇ";
            CategotyButton.UseVisualStyleBackColor = true;
            CategotyButton.Click += CategotyButton_Click;
            // 
            // ItemButton
            // 
            ItemButton.Location = new System.Drawing.Point(523, 12);
            ItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ItemButton.Name = "ItemButton";
            ItemButton.Size = new System.Drawing.Size(250, 65);
            ItemButton.TabIndex = 1;
            ItemButton.Text = "ТОВАРИ";
            ItemButton.UseVisualStyleBackColor = true;
            ItemButton.Click += ItemButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.Location = new System.Drawing.Point(11, 12);
            OrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new System.Drawing.Size(250, 65);
            OrderButton.TabIndex = 0;
            OrderButton.Text = "ЗАМОВЛЕННЯ";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new System.Drawing.Point(1002, 504);
            returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            returnButton.Name = "returnButton";
            returnButton.Size = new System.Drawing.Size(250, 65);
            returnButton.TabIndex = 1;
            returnButton.Text = "Повернутися до авторизації";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += returnButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(172, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 32);
            label1.TabIndex = 2;
            // 
            // exitButton
            // 
            exitButton.Location = new System.Drawing.Point(1002, 573);
            exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(250, 65);
            exitButton.TabIndex = 4;
            exitButton.Text = "Завершити роботу";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(exitButton);
            Controls.Add(label1);
            Controls.Add(returnButton);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Головна";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button CategotyButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
    }
}