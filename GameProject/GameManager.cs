using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine("{0} oyunu , {1} tarafindan satin alinmistir",game.GameName,gamer.FirstName + " "+ gamer.LastName);
        }
    }
}
