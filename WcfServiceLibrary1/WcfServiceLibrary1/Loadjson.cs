using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace WcfServiceLibrary1
{
    class Loadjson
    {

        public List<HotelEntity> LoadData()
        {
            List<HotelEntity> hoteldata = new List<HotelEntity>();
            using (StreamReader r = new StreamReader("C:/Users/rnayyar/desktop/WcfServiceLibrary1/TextFile1.json"))
            {
                var json = r.ReadToEnd();
                hoteldata = Newtonsoft.Json.JsonConvert.DeserializeObject<List<HotelEntity>>(json);
                
            }
            return hoteldata;
        }
    }
}
