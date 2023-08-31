using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
    }
}
