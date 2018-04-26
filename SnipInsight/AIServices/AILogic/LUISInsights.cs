// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using SnipInsight.AIServices.AIModels;
using SnipInsight.Util;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace SnipInsight.AIServices.AILogic
{
    public class LUISInsights : CloudService<LUISModel>
    {
        /// <summary>
        /// Backend logic to access LUIS API
        /// </summary>
        /// <param name="keyFile"></param>
        public LUISInsights(string keyFile) : base(keyFile)
        {
            Host = "westus.api.cognitive.microsoft.com";
            Endpoint = "luis/v2.0/apps/" + UserSettings.GetKey("LUISAppId");
        }

        /// <summary>
        /// Returns the result of the API call
        /// </summary>
        /// <param name="ocrResult">OCR text string used for the call</param>
        /// <returns>Data extracted from successful API response, default in case of failure</returns>
        public async Task<LUISModel> GetResult(string ocrResult)
        {
            try
            {
                var result = await Run(ocrResult);
                return ExtractResult(await result.Content.ReadAsStringAsync());
            }
            catch (WebException e)
            {
                Debug.WriteLine(e.Message + URI);
                return default(LUISModel);
            }
        }

        /// <summary>
        /// Run the API call and get the response message and records telemetry event with time to complete api call and status code
        /// </summary>
        /// <param name="ocrResult">OCR results to be used for the call</param>
        /// <returns>The HttpResponseMessage containing the Json result</returns>
        protected async Task<HttpResponseMessage> Run(string ocrResult)
        {
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["q"] = ocrResult;
            // These optional request parameters are set to their default values
            queryString["timezoneOffset"] = "0";
            queryString["verbose"] = "false";
            queryString["spellCheck"] = "false";
            queryString["staging"] = "false";

            RequestParams = queryString.ToString();
            BuildURI();

            HttpResponseMessage response = await RequestAndRetry(() => CloudServiceClient.GetAsync(URI));
            response.EnsureSuccessStatusCode();

            return response;
        }
    }
}
