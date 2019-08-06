using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject1
{
    public static class Repos
    {

        public static async Task<RepoModel> LoadRepo(string username)
        {
            string url = "";
            url = $"https://api.github.com/users/{ username }/repos";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<RepoModel> models = await response.Content.ReadAsAsync<List<RepoModel>>();
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
