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

    public class ScanBaselineRiskListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>基线策略类型。取值：</p><ul><li>SYSTEM：系统策略（CSIP 内置）</li><li>SELF：用户自定义策略</li></ul>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>目标基线策略 ID，必须大于 0。</p>
        /// </summary>
        [JsonProperty("PolicyID")]
        public ulong? PolicyID{ get; set; }

        /// <summary>
        /// <p>基线系统父分类 ID。</p>
        /// </summary>
        [JsonProperty("ParentCategoryID")]
        public ulong? ParentCategoryID{ get; set; }

        /// <summary>
        /// <p>待重新扫描的风险记录 RiskID 列表，不可为空且元素不可为空字符串。</p>
        /// </summary>
        [JsonProperty("RiskIDList")]
        public string[] RiskIDList{ get; set; }

        /// <summary>
        /// <p>检测项ID</p>
        /// </summary>
        [JsonProperty("ItemID")]
        public ulong? ItemID{ get; set; }

        /// <summary>
        /// <p>基线子分类 ID。</p>
        /// </summary>
        [JsonProperty("CategoryID")]
        public ulong? CategoryID{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyID", this.PolicyID);
            this.SetParamSimple(map, prefix + "ParentCategoryID", this.ParentCategoryID);
            this.SetParamArraySimple(map, prefix + "RiskIDList.", this.RiskIDList);
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamSimple(map, prefix + "CategoryID", this.CategoryID);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

