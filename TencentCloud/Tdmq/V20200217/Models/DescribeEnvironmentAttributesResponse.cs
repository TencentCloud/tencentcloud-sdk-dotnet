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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEnvironmentAttributesResponse : AbstractModel
    {
        
        /// <summary>
        /// 未消费消息过期时间，单位：秒，最大1296000（15天）。
        /// </summary>
        [JsonProperty("MsgTTL")]
        public ulong? MsgTTL{ get; set; }

        /// <summary>
        /// 消费速率限制，单位：byte/秒，0：不限速。
        /// </summary>
        [JsonProperty("RateInByte")]
        public ulong? RateInByte{ get; set; }

        /// <summary>
        /// 消费速率限制，单位：个数/秒，0：不限速。
        /// </summary>
        [JsonProperty("RateInSize")]
        public ulong? RateInSize{ get; set; }

        /// <summary>
        /// 已消费消息保存策略，单位：小时，0：消费完马上删除。
        /// </summary>
        [JsonProperty("RetentionHours")]
        public ulong? RetentionHours{ get; set; }

        /// <summary>
        /// 已消费消息保存策略，单位：G，0：消费完马上删除。
        /// </summary>
        [JsonProperty("RetentionSize")]
        public ulong? RetentionSize{ get; set; }

        /// <summary>
        /// 环境（命名空间）名称。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 副本数。
        /// </summary>
        [JsonProperty("Replicas")]
        public ulong? Replicas{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 离线订阅过期自动清理时间
        /// </summary>
        [JsonProperty("SubscriptionExpirationTime")]
        public ulong? SubscriptionExpirationTime{ get; set; }

        /// <summary>
        /// 离线订阅过期自动清理时间开关
        /// </summary>
        [JsonProperty("SubscriptionExpirationTimeEnable")]
        public bool? SubscriptionExpirationTimeEnable{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "RateInByte", this.RateInByte);
            this.SetParamSimple(map, prefix + "RateInSize", this.RateInSize);
            this.SetParamSimple(map, prefix + "RetentionHours", this.RetentionHours);
            this.SetParamSimple(map, prefix + "RetentionSize", this.RetentionSize);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SubscriptionExpirationTime", this.SubscriptionExpirationTime);
            this.SetParamSimple(map, prefix + "SubscriptionExpirationTimeEnable", this.SubscriptionExpirationTimeEnable);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

