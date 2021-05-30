using DatasetService.Interfaces;
using Newtonsoft.Json;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace DatasetService
{
    public class FetchData : IFetchData<WebResponse>
    {
        /// <summary>
        /// Fetch data from Web
        /// </summary>
        /// <returns>List of Cheese entity</returns>
        public async Task<WebResponse> GetDataFromWeb()
        {
            var results = new WebResponse();
            try
            {
                // Use HttpClient for executing WebRequest
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //GET Method  
                    HttpResponseMessage response = await client.GetAsync(Utility.CHEESEURL);
                    if (response.IsSuccessStatusCode)
                    {
                        // Get String Response from Response Body
                        var jasonResult = await response.Content.ReadAsStringAsync();
                        // Convert to List of Entity
                        results = JsonConvert.DeserializeObject<WebResponse>(jasonResult);
                    }
                    else
                    {
                        throw new Exception("Invalid Response from Web");
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO: Manage Error Logs
            }
            return results;
        }

        public Task<int> InsertBulkData(WebResponse lstData)
        {
            try
            {
                using (var db = new DBManager().OrmLite.Open())
                {
                    // ORM Lite for inserting Bulk Data
                    db.InsertAll(lstData.CheeseDirectory);
                }
                return Task.FromResult(1);
            }
            catch (Exception ex)
            {
                //TODo: Handle Error Logs
                throw ex;
            }
            return Task.FromResult(0);
        }
    }
}
