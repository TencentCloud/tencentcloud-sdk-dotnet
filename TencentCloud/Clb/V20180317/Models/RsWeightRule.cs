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

    public class RsWeightRule : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡监听器 ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 要修改权重的后端机器列表。
        /// </summary>
        [JsonProperty("Targets")]
        public Target[] Targets{ get; set; }

        /// <summary>
        /// 转发规则的ID，七层规则时需要此参数，4层规则不需要。
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// 目标规则的域名，提供LocationId参数时本参数不生效。
        /// </summary>
        [JsonProperty("Domain")]
        [System.Obsolete]
        public string Domain{ get; set; }

        /// <summary>
        /// 目标规则的URL，提供LocationId参数时本参数不生效。
        /// </summary>
        [JsonProperty("Url")]
        [System.Obsolete]
        public string Url{ get; set; }

        /// <summary>
        /// 后端服务修改后的转发权重，取值范围：[0，100]。此参数的优先级低于前述[Target](https://cloud.tencent.com/document/api/214/30694#Target)中的Weight参数，即最终的权重值以Target中的Weight参数值为准，仅当Target中的Weight参数为空时，才以RsWeightRule中的Weight参数为准。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamArrayObj(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
        }
    }
}

