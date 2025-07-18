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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDiscoveredResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 每页显示数量
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }

        /// <summary>
        /// resourceName：资源名  resourceId ：资源ID
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 下一页token
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 排序方式 asc、desc
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
        }
    }
}

