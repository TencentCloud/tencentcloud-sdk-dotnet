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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskCategoryItem : AbstractModel
    {
        
        /// <summary>
        /// 风险大类ID
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }

        /// <summary>
        /// 风险大类名称
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// 风险子类ID
        /// </summary>
        [JsonProperty("SubcategoryId")]
        public string SubcategoryId{ get; set; }

        /// <summary>
        /// 风险子类名称
        /// </summary>
        [JsonProperty("SubcategoryName")]
        public string SubcategoryName{ get; set; }

        /// <summary>
        /// 风险等级(0-低危,1-中危,2-高危)
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// 风险等级名称(低/中/高)
        /// </summary>
        [JsonProperty("RiskLevelName")]
        public string RiskLevelName{ get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 处置建议
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 该类风险的规则数量
        /// </summary>
        [JsonProperty("RuleCount")]
        public long? RuleCount{ get; set; }

        /// <summary>
        /// 已处置数量
        /// </summary>
        [JsonProperty("TreatedCount")]
        public long? TreatedCount{ get; set; }

        /// <summary>
        /// 已忽略数量
        /// </summary>
        [JsonProperty("IgnoredCount")]
        public long? IgnoredCount{ get; set; }

        /// <summary>
        /// 待整改数量
        /// </summary>
        [JsonProperty("UntreatedCount")]
        public long? UntreatedCount{ get; set; }

        /// <summary>
        /// 整改率(百分比字符串)
        /// </summary>
        [JsonProperty("DisposalRate")]
        public ulong? DisposalRate{ get; set; }

        /// <summary>
        /// 是否有未处理风险
        /// -1: 未体检
        /// 0: 无风险
        /// 1: 有风险
        /// </summary>
        [JsonProperty("HasRisk")]
        public long? HasRisk{ get; set; }

        /// <summary>
        /// 整改状态：
        /// Completed： 已整改完成（整改率 100%）
        /// Incomplete： 未整改完成（整改率 < 100%）
        /// -：未体检/无数据
        /// </summary>
        [JsonProperty("RemediationStatus")]
        public string RemediationStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "SubcategoryId", this.SubcategoryId);
            this.SetParamSimple(map, prefix + "SubcategoryName", this.SubcategoryName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskLevelName", this.RiskLevelName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "TreatedCount", this.TreatedCount);
            this.SetParamSimple(map, prefix + "IgnoredCount", this.IgnoredCount);
            this.SetParamSimple(map, prefix + "UntreatedCount", this.UntreatedCount);
            this.SetParamSimple(map, prefix + "DisposalRate", this.DisposalRate);
            this.SetParamSimple(map, prefix + "HasRisk", this.HasRisk);
            this.SetParamSimple(map, prefix + "RemediationStatus", this.RemediationStatus);
        }
    }
}

