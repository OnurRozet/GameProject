using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Added :"  + gamer.FirstName+ " " + gamer.LastName + " " ); 
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted :" + gamer.FirstName + " " + gamer.LastName + " ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated :" + gamer.FirstName + " " + gamer.LastName + " ");
        }
    }
}
