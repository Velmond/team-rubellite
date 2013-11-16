namespace AgendaBackend
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Simple task without deadline and optional priority.
    /// <para>???Maybe it needs Recurrence???</para>
    /// </summary>
    public class Task : AgendaObject, IComparable<Task>
    {
        public Priority Priority { get; protected set; }

        public Task(string title, string description, DateTime dateCreated, Priority priority = Priority.None)
            : base(title, description, dateCreated)
        { this.Priority = priority; }

        /// <summary>
        /// CompareTo overload to help with task sorting by priority.
        /// </summary>
        public int CompareTo(Task other)
        {
            return this.Priority.CompareTo(other.Priority);
        }
    }
}
