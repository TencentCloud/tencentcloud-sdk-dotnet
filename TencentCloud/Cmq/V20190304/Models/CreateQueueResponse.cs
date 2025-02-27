using System.Collections.Generic;
using TencentCloud.Common;
using TencentCloud.Common.Extensions;

namespace TencentCloud.Cmq.V20190304.Models
{
    public class CreateQueueResponse : AbstractModel
    {
        /// <summary>
        /// 创建成功的queueId
        /// </summary>
        /// <example>
        ///示例值：cmqq-o9p8j9vp
        /// </example>
        public string QueueId { get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        public string RequestId { get; set; }

        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            map.AddParam(prefix + "QueueId", QueueId)
                .AddParam(prefix + "RequestId", RequestId);
        }
    }
}