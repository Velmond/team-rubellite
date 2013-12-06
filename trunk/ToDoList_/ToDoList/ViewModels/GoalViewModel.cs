namespace ToDoList.ViewModels
{
    using System;
    using System.Linq;
    using System.Collections.ObjectModel;
    using System.Windows.Data;
    using System.Windows.Input;
    using ToDoList.Commands;
    using ToDoList.Models;

    /// <summary>
    /// View model for all the goals
    /// </summary>
    public class GoalViewModel : BaseViewModel<Goal>
    {
        /// <summary>
        /// Constructor for the goal's view model
        /// </summary>
        public GoalViewModel()
            : base()
        {
            this.SortItems = new RelayCommand(this.HandleSortItems);
            this.AddNewSubtask = new RelayCommand(this.HandleAddNewSubtask);
            this.DeleteSubtask = new RelayCommand(this.HandleDeleteSubtask);
            this.itemPool = DataTranslator<Goal>.Deserialize();
        }

        /// <summary>
        /// Command to add new subtask to selected goal
        /// </summary>
        public ICommand AddNewSubtask { get; set; }

        /// <summary>
        /// Command to delete selected subtask from selected goal
        /// </summary>
        public ICommand DeleteSubtask { get; set; }

        /// <summary>
        /// Command to sort all goals by their deadline
        /// </summary>
        public ICommand SortItems { get; set; }

        private void HandleAddNewSubtask(object obj)
        {
            var view = CollectionViewSource.GetDefaultView(this.itemPool);
            int index = this.itemPool.IndexOf(view.CurrentItem as Goal);
            this.itemPool[index].AddSubtask(new Goal("", "", itemPool[index].EventDate));
        }

        private void HandleDeleteSubtask(object obj)
        {
            var view = CollectionViewSource.GetDefaultView(this.itemPool);
            int index = this.itemPool.IndexOf(view.CurrentItem as Goal);
            var subview = CollectionViewSource.GetDefaultView(this.itemPool[index].Subtasks);
            var selected = subview.CurrentItem as Goal;
            this.itemPool[index].RemoveSubtask(selected);
        }

        private void HandleSortItems(object obj)
        {
            this.Items = new ObservableCollection<Goal>(this.itemPool.OrderBy(goal => goal.EventDate)
                                                                     .ThenByDescending(goal => goal.Priority));
        }

        /// <summary>
        /// Looks for a sertain sequence of characters in the titles, descriprions, or tags of all goals and subtasks
        /// </summary>
        /// <param name="query">The sequence of characters that are being sought</param>
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

                        foreach (var tag in currentItem.Tags)
                        {
                            if (tag.ToLower().Contains(queryToLower))
                            {
                                return true;
                            }
                        }

                        foreach (var subtask in currentItem.Subtasks)
                        {
                            if (subtask.Title.ToLower().Contains(queryToLower) ||
                                subtask.Description.ToLower().Contains(queryToLower))
                            {
                                return true;
                            }

                            foreach (var tag in subtask.Tags)
                            {
                                if (tag.ToLower().Contains(queryToLower))
                                {
                                    return true;
                                }
                            }
                        }

                        return currentItem.Title.ToLower().Contains(queryToLower) ||
                               currentItem.Description.ToLower().Contains(queryToLower);
                    };
            }
        }
    }
}
