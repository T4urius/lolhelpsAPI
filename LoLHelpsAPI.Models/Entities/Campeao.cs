﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoLHelpsAPI.Models.Entities
{
    public class Campeao
    {
        public string Version { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Blurb { get; set; }
        public Info Info { get; set; }
        public Image Image { get; set; }
        public List<string> Tags { get; set; }
        public string Partype { get; set; }
        public Status Stats { get; set; }
    }
}
