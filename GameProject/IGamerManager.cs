using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamerManager
    {
        void Add(Gamer gamer, List<Gamer> gamers);
        void Update(Gamer gamer);
        void Delete(Gamer gamer, List<Gamer> gamers);
    }
}
