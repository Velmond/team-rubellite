namespace ToDoList.Models
{
    using System;
    using System.Linq;
    using System.Xml.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    public class DataManager
    {
        /// <summary>
        /// Get tasks from xml db
        /// </summary>
        /// <param name="pathToTasks">path of xml db</param>
        public static IEnumerable<Task> GetTasks(string pathToTasks)
        {
            var tasksRoot = XDocument.Load(pathToTasks).Root;

            var tasks = from task in tasksRoot.Elements("task")
                        select new Task()
                        {
                            Title = task.Element("title").Value,
                            Description = task.Element("description").Value,
                            Priority = (Priority)int.Parse(task.Element("priority").Value),
                            Tags = task.Elements("tags").Elements("tag").Select(t => t.Value)
                        };
            return tasks;
        }

        /// <summary>
        /// Add task to xml DB
        /// </summary>
        /// <param name="docPath">path to the xml file</param>
        /// <param name="task">task to be added</param>
        public static void AddTask(string docPath, Task task)
        {
            var root = XDocument.Load(docPath).Root;
            var entry = new XElement("task",
                new XElement("title", task.Title),
                new XElement("description", task.Description),
                new XElement("priority", (int)task.Priority),
                new XElement("tags"));
            foreach (var tag in task.Tags)
            {
                entry.Element("tags").Add(new XElement("tag", tag));
            }
            root.Add(entry);
            root.Document.Save(docPath);
        }

        public static void RemoveTask(Task target)
        {

        }
    }
}
