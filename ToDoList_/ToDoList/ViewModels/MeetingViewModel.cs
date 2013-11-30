using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using System.Collections.ObjectModel;

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
    }
}
