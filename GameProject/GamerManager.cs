using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerManager
    {
        IValidationManager _validation;
        public GamerManager(IValidationManager validation)
        {
            _validation = validation;
        }

        public void Add(Gamer gamer, List<Gamer> gamers)
        {
            if(_validation.Validate(gamer))
            {
                Console.WriteLine("Congratulations " + gamer.Name + " added the server");
                gamers.Add(gamer);
            }
            else
            {
                Console.WriteLine("Validation failed.");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_validation.Validate(gamer))
            {
                Console.WriteLine("Congratulations " + gamer.Name + " updated");
            }
            else
            {
                Console.WriteLine("Validation failed.");
            }
        }

        public void Delete(Gamer gamer, List<Gamer> gamers)
        {
            if (_validation.Validate(gamer))
            {
                Console.WriteLine(gamer.Name + " deleted");
                gamers.Remove(gamer);
            }
            else
            {
                Console.WriteLine("Validation failed.");
            }
        }
    }
}
