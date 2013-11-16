using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgendaBackend;
using Task = System.Threading.Tasks.Task;

namespace TodoListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Note note = new Note("aNotes title", "Note content Note content Note content");
            Note note2 = new Note("qNote23 title", "Note content Note content Note content");
            Note note3= new Note("bNote3 title", "Note content Note content Note content");

            
            
            List<string> tags = new List<string>();
            tags.Add("First tag");
            note.Tags = tags;
            
            note.GetTags();
            Console.WriteLine(note.ToString());
            List<AgendaObject> l = new List<AgendaObject>();
            l.Add(note);
            l.Add(note2);
            l.Add(note3);
            AgendaObject.SortByTitle(l);
            AgendaObject.SortByIsDone(l);
        }
    }
}
