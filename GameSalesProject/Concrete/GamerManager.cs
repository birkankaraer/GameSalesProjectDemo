using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    internal class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager (IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Oyuncu eklendi : " + gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Gerçek kullanıcı değilsiniz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi : " + gamer.FirstName);
        }
    }
}
