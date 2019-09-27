using Newtonsoft.Json;
using Sintalocas.UI.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Sintalocas.UI.Mobile.Services
{
    public class DataService
    {
        HttpClient client = new HttpClient();

        private string webapi = "http://mobileapp.somee.com/api/values";

        public async Task<List<Noticia>> GetProdutosAsync()
        {
            try
            {
                string url = webapi;
                var response = await client.GetStringAsync(url);
                var produtos = JsonConvert.DeserializeObject<List<Noticia>>(response);
                return produtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public async Task AddProdutoAsync(Noticia noticia)
        //{
        //    try
        //    {
        //        string url = "http://www.macwebapi.somee.com/api/produtos/{0}";
        //        var uri = new Uri(string.Format(url, noticia.id));
        //        var data = JsonConvert.SerializeObject(noticia);
        //        var content = new StringContent(data, Encoding.UTF8, "application/json");
        //        HttpResponseMessage response = null;
        //        response = await client.PostAsync(uri, content);

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            throw new Exception("Erro ao incluir produto");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public async Task UpdateProdutoAsync(Noticia noticia)
        //{
        //    string url = "http://www.macwebapi.somee.com/api/produtos/{0}";
        //    var uri = new Uri(string.Format(url, noticia.id));
        //    var data = JsonConvert.SerializeObject(noticia);
        //    var content = new StringContent(data, Encoding.UTF8, "application/json");
        //    HttpResponseMessage response = null;
        //    response = await client.PutAsync(uri, content);

        //    if (!response.IsSuccessStatusCode)
        //    {
        //        throw new Exception("Erro ao atualizar produto");
        //    }
        //}
        //public async Task DeletaProdutoAsync(Noticia noticia)
        //{
        //    string url = "  http://www.macwebapi.somee.com/api/produtos/{0}";
        //    var uri = new Uri(string.Format(url, noticia.id));
        //    await client.DeleteAsync(uri);
        //}
    }
}
