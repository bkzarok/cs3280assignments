using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace FinalProject1
{
    public static class GetCommits
    {
        public static async Task<RootObject1> LoadCommits(string username, string repo)
        {
            string url = "";
            url = $"https://api.github.com/repos/{ username }/{repo}/commits";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<RootObject1> models = await response.Content.ReadAsAsync<List<RootObject1>>();
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
