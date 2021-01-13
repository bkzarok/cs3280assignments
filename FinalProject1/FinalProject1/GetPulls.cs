using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    public static class GetPulls
    {
        public static async Task<RootObject2> LoadPulls(string username, string repo)
        {
            string url = "";
            url = $"https://api.github.com/repos/{ username }/{repo}/pulls";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<RootObject2> models = await response.Content.ReadAsAsync<List<RootObject2>>();
                    return models[0];
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }


        }
    }
}
