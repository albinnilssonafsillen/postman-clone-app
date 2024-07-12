
namespace PostmanClone.Library
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatOutPut = true, HttpAction action = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}