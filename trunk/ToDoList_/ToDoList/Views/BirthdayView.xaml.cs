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
using System.Windows.Shapes;
using ToDoList.ViewModels;

namespace ToDoList.Views
{
    /// <summary>
    /// Interaction logic for BirthdayView.xaml
    /// </summary>
    public partial class BirthdayView : UserControl
    {
        public BirthdayView()
        {
            InitializeComponent();
        }

        private void TextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var filterText = this.TextBoxSearch.Text;

            (this.DataContext as BirthdayViewModel).Filter(filterText);

        }

        private void ListBoxTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
