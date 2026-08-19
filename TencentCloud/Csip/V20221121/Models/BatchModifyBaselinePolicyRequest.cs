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

    public class BatchModifyBaselinePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待修改的基线策略 ID 列表，不可为空且元素不可为 0。</p>
        /// </summary>
        [JsonProperty("PolicyIDList")]
        public ulong?[] PolicyIDList{ get; set; }

        /// <summary>
        /// <p>周期扫描配置；不修改时可省略。Enable=1 时必须同时传 IntervalType 与 IntervalValueList。</p>
        /// </summary>
        [JsonProperty("CycleScanConf")]
        public CycleScanConf CycleScanConf{ get; set; }

        /// <summary>
        /// <p>新增内置检测项自动同步开关。true 自动加入，false 不加入。</p>
        /// </summary>
        [JsonProperty("AutoSyncItem")]
        public bool? AutoSyncItem{ get; set; }

        /// <summary>
        /// <p>分类 / 子分类 / 检测项命中配置；不修改时可省略。</p>
        /// </summary>
        [JsonProperty("CategoryConf")]
        public BaselinePolicySystemCategoryConf[] CategoryConf{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>自定义检测项取值配置列表；不修改时可省略。每个元素 RuleID 与 CustomItemID 不能同时为 0。</p>
        /// </summary>
        [JsonProperty("CustomItemConf")]
        public BaselineCustomItemConf[] CustomItemConf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PolicyIDList.", this.PolicyIDList);
            this.SetParamObj(map, prefix + "CycleScanConf.", this.CycleScanConf);
            this.SetParamSimple(map, prefix + "AutoSyncItem", this.AutoSyncItem);
            this.SetParamArrayObj(map, prefix + "CategoryConf.", this.CategoryConf);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArrayObj(map, prefix + "CustomItemConf.", this.CustomItemConf);
        }
    }
}

