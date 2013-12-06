namespace ToDoList.Models
{
    using System.Collections.ObjectModel;

    interface ITaggable
    {
        ObservableCollection<string> Tags { get; set; }
    }
}
