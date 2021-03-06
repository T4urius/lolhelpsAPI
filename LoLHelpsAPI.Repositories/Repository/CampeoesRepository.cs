﻿using LoLHelpsAPI.Models.Entities;
using LoLHelpsAPI.Models.Request;
using LoLHelpsAPI.Repositories.Contracts;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LoLHelpsAPI.Repositories.Repository
{
    public class CampeoesRepository : ICampeoesRepository
    {
        public async Task<IList<CampeoesResponse>> ListarCampeoes()
        {
            var list = new List<CampeoesResponse>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/10.2.1/data/pt_BR/champion.json"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        WriteIndented = true
                    };

                    var jsonModel = JsonSerializer.Deserialize<CampeoesResponse>(apiResponse, options);
                    list.Add(jsonModel);
                }
            }
            return list;
        }

        //public async Task<byte[]> PegarImagem(string full)
        //{
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/10.2.1/img/champion/" + full))
        //        {
        //            var context = await response.Content.ReadAsByteArrayAsync();
        //            return context;
        //        }
        //    }
        //}
    }
}
