namespace ToDoList.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Data;
    using System.Windows.Input;
    using ToDoList.Commands;
    using ToDoList.Models;

    public class GoalViewModel : BaseViewModel<Goal>
    {
        /// <summary>
        /// Constructor for the goal's view model
        /// </summary>
        public GoalViewModel()
            : base()
        {
            this.AddNewSubtask = new RelayCommand(this.HandleAddNewSubtask);
            this.DeleteSubtask = new RelayCommand(this.HandleDeleteSubtask);

            //this.itemPool = new ObservableCollection<Goal>(DataManager.GetGoals(@"..\..\tasks.xml"));
            this.itemPool = DataTranslator<Goal>.Deserialize();
        }

        public ICommand AddNewSubtask { get; set; }
        public ICommand DeleteSubtask { get; set; }

        private void HandleAddNewSubtask(object obj)
        {
            var view = CollectionViewSource.GetDefaultView(this.itemPool);
            int index = this.itemPool.IndexOf(view.CurrentItem as Goal);
            this.itemPool[index].AddSubtask(new Task());
        }

        private void HandleDeleteSubtask(object obj)
        {
            var view = CollectionViewSource.GetDefaultView(this.itemPool);
            int index = this.itemPool.IndexOf(view.CurrentItem as Goal);
            var subview = CollectionViewSource.GetDefaultView(this.itemPool[index].Subtasks);
            var selected = subview.CurrentItem as Task;
            this.itemPool[index].RemoveSubtask(selected);
        }

        public override void Filter(string query)
        {
            var itemView = CollectionViewSource.GetDefaultView(this.itemPool);

            if (query == string.Empty)
            {
                itemView.Filter = null;
            }
            else
            {
                var queryToLower = query.ToLower();

                itemView.Filter = (item) =>
                    {
                        var currentItem = item as Goal;

                        if (currentItem == null)
                        {
                            return false;
                        }

                        // ??? Not sure if we should get the goal back after filtering because of a subtask
                        foreach (var subtask in currentItem.Subtasks)
                        {
                            if (subtask.Title.ToLower().Contains(queryToLower) ||
                                subtask.Description.ToLower().Contains(queryToLower))
                            {
                                return true;
                            }
                        }

                        return currentItem.Title.ToLower().Contains(queryToLower) ||
                               currentItem.Description.ToLower().Contains(queryToLower);
                    };
            }
        }
    }
}
