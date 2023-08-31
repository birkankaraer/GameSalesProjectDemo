using GameSalesProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Entities
{
    public class Campaing :IEntity
    {
        public int CampaingId { get; set; }
        public string CampaingName { get; set; }
    }
}
