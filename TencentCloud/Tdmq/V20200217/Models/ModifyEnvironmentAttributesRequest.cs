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

    public class ModifyEnvironmentAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 命名空间名称。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 未消费消息过期时间，单位：秒，范围60秒~15天。
        /// </summary>
        [JsonProperty("MsgTTL")]
        public ulong? MsgTTL{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 备注，字符串最长不超过128。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 消息保留策略
        /// </summary>
        [JsonProperty("RetentionPolicy")]
        public RetentionPolicy RetentionPolicy{ get; set; }

        /// <summary>
        /// 是否开启自动创建订阅
        /// </summary>
        [JsonProperty("AutoSubscriptionCreation")]
        public bool? AutoSubscriptionCreation{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "RetentionPolicy.", this.RetentionPolicy);
            this.SetParamSimple(map, prefix + "AutoSubscriptionCreation", this.AutoSubscriptionCreation);
            this.SetParamSimple(map, prefix + "SubscriptionExpirationTime", this.SubscriptionExpirationTime);
            this.SetParamSimple(map, prefix + "SubscriptionExpirationTimeEnable", this.SubscriptionExpirationTimeEnable);
        }
    }
}

