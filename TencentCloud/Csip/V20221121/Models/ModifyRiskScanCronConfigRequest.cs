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

    public class ModifyRiskScanCronConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>计划开启状态</p>
        /// </summary>
        [JsonProperty("CronStatus")]
        public ulong? CronStatus{ get; set; }

        /// <summary>
        /// <p>计划表达式</p>
        /// </summary>
        [JsonProperty("CronPlanContent")]
        public string CronPlanContent{ get; set; }

        /// <summary>
        /// <p>新增规则是否自动执行</p>
        /// </summary>
        [JsonProperty("RuleAutoEnable")]
        public bool? RuleAutoEnable{ get; set; }

        /// <summary>
        /// <p>时区</p>
        /// </summary>
        [JsonProperty("ScanPlanTimezone")]
        public string ScanPlanTimezone{ get; set; }

        /// <summary>
        /// <p>增量资产开启风险扫描开关</p>
        /// </summary>
        [JsonProperty("IncrementAssetScanRisk")]
        public bool? IncrementAssetScanRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "CronStatus", this.CronStatus);
            this.SetParamSimple(map, prefix + "CronPlanContent", this.CronPlanContent);
            this.SetParamSimple(map, prefix + "RuleAutoEnable", this.RuleAutoEnable);
            this.SetParamSimple(map, prefix + "ScanPlanTimezone", this.ScanPlanTimezone);
            this.SetParamSimple(map, prefix + "IncrementAssetScanRisk", this.IncrementAssetScanRisk);
        }
    }
}

