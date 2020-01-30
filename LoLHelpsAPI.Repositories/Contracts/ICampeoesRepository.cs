using LoLHelpsAPI.Models.Request;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoLHelpsAPI.Repositories.Contracts
{
    public interface ICampeoesRepository
    {
        Task<IList<CampeoesResponse>> ListarCampeoes();
        //Task<byte[]> PegarImagem(string full);
    }
}
