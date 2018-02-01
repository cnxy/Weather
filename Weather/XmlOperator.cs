using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Weather
{
    class XmlOperator
    {
        public static void  Serialize<T>(string fileName, T instance)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                xmlSerializer.Serialize(stream, instance);
            }
        }

        public static T Deserialize<T>(string fileName)
        {
            if (!File.Exists(fileName)) return default(T);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
               return (T)xmlSerializer.Deserialize(stream);
            }
        }
    }

    public class AreaCollection
    {
        public Area[] Areas { set; get; }

        public void Add(Area area)
        {
            if (this.Areas == null) this.Areas = new Area[0];
            List<Area> list = this.Areas.ToList();
            if(!list.Contains(area))
            {
                list.Add(area);
                this.Areas = list.ToArray();
            }
        }

        public void Remove(Area area)
        {
            if (this.Areas == null) this.Areas = new Area[0];
            List<Area> list = this.Areas.ToList();
            if (list.Contains(area))
            {
                list.Remove(area);
                this.Areas = list.ToArray();
            }
        }

    }

    public class Area:IEquatable<Area>
    {
        public string Name { set; get; }

        public PlaceModel Province { set; get; }
        public PlaceModel City { set; get; }
        public PlaceModel District { set; get; }


        public bool Equals(Area other)
        {
            if (this.Name == other.Name && this.Province.Equals(other.Province) && this.City.Equals(other.City) && this.District.Equals(other.District))
                return true;
            return false;   
        }
    }
}
