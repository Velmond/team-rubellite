namespace ToDoList.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Xml.Serialization;

    /// <summary>
    /// The basic class for ToDo list entities
    /// <para>Title - short description of entity</para>
    /// <para>Description - Description of the entity</para>
    /// <para>Tags - Multiple references describing the entity NotImplemented</para>
    /// </summary>
    public abstract class BaseObjectModel : INotifyPropertyChanged
    {
        private bool done;
        private string title;

        /// <summary>
        /// The entity's title
        /// </summary>
        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                /* If property changes notify who is interested */
                this.OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// The entity's description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A boolean property that shows if the entity has been done already
        /// </summary>
        public bool Done
        {
            get { return this.done; }
            set
            {
                this.done = value;
                /* If property changes notify who is interested */
                this.OnPropertyChanged("Done");
            }
        }

        /// <summary>
        /// A collection of labels for easy grouping of entities
        /// </summary>
        [XmlIgnore()] 
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        /// Basic class for ToDo entities
        /// </summary>
        public BaseObjectModel() 
        {
            this.Title = "NewItem";
            this.Description = "Enter Description";
        }

        /// <summary>
        /// Basic class for ToDo entities
        /// </summary>
        /// <param name="title">Title for the entity</param>
        /// <param name="description">Description for the entity</param>
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