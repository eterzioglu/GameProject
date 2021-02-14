using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ValidationManager : IValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.YearOfBrith == 1997 && gamer.Name == "Ebru" && gamer.Surname == "TERZIOGLU" && gamer.IdentityNumber == "123456987")
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
