using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Note : BaseObjectModel, INotifyPropertyChanged
    {
        private ObservableCollection<Note> Notes;
        public string Description { get; set; }

        //Constructors
        public Note(string title, string description) : base(title, description)
        {
            this.Notes = new ObservableCollection<Note>();
        }
        public Note()
        {
        }

        //Methods
        public void AddNote(Note note)
        {
            if (!this.Notes.Contains(note))
            {
                this.Notes.Add(note);
            }
        }
        public void RemoveNote(Note note)
        {
            if (this.Notes.Contains(note))
            {
                this.Notes.Remove(note);
            }
        }
        public override string ToString()
        {
            return String.Format("{0}", this.Description);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
