/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCmqQueueAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 队列名字，在单个地域同一账号下唯一。队列名称是一个不超过 64 个字符的字符串，必须以字母为首字符，剩余部分可以包含字母、数字和横划线(-)。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 最大堆积消息数。取值范围在公测期间为 1,000,000 - 10,000,000，正式上线后范围可达到 1000,000-1000,000,000。默认取值在公测期间为 10,000,000，正式上线后为 100,000,000。
        /// </summary>
        [JsonProperty("MaxMsgHeapNum")]
        public ulong? MaxMsgHeapNum{ get; set; }

        /// <summary>
        /// 消息接收长轮询等待时间。取值范围 0-30 秒，默认值 0。
        /// </summary>
        [JsonProperty("PollingWaitSeconds")]
        public ulong? PollingWaitSeconds{ get; set; }

        /// <summary>
        /// 消息可见性超时。取值范围 1-43200 秒（即12小时内），默认值 30。
        /// </summary>
        [JsonProperty("VisibilityTimeout")]
        public ulong? VisibilityTimeout{ get; set; }

        /// <summary>
        /// 消息最大长度，新版CMQ新建的队列默认1024KB，不支持修改
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// 消息最长未确认时间。取值范围 30-43200 秒（30秒~12小时），默认值 3600 (1 小时)。
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// 队列是否开启回溯消息能力，该参数取值范围0-1296000，0表示不开启。
        /// </summary>
        [JsonProperty("RewindSeconds")]
        public ulong? RewindSeconds{ get; set; }

        /// <summary>
        /// 第一次查询时间
        /// </summary>
        [JsonProperty("FirstQueryInterval")]
        public ulong? FirstQueryInterval{ get; set; }

        /// <summary>
        /// 最大查询次数
        /// </summary>
        [JsonProperty("MaxQueryCount")]
        public ulong? MaxQueryCount{ get; set; }

        /// <summary>
        /// 死信队列名称
        /// </summary>
        [JsonProperty("DeadLetterQueueName")]
        public string DeadLetterQueueName{ get; set; }

        /// <summary>
        /// MaxTimeToLivepolicy为1时必选。最大未消费过期时间。范围300-43200，单位秒，需要小于消息最大保留时间MsgRetentionSeconds
        /// </summary>
        [JsonProperty("MaxTimeToLive")]
        public ulong? MaxTimeToLive{ get; set; }

        /// <summary>
        /// 最大接收次数
        /// </summary>
        [JsonProperty("MaxReceiveCount")]
        public ulong? MaxReceiveCount{ get; set; }

        /// <summary>
        /// 死信队列策略
        /// </summary>
        [JsonProperty("Policy")]
        public ulong? Policy{ get; set; }

        /// <summary>
        /// 是否开启消息轨迹标识，true表示开启，false表示不开启，不填表示不开启。
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }

        /// <summary>
        /// 是否开启事务，1开启，0不开启
        /// </summary>
        [JsonProperty("Transaction")]
        public ulong? Transaction{ get; set; }

        /// <summary>
        /// 队列可回溯存储空间：若开启消息回溯，取值范围：10240MB - 512000MB，若不开启消息回溯，取值：0
        /// </summary>
        [JsonProperty("RetentionSizeInMB")]
        public ulong? RetentionSizeInMB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "MaxMsgHeapNum", this.MaxMsgHeapNum);
            this.SetParamSimple(map, prefix + "PollingWaitSeconds", this.PollingWaitSeconds);
            this.SetParamSimple(map, prefix + "VisibilityTimeout", this.VisibilityTimeout);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "RewindSeconds", this.RewindSeconds);
            this.SetParamSimple(map, prefix + "FirstQueryInterval", this.FirstQueryInterval);
            this.SetParamSimple(map, prefix + "MaxQueryCount", this.MaxQueryCount);
            this.SetParamSimple(map, prefix + "DeadLetterQueueName", this.DeadLetterQueueName);
            this.SetParamSimple(map, prefix + "MaxTimeToLive", this.MaxTimeToLive);
            this.SetParamSimple(map, prefix + "MaxReceiveCount", this.MaxReceiveCount);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
            this.SetParamSimple(map, prefix + "Transaction", this.Transaction);
            this.SetParamSimple(map, prefix + "RetentionSizeInMB", this.RetentionSizeInMB);
        }
    }
}

