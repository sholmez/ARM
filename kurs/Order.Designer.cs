
namespace kurs
{
    partial class Order
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
            ItemButton = new System.Windows.Forms.Button();
            OrderButton = new System.Windows.Forms.Button();
            ClientButton = new System.Windows.Forms.Button();
            CategotyButton = new System.Windows.Forms.Button();
            PriceTextBox = new System.Windows.Forms.TextBox();
            IDtextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            DeleteButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            UpdateButton = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            QuanityNumeric = new System.Windows.Forms.NumericUpDown();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuanityNumeric).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(ItemButton);
            panel1.Controls.Add(OrderButton);
            panel1.Controls.Add(ClientButton);
            panel1.Controls.Add(CategotyButton);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1280, 90);
            panel1.TabIndex = 1;
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
            // PriceTextBox
            // 
            PriceTextBox.Enabled = false;
            PriceTextBox.Location = new System.Drawing.Point(0, 485);
            PriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new System.Drawing.Size(219, 23);
            PriceTextBox.TabIndex = 56;
            // 
            // IDtextBox
            // 
            IDtextBox.Enabled = false;
            IDtextBox.Location = new System.Drawing.Point(0, 584);
            IDtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new System.Drawing.Size(219, 23);
            IDtextBox.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(0, 567);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(18, 15);
            label4.TabIndex = 53;
            label4.Text = "ID";
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
            dataGridView1.TabIndex = 45;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new System.Drawing.Point(1002, 554);
            DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(250, 65);
            DeleteButton.TabIndex = 52;
            DeleteButton.Text = "Видалити";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(1002, 485);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(250, 65);
            button1.TabIndex = 44;
            button1.Text = "Створити звіт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new System.Drawing.Point(746, 554);
            UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new System.Drawing.Size(250, 65);
            UpdateButton.TabIndex = 51;
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
            AddButton.TabIndex = 50;
            AddButton.Text = "Додати";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(0, 468);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 49;
            label3.Text = "Вартість";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(236, 466);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 15);
            label1.TabIndex = 47;
            label1.Text = "Назва товару";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(236, 584);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(219, 23);
            dateTimePicker1.TabIndex = 57;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(236, 565);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 15);
            label2.TabIndex = 58;
            label2.Text = "Дата замовлення";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(0, 516);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 15);
            label5.TabIndex = 60;
            label5.Text = "Кількість";
            // 
            // QuanityNumeric
            // 
            QuanityNumeric.Location = new System.Drawing.Point(0, 533);
            QuanityNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            QuanityNumeric.Name = "QuanityNumeric";
            QuanityNumeric.Size = new System.Drawing.Size(219, 23);
            QuanityNumeric.TabIndex = 61;
            QuanityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            QuanityNumeric.ValueChanged += QuanityNumeric_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(236, 532);
            comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(219, 23);
            comboBox1.TabIndex = 62;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(236, 515);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 15);
            label6.TabIndex = 63;
            label6.Text = "Клієнт";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(471, 567);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(112, 15);
            label7.TabIndex = 65;
            label7.Text = "Статус замовлення";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Оплачено", "В обробці", "Доставлено" });
            comboBox2.Location = new System.Drawing.Point(471, 584);
            comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(219, 23);
            comboBox2.TabIndex = 66;
            comboBox2.Text = "В обробці";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(236, 484);
            comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(219, 23);
            comboBox3.TabIndex = 67;
            // 
            // Order
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(QuanityNumeric);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(PriceTextBox);
            Controls.Add(IDtextBox);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(DeleteButton);
            Controls.Add(button1);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Order";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Замовлення";
            FormClosing += Order_FormClosing;
            Load += Order_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuanityNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button CategotyButton;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown QuanityNumeric;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}