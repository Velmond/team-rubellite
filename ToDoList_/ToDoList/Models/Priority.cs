namespace ToDoList.Models
{
    using System;

    /// <summary>
    /// Combine Urgency and Importance using Flags
    /// <para>Order is important for sorting by priority.</para>>
    /// </summary>
    [Flags]
    public enum Priority
    {
        None = 0x0,
        Urgent = 0x1,
        Important = 0x2
    }
}
