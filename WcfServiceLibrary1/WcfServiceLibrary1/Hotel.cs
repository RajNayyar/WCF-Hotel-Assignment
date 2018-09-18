using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public class Hotel : IHotel
    {
        List<HotelEntity> dataList = new List<HotelEntity>();
        
        public List<HotelEntity> GetHotelData()
        {
            Loadjson data = new Loadjson();
            dataList = data.LoadData();
            return dataList;

        }
        public HotelEntity GetHotelById(int id)
        {
            Loadjson data = new Loadjson();
            dataList = data.LoadData();
            foreach(var item in dataList)
            {
                if(item.Id==id)
                {
                    return item;
                }
            }
            return null;
        }
       

    }

}
