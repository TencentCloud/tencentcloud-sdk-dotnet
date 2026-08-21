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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBaselinePolicyItemListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>基线策略ID</p>
        /// </summary>
        [JsonProperty("PolicyID")]
        public ulong? PolicyID{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>基线父分类 ID，用于筛选指定父分类下的检测项。</p>
        /// </summary>
        [JsonProperty("ParentCategoryID")]
        public ulong? ParentCategoryID{ get; set; }

        /// <summary>
        /// <p>分页查询每页返回条数，默认值 10，最大值 100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>分页查询偏移量，默认值 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>通用过滤条件列表。支持的过滤字段：</p><ul><li>CategoryID：子分类 ID，精确匹配</li><li>Name：检测项名称，模糊匹配</li><li>RiskLevel：风险等级，精确匹配。取值：LOW、MEDIUM、HIGH、CRITICAL</li><li>SupportCustomValue：是否支持编辑，精确匹配。取值：true、false</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyID", this.PolicyID);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "ParentCategoryID", this.ParentCategoryID);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

