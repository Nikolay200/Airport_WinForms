namespace AirPort_WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowPassengers_button = new System.Windows.Forms.Button();
            this.AddData_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowPassengers_button
            // 
            this.ShowPassengers_button.Location = new System.Drawing.Point(23, 32);
            this.ShowPassengers_button.Name = "ShowPassengers_button";
            this.ShowPassengers_button.Size = new System.Drawing.Size(223, 23);
            this.ShowPassengers_button.TabIndex = 0;
            this.ShowPassengers_button.Text = "Посмотреть данные пассажиров";
            this.ShowPassengers_button.UseVisualStyleBackColor = true;
            this.ShowPassengers_button.Click += new System.EventHandler(this.ShowPassengers_button_Click);
            // 
            // AddData_button
            // 
            this.AddData_button.Location = new System.Drawing.Point(25, 82);
            this.AddData_button.Name = "AddData_button";
            this.AddData_button.Size = new System.Drawing.Size(221, 23);
            this.AddData_button.TabIndex = 1;
            this.AddData_button.Text = "Добавить данные пассажира";
            this.AddData_button.UseVisualStyleBackColor = true;
            this.AddData_button.Click += new System.EventHandler(this.AddData_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 154);
            this.Controls.Add(this.AddData_button);
            this.Controls.Add(this.ShowPassengers_button);
            this.Name = "MainForm";
            this.Text = "Меню диспетчера";            
            this.ResumeLayout(false);

        }

        #endregion

        private Button ShowPassengers_button;
        private Button AddData_button;
    }
}