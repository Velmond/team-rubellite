using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{

    public class Meeting : BaseObjectModel, IComparable<Meeting>
        {
            public DateTime Beginning { get; protected set; }
            public ushort Duration { get; protected set; }

            public Meeting() { }
            public Meeting(string title, string description, DateTime start, ushort duration)
                : base(title, description)
            {
                this.Beginning = start;
                this.Duration = duration;
            }

            public Meeting(string title, string description, DateTime start)
                : base(title, description)
            {
                this.Beginning = start;
            }

            public void EditBeginning(DateTime newBeginning)
            {
                this.Beginning = newBeginning;
            }

            public void EditDuration(ushort newDuration)
            {
                this.Duration = newDuration;
            }

            public int CompareTo(Meeting other)
            {
                return this.Beginning.CompareTo(other.Beginning);
            }
        }
    }