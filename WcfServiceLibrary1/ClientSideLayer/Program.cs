using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientSideLayer.HotelServiceReference;
namespace ClientSideLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 to get all hotels\n2 to get hotel by id\n3 to exit");
                int option = int.Parse(Console.ReadLine());
                HotelClient client = new HotelClient("BasicHttpBinding_IHotel");
                List<HotelEntity> HotelList = new List<HotelEntity>();
                if (option==1)
                {
                    HotelList = new List<HotelEntity>(client.GetHotelData());
                    foreach( var items in HotelList)
                    {
                        Console.WriteLine("Id: "+items.Id+"  Name: " + items.Name + "  Rating: " +items.rating+"  Price: "+items.price);
                    }
                }
                else if(option==2)
                {
                    Console.WriteLine("Enter Id");
                    int id = int.Parse(Console.ReadLine());
                    if (client.GetHotelById(id) == null)
                    {
                        Console.WriteLine("No Hotel Found");
                    }
                    else
                    {
                        HotelList.Add(client.GetHotelById(id));
                        Console.WriteLine("Id: " + HotelList[0].Id + "  Name: " + HotelList[0].Name + "  Rating: " + HotelList[0].rating + "  Price: " + HotelList[0].price);
                    }
                    
                }
                else if(option==3)
                {
                    break;
                }
            }
        }
    }
}
