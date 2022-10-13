namespace AirPort_WinFormsApp
{
    partial class AddDataForm
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
            this.SaveData_button = new System.Windows.Forms.Button();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.PatronymicName_textBox = new System.Windows.Forms.TextBox();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.LastName_label = new System.Windows.Forms.Label();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.PatronymicName_label = new System.Windows.Forms.Label();
            this.FlightId_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartureTime_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FlightId_comboBox = new System.Windows.Forms.ComboBox();
            this.DepartureDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // SaveData_button
            // 
            this.SaveData_button.Location = new System.Drawing.Point(47, 421);
            this.SaveData_button.Name = "SaveData_button";
            this.SaveData_button.Size = new System.Drawing.Size(101, 51);
            this.SaveData_button.TabIndex = 0;
            this.SaveData_button.Text = "Сохранить";
            this.SaveData_button.UseVisualStyleBackColor = true;
            this.SaveData_button.Click += new System.EventHandler(this.SaveData_button_Click);
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Location = new System.Drawing.Point(47, 61);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(223, 23);
            this.LastName_textBox.TabIndex = 1;
            this.LastName_textBox.TextChanged += new System.EventHandler(this.LastName_textBox_TextChanged);
            // 
            // PatronymicName_textBox
            // 
            this.PatronymicName_textBox.Location = new System.Drawing.Point(47, 205);
            this.PatronymicName_textBox.Name = "PatronymicName_textBox";
            this.PatronymicName_textBox.Size = new System.Drawing.Size(223, 23);
            this.PatronymicName_textBox.TabIndex = 2;
            this.PatronymicName_textBox.TextChanged += new System.EventHandler(this.PatronymicName_textBox_TextChanged);
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Location = new System.Drawing.Point(47, 131);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(223, 23);
            this.FirstName_textBox.TabIndex = 3;
            this.FirstName_textBox.TextChanged += new System.EventHandler(this.FirstName_textBox_TextChanged);
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Location = new System.Drawing.Point(47, 33);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(58, 15);
            this.LastName_label.TabIndex = 4;
            this.LastName_label.Text = "Фамилия";
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Location = new System.Drawing.Point(47, 104);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(31, 15);
            this.FirstName_label.TabIndex = 5;
            this.FirstName_label.Text = "Имя";
            // 
            // PatronymicName_label
            // 
            this.PatronymicName_label.AutoSize = true;
            this.PatronymicName_label.Location = new System.Drawing.Point(47, 176);
            this.PatronymicName_label.Name = "PatronymicName_label";
            this.PatronymicName_label.Size = new System.Drawing.Size(58, 15);
            this.PatronymicName_label.TabIndex = 6;
            this.PatronymicName_label.Text = "Отчество";
            // 
            // FlightId_label
            // 
            this.FlightId_label.AutoSize = true;
            this.FlightId_label.Location = new System.Drawing.Point(47, 248);
            this.FlightId_label.Name = "FlightId_label";
            this.FlightId_label.Size = new System.Drawing.Size(49, 15);
            this.FlightId_label.TabIndex = 7;
            this.FlightId_label.Text = "Рейс №";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Время вылета";
            // 
            // DepartureTime_dateTimePicker
            // 
            this.DepartureTime_dateTimePicker.CustomFormat = "";
            this.DepartureTime_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DepartureTime_dateTimePicker.Location = new System.Drawing.Point(191, 357);
            this.DepartureTime_dateTimePicker.Name = "DepartureTime_dateTimePicker";
            this.DepartureTime_dateTimePicker.ShowUpDown = true;
            this.DepartureTime_dateTimePicker.Size = new System.Drawing.Size(79, 23);
            this.DepartureTime_dateTimePicker.TabIndex = 10;
            this.DepartureTime_dateTimePicker.ValueChanged += new System.EventHandler(this.DepartureTime_dateTimePicker_ValueChanged);
            // 
            // FlightId_comboBox
            // 
            this.FlightId_comboBox.FormattingEnabled = true;
            this.FlightId_comboBox.Location = new System.Drawing.Point(51, 283);
            this.FlightId_comboBox.Name = "FlightId_comboBox";
            this.FlightId_comboBox.Size = new System.Drawing.Size(219, 23);
            this.FlightId_comboBox.TabIndex = 11;
            this.FlightId_comboBox.DropDown += new System.EventHandler(this.FlightId_comboBox_DropDown);
            this.FlightId_comboBox.SelectedIndexChanged += new System.EventHandler(this.FlightId_comboBox_SelectedIndexChanged);
            // 
            // DepartureDate_dateTimePicker
            // 
            this.DepartureDate_dateTimePicker.Location = new System.Drawing.Point(51, 357);
            this.DepartureDate_dateTimePicker.Name = "DepartureDate_dateTimePicker";
            this.DepartureDate_dateTimePicker.Size = new System.Drawing.Size(134, 23);
            this.DepartureDate_dateTimePicker.TabIndex = 12;
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 508);
            this.Controls.Add(this.DepartureDate_dateTimePicker);
            this.Controls.Add(this.FlightId_comboBox);
            this.Controls.Add(this.DepartureTime_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlightId_label);
            this.Controls.Add(this.PatronymicName_label);
            this.Controls.Add(this.FirstName_label);
            this.Controls.Add(this.LastName_label);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.PatronymicName_textBox);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.SaveData_button);
            this.Name = "AddDataForm";
            this.Text = "Добавление нового пассажира";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveData_button;
        private TextBox LastName_textBox;
        private TextBox PatronymicName_textBox;
        private TextBox FirstName_textBox;
        private Label LastName_label;
        private Label FirstName_label;
        private Label PatronymicName_label;
        private Label FlightId_label;
        private Label label1;
        private DateTimePicker DepartureTime_dateTimePicker;
        private ComboBox FlightId_comboBox;
        private DateTimePicker DepartureDate_dateTimePicker;
    }
}