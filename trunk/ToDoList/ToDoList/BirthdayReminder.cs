using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AgendaBackend;

namespace TodoListConsole
{
    public class BirthdayReminder : AgendaObject, ITaggable
    {
        private string personName = null;
        private byte age = 0;
        private DateTime birthDate;

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
        public DateTime BirthDate
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
        public IEnumerable<string> Tags
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public BirthdayReminder(string title, string description, string personName, byte age, DateTime birthDate)
            : base(title, description)
        {
            this.PersonName = personName;
            this.Age = age;
            this.BirthDate = birthDate;
        }

        public BirthdayReminder(DateTime dateCreated, string title, string description, string personName, byte age, DateTime birthDate)
            : base(dateCreated, title, description)
        {
            this.PersonName = personName;
            this.Age = age;
            this.BirthDate = birthDate;
        }
    }
}
