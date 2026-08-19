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

    public class AssetRiskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>风险类型</p>
        /// </summary>
        [JsonProperty("ResultType")]
        public string ResultType{ get; set; }

        /// <summary>
        /// <p>总风险数量</p>
        /// </summary>
        [JsonProperty("RiskCount")]
        public ulong? RiskCount{ get; set; }

        /// <summary>
        /// <p>严重风险数量</p>
        /// </summary>
        [JsonProperty("RiskCritical")]
        public ulong? RiskCritical{ get; set; }

        /// <summary>
        /// <p>高风险数量</p>
        /// </summary>
        [JsonProperty("RiskHigh")]
        public ulong? RiskHigh{ get; set; }

        /// <summary>
        /// <p>中风险数量</p>
        /// </summary>
        [JsonProperty("RiskMedium")]
        public ulong? RiskMedium{ get; set; }

        /// <summary>
        /// <p>低风险数量</p>
        /// </summary>
        [JsonProperty("RiskLow")]
        public ulong? RiskLow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "RiskCritical", this.RiskCritical);
            this.SetParamSimple(map, prefix + "RiskHigh", this.RiskHigh);
            this.SetParamSimple(map, prefix + "RiskMedium", this.RiskMedium);
            this.SetParamSimple(map, prefix + "RiskLow", this.RiskLow);
        }
    }
}

