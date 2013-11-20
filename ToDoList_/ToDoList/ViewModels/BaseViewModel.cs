namespace ToDoList.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows.Data;
    using System.Windows.Input;
    using ToDoList.Commands;
    using ToDoList.Models;

    public class BaseViewModel<T> : INotifyPropertyChanged
                          where T : BaseObjectModel, new()
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /* Field */
        protected ObservableCollection<T> itemPool;

        /* Properties */
        public IEnumerable<T> Items
        {
            get { return itemPool; }
            //set
            //{
            //    if (this.tasks==null)
            //    {
            //        this.tasks = new ObservableCollection<Task>();
            //    }
            //    this.tasks.Clear();
            //    foreach (var item in value)
            //    {
            //        this.tasks.Add(item);
            //    }
            //}
        }
        public T NewItem { get; set; }
        public ICommand AddNewItem { get; set; }
        public ICommand DeleteItem { get; set; }

        /* Constructor */
        public BaseViewModel()
        {
            this.AddNewItem =
                new RelayCommand(this.HandleAddNewItem);
            this.DeleteItem =
                new RelayCommand(this.HandleDeleteItem);
            this.NewItem = new T();
        }

        /* Methods */
        private void HandleDeleteItem(object obj)
        {
            var view = CollectionViewSource.GetDefaultView(this.itemPool);
            var selected = view.CurrentItem as T;
            this.itemPool.Remove(selected);
        }

        private void HandleAddNewItem(object obj)
        {
            this.itemPool.Add(new T());
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
