using Newtonsoft.Json;

namespace TencentCloud.Common
{
    public class JsonResponseErrModel
    {
        [JsonProperty("RequestId")]
        public string RequestId { get; set; }

        [JsonProperty("Error")]
        public ErrorInfo Error { get; set; }       
    }

    public class ErrorInfo
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }
    }
}
