using Refit;
using System;
using System.Threading.Tasks;

namespace API_Via_Cep
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                Console.WriteLine("Infome seu cep");

                string cepInformado = Console.ReadLine().ToString();
                Console.WriteLine("Consultando informações do CEP: " + cepInformado);

                var adress = await cepClient.GetAdressAsync(cepInformado);

                Console.Write($"\nLogradouro: {adress.Logradouro}" +
                    $" \nBairro: {adress.Bairro}" +
                    $"\nCidade: {adress.Localidade}" +
                    $"\nLogradouro: {adress.Logradouro}" +
                    $"\nComplemento: {adress.Complemento}");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error na consulta de cep: " + e.Message);
            }


        }
    }
}
