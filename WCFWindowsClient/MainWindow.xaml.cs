using System;
using System.Windows;
using System.Windows.Controls;
using WCFWindowsClient.SampleServiceReference;

namespace WCFWindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _operation;
        private readonly Lazy<SampleServiceClient> _service = new Lazy<SampleServiceClient>(CreateClient);
        private static SampleServiceClient CreateClient()
        {
            return new SampleServiceClient("BasicHttpsBinding_ISampleService");
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Rb_Checked(object sender, RoutedEventArgs e)
        {
            var rb = sender as RadioButton;
            grpIndex.Visibility = Visibility.Visible;
            grpValue.Visibility = Visibility.Visible;
            txtValue.IsEnabled = true;
            _operation = rb?.Content.ToString().ToLower();

            switch(_operation)
            {
                case "add": grpIndex.Visibility = Visibility.Hidden; break;
                case "update": break;
                case "delete": grpValue.Visibility = Visibility.Hidden; break;
                case "get": txtValue.IsEnabled = false; break;
            }
        }

        private void BtnDoIt_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtIndex.Text, out int index) ||
                grpIndex.Visibility != Visibility.Visible )
            {
                var value = txtValue.Text;
                switch (_operation)
                {
                    case "add": _service.Value.PostValue(value); break;
                    case "update": _service.Value.PutValue(index, value); break;
                    case "delete": _service.Value.DeleteValue(index); break;
                    case "get": txtValue.Text = _service.Value.GetValue(index); break;
                }
                lbxItems.Items.Clear();
                foreach(var item in _service.Value.GetValues())
                {
                    lbxItems.Items.Add(item);
                }
            }
        }
    }
}
