using rec43a.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace rec43a.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainWindowViewModel).Summ(int.Parse(numberTextBox.Text));

        }
    }
}
