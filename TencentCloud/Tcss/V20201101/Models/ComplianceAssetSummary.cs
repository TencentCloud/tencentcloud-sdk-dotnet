/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ComplianceAssetSummary : AbstractModel
    {
        
        /// <summary>
        /// 资产类别。
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 是否为客户的首次检测。与CheckStatus配合使用。
        /// </summary>
        [JsonProperty("IsCustomerFirstCheck")]
        public bool? IsCustomerFirstCheck{ get; set; }

        /// <summary>
        /// 检测状态
        /// 
        /// CHECK_UNINIT, 用户未启用此功能
        /// 
        /// CHECK_INIT, 待检测
        /// 
        /// CHECK_RUNNING, 检测中
        /// 
        /// CHECK_FINISHED, 检测完成
        /// 
        /// CHECK_FAILED, 检测失败
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// 此类别的检测进度，为 0~100 的数。若未在检测中，无此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckProgress")]
        public float? CheckProgress{ get; set; }

        /// <summary>
        /// 此类资产通过的检测项的数目。
        /// </summary>
        [JsonProperty("PassedPolicyItemCount")]
        public ulong? PassedPolicyItemCount{ get; set; }

        /// <summary>
        /// 此类资产未通过的检测的数目。
        /// </summary>
        [JsonProperty("FailedPolicyItemCount")]
        public ulong? FailedPolicyItemCount{ get; set; }

        /// <summary>
        /// 此类资产下未通过的严重级别的检测项的数目。
        /// </summary>
        [JsonProperty("FailedCriticalPolicyItemCount")]
        public ulong? FailedCriticalPolicyItemCount{ get; set; }

        /// <summary>
        /// 此类资产下未通过的高危检测项的数目。
        /// </summary>
        [JsonProperty("FailedHighRiskPolicyItemCount")]
        public ulong? FailedHighRiskPolicyItemCount{ get; set; }

        /// <summary>
        /// 此类资产下未通过的中危检测项的数目。
        /// </summary>
        [JsonProperty("FailedMediumRiskPolicyItemCount")]
        public ulong? FailedMediumRiskPolicyItemCount{ get; set; }

        /// <summary>
        /// 此类资产下未通过的低危检测项的数目。
        /// </summary>
        [JsonProperty("FailedLowRiskPolicyItemCount")]
        public ulong? FailedLowRiskPolicyItemCount{ get; set; }

        /// <summary>
        /// 此类资产下提示级别的检测项的数目。
        /// </summary>
        [JsonProperty("NoticePolicyItemCount")]
        public ulong? NoticePolicyItemCount{ get; set; }

        /// <summary>
        /// 通过检测的资产的数目。
        /// </summary>
        [JsonProperty("PassedAssetCount")]
        public ulong? PassedAssetCount{ get; set; }

        /// <summary>
        /// 未通过检测的资产的数目。
        /// </summary>
        [JsonProperty("FailedAssetCount")]
        public ulong? FailedAssetCount{ get; set; }

        /// <summary>
        /// 此类资产的合规率，0~100的数。
        /// </summary>
        [JsonProperty("AssetPassedRate")]
        public float? AssetPassedRate{ get; set; }

        /// <summary>
        /// 检测失败的资产的数目。
        /// </summary>
        [JsonProperty("ScanFailedAssetCount")]
        public ulong? ScanFailedAssetCount{ get; set; }

        /// <summary>
        /// 上次检测的耗时，单位为秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckCostTime")]
        public float? CheckCostTime{ get; set; }

        /// <summary>
        /// 上次检测的时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// 定时检测规则。
        /// </summary>
        [JsonProperty("PeriodRule")]
        public CompliancePeriodTaskRule PeriodRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "IsCustomerFirstCheck", this.IsCustomerFirstCheck);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CheckProgress", this.CheckProgress);
            this.SetParamSimple(map, prefix + "PassedPolicyItemCount", this.PassedPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedPolicyItemCount", this.FailedPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedCriticalPolicyItemCount", this.FailedCriticalPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedHighRiskPolicyItemCount", this.FailedHighRiskPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedMediumRiskPolicyItemCount", this.FailedMediumRiskPolicyItemCount);
            this.SetParamSimple(map, prefix + "FailedLowRiskPolicyItemCount", this.FailedLowRiskPolicyItemCount);
            this.SetParamSimple(map, prefix + "NoticePolicyItemCount", this.NoticePolicyItemCount);
            this.SetParamSimple(map, prefix + "PassedAssetCount", this.PassedAssetCount);
            this.SetParamSimple(map, prefix + "FailedAssetCount", this.FailedAssetCount);
            this.SetParamSimple(map, prefix + "AssetPassedRate", this.AssetPassedRate);
            this.SetParamSimple(map, prefix + "ScanFailedAssetCount", this.ScanFailedAssetCount);
            this.SetParamSimple(map, prefix + "CheckCostTime", this.CheckCostTime);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamObj(map, prefix + "PeriodRule.", this.PeriodRule);
        }
    }
}

