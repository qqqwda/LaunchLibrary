using LaunchLibrary.Models;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LaunchLibrary.Services
{
    public class ApiService
    {

        #region CheckConnection
        public async Task<Response> CheckConnection()
        {

            if (!CrossConnectivity.Current.IsConnected)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "No connection",

                };
            }

            var isReachable = await CrossConnectivity.Current.IsRemoteReachable("google.com");

            if (!isReachable)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "No connection",

                };
            }

            return new Response
            {
                IsSuccess = true,
                Message = "OK"

            };
        }
        #endregion

        #region Services

        public async Task<Response> GetList<T>(string urlBase, string servicePrefix, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = string.Format("{0}{1}{2}", urlBase, servicePrefix, controller);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = "Json returned empty",

                    };
                }
                var list = JsonConvert.DeserializeObject<List<T>>(json);

                return new Response
                {
                    IsSuccess = true,
                    Message = list.ToString(),
                    Result = list
                };


            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }

        public async Task<Launchs> GetLaunchs<T>(string urlBase, string servicePrefix, string controller)
        {
            using (var client = new HttpClient())
            {
                var url = string.Format("{0}{1}{2}", urlBase, servicePrefix, controller);
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                    return null;

                return JsonConvert.DeserializeObject<Launchs>(json);
            }

        }
        #endregion

    }
}