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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComplianceAssetPolicyItem : AbstractModel
    {
        
        /// <summary>
        /// 为客户分配的唯一的检测项的ID。
        /// </summary>
        [JsonProperty("CustomerPolicyItemId")]
        public ulong? CustomerPolicyItemId{ get; set; }

        /// <summary>
        /// 检测项的原始ID
        /// </summary>
        [JsonProperty("BasePolicyItemId")]
        public ulong? BasePolicyItemId{ get; set; }

        /// <summary>
        /// 检测项的名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 检测项所属的类型的名称
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 所属的合规标准的ID
        /// </summary>
        [JsonProperty("BenchmarkStandardId")]
        public ulong? BenchmarkStandardId{ get; set; }

        /// <summary>
        /// 所属的合规标准的名称
        /// </summary>
        [JsonProperty("BenchmarkStandardName")]
        public string BenchmarkStandardName{ get; set; }

        /// <summary>
        /// 威胁等级
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 检测状态
        /// CHECK_INIT, 待检测
        /// CHECK_RUNNING, 检测中
        /// CHECK_FINISHED, 检测完成
        /// CHECK_FAILED, 检测失败
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 检测结果
        /// RESULT_PASSED: 通过
        /// RESULT_FAILED: 未通过
        /// </summary>
        [JsonProperty("CheckResult")]
        public string CheckResult{ get; set; }

        /// <summary>
        /// 检测项对应的白名单项的ID。如果存在且非0，表示检测项被用户忽略。
        /// </summary>
        [JsonProperty("WhitelistId")]
        public ulong? WhitelistId{ get; set; }

        /// <summary>
        /// 处理建议。
        /// </summary>
        [JsonProperty("FixSuggestion")]
        public string FixSuggestion{ get; set; }

        /// <summary>
        /// 最近检测的时间。
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// 验证信息
        /// </summary>
        [JsonProperty("VerifyInfo")]
        public string VerifyInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerPolicyItemId", this.CustomerPolicyItemId);
            this.SetParamSimple(map, prefix + "BasePolicyItemId", this.BasePolicyItemId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "BenchmarkStandardId", this.BenchmarkStandardId);
            this.SetParamSimple(map, prefix + "BenchmarkStandardName", this.BenchmarkStandardName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CheckResult", this.CheckResult);
            this.SetParamSimple(map, prefix + "WhitelistId", this.WhitelistId);
            this.SetParamSimple(map, prefix + "FixSuggestion", this.FixSuggestion);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamSimple(map, prefix + "VerifyInfo", this.VerifyInfo);
        }
    }
}

