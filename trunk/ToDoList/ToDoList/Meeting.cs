namespace AgendaBackend
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class for recording meetings.
    /// <para>It has beggining and end.</para>
    /// <para>TODO: Making it Recurring event (preferably making recurrence Interface)</para>
    /// <para>TODO: Auto close event when end has passed </para>
    /// </summary>
    public class Meeting : AgendaObject, ITimeLimited
    {
        public DateTime Beginning { get; protected set; }
        public DateTime End { get; set; }
        // TODO: Recurring event; sanitize Beginning and End

        public Meeting(string title, string description, DateTime start, DateTime end, DateTime dateCreated)
            : base(title, description, dateCreated)
        {
            if (this.Beginning > this.End)
            {
                // TODO: more sanitation
                throw new ArgumentException("");
            }
            this.Beginning = start;
            this.End = end;
        }

        public void ExtendDuration(int minutes)
        {
            throw new NotImplementedException();
        }
    }
}
