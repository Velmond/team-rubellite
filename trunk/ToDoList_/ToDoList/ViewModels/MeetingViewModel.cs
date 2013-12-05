using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace ToDoList.ViewModels
{
   public class MeetingViewModel:BaseViewModel<Meeting>
    {
        public MeetingViewModel()
            : base()
        {
        //    this.itemPool = new ObservableCollection<Meeting>(
        //         DataTranslator<Meeting>.Serialize(@"..\..\tasks.xml"));

            this.itemPool = DataTranslator<Meeting>.Deserialize();
    
        }

        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            // Handle closing logic, set e.Cancel as needed
            //tried to set event on closing the window, but it's not working

            //MessageBox.Show("Exit The Project");
        }
    }
}
