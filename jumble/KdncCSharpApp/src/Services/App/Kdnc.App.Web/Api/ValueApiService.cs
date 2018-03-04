using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Kdnc.App.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;

namespace Kdnc.App.Web.Api
{
    public class ValueApiService
    {
        private readonly HttpClient client;
        private readonly IHttpContextAccessor httpContextAccessor;

        public ValueApiService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            this.client = client;
            this.httpContextAccessor = httpContextAccessor;
        }
        private async Task EnsureBearerToken()
        {
            client.SetBearerToken(await httpContextAccessor.HttpContext.GetTokenAsync("access_token"));
        }

        public async Task<IEnumerable<ValueModel>> GetAll()
        {
            List<ValueModel> result;
            await EnsureBearerToken();
            var response = await client.GetAsync("/Value/GetAll");
            if (response.IsSuccessStatusCode)
                result = await response.Content.ReadAsAsync<List<ValueModel>>();
            else
                throw new HttpRequestException(response.ReasonPhrase);

            return result;
        }
    }

    
}