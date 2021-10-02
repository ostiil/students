namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.Label();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.GendercomboBox = new System.Windows.Forms.ComboBox();
            this.BirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.KickcheckBox = new System.Windows.Forms.CheckBox();
            this.DutycheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.Avg = new System.Windows.Forms.Label();
            this.AvgUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvgUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._1484328128_6543f;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 80);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Политическая карьера Брентано связана с партией ХДС, одним из основателей которой" +
    " он является.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление студента";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(14, 113);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(56, 13);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Фамилия";
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Location = new System.Drawing.Point(108, 113);
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(172, 20);
            this.SurnametextBox.TabIndex = 2;
            this.SurnametextBox.TextChanged += new System.EventHandler(this.SurnametextBox_TextChanged);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(14, 147);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 13);
            this.Name.TabIndex = 3;
            this.Name.Text = "Имя";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(14, 179);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(54, 13);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Отчество";
            this.LastName.Click += new System.EventHandler(this.label5_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(14, 212);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(27, 13);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Пол";
            this.Gender.Click += new System.EventHandler(this.label6_Click);
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.Location = new System.Drawing.Point(14, 240);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(86, 13);
            this.BirthDay.TabIndex = 6;
            this.BirthDay.Text = "Дата рождения";
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(108, 179);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(172, 20);
            this.LastNametextBox.TabIndex = 7;
            this.LastNametextBox.TextChanged += new System.EventHandler(this.SurnametextBox_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(108, 147);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(172, 20);
            this.NametextBox.TabIndex = 8;
            this.NametextBox.TextChanged += new System.EventHandler(this.SurnametextBox_TextChanged);
            // 
            // GendercomboBox
            // 
            this.GendercomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendercomboBox.FormattingEnabled = true;
            this.GendercomboBox.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.GendercomboBox.Location = new System.Drawing.Point(108, 212);
            this.GendercomboBox.Name = "GendercomboBox";
            this.GendercomboBox.Size = new System.Drawing.Size(172, 21);
            this.GendercomboBox.TabIndex = 9;
            this.GendercomboBox.TextChanged += new System.EventHandler(this.SurnametextBox_TextChanged);
            // 
            // BirthDayPicker
            // 
            this.BirthDayPicker.Location = new System.Drawing.Point(108, 240);
            this.BirthDayPicker.Name = "BirthDayPicker";
            this.BirthDayPicker.Size = new System.Drawing.Size(172, 20);
            this.BirthDayPicker.TabIndex = 10;
            // 
            // KickcheckBox
            // 
            this.KickcheckBox.AutoSize = true;
            this.KickcheckBox.Location = new System.Drawing.Point(108, 267);
            this.KickcheckBox.Name = "KickcheckBox";
            this.KickcheckBox.Size = new System.Drawing.Size(74, 17);
            this.KickcheckBox.TabIndex = 11;
            this.KickcheckBox.Text = "Отчислен";
            this.KickcheckBox.UseVisualStyleBackColor = true;
            // 
            // DutycheckBox
            // 
            this.DutycheckBox.AutoSize = true;
            this.DutycheckBox.Location = new System.Drawing.Point(108, 290);
            this.DutycheckBox.Name = "DutycheckBox";
            this.DutycheckBox.Size = new System.Drawing.Size(132, 17);
            this.DutycheckBox.TabIndex = 12;
            this.DutycheckBox.Text = "Есть задолженность";
            this.DutycheckBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Cancelbutton);
            this.panel2.Controls.Add(this.OKbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 40);
            this.panel2.TabIndex = 13;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(217, 5);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 1;
            this.Cancelbutton.Text = "Отмена";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbutton.Enabled = false;
            this.OKbutton.Location = new System.Drawing.Point(152, 5);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(53, 23);
            this.OKbutton.TabIndex = 0;
            this.OKbutton.Text = "ОК";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Avg
            // 
            this.Avg.AutoSize = true;
            this.Avg.Location = new System.Drawing.Point(14, 313);
            this.Avg.Name = "Avg";
            this.Avg.Size = new System.Drawing.Size(77, 13);
            this.Avg.TabIndex = 14;
            this.Avg.Text = "Средний балл";
            // 
            // AvgUpDown
            // 
            this.AvgUpDown.DecimalPlaces = 1;
            this.AvgUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.AvgUpDown.Location = new System.Drawing.Point(108, 313);
            this.AvgUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.AvgUpDown.Name = "AvgUpDown";
            this.AvgUpDown.Size = new System.Drawing.Size(172, 20);
            this.AvgUpDown.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 418);
            this.Controls.Add(this.AvgUpDown);
            this.Controls.Add(this.Avg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DutycheckBox);
            this.Controls.Add(this.KickcheckBox);
            this.Controls.Add(this.BirthDayPicker);
            this.Controls.Add(this.GendercomboBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.LastNametextBox);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.SurnametextBox);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvgUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button OKbutton;
        public System.Windows.Forms.TextBox SurnametextBox;
        public System.Windows.Forms.TextBox LastNametextBox;
        public System.Windows.Forms.TextBox NametextBox;
        public System.Windows.Forms.ComboBox GendercomboBox;
        public System.Windows.Forms.DateTimePicker BirthDayPicker;
        public System.Windows.Forms.Label Avg;
        public System.Windows.Forms.NumericUpDown AvgUpDown;
        public System.Windows.Forms.CheckBox KickcheckBox;
        public System.Windows.Forms.CheckBox DutycheckBox;
    }
}