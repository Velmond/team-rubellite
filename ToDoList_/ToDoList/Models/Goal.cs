namespace ToDoList.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Long term task which can contain subtasks and has a deadline
    /// </summary>
    public class Goal : Task, IComparable<Goal>
    {
        // Goal specific fields
        private DateTime endDate;
        private ICollection<Task> subtasks;

        /// <summary>
        /// Long term task which can contain subtasks and has a deadline
        /// </summary>
        public Goal()
            : base()
        {
            this.EndDate = DateTime.Now.AddMonths(1);
            // This is repeated in both constructors. Should see how to get rid of one of those.
            this.subtasks = new List<Task>();
        }

        /// <summary>
        /// Long term task which can contain subtasks and has a deadline
        /// </summary>
        /// <param name="title">The goal's title</param>
        /// <param name="description">The goal's description</param>
        /// <param name="endTimeInMonths">The time limit for the goal's achievement in months</param>
        /// <param name="priority">The goal's priority</param>
        public Goal(string title, string description, int endTimeInMonths, Priority priority = Priority.None)
            : base(title, description, priority)
        {
            this.EndDate = DateTime.Now.AddMonths(endTimeInMonths);
            this.subtasks = new List<Task>();
        }

        /// <summary>
        /// The time set for accomplishing the goal
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">End date for the goal cannot be before the current one</exception>
        public DateTime EndDate
        {
            get { return this.endDate.Date; }
            set
            {
                if (value.CompareTo(DateTime.Now) < 0)
                {
                    throw new ArgumentOutOfRangeException("endDate", "End date for the goal cannot be before the current one.");
                }

                this.endDate = value;
            }
        }

        /// <summary>
        /// A Collection of the subtasks for this goal
        /// </summary>
        /// <exception cref="NullReferenceException">Trying to assign null value to the goal's collection of the subtasks</exception>
        public ICollection<Task> Subtasks
        {
            get { return this.subtasks; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException(
                        string.Format("Trying to assign null value to Subtasks collection of the goal [{0}]", this.Title));
                }

                this.subtasks = value;
            }
        }

        /// <summary>
        /// Add a subtask to the goal
        /// </summary>
        /// <param name="subtask">Subtask to be added to the goal</param>
        public void AddSubtask(Task subtask)
        {
            if (!this.subtasks.Contains(subtask))
            {
                this.subtasks.Add(subtask);
            }
        }

        /// <summary>
        /// Remove a subtask from the goal
        /// </summary>
        /// <param name="subtask">Subtask to be removed from the goal</param>
        public void RemoveSubtask(Task subtask)
        {
            if (this.subtasks.Contains(subtask))
            {
                this.subtasks.Remove(subtask);
            }
        }

        /// <summary>
        /// A method for editing the goal's end date.
        /// </summary>
        /// <param name="months">The number of months to be added to the end date for this goal</param>
        public void ExtendDuration(int months)
        {
            this.EndDate = this.EndDate.AddMonths(months);
        }

        /// <summary>
        /// Compares this instance with a specific ToDoList.Models.Goal and indicates whether this instance precedes, follows,
        /// or appears in the same position in the sort order as the specified ToDoList.Models.Goal
        /// </summary>
        /// <param name="other">A ToDoList.Models.Goal to compare this instance to</param>
        /// <returns>-1, 0, or 1 depending on the end dates of the goals that are compared</returns>
        public int CompareTo(Goal other)
        {
            return this.EndDate.CompareTo(other.EndDate);
        }

        /// <summary>
        /// Returns all the information of this instance of Goal as a string
        /// </summary>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0}\n{1}\n", base.ToString(), this.EndDate);

            foreach (Task subtask in this.Subtasks)
            {
                output.AppendLine(subtask.ToString());
            }

            return output.ToString();
        }
    }
}
