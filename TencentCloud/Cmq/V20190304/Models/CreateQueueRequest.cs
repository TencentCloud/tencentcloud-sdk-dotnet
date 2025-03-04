using System.Collections.Generic;
using Newtonsoft.Json;
using TencentCloud.Common;
using TencentCloud.Common.Extensions;

namespace TencentCloud.Cmq.V20190304.Models
{
    public class CreateQueueRequest : AbstractModel
    {
        /// <summary>
        /// 队列名字，在单个地域同一账号下唯一。队列名称是一个不超过 64 个字符的字符串，必须以字母为首字符，剩余部分可以包含字母、数字和横划线(-)。
        /// </summary>
        /// <example>
        /// testQueue
        /// </example>
        [JsonProperty("QueueName")]
        public string QueueName { get; set; }

        /// <summary>
        /// 最大堆积消息数。取值范围在公测期间为 1,000,000 - 10,000,000，正式上线后范围可达到 1000,000-1000,000,000。
        /// 默认取值在公测期间为 10,000,000，正式上线后为 100,000,000。
        /// </summary>
        [JsonProperty("MaxMsgHeapNum")]
        public ulong? MaxMsgHeapNum { get; set; }

        /// <summary>
        /// 消息接收长轮询等待时间。取值范围 0-30 秒，默认值 0。
        /// </summary>
        [JsonProperty("PollingWaitSeconds")]
        public ulong? PollingWaitSeconds { get; set; }

        /// <summary>
        /// 消息可见性超时。取值范围 1-43200 秒（即12小时内），默认值 30。示例值：30 
        /// </summary>
        [JsonProperty("VisibilityTimeout")]
        public ulong? VisibilityTimeout { get; set; }

        /// <summary>
        /// 消息最大长度。取值范围 1024-1048576 Byte（即1-1024K），默认值 1048576。 示例值：1048576
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize { get; set; }

        /// <summary>
        /// 消息最长未确认时间。取值范围 30-43200 秒（30秒~12小时），默认值 3600 (1 小时)。示例值：3600
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds { get; set; }

        /// <summary>
        /// 队列是否开启回溯消息能力，该参数取值范围0-1296000，0表示不开启。示例值：0
        /// </summary>
        [JsonProperty("RewindSeconds")]
        public ulong? RewindSeconds { get; set; }

        /// <summary>
        /// 1 表示事务队列，0 表示普通队列
        /// 示例值：0
        /// </summary>
        [JsonProperty("Transaction")]
        public ulong? Transaction { get; set; }

        /// <summary>
        /// 次回查间隔
        /// 示例值：0
        /// </summary>
        [JsonProperty("FistQueryInterval")]
        public ulong? FistQueryInterval { get; set; }

        /// <summary>
        ///最大回查次数
        /// 示例值：0
        /// </summary>
        [JsonProperty("MaxQueryCount")]
        public ulong? MaxQueryCount { get; set; }

        /// <summary>
        /// 死信队列名称
        /// </summary>
        /// <example>
        /// test1
        /// </example>
        [JsonProperty("DeadLetterQueueName")]
        public string DeadLetterQueueName { get; set; }

        /// <summary>
        /// 死信策略。0为消息被多次消费未删除，1为Time-To-Live过期
        /// 示例值：0
        /// </summary>
        [JsonProperty("Policy")]
        public ulong? Policy { get; set; }

        /// <summary>
        /// 最大接收次数 1-1000
        /// 示例值：1
        /// </summary>
        [JsonProperty("MaxReceiveCount")]
        public ulong? MaxReceiveCount { get; set; }

        /// <summary>
        /// policy为1时必选。最大未消费过期时间。范围300-43200，单位秒，需要小于消息最大保留时间 <see cref="MsgRetentionSeconds"/> 
        /// 示例值：300
        /// </summary>
        [JsonProperty("MaxTimeToLive")]
        public ulong? MaxTimeToLive { get; set; }

        /// <summary>
        /// 是否开启消息轨迹追踪，当不设置字段时，默认为不开启，该字段为true表示开启，为false表示不开启
        /// 示例值：false
        /// </summary>
        public bool? Trace { get; set; }

        /// <summary>
        /// 标签数组
        /// </summary>
        /// <example>
        /// [{"TagKey":"aa","TagValue":"bb"}]
        /// </example>
        [JsonProperty("Tags")]
        public Tag[] Tags { get; set; }

        /// <summary>
        /// 队列可回溯存储空间：若开启消息回溯，取值范围：10240MB - 512000MB，若不开启消息回溯，取值：0
        /// 示例值：0
        /// </summary>
        [JsonProperty("RetentionSizeInMB")]
        public long? RetentionSizeInMb { get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        /// <param name="map"></param>
        /// <param name="prefix"></param>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            map
                .AddParam(prefix + "Queue", QueueName)
                .AddParam(prefix + "MaxMsgHeapNum", MaxMsgHeapNum)
                .AddParam(prefix + "PollingWaitSeconds", PollingWaitSeconds)
                .AddParam(prefix + "VisibilityTimeout", VisibilityTimeout)
                .AddParam(prefix + "MaxMsgSize", MaxMsgSize)
                .AddParam(prefix + "MsgRetentionSeconds", MsgRetentionSeconds)
                .AddParam(prefix + "RewindSeconds", RewindSeconds)
                .AddParam(prefix + "Transaction", Transaction)
                .AddParam(prefix + "FistQueryInterval", FistQueryInterval)
                .AddParam(prefix + "MaxQueryCount", MaxQueryCount)
                .AddParam(prefix + "DeadLetterQueueName", DeadLetterQueueName)
                .AddParam(prefix + "Policy", Policy)
                .AddParam(prefix + "MaxReceiveCount", MaxReceiveCount)
                .AddParam(prefix + "MaxTimeToLive", MaxTimeToLive)
                .AddParam(prefix + "Trace", Trace)
                .AddParam(prefix + "Tags", Tags)
                .AddParam(prefix + "RetentionSizeInMB", RetentionSizeInMb);
        }
    }
}