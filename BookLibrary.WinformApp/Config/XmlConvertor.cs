using System.Xml.Serialization;

namespace LibraryWindowsApp
{
    public class XmlConvertor
    {
        static public T XmlDeserialization<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(new System.IO.StringReader(xml));
        }

        static public string Serialize<T>(string path, T type)
        {
            var serializer = new XmlSerializer(type.GetType());
            using (var writer = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(writer, type);
                return writer.ToString();
            }
        }
    }
}
