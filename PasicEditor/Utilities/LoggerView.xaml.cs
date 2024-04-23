using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasicEditor.Utilities
{
    /// <summary>
    /// Interaction logic for LoggerView.xaml
    /// </summary>
    public partial class LoggerView : UserControl
    {
        public LoggerView()
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                Logger.Log(MessageType.Information, "Information Message");
                Logger.Log(MessageType.Warning, "Warning Message");
                Logger.Log(MessageType.Error, "Error Message");
            };
        }

        private void OnClear_Button_Click(object sender, RoutedEventArgs e)
        {
            Logger.clear();
        }

        private void OnMessageFilter_Button_Click(object sender, RoutedEventArgs e)
        {
            var filter = 0x0;
            if (toggleInformation.IsChecked == true) filter |= (int)MessageType.Information;
            if (toggleWarnings.IsChecked == true) filter |= (int)MessageType.Warning;
            if (toggleErrors.IsChecked == true) filter |= (int)MessageType.Error;
            Logger.SetMessageFilter(filter);
        }
    }
}
