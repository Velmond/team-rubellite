namespace AgendaBackend
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interface Describing entities that have deadline
    /// <para>Deadline can be extended</para>
    /// </summary>
    public interface ITimeLimited
    {
        DateTime End { get; set; }

        void ExtendDuration(int minutes);
    }
}