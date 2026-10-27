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

namespace TencentCloud.Workbuddyenterprise.V20260709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExpertListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>专家来源，必填：BUILTIN（内置）/ CUSTOM（自建）</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>标准过滤条件：ExpertId（精确，多值 OR，携带即按 ID 批量查询，忽略分页）/ Keyword（模糊）/ PublishStatus（DRAFT、PUBLISHED、ALL，仅 CUSTOM）/ ExpertType（AGENT 普通专家、TEAM 专家团）。ExpertType 只允许一个过滤条件且 Values 必须仅含一个值，不传则不增加形态过滤；可与 ExpertId 组合取交集，分页总数 TotalCount 为过滤后的匹配数。专家选择列表建议传 {&quot;Name&quot;:&quot;ExpertType&quot;,&quot;Values&quot;:[&quot;AGENT&quot;]}。CAPI 的 CUSTOM 目录仅有普通专家，按 TEAM 过滤返回空集。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>偏移量，从 0 开始，默认 0（按 ID 批量查询时忽略）</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>每页数量，默认 20，最大 200（按 ID 批量查询时忽略）</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

