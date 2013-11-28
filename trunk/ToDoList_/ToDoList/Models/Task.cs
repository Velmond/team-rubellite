namespace ToDoList.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Simple task without deadline and optional priority.
    /// <para>???Maybe it needs Recurrence???</para>
    /// </summary>
    public class Task : BaseObjectModel, IComparable<Task>
    {
        private Priority priority;
        public Priority Priority
        {
            get { return priority; }
            set
            {
                this.priority ^= value;
                /* If property changes notify who is interested */
                this.OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// Default task creation that can be modified.
        /// </summary>
        public Task() 
        {
            this.Title = "New Task";
            this.Description = "Enter_description";
        }
        public Task(string title, string description, Priority priority = Priority.None)
            : base(title, description)
        { this.Priority = priority; }

        /// <summary>
        /// CompareTo overload to help with task sorting by priority.
        /// </summary>
        public int CompareTo(Task other)
        {
            return this.Priority.CompareTo(other.Priority) * (-1);
        }

        /// <summary>
        /// for debugging
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}\n{1}",
                base.ToString(),
                this.Priority);
        }
    }
}