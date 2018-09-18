using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    [DataContract]
    public class HotelEntity
    {
        [DataMember]
        public string Name;
        [DataMember]
        public int Id;
        [DataMember]
        public int rating;
        [DataMember]
        public int price;

    }
}
