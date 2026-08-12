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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Score : AbstractModel
    {
        
        /// <summary>
        /// <p>风险分值，范围[1, 1000]，分值越大，风险越高</p>
        /// </summary>
        [JsonProperty("RiskScore")]
        public long? RiskScore{ get; set; }

        /// <summary>
        /// <p>风险标签</p>
        /// </summary>
        [JsonProperty("RiskLabels")]
        public RiskLabel[] RiskLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskScore", this.RiskScore);
            this.SetParamArrayObj(map, prefix + "RiskLabels.", this.RiskLabels);
        }
    }
}

