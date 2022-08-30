using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {

            Console.WriteLine("Added :"  + gamer.FirstName+ " " + gamer.LastName + " " );
            }
            else
            {
                Console.WriteLine("Dogrulama basarisiz Kayit olunamadi");
            }
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
