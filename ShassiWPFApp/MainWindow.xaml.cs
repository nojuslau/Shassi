using ShassiWPFApp.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShassiWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IHarnessService _harnessService;

        public MainWindow(IHarnessService harnessService)
        {
            InitializeComponent();
            _harnessService = harnessService;
        }

        private async void OnGenerateCombinationsClick(object sender, RoutedEventArgs e)
        {
            Random random = new();

            var displayData = await
                _harnessService.GenerateAndValidateHarnessesAsync(random.Next(3, 4));

            // Bind the data to the DataGrid
            HarnessCombinationDataGrid.ItemsSource = displayData;
        }
    }
}