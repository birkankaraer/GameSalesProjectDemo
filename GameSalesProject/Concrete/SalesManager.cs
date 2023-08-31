using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sale(Sales sales, Gamer gamer, Game game, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + ": kullanicisina " + game.GameName + " oyunu " +
                campaing.CampaingName + " kampanyasi dahilinde " + sales.GamePrice + " fiyatina Satilmistir.");
        }
    }
}
