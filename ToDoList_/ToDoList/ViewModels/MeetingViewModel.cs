using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using ToDoList.Commands;
using System.Windows.Input;

namespace ToDoList.ViewModels
{
   public class MeetingViewModel:BaseViewModel<Meeting>
    {
       public ICommand SortItems { get; set; }

        public MeetingViewModel()
            : base()
        {
        //    this.itemPool = new ObservableCollection<Meeting>(
        //         DataTranslator<Meeting>.Serialize(@"..\..\tasks.xml"));
            this.SortItems =
                new RelayCommand(this.Sort);
            this.itemPool = DataTranslator<Meeting>.Deserialize();
    
        }

        public void OnWindowClosing(object sender, CancelEventArgs e)
        {
            // Handle closing logic, set e.Cancel as needed
            //tried to set event on closing the window, but it's not working

            //MessageBox.Show("Exit The Project");
        }


        private void Sort(object obj)
        {
            
            ObservableCollection<Meeting> sorted = 
                new ObservableCollection<Meeting>(
                    this.itemPool.OrderBy(meeting => meeting.EventDate).ThenBy(meeting => meeting.StartTime));
            this.Items = sorted;
       
            //this.itemPool.OrderBy(obj => obj.EventDate).ThenBy(obj=> obj.StartTime).ToList();
            
        }
    }
}
