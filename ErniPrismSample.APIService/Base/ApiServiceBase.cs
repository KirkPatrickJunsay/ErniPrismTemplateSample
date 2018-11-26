using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ErniPrismSample.APIService.Base
{
    public class ApiServiceBase
    {
        public static string AppBaseAddress = @"https://SampleBaseAddress.azurewebsites.net";
        private Uri BaseAddress = new Uri(AppBaseAddress);
        public static string AccessToken { get; set; }
        public HttpClient httpClient { get; set; }

        public ApiServiceBase()
        {
            this.httpClient = new HttpClient() { BaseAddress = BaseAddress };
            this.httpClient.Timeout = TimeSpan.FromSeconds(60);
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// GetRequestAsync method handles the Get Request sent to API and returns a type HttpContent.
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns>HttpContent</returns>
        public async Task<HttpContent> GetRequestAsync(string requestUri)
        {
            HttpResponseMessage requestResponse = new HttpResponseMessage();

            try
            {
                if (!string.IsNullOrEmpty(AccessToken))
                {
                    this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                }

                requestResponse = await this.httpClient.GetAsync(requestUri);


                if (requestResponse.IsSuccessStatusCode)
                {
                    //Dev Hint: This clause statement represents that the Get action has been processed successfully.
                }
                else if (requestResponse.StatusCode == HttpStatusCode.InternalServerError)
                {
                    //Dev Hint: This clause statement represents that the Get action has encountered InternalServer Error.
                }
                else if (requestResponse.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //Dev Hint: This clause statement represents that the Get action has encountered Unauthorized Error.
                }

            }
            catch (TaskCanceledException)
            {
                //Dev Hint: Need to throw or log the encountered TaskCanceledException.
            }
            catch (HttpRequestException)
            {
                //Dev Hint: Need to throw or log the encountered HttpRequestException.
            }
            catch (Exception)
            {
                //Dev Hint: Need to throw or log the encountered General Exception.
            }

            return requestResponse?.Content;
        }

        /// <summary>
        /// PostRequestAsync method handles the Post Request sent to API and returns a type HttpContent.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUri"></param>
        /// <param name="content"></param>
        /// <returns>HttpContent</returns>
        public async Task<HttpContent> PostRequestAsync<T>(string requestUri, T content)
        {
            string jsonString = string.Empty;
            StringContent stringJsonContent = default(StringContent);
            HttpResponseMessage requestResponse = new HttpResponseMessage();

            try
            {
                if (!string.IsNullOrEmpty(AccessToken))
                {
                    this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
                }

                jsonString = JsonConvert.SerializeObject(content);
                stringJsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
                requestResponse = await this.httpClient.PostAsync(requestUri, stringJsonContent);

                if (requestResponse.IsSuccessStatusCode)
                {
                    //Dev Hint: This clause statement represents that the Get action has been processed successfully.
                }
                else if (requestResponse.StatusCode == HttpStatusCode.InternalServerError)
                {
                    //Dev Hint: This clause statement represents that the Get action has encountered InternalServer Error.
                }
                else if (requestResponse.StatusCode == HttpStatusCode.Unauthorized)
                {
                    //Dev Hint: This clause statement represents that the Get action has encountered Unauthorized Error.
                }

            }
            catch (TaskCanceledException)
            {
                //Dev Hint: Need to throw or log the encountered TaskCanceledException.
            }
            catch (HttpRequestException)
            {
                //Dev Hint: Need to throw or log the encountered HttpRequestException.
            }
            catch (Exception)
            {
                //Dev Hint: Need to throw or log the encountered General Exception.
            }

            return requestResponse?.Content;
        }
    }
}
