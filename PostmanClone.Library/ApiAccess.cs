using System.Text;
using System.Text.Json;

namespace PostmanClone.Library
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _httpClient = new();


        public async Task<string> CallApiAsync(string url,
           string content, HttpAction action = HttpAction.GET, bool formatOUtput = true)
        {
            StringContent stringContent = new(content, Encoding.UTF8, "application/json");

            return await CallApiAsync(url, stringContent, action, formatOUtput);
        }



        public async Task<string> CallApiAsync(string url, HttpContent content = null,
            HttpAction action = HttpAction.GET,
            bool formatOutPut = true
            )
        {


            HttpResponseMessage? response;
            switch (action)
            {
                case HttpAction.GET:
                    response = await _httpClient.GetAsync(url);
                    break;
                case HttpAction.POST:
                    response = await _httpClient.PostAsync(url, content);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action));
                    break;
            }


            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                if (formatOutPut)
                {

                    var jsonEl = JsonSerializer.Deserialize<JsonElement>(json);
                    string prettyJson = JsonSerializer.Serialize(jsonEl,
                        new JsonSerializerOptions { WriteIndented = true }
                        );
                    return prettyJson;
                }
                else
                {
                    return json;
                }
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }



        public bool IsValidUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }

            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) &&
            (uriOutput.Scheme == Uri.UriSchemeHttps);

            return output;
        }
    }
}
