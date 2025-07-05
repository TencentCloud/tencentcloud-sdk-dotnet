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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainListRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始，从0开始(只支持32位)
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// limit,最大值200(只支持32位)
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 资产大类，根据此字段时返回不同的子结构,AssetBasicType(只支持32位)
        /// </summary>
        [JsonProperty("AssetBasicType")]
        public ulong? AssetBasicType{ get; set; }

        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("Filter")]
        public QueryFilterV3[] Filter{ get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 导出字段
        /// </summary>
        [JsonProperty("Field")]
        public string[] Field{ get; set; }

        /// <summary>
        /// 时间范围(只支持32位)
        /// </summary>
        [JsonProperty("TimeRange")]
        public ulong? TimeRange{ get; set; }

        /// <summary>
        /// 逻辑字段(只支持32位)
        /// </summary>
        [JsonProperty("Logic")]
        public ulong? Logic{ get; set; }

        /// <summary>
        /// 聚合字段  
        /// </summary>
        [JsonProperty("GroupByField")]
        public string GroupByField{ get; set; }

        /// <summary>
        /// -
        /// </summary>
        [JsonProperty("Task")]
        public string Task{ get; set; }

        /// <summary>
        /// 0:cfw 1:vss 2.soc 3.waf 4.cwp
        /// </summary>
        [JsonProperty("RequestFrom")]
        public ulong? RequestFrom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "AssetBasicType", this.AssetBasicType);
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArraySimple(map, prefix + "Field.", this.Field);
            this.SetParamSimple(map, prefix + "TimeRange", this.TimeRange);
            this.SetParamSimple(map, prefix + "Logic", this.Logic);
            this.SetParamSimple(map, prefix + "GroupByField", this.GroupByField);
            this.SetParamSimple(map, prefix + "Task", this.Task);
            this.SetParamSimple(map, prefix + "RequestFrom", this.RequestFrom);
        }
    }
}

