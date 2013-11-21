namespace ToDoList.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// The basic class for ToDo list entities
    /// <para>Title - short description of entity</para>
    /// <para>Description - Description of the entity</para>
    /// <para>Tags - Multiple references describing the entity NotImplemented</para>
    /// </summary>
    public abstract class BaseObjectModel : INotifyPropertyChanged
    {
        private string title;
        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }
        public string Description { get; set; }
        public bool Done { get; set; }
        public IEnumerable<string> Tags { get; set; }

        public BaseObjectModel() 
        {
            this.Title = "New Item";
            this.Description = "Enter Description";
        }

        public BaseObjectModel(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Done = false;
        }

        /// <summary>
        /// Discern the objects by title
        /// <para>Not functional</para>
        /// </summary>
        //public override int GetHashCode()
        //{
        //    return this.Title.GetHashCode();
        //}

        /// <summary>
        /// For debugging
        /// </summary>
        public override string ToString()
        {
            return string.Format("[{0}]\n{1}\n{2}",
                this.Title,
                this.Description,
                string.Join("; ", this.Tags));
        }

        /* Need this for XAML Two-Way Binding */
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