namespace AgendaBackend
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Maps Tag:Tasks (1:N) so you can list all tasks that correspond to certain tag
    /// </summary>
    /// <typeparam name="T">Might be good idea to restrain this fucker</typeparam>
    public class TagCloud<T>
    {
        // TODO: substitute List<T> with HashSet<T> ???
        private Dictionary<string, List<T>> cloud =
            new Dictionary<string, List<T>>();

        public void Add(string tag, T item)
        {
            List<T> list;
            if (this.cloud.TryGetValue(tag, out list))
            {
                list.Add(item);
            }
            else
            {
                list = new List<T>();
                list.Add(item);
                this.cloud[tag] = list;
            }
        }

        // TODO: Debug
        public void Add(IEnumerable<string> tags, T item)
        {
            foreach (var tag in tags)
            {
                this.Add(tag, item);
            }
        }

        public IEnumerable<string> Tags
        {
            get { return this.cloud.Keys; }
        }

        public List<T> this[string tag]
        {
            get
            {
                List<T> list;
                if (!this.cloud.TryGetValue(tag, out list))
                {
                    list = new List<T>();
                    this.cloud[tag] = list;
                }
                return list;
            }
        }
    }
}