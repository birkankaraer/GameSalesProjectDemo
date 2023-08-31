using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Kampanya eklendi :"+ campaing.CampaingName);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kampanya kaldırıldı :" + campaing.CampaingName);
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanya güncellendi :" + campaing.CampaingName);
        }
    }
}
