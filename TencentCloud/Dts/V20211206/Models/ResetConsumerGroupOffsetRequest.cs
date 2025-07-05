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
        /// 订阅实例id
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// 订阅的kafka topic
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 消费组名称。实际的消费组全称形如：consumer-grp-#{SubscribeId}-#{ConsumerGroupName}
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// 需要修改offset的分区编号
        /// </summary>
        [JsonProperty("PartitionNos")]
        public long?[] PartitionNos{ get; set; }

        /// <summary>
        /// 重置方式。枚举值为 earliest-从最开始位置开始消费；latest-从最新位置开始消费；datetime-从指定时间前最近的checkpoint开始消费
        /// </summary>
        [JsonProperty("ResetMode")]
        public string ResetMode{ get; set; }

        /// <summary>
        /// 当 ResetMode 为 datetime 时，该项需要填，格式为：Y-m-d h:m:s。如果不填，默认用0时间，效果与earliest相同。
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

