using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practic._5__практична
{
    internal class People
    {
        public List<Person> people = new List<Person>();

        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

        public void Add(Person person)
        {
            people.Add(person);
        }

        public void Remove(int i)
        {
               people.RemoveAt(i);
        }

        public void SortByStage()
        {
            people.Sort(new SortByStage());
        }

        public void WriteFile( string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            serializer.Serialize(fs, people);
            fs.Close();
        }

        public void ReadFile( string path )
        {
               FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
            people = serializer.Deserialize(fs) as List<Person>;
            fs.Close();
        }
    }
}
