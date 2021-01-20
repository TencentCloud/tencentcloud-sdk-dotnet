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

    public class CreateSubscriptionRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境（命名空间）名称。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 主题名称。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 订阅者名称，不支持中字以及除了短线和下划线外的特殊字符且不超过150个字符。
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// 是否幂等创建，若否不允许创建同名的订阅关系。
        /// </summary>
        [JsonProperty("IsIdempotent")]
        public bool? IsIdempotent{ get; set; }

        /// <summary>
        /// 备注，128个字符以内。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Pulsar 集群的ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 是否自动创建死信和重试主题，True 表示创建，False表示不创建，默认自动创建死信和重试主题。
        /// </summary>
        [JsonProperty("AutoCreatePolicyTopic")]
        public bool? AutoCreatePolicyTopic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "IsIdempotent", this.IsIdempotent);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AutoCreatePolicyTopic", this.AutoCreatePolicyTopic);
        }
    }
}

