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

namespace WpfPomodoro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            controller = new Controller();
            this.DataContext = controller;
        }

        private void StartTimer(object sender, RoutedEventArgs e)
        {
            controller.Start();
        }

        private void StopTimer(object sender, RoutedEventArgs e)
        {
            controller.Stop();
        }

        private void ResetTimer(object sender, RoutedEventArgs e)
        {
            controller.Reset();
        }
    }
}
