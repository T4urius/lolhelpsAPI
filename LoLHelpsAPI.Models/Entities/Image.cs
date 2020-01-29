using System;
using System.Collections.Generic;
using System.Text;

namespace LoLHelpsAPI.Models.Entities
{
    public class Image
    {
        public string Full { get; set; }
        public string Sprite { get; set; }
        public string Group { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal W { get; set; }
        public decimal H { get; set; }
    }
}
