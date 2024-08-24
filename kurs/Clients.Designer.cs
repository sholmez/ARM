
namespace kurs
{
    partial class Clients
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
            CategotyButton = new System.Windows.Forms.Button();
            OrderButton = new System.Windows.Forms.Button();
            ItemButton = new System.Windows.Forms.Button();
            ClientButton = new System.Windows.Forms.Button();
            report = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            NameTextBox = new System.Windows.Forms.TextBox();
            SurnameTextBox = new System.Windows.Forms.TextBox();
            PhoneTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            AddButton = new System.Windows.Forms.Button();
            UpdateButton = new System.Windows.Forms.Button();
            DeleteButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            IDtextBox = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(CategotyButton);
            panel1.Controls.Add(OrderButton);
            panel1.Controls.Add(ItemButton);
            panel1.Controls.Add(ClientButton);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1280, 90);
            panel1.TabIndex = 8;
            // 
            // CategotyButton
            // 
            CategotyButton.Location = new System.Drawing.Point(779, 12);
            CategotyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            CategotyButton.Name = "CategotyButton";
            CategotyButton.Size = new System.Drawing.Size(250, 65);
            CategotyButton.TabIndex = 2;
            CategotyButton.Text = "КАТЕГОРІЇ";
            CategotyButton.UseVisualStyleBackColor = true;
            CategotyButton.Click += CategotyButton_Click;
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
            // ClientButton
            // 
            ClientButton.Location = new System.Drawing.Point(267, 12);
            ClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new System.Drawing.Size(250, 65);
            ClientButton.TabIndex = 4;
            ClientButton.Text = "КЛІЄНТИ";
            ClientButton.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            report.Location = new System.Drawing.Point(1002, 485);
            report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            report.Name = "report";
            report.Size = new System.Drawing.Size(250, 65);
            report.TabIndex = 9;
            report.Text = "Створити звіт";
            report.UseVisualStyleBackColor = true;
            report.Click += report_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 94);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1240, 354);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new System.Drawing.Point(102, 576);
            NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(194, 23);
            NameTextBox.TabIndex = 14;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new System.Drawing.Point(390, 502);
            SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new System.Drawing.Size(194, 23);
            SurnameTextBox.TabIndex = 15;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new System.Drawing.Point(390, 577);
            PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new System.Drawing.Size(194, 23);
            PhoneTextBox.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(100, 559);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(28, 15);
            label1.TabIndex = 17;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(389, 485);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 15);
            label2.TabIndex = 18;
            label2.Text = "Прізвище";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(389, 559);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 15);
            label3.TabIndex = 19;
            label3.Text = "Номер телефону";
            // 
            // AddButton
            // 
            AddButton.Location = new System.Drawing.Point(746, 485);
            AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(250, 65);
            AddButton.TabIndex = 20;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new System.Drawing.Point(746, 554);
            UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new System.Drawing.Size(250, 65);
            UpdateButton.TabIndex = 21;
            UpdateButton.Text = "Змінити";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new System.Drawing.Point(1002, 554);
            DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(250, 65);
            DeleteButton.TabIndex = 22;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(100, 485);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(18, 15);
            label4.TabIndex = 23;
            label4.Text = "ID";
            // 
            // IDtextBox
            // 
            IDtextBox.Enabled = false;
            IDtextBox.Location = new System.Drawing.Point(102, 502);
            IDtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new System.Drawing.Size(194, 23);
            IDtextBox.TabIndex = 24;
            // 
            // Clients
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(IDtextBox);
            Controls.Add(label4);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(report);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Clients";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Клієнти";
            FormClosing += Clients_FormClosing;
            Load += Clients_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button CategotyButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDtextBox;
    }
}