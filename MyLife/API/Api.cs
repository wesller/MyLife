using MyLifeModel.Domain;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace MyLife.API
{
    public class Api
    {
        public Api() { }

        public async void Add(Anotacao anotacao)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5179/");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "anotacao", anotacao);
            MessageBox.Show(response.ToString());
        }
    }
}
