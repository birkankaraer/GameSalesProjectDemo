using GameSalesProject.Adapters;
using GameSalesProject.Concrete;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                FirstName = "MUSTAFA BİRKAN",
                LastName = "KARAER",
                BirthdayYear = new DateTime(2000, 00, 00),
                TcNo = "11111111111"
            };
           

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);

            Console.WriteLine("\n");

            Game game1 = new Game() { Id = 1, GameName = "CounterStrike", GamePrice = 144 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            Console.WriteLine("\n");


            Campaing campagin1 = new Campaing() { CampaingId = 1, CampaingName = "Fps oyunlarinda %10 indirim firsati!!!! " };
            CampaignManager campaginManager = new CampaignManager();
            campaginManager.Add(campagin1);
            campaginManager.Delete(campagin1);
            campaginManager.Update(campagin1);
            Console.WriteLine("\n");

            Sales sales1 = new Sales() { SalesId = 1, GamePrice = 149 };
            SalesManager salesManager = new SalesManager();
            salesManager.Sale(sales1, gamer1, game1, campagin1);

        }
    }
}
