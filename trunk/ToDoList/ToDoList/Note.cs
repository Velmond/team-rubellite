using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaBackend;

namespace TodoListConsole
{
    class Note : AgendaObject
    {
        IEnumerable<string> tags = new List<string>();


        public Note(string title, string description, DateTime dateCreated)
            : base(title, description, dateCreated)
        {
        }

        public Note(DateTime dateCreated, string title, string description)
            : base(title, description, dateCreated)
        {
        }

        public override string ToString()
        {
            StringBuilder noteStringBuilder = new StringBuilder();

            noteStringBuilder.Append(this.DateCreated + "\n" + "\n");

            noteStringBuilder.Append(this.Description);
            return noteStringBuilder.ToString();
        }
    }
}
