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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWLLMQuotaFallbackTrigger : AbstractModel
    {
        
        /// <summary>
        /// <p>配额感知阈值百分比（RPM 与 TPM 共用）</p><p>取值范围：[0, 99]</p>
        /// </summary>
        [JsonProperty("ThresholdPercent")]
        public long? ThresholdPercent{ get; set; }

        /// <summary>
        /// <p>检查维度策略</p><p>枚举值：</p><ul><li>AnyInsufficient：  RPM 或 TPM 任一不足即触发</li><li>AllInsufficient： RPM 和 TPM 同时不足才触发</li></ul>
        /// </summary>
        [JsonProperty("CheckDimension")]
        public string CheckDimension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ThresholdPercent", this.ThresholdPercent);
            this.SetParamSimple(map, prefix + "CheckDimension", this.CheckDimension);
        }
    }
}

