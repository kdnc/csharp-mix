using System;
using System.Collections.Generic;

namespace Kdnc.App.Domain.Models
{
    public class Battle
    {
        public Battle()
        {
            SamuraiBattles = new List<SamuraiBattle>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
