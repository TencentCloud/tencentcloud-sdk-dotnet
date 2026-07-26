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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppTriggerScheduleStatus : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LastFireTime")]
        public string LastFireTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NextFireTime")]
        public string NextFireTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PolicySummary")]
        public string PolicySummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LastFireTime", this.LastFireTime);
            this.SetParamSimple(map, prefix + "NextFireTime", this.NextFireTime);
            this.SetParamSimple(map, prefix + "PolicySummary", this.PolicySummary);
        }
    }
}

