namespace ToDoList.ViewModels
{
    using ToDoList.Models;

    /// <summary>
    /// View model for all objects of type ToDoList.Models.Note
    /// </summary>
    public class NoteViewModel : BaseViewModel<Note>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoteViewModel"/> class
        /// </summary>
        public NoteViewModel()
            : base()
        {
            this.itemPool = DataTranslator<Note>.Deserialize();
        }
    }
}
