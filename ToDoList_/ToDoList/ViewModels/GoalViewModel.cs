 namespace ToDoList.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Windows.Data;
    using ToDoList.Models;

    public class GoalViewModel : BaseViewModel<Goal>
    {
        /// <summary>
        /// Constructor for the goal's view model
        /// </summary>
        public GoalViewModel()
            : base()
        {
            // !!! There is some problem in this row            this.itemPool = new ObservableCollection<Goal>(DataManager.GetGoals(@"..\..\tasks.xml"));        }

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
