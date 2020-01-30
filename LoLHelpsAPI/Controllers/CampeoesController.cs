using LoLHelpsAPI.Models.Request;
using LoLHelpsAPI.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LoLHelpsAPI.Controllers
{
    [ApiController]
    [Route("api/campeoes")]
    public class CampeoesController : ControllerBase
    {
        private readonly ICampeoesRepository _repository;

        public CampeoesController(ICampeoesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public Task<IList<CampeoesResponse>> ListarCampeoes()
        {
            var response = _repository.ListarCampeoes();
            return response;
        }

        [HttpPost("images")]
        public async Task<IList<byte[]>> ListarImagens([FromBody] string[] fulls)
        {
            var listFulls = new List<byte[]>();
            if (fulls.Any())
            {
                foreach (var full in fulls)
                 {
                    using (var httpClient = new HttpClient())
                    {
                        using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/10.2.1/img/champion/" + full))
                        {
                            var context = await response.Content.ReadAsStreamAsync();
                            using (var memoryStream = new MemoryStream())
                            {
                                context.CopyTo(memoryStream);
                                Bitmap image = new Bitmap(1, 1);
                                image.Save(memoryStream, ImageFormat.Png);

                                byte[] byteImage = memoryStream.ToArray();
                                listFulls.Add(byteImage);
                            }
                        }
                    }
                }
                return listFulls;
            }
            else
            {
                return listFulls;
            }
        }

        [HttpGet("image")]
        public async Task<byte[]> PegarImagem(string full)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://ddragon.leagueoflegends.com/cdn/10.2.1/img/champion/" + full))
                {
                    var context = await response.Content.ReadAsStreamAsync();
                    using (var memoryStream = new MemoryStream())
                    {
                        context.CopyTo(memoryStream);
                        Bitmap image = new Bitmap(1, 1);
                        image.Save(memoryStream, ImageFormat.Png);

                        byte[] byteImage = memoryStream.ToArray();
                        return byteImage;
                    }
                }
            }
        }

        //var response = await _repository.PegarImagem(full);
        //return File(response, "image/png");
    }
}
