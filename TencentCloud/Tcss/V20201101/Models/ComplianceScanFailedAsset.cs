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

    public class ComplianceScanFailedAsset : AbstractModel
    {
        
        /// <summary>
        /// 客户资产的ID。
        /// </summary>
        [JsonProperty("CustomerAssetId")]
        public ulong? CustomerAssetId{ get; set; }

        /// <summary>
        /// 资产类别。
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

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
        /// 资产的名称。
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产检测失败的原因。
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// 检测失败的处理建议。
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 检测的时间。
        /// </summary>
        [JsonProperty("CheckTime")]
        public string CheckTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerAssetId", this.CustomerAssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "CheckTime", this.CheckTime);
        }
    }
}

