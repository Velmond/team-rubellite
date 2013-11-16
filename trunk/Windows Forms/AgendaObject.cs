namespace AgendaBackend
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// The basic class for ToDo list entities
    /// <para>Title - short description of entity</para>
    /// <para>Description - Description of the entity</para>
    /// <para>Tags - Multiple references describing the entity NotImplemented</para>
    /// </summary>
    public abstract class AgendaObject : ITaggable
    {
        public string Title { get; protected set; }
        public string Description { get; protected set; }
        public bool Done { get; protected set; }
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
        public AgendaObject(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.Done = false;
        }

        /*
         * TODO: Proper Hashing
         */


    }
}
