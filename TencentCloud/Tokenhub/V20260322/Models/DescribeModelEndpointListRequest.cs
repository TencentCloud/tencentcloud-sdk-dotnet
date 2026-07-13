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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModelEndpointListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>偏移量，从 0 开始，默认为 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>每页返回数量，默认为 20，最大值为 100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>过滤条件列表。支持的过滤字段：Status（状态，取值 ACTIVE/INACTIVE）、ChargeType（计费方式，取值 FREE/TOKEN）、RequestSource（创建来源，取值 MC/GW）、ModelName（模型名称）、ModelId（模型 ID）、PaymentEnabled（是否已开启后付费，取值 true/false）。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public RequestFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>排序条件列表。支持的排序字段：CreatedTime、UpdatedTime。不传时使用默认排序规则。</p>
        /// </summary>
        [JsonProperty("Sorts")]
        public RequestSort[] Sorts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "Sorts.", this.Sorts);
        }
    }
}

