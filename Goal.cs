namespace AgendaBackend
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Long Term Task which can contain otrher subtasks
    /// <para>TimeLimited - There is deadline ofr it</para>
    /// <para>You can Extend the deadline; for all the procrastinators out there</para>
    /// <para>Contains other subtasks which have to be completed</para>
    /// </summary>
    public class Goal : Task, ITimeLimited
    {

        // TODO: It can/must contain subtask which have to be completed so you have completed goal
        // When you select Goal you must be able to see subtask and vice versa
        // When you select task that is part of bigger Goal you have to see part of which goal it is

        public Goal(string title, string description, Priority priority)
            : base(title, description, priority)
        { }

        public DateTime End
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

        public void ExtendDuration(int minutes)
        {
            throw new NotImplementedException();
        }

    }
}
