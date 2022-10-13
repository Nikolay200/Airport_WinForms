namespace AirPort_WinFormsApp
{
    partial class PassengersListForm
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
            this.Passengers_dataGridView = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Passengers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Passengers_dataGridView
            // 
            this.Passengers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Passengers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.PatronymicName,
            this.FlightType,
            this.DepartureTime});
            this.Passengers_dataGridView.Location = new System.Drawing.Point(12, 12);
            this.Passengers_dataGridView.Name = "Passengers_dataGridView";
            this.Passengers_dataGridView.RowTemplate.Height = 25;
            this.Passengers_dataGridView.Size = new System.Drawing.Size(545, 371);
            this.Passengers_dataGridView.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            // 
            // PatronymicName
            // 
            this.PatronymicName.DataPropertyName = "PatronymicName";
            this.PatronymicName.HeaderText = "Отчество";
            this.PatronymicName.Name = "PatronymicName";
            // 
            // FlightType
            // 
            this.FlightType.DataPropertyName = "FlightType";
            this.FlightType.HeaderText = "Рейс №";
            this.FlightType.Name = "FlightType";
            // 
            // DepartureTime
            // 
            this.DepartureTime.DataPropertyName = "DepartureTime";
            this.DepartureTime.HeaderText = "Время вылета";
            this.DepartureTime.Name = "DepartureTime";
            // 
            // PassengersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 387);
            this.Controls.Add(this.Passengers_dataGridView);
            this.Name = "PassengersListForm";
            this.Text = "Список пассажиров";            
            ((System.ComponentModel.ISupportInitialize)(this.Passengers_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Passengers_dataGridView;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn PatronymicName;
        private DataGridViewTextBoxColumn FlightType;
        private DataGridViewTextBoxColumn DepartureTime;
    }
}