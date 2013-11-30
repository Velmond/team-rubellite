using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;

namespace ToDoList.Models
{

    public class Meeting : BaseObjectModel, IComparable<Meeting>, INotifyPropertyChanged
    {
        //TODO encapsulation
            private DateTime beginning; 
            public ushort Duration { get;  set; }

            public Meeting():base()
            {
                this.Title = "New Meeting";
                this.Description = "Add Description";
                //this.Beginning = DateTime.Now;
            }
            public Meeting(string title, string description, DateTime start, ushort duration)
                : base(title, description)
            {
                this.Beginning = start;
                this.Duration = duration;
            }

            public DateTime Beginning
            {
                get
                {
                    return this.beginning;
                }
                set
                {
                    this.beginning = value;
                    this.OnPropertyChanged("Beginning");
                }
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