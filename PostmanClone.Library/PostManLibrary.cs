using Microsoft.Extensions.Logging;

namespace PostmanClone.Library
{
    public class PostManLibrary
    {
        private readonly ILogger<PostManLibrary> _logger;

        public async Task<bool> Call(string text, int callType)
        {
            switch (callType != 1)
            {
                default:
                    break;
            }
            return false;

        }
    }
}
