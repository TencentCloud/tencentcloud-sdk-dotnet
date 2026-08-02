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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoutingStrategyArgs : AbstractModel
    {
        
        /// <summary>
        /// <p>最低繁忙路由算法相对近优容差。</p><p>取值范围：[0, 100]</p><p>默认值：0</p><p>仅最低繁忙路由算法生效。0 表示请求仅会路由到在途数最小的上游大模型部署，0.10 表示请求路由到的上游大模型部署在途请求数最多比最小在途数高10%，依次类推。</p>
        /// </summary>
        [JsonProperty("LeastBusyBuffer")]
        public float? LeastBusyBuffer{ get; set; }

        /// <summary>
        /// <p>用量均衡路由算法相对近优容差</p><p>取值范围：[0, 100]</p><p>默认值：0</p><p>仅用量均衡路由算法生效。0 表示请求仅会路由到TPM最低的上游大模型部署；0.10 表示请求最多会路由到比TPM最小值高10%的上游大模型部署，依次类推。</p>
        /// </summary>
        [JsonProperty("UsageBasedBuffer")]
        public float? UsageBasedBuffer{ get; set; }

        /// <summary>
        /// <p>最低延迟路由算法相对近优容差</p><p>取值范围：[0, 100]</p><p>默认值：0</p><p>仅最低延迟路由算法生效。0 表示请求仅会路由到延迟最低的上游大模型部署；0.10 表示请求最多会路由到比延迟最小值高10%的上游大模型部署，依次类推。</p>
        /// </summary>
        [JsonProperty("LowestLatencyBuffer")]
        public float? LowestLatencyBuffer{ get; set; }

        /// <summary>
        /// <p>最低积分系数路由算法相对近优容差</p><p>取值范围：[0, 100]</p><p>默认值：0</p><p>仅最低积分系数路由算法生效。0 表示请求仅会路由到积分系数最低的上游大模型部署；0.10 表示请求最多会路由到比积分系数最小值高10%的上游大模型部署，依次类推。</p>
        /// </summary>
        [JsonProperty("LowestCostBuffer")]
        public float? LowestCostBuffer{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LeastBusyBuffer", this.LeastBusyBuffer);
            this.SetParamSimple(map, prefix + "UsageBasedBuffer", this.UsageBasedBuffer);
            this.SetParamSimple(map, prefix + "LowestLatencyBuffer", this.LowestLatencyBuffer);
            this.SetParamSimple(map, prefix + "LowestCostBuffer", this.LowestCostBuffer);
        }
    }
}

