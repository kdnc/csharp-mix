﻿namespace Kdnc.App.Domain.Models
{
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
        public int BattleId { get; set; }
        public Battle Battle { get; set; }
    }
}
