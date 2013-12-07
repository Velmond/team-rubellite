namespace ToDoList.ViewModels
{
    using ToDoList.Models;

    /// <summary>
    /// View model for all objects of type ToDoList.Models.BirthdayReminder
    /// </summary>
    public class BirthdayViewModel : BaseViewModel<BirthdayReminder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BirthdayViewModel"/> class
        /// </summary>
        public BirthdayViewModel()
            : base()
        {
            this.itemPool = DataTranslator<BirthdayReminder>.Deserialize();
        }
    }
}
