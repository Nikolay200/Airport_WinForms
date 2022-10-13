using Library;
using Tools;

namespace AirPort_WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddData_button_Click(object sender, EventArgs e)
        {
            var addDataForm = new AddDataForm(new Passenger());
            addDataForm.ShowDialog();
        }

        private void ShowPassengers_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var path = openFileDialog.FileName;
                    var passengers = FileProvider.ReadDataFromFile(path);
                    var passengersList = passengers?
                        .Select(obj => JsonHelper.DeSerializeObject(obj, typeof(Passenger)))?
                        .Select(pass => pass as Passenger)?.ToList();
                    if (passengersList == null) return;
                    var passengersForm = new PassengersListForm(passengersList);
                    passengersForm.ShowDialog();
                }
            }
        }
    }
}