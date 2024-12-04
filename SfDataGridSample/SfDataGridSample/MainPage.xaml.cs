namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void sfGrid_CurrentCellBeginEdit(object sender, Syncfusion.Maui.DataGrid.DataGridCurrentCellBeginEditEventArgs e)
        {
            if (e.Column.MappingName == "EmployeeID")
            {
                if(e.RowColumnIndex.ColumnIndex == 0 && e.RowColumnIndex.RowIndex == 2)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
