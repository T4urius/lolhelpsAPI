using LoLHelpsAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLHelpsAPI.Models.Request
{
    public class CampeoesResponse
    {
        public string Tipo { get; set; }
        public string Formato { get; set; }
        public string Versao { get; set; }
        public Data Data { get; set; }
    }
}
