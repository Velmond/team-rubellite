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
            private DateTime beginning ; 
            public ushort Duration { get;  set; }
            private string startTime;
            

            public Meeting():base()
            {
                this.Title = "New Meeting";
                this.Description = "Add Description";
                this.Beginning = DateTime.Now;
                this.StartTime = "--:-- h";
            }
            public Meeting(string title, string description, DateTime startDate, ushort duration, string startTime)
                : base(title, description)
            {
                this.Beginning = startDate;
                this.Duration = duration;
                this.StartTime = startTime;
            }

            public Meeting(string title, string description, DateTime startDate, string startTime)
                : base(title, description)
            {
                this.Beginning = startDate;
                this.StartTime = startTime;
            }

            public Meeting(string title, string description, DateTime startDate)
                : base(title, description)
            {
                this.Beginning = startDate;
               
            }

            public string StartTime
            {
                get
                {
                    return this.startTime;
                }
                set
                {
                    this.startTime = value;
                    this.OnPropertyChanged("StartTime");
                }
            }

            public DateTime Beginning
            {
                get
                {
                    return this.beginning.Date;
                }
                set
                {
                    this.beginning = value;
                    this.OnPropertyChanged("Beginning");
                }
            }

            public void EditStartTime(string newStartTime)
            {
                this.StartTime = newStartTime;
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