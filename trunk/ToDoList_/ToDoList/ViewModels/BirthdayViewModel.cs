using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using TodoListConsole;

namespace ToDoList.ViewModels
{
    class BirthdayViewModel : BaseViewModel<BirthdayReminder>
    {
        public BirthdayViewModel()
            : base()
        {
            this.itemPool = new ObservableCollection<BirthdayReminder>(DataTranslator<BirthdayReminder>.Deserialize());
        }


    }
}
