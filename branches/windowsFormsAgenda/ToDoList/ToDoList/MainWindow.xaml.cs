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

namespace ToDoList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //some basic logic for displaying a message on the screen
        //enter a text and click on "Send" button
        private void InputButton_Click(object sender, RoutedEventArgs e)
        {
            var inputText = this.InputBox.Text;
            TextBlock printTextBlock = new TextBlock();
            printTextBlock.Text = inputText;
            this.DisplayInfo.Children.Add(printTextBlock);
        }
    }
}
