using Newtonsoft.Json;

namespace TencentCloud.Common
{
    public class JsonResponseModel<T>
    {
        [JsonProperty("Response")]
        public T Response { get; set; }
    }
}
