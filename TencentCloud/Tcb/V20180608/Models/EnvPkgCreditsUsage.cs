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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvPkgCreditsUsage : AbstractModel
    {
        
        /// <summary>
        /// <p>环境id</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>模块</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>module总资源点用量</p>
        /// </summary>
        [JsonProperty("CreditsValue")]
        public float? CreditsValue{ get; set; }

        /// <summary>
        /// <p>指标用量明细</p>
        /// </summary>
        [JsonProperty("MetricUsageDetail")]
        public MetricUsage[] MetricUsageDetail{ get; set; }

        /// <summary>
        /// <p>资源点套餐内用量</p>
        /// </summary>
        [JsonProperty("DeductValue")]
        public float? DeductValue{ get; set; }

        /// <summary>
        /// <p>资源点资源包用量</p>
        /// </summary>
        [JsonProperty("PackageDeductValue")]
        public float? PackageDeductValue{ get; set; }

        /// <summary>
        /// <p>资源点按量用量</p>
        /// </summary>
        [JsonProperty("ReportValue")]
        public float? ReportValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "CreditsValue", this.CreditsValue);
            this.SetParamArrayObj(map, prefix + "MetricUsageDetail.", this.MetricUsageDetail);
            this.SetParamSimple(map, prefix + "DeductValue", this.DeductValue);
            this.SetParamSimple(map, prefix + "PackageDeductValue", this.PackageDeductValue);
            this.SetParamSimple(map, prefix + "ReportValue", this.ReportValue);
        }
    }
}

