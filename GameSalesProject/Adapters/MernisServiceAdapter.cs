using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using GameSalesProject.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Adapters
{
    internal class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.TcNo), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthdayYear.Year);
        }
    }
}
