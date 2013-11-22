namespace ToDoList.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Xml.Serialization;

    class DataTranslator<T> where T : BaseObjectModel
    {
        public static void Serialize(ObservableCollection<T> list)
        {
            XmlSerializer seri =
                new XmlSerializer(typeof(ObservableCollection<T>));
            using (TextWriter writer = new StreamWriter(@"..\..\serialization_test.xml"))
            {
                seri.Serialize(writer, list);
            }
        }
    }
}
