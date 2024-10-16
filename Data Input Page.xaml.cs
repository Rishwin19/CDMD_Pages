using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AlertsAndNotificationsPage
{
    public partial class AlertsAndNotificationsPage : Window
    {
        public ObservableCollection<Alert> Alerts { get; set; }
        public ObservableCollection<string> Parameters { get; set; }

        public AlertsAndNotificationsPage()
        {
            InitializeComponent();

            Alerts = new ObservableCollection<Alert>();
            Parameters = new ObservableCollection<string>();

            // Initialize parameters
            Parameters.Add("Glucose");
            Parameters.Add("Heart Rate");

            // Initialize alerts
            Alerts.Add(new Alert { AlertType = "High Glucose", Value = 200, Threshold = 180 });
            Alerts.Add(new Alert { AlertType = "Low Heart Rate", Value = 50, Threshold = 60 });

            AlertsDataGrid.ItemsSource = Alerts;
            ParameterComboBox.ItemsSource = Parameters;
        }

        private void SetThresholdButton_Click(object sender, RoutedEventArgs e)
        {
            // Set threshold logic here
        }
    }

    public class Alert
    {
        public string AlertType { get; set; }
        public int Value { get; set; }
        public int Threshold { get; set; }
        public string ActionTaken { get; set; }
    }
}
