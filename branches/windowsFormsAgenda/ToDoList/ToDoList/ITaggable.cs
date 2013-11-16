namespace AgendaBackend
{
    using System;
    using System.Collections.Generic;

    interface ITaggable
    {
        IEnumerable<string> Tags { get; set; }
    }
}
