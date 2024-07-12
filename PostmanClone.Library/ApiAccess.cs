using System.Text.Json;

namespace PostmanClone.Library
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient _httpClient = new();

        public async Task<string> CallApiAsync(string url,
            bool formatOutPut = true,
            HttpAction action = HttpAction.GET)
        {
            var response = await _httpClient.GetAsync(url);

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
