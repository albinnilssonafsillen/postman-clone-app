

namespace PostmanClone.Library
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, HttpContent content = null, HttpAction action = HttpAction.GET, bool formatOutPut = true);
        Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOUtput = true);
        bool IsValidUrl(string url);
    }
}