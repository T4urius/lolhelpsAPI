using System;
using System.Collections.Generic;
using System.Text;

namespace LoLHelpsAPI.Models.Entities
{
    public class Status
    {
        public decimal HP { get; set; }
        public decimal Hpperlevel { get; set; }
        public decimal MP { get; set; }
        public decimal Mpperlevel { get; set; }
        public decimal Movespeed { get; set; }
        public decimal Armor { get; set; }
        public decimal Armorperlevel { get; set; }
        public decimal Spellblock { get; set; }
        public decimal Spellblockperlevel { get; set; }
        public long Attackrange { get; set; }
        public decimal Hpregen { get; set; }
        public decimal Hpregenperlevel { get; set; }
        public decimal Mpregen { get; set; }
        public decimal Mpregenperlevel { get; set; }
        public decimal Crit { get; set; }
        public decimal Critperlevel { get; set; }
        public decimal Attackdamage { get; set; }
        public decimal Attackdamageperlevel { get; set; }
        public decimal Attackspeedperlevel { get; set; }
        public decimal Attackspeed { get; set; }
    }
}
