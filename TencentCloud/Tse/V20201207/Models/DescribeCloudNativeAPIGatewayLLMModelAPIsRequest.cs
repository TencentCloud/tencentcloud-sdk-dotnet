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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudNativeAPIGatewayLLMModelAPIsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关 id。</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>每页条数，范围 [1, 1000]，默认 10。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>起始位置，从 0 开始。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>过滤条件。当前未启用具体字段。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>模糊匹配模型 API 名称。</p>
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <p>消费者组 ID（以 cg- 开头），与 UseToBind 搭配使用。</p>
        /// </summary>
        [JsonProperty("ConsumerGroupId")]
        public string ConsumerGroupId{ get; set; }

        /// <summary>
        /// <p>是否用于绑定场景。true 时仅返回可被绑定到指定消费者组的模型 API。</p>
        /// </summary>
        [JsonProperty("UseToBind")]
        public bool? UseToBind{ get; set; }

        /// <summary>
        /// <p>消费者ID</p>
        /// </summary>
        [JsonProperty("ConsumerId")]
        public string ConsumerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "ConsumerGroupId", this.ConsumerGroupId);
            this.SetParamSimple(map, prefix + "UseToBind", this.UseToBind);
            this.SetParamSimple(map, prefix + "ConsumerId", this.ConsumerId);
        }
    }
}

