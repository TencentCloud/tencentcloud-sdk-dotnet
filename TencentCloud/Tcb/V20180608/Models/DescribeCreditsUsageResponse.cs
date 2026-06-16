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

    public class DescribeCreditsUsageResponse : AbstractModel
    {
        
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
        /// <p>历史周期资源点用量</p>
        /// </summary>
        [JsonProperty("HistoryDeducted")]
        public float? HistoryDeducted{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeductValue", this.DeductValue);
            this.SetParamSimple(map, prefix + "PackageDeductValue", this.PackageDeductValue);
            this.SetParamSimple(map, prefix + "ReportValue", this.ReportValue);
            this.SetParamSimple(map, prefix + "HistoryDeducted", this.HistoryDeducted);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

