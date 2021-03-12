using NewsApp.Models;
using System.Collections.Generic;
using System.Net.Http;


namespace NewsApp.Data
{
    public class Info : IInfo
    {

        IEnumerable<News> IInfo.GetAll()
        {
            IEnumerable<News> res = null;
            using (var client = new HttpClient())
            {
                var response = client.GetAsync("http://localhost:5000/api/news").Result;
                if (response.IsSuccessStatusCode)
                {
                    res = response.Content.ReadAsAsync<IEnumerable<News>>().Result;
                }
                return res;
            }
        }


        News IInfo.GetById(int id)
        {
            using (var client = new HttpClient())
            {
                News res = null;
                var response = client.GetAsync($"http://localhost:5000/api/news/{id}").Result;
                if (response.IsSuccessStatusCode)
                {
                    res = response.Content.ReadAsAsync<News>().Result;
                }
                return res;
            }
        }
    }
}
