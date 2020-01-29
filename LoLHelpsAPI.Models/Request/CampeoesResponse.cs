using LoLHelpsAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoLHelpsAPI.Models.Request
{
    public class CampeoesResponse
    {
        public string Type { get; set; }
        public string Format { get; set; }
        public string Version { get; set; }
        public IDictionary<string, Campeao> Data { get; set; }        


    }
}
