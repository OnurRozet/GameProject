using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer,Game game)
        {
            Console.WriteLine("Sale has been Completed : " + gamer.FirstName);
            Console.WriteLine("Game Taken is : " + game.GameName);
        }
    }
}
