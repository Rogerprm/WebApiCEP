
using System.Text.Json;
using WebApi.Interface;
using WebApi.Model;
using WebApi.Repository;

namespace WebApi.Service
{
    public class ApiCepService : IApiCepService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IRepository _repository;

        public ApiCepService(IHttpClientFactory httpClientFactory, IRepository repository)
        {
            _httpClientFactory = httpClientFactory;
            _repository = repository;
        }

        public async Task<ApiCepModel> GetByCep(string cep)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();

                var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var apiCepModel = JsonSerializer.Deserialize<ApiCepModel>(content);

                    //ApiCepModel apiCep = new ApiCepModel
                    //{
                    //    Id = apiCepModel.Id,
                    //    Ddd = apiCepModel.Ddd,
                    //    Cep = apiCepModel.Cep,
                    //    Logradouro = apiCepModel.Logradouro,
                    //    Complemento = apiCepModel.Complemento,
                    //    Bairro = apiCepModel.Bairro,
                    //    Localidade = apiCepModel.Localidade,
                    //    Uf = apiCepModel.Uf,
                    //    Ibge = apiCepModel.Ibge,
                    //    Gia = apiCepModel.Gia,
                    //    Diafi = apiCepModel.Diafi
                    //};

                    await _repository.CreateAsync(apiCepModel);

                    return apiCepModel;
                }
                else {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
    }
}
