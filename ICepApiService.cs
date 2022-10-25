using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Via_Cep
{
    public interface ICepApiService
    {

        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAdressAsync(string cep);


    }
}
