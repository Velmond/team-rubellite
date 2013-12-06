using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ToDoList.Models;

namespace TodoListConsole
{
    public class BirthdayReminder : BaseObjectModel, IDateable
    {
        private string personName = null;
        private byte age = 0;
        private DateTime birthDate;
        private DateTime dateCreated;

        public string PersonName
        {
            get
            {
                return this.personName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("The age of the person must have name.");
                }
                this.personName = value;
            }
        }
        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The person must be on age bigger or equal to 0 years.");
                }

                this.age = value;
            }
        }
        public DateTime EventDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                this.birthDate = value;
            }
        }
      
        public DateTime DateCreated
        {
            get
            {
                return this.dateCreated;
            }
            set
            {
                this.dateCreated = value;
            }
        }

        public BirthdayReminder()
        {
        }

        public BirthdayReminder(string title, string description, string personName, byte age, DateTime birthDate)
            : base(title, description)
        {
            this.DateCreated = DateTime.Now;
            this.PersonName = personName;
            this.Age = age;
            this.EventDate = birthDate;
        }
    }
}
