using netatmocore.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NetatmoCore.Helpers;

namespace NetatmoCore
{
    public class NetAtmoClient
    {
        /// <summary>
        /// Retrieved with NetatmoAuth class
        /// </summary>
        public string AccessToken { get; set; }

        private HttpClient httpClient;

        private const string BASE_URI = "https://api.netatmo.com/api/";

        public NetAtmoClient(string access_token)
        {
            AccessToken = access_token;
            Initialize();
        }

        protected void Initialize()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BASE_URI);
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
        }

        /// <summary>
        /// Returns data from a user Weather Stations (measures and device specific data).
        /// <see cref="https://dev.netatmo.com/resources/technical/reference/weatherstation/getstationsdata"/>
        /// </summary>
        /// <returns></returns>
        public async Task<NAStationDataResponse> Getthermostatsdata(string deviceId)
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("device_id", deviceId);
            var thermostatDataJson = await httpClient.PostAsync(UriHelper.ResourceUriBuilder(httpClient, "getstationsdata", AccessToken), null);

            if (!thermostatDataJson.IsSuccessStatusCode)
                throw new Exception("Server returned " + thermostatDataJson.StatusCode.ToString() + " - Check access_token and device_id parameter.");

            var thermostatData = JsonConvert.DeserializeObject<NAStationDataResponse>(await thermostatDataJson.Content.ReadAsStringAsync());

            if (thermostatData == null || thermostatData.Body == null)
                throw new Exception("Unable to deserialize reply into NAStationDataResponse. Possible version mismatch.");

            return thermostatData;
        }

    }
}
