using Library;
using System.Data;

namespace AirPort_WinFormsApp
{
    public partial class PassengersListForm : Form
    {
        
        public PassengersListForm(List<Passenger> passengers)
        {
            InitializeComponent();            
            Passengers_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;                                  
            Passengers_dataGridView.DataSource = passengers;
        }
    }
}
