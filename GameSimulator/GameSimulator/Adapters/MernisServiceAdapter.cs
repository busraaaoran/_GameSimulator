using GameSimulator.Abstract;
using GameSimulator.Entities;
using MernisServiceReference;
using GameSimulator.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Adapters
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool IsPerson(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return Convert.ToBoolean(client.TCKimlikNoDogrula(player.TCKN,player.FirstName.ToUpper(),player.LastName.ToUpper(),player.DateOfBirth.Year));
        }
    }
}
