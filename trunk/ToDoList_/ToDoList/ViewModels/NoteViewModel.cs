using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class NoteViewModel : BaseViewModel<Note>
    {
        public NoteViewModel()
            : base()
        {
            this.itemPool = DataTranslator<Note>.Deserialize();
        }
    }
}
