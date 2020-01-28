using System;
using System.Collections.Generic;
using System.Text;

namespace LoLHelpsAPI.Models.Entities
{
    public class Campeao
    {
        public string Versao { get; set; }
        public string Id { get; set; }
        public string Chave { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public string Blurb { get; set; }
        public Info Info { get; set; }
        public Tags Tags { get; set; }
        public string Parttype { get; set; }
        public Status Status { get; set; }
    }
}
