namespace ToDoList.ViewModels
{
    using System;
    using System.Linq;
    using System.Collections.ObjectModel;
    using System.Windows.Input;
    using ToDoList.Commands;
    using ToDoList.Models;

    public class TaskViewModel : BaseViewModel<Task>
    {
        public ICommand SortItems { get; set; }

        /* Constructor */
        public TaskViewModel()
            : base()
        {
            this.SortItems =
                new RelayCommand(this.HandleSortItems);
            this.itemPool = DataTranslator<Task>.Deserialize();
        }

        private void HandleSortItems(object obj)
        {
            ObservableCollection<Task> sorted = 
                new ObservableCollection<Task>(
                    this.itemPool.OrderByDescending(task=>task.Priority));
            this.Items = sorted;
        }

    } 
}