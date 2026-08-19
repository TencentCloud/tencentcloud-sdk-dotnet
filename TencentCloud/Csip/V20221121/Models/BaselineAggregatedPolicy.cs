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

    public class BaselineAggregatedPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>系统策略所属父分类 ID（仅 PolicyType=SYSTEM 时聚合使用，自定义策略为 0）。</p>
        /// </summary>
        [JsonProperty("ParentCategoryID")]
        public ulong? ParentCategoryID{ get; set; }

        /// <summary>
        /// <p>本次聚合涉及的基线策略 ID 列表。</p>
        /// </summary>
        [JsonProperty("PolicyID")]
        public ulong?[] PolicyID{ get; set; }

        /// <summary>
        /// <p>策略名称（自定义策略为用户输入，系统策略为内置分类名）。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>策略描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>策略已配置的检测项数量。</p>
        /// </summary>
        [JsonProperty("ConfItemCount")]
        public ulong? ConfItemCount{ get; set; }

        /// <summary>
        /// <p>本策略下结果为 PASS 的检测项数量。</p>
        /// </summary>
        [JsonProperty("PassItemCount")]
        public ulong? PassItemCount{ get; set; }

        /// <summary>
        /// <p>本策略下结果为 NOT_PASS 的检测项数量。</p>
        /// </summary>
        [JsonProperty("NotPassItemCount")]
        public ulong? NotPassItemCount{ get; set; }

        /// <summary>
        /// <p>未通过检测项按风险等级（LOW/MEDIUM/HIGH/CRITICAL）的分布统计。</p>
        /// </summary>
        [JsonProperty("NotPassItemRiskLevelStatistic")]
        public BaselineRiskLevelStatistic[] NotPassItemRiskLevelStatistic{ get; set; }

        /// <summary>
        /// <p>本策略最近一次扫描的通过率，单位为百分比（0~100），保留两位小数。</p>
        /// </summary>
        [JsonProperty("PassRate")]
        public float? PassRate{ get; set; }

        /// <summary>
        /// <p>该策略下各子分类的扫描结果统计明细。</p>
        /// </summary>
        [JsonProperty("CategoryStatistic")]
        public BaselineAggregatedCategory[] CategoryStatistic{ get; set; }

        /// <summary>
        /// <p>基线策略类型。取值：</p><ul><li>SYSTEM：系统策略（CSIP 内置）</li><li>SELF：用户自定义策略</li></ul>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>检测资产大类，区分主机基线与容器集群基线。取值：</p><ul><li>HOST：主机</li><li>CLUSTER：容器集群</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>该基线类别是否被扫描过</p>
        /// </summary>
        [JsonProperty("Scanned")]
        public bool? Scanned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParentCategoryID", this.ParentCategoryID);
            this.SetParamArraySimple(map, prefix + "PolicyID.", this.PolicyID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConfItemCount", this.ConfItemCount);
            this.SetParamSimple(map, prefix + "PassItemCount", this.PassItemCount);
            this.SetParamSimple(map, prefix + "NotPassItemCount", this.NotPassItemCount);
            this.SetParamArrayObj(map, prefix + "NotPassItemRiskLevelStatistic.", this.NotPassItemRiskLevelStatistic);
            this.SetParamSimple(map, prefix + "PassRate", this.PassRate);
            this.SetParamArrayObj(map, prefix + "CategoryStatistic.", this.CategoryStatistic);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "Scanned", this.Scanned);
        }
    }
}

