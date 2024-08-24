
namespace kurs
{
    partial class Items
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
            IDtextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            DeleteButton = new System.Windows.Forms.Button();
            UpdateButton = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            NameTextBox = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            report = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            PriceTextBox = new System.Windows.Forms.TextBox();
            DescriptionTextBox = new System.Windows.Forms.TextBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
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
            // IDtextBox
            // 
            IDtextBox.Enabled = false;
            IDtextBox.Location = new System.Drawing.Point(114, 486);
            IDtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new System.Drawing.Size(70, 23);
            IDtextBox.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(114, 463);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(18, 15);
            label4.TabIndex = 36;
            label4.Text = "ID";
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new System.Drawing.Point(1002, 554);
            DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(250, 65);
            DeleteButton.TabIndex = 35;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new System.Drawing.Point(746, 554);
            UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new System.Drawing.Size(250, 65);
            UpdateButton.TabIndex = 34;
            UpdateButton.Text = "Змінити";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new System.Drawing.Point(746, 485);
            AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(250, 65);
            AddButton.TabIndex = 33;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(514, 463);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 15);
            label3.TabIndex = 32;
            label3.Text = "Ціна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(364, 463);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 15);
            label2.TabIndex = 31;
            label2.Text = "Категорія";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(202, 463);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 15);
            label1.TabIndex = 30;
            label1.Text = "Назва товару";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new System.Drawing.Point(202, 486);
            NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(142, 23);
            NameTextBox.TabIndex = 27;
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
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // report
            // 
            report.Location = new System.Drawing.Point(1002, 485);
            report.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            report.Name = "report";
            report.Size = new System.Drawing.Size(250, 65);
            report.TabIndex = 25;
            report.Text = "Створити звіт";
            report.UseVisualStyleBackColor = true;
            report.Click += report_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(114, 518);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(36, 15);
            label6.TabIndex = 39;
            label6.Text = "Опис";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new System.Drawing.Point(514, 486);
            PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new System.Drawing.Size(80, 23);
            PriceTextBox.TabIndex = 40;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new System.Drawing.Point(114, 535);
            DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new System.Drawing.Size(480, 84);
            DescriptionTextBox.TabIndex = 42;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(364, 486);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(133, 23);
            comboBox1.TabIndex = 43;
            // 
            // Items
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(comboBox1);
            Controls.Add(DescriptionTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(label6);
            Controls.Add(IDtextBox);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteButton);
            Controls.Add(report);
            Controls.Add(UpdateButton);
            Controls.Add(NameTextBox);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Items";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Товари";
            FormClosing += Items_FormClosing;
            Load += Items_Load;
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
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}