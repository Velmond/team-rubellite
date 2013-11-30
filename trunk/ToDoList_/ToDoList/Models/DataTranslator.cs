namespace ToDoList.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Xml.Serialization;

    class DataTranslator<T> where T : BaseObjectModel
    {
        private static readonly string path = @"..\..\Data\";

        public static void Serialize(ObservableCollection<T> list)
        {
          
            XmlSerializer seri =
                new XmlSerializer(typeof(ObservableCollection<T>));
            using (TextWriter writer = new StreamWriter(path+(typeof(T).ToString())+".xml"))
            {
                seri.Serialize(writer, list);
            }
        }

        public static ObservableCollection<T> Deserialize()
        {
            ObservableCollection<T> result=new ObservableCollection<T>();
            XmlSerializer deseri =
                new XmlSerializer(typeof(ObservableCollection<T>));

            if (!File.Exists(path + (typeof(T).ToString()) + ".xml"))
            {
                Serialize(new ObservableCollection<T>());
            }

            using (TextReader reader = new StreamReader(path + (typeof(T).ToString()) + ".xml"))
            {
                result = deseri.Deserialize(reader) as ObservableCollection<T>;
            }
            return result;
        }
    }
}
