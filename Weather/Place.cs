using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Weather
{
    class Place
    {
        public static PlaceModel[] GetProvinces()
        {
            return GetPlaceList("http://www.weather.com.cn/data/city3jdata/china.html");
        }

        public static PlaceModel[] GetCitys(PlaceModel province)
        {
            return GetPlaceList($"http://www.weather.com.cn/data/city3jdata/provshi/{province.ID}.html");
        }

        public static PlaceModel[] GetDistricts(PlaceModel province,PlaceModel city)
        {
            return GetPlaceList($"http://www.weather.com.cn/data/city3jdata/station/{province.ID}{city.ID}.html");
        }

        static PlaceModel[] GetPlaceList(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //request.Timeout = 3000;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string content = reader.ReadToEnd();
                    response.Close();
                    return JsonToArray(content).ToArray();
                }
            }
            catch
            {
                return new List<PlaceModel>().ToArray();
            }
        }

        static PlaceModel[] JsonToArray(string json)
        {
            List<PlaceModel> list = new List<PlaceModel>();
            string[] array1 = json.Replace("{", "").Replace("}", "").Split(',');
            string[] array2;
            for (int i = 0; i < array1.Length; i++)
            {
                array2 = array1[i].Split(':');
                for (int j = 0; j < array2.Length; j = j + 2)
                {
                    list.Add(new PlaceModel { ID = array2[j].Replace("\"", ""), Name = array2[j + 1].Replace("\"", "") });
                }
            }
            return list.ToArray();
        }
    }

    public class PlaceModel
    {
        public string ID { set; get; }
        public string Name { set; get; }

        public override bool Equals(object obj)
        {
            PlaceModel pm = (PlaceModel)obj;
            if (this.ID == pm.ID && this.Name == pm.Name)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (this.ID + this.Name).GetHashCode();
        }

    }
}
