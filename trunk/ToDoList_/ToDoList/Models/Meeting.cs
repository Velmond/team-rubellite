using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;

namespace ToDoList.Models
{

    public class Meeting : BaseObjectModel, IComparable<Meeting>, INotifyPropertyChanged, IDateable
    {
        //TODO encapsulation
            private DateTime beginning ; 
            public ushort Duration { get;  set; }
            private string startTime;
            

            public Meeting():base()
            {
                this.Title = "New Meeting";
                this.Description = "Add Description";
                this.EventDate = DateTime.Now;
                this.StartTime = "hh:mm";
            }
            public Meeting(string title, string description, DateTime startDate, ushort duration, string startTime)
                : base(title, description)
            {
                this.EventDate = startDate;
                this.Duration = duration;
                this.StartTime = startTime;
            }

            public Meeting(string title, string description, DateTime startDate, string startTime)
                : base(title, description)
            {
                this.EventDate = startDate;
                this.StartTime = startTime;
            }

            public Meeting(string title, string description, DateTime startDate)
                : base(title, description)
            {
                this.EventDate = startDate;
               
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

            public DateTime EventDate
            {
                get
                {
                    return this.beginning.Date;
                }
                set
                {
                    this.beginning = value;
                    this.OnPropertyChanged("EventDate");
                }
            }

            public void EditStartTime(string newStartTime)
            {
                this.StartTime = newStartTime;
            }

            public void EditBeginning(DateTime newBeginning)
            {
                this.EventDate = newBeginning;
            }

            public void EditDuration(ushort newDuration)
            {
                this.Duration = newDuration;
            }

            public int CompareTo(Meeting other)
            {
                return this.EventDate.CompareTo(other.EventDate);
            }

        }
    }