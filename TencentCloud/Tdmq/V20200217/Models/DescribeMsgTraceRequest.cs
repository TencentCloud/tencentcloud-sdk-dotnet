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

    public class DescribeMsgTraceRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境（命名空间）。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 消息ID。
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// 消息生产时间。
        /// </summary>
        [JsonProperty("ProduceTime")]
        public string ProduceTime{ get; set; }

        /// <summary>
        /// 起始下标，不填默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，不填则默认为10，最大值为20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 消费组名称模糊匹配。
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// Pulsar 集群的ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "ProduceTime", this.ProduceTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
        }
    }
}

