using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class BaseGamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Added to Gamer : " + gamer.FirstName + gamer.LastName ); ;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to Gamer :" + gamer.FirstName + gamer.LastName); ;
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to Gamer : " + gamer.FirstName + gamer.LastName); 
        }
    }
}
