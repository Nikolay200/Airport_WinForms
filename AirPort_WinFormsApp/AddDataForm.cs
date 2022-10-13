using Library;
using Tools;

namespace AirPort_WinFormsApp
{
    public partial class AddDataForm : Form
    {
        public Passenger NewPassenger = new Passenger();
        public AddDataForm(Passenger passenger)
        {
            InitializeComponent();
            NewPassenger = passenger;
        }

        private void LastName_textBox_TextChanged(object sender, EventArgs e)
        {
            NewPassenger.LastName = LastName_textBox.Text;
        }

        private void FirstName_textBox_TextChanged(object sender, EventArgs e)
        {
            NewPassenger.FirstName = FirstName_textBox.Text;
        }

        private void PatronymicName_textBox_TextChanged(object sender, EventArgs e)
        {
            NewPassenger.PatronymicName = PatronymicName_textBox.Text;
        }

        private void FlightId_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            NewPassenger.FlightType = (FlightType)FlightId_comboBox.SelectedItem;
        }

        private void FlightId_comboBox_DropDown(object sender, EventArgs e)
        {
            FlightId_comboBox.DataSource = Enum.GetValues(typeof(FlightType));
        }

        private void DepartureTime_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            NewPassenger.DepartureTime = DepartureDate_dateTimePicker.Value.Date +
                    DepartureTime_dateTimePicker.Value.TimeOfDay;           
        }

        private void SaveData_button_Click(object sender, EventArgs e)
        {
            var json = NewPassenger.SerializeObject();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = fbd.SelectedPath;
                FileProvider.WriteDataToFile(json, path);
            }
            Close();
        }
    }
}
