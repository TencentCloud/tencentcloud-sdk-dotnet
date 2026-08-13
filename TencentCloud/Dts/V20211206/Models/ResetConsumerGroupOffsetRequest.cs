/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResetConsumerGroupOffsetRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>订阅实例id，可通过<a href="https://cloud.tencent.com/document/product/571/82103">DescribeSyncJobs</a>接口获取。</p>
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// <p>订阅的kafka topic，可通过<a href="https://cloud.tencent.com/document/product/571/82103">DescribeSyncJobs</a>接口获取。</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>消费组名称。实际的消费组全称形如：consumer-grp-#{SubscribeId}-#{ConsumerGroupName}。可通过<a href="https://cloud.tencent.com/document/api/571/102947">DescribeConsumerGroups</a>接口获取。</p>
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// <p>需要修改offset的分区编号，可通过<a href="https://cloud.tencent.com/document/api/571/102946">DescribeOffsetByTime</a>接口获取。</p>
        /// </summary>
        [JsonProperty("PartitionNos")]
        public long?[] PartitionNos{ get; set; }

        /// <summary>
        /// <p>重置方式。枚举值为 earliest-从最开始位置开始消费；latest-从最新位置开始消费；datetime-从指定时间前最近的checkpoint开始消费</p>
        /// </summary>
        [JsonProperty("ResetMode")]
        public string ResetMode{ get; set; }

        /// <summary>
        /// <p>当 <code>ResetMode</code> 为 <code>datetime</code> 时该项需要填。当 <code>DateTimeISOFormat=true</code> 时按 RFC 3339 传入（如 <code>2026-04-23T20:21:35+08:00</code>），否则按 <code>Y-m-d h:m:s</code>（北京时间）传入。如果不填，默认用 0 时间，效果与 <code>earliest</code> 相同。 </p><p>参数格式：2026-04-23T20:21:35+08:00</p>
        /// </summary>
        [JsonProperty("ResetDatetime")]
        public string ResetDatetime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamArraySimple(map, prefix + "PartitionNos.", this.PartitionNos);
            this.SetParamSimple(map, prefix + "ResetMode", this.ResetMode);
            this.SetParamSimple(map, prefix + "ResetDatetime", this.ResetDatetime);
        }
    }
}

