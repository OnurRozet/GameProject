using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {

            if (gamer.FirstName=="Onur" && gamer.LastName=="Rozet" && gamer.YearOfBirth==1989 && gamer.NationalId=="11111111111")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
