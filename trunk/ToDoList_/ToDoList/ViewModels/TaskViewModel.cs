namespace ToDoList.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using ToDoList.Models;

    public class TaskViewModel : BaseViewModel<Task>
    {
        /* Constructor */
        public TaskViewModel()
            : base()
        {
            //this.itemPool = new ObservableCollection<Task>(
            //     DataManager.GetTasks(@"..\..\tasks.xml"));
            this.itemPool = DataTranslator<Task>.Deserialize();
        }
    } 
}