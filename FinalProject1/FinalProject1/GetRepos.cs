using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    public static class GetRepos
    {

        public static async Task<RootObject> LoadRepo(string username)
        {
            string url = "";
            url = $"https://api.github.com/users/{ username }/repos";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<RootObject> models = await response.Content.ReadAsAsync<List<RootObject>>();
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
