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

    public class AssetBaselineRisk : AbstractModel
    {
        
        /// <summary>
        /// <p>风险记录唯一标识。</p>
        /// </summary>
        [JsonProperty("RiskID")]
        public string RiskID{ get; set; }

        /// <summary>
        /// <p>检测项详细信息。</p>
        /// </summary>
        [JsonProperty("Item")]
        public BaselineItem Item{ get; set; }

        /// <summary>
        /// <p>最近一次检测时间（ISO 8601 格式）。</p>
        /// </summary>
        [JsonProperty("LatestCheckTime")]
        public string LatestCheckTime{ get; set; }

        /// <summary>
        /// <p>检测结果状态。取值：</p><ul><li>NOT_PASS：未通过</li><li>PASS：通过</li><li>CHECKING：检测中</li></ul><p></p>
        /// </summary>
        [JsonProperty("ResultStatus")]
        public string ResultStatus{ get; set; }

        /// <summary>
        /// <p>所属基线策略简要信息。</p>
        /// </summary>
        [JsonProperty("PolicyInfo")]
        public BaselinePolicyBrief PolicyInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamSimple(map, prefix + "LatestCheckTime", this.LatestCheckTime);
            this.SetParamSimple(map, prefix + "ResultStatus", this.ResultStatus);
            this.SetParamObj(map, prefix + "PolicyInfo.", this.PolicyInfo);
        }
    }
}

