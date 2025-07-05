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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulLevelSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 高危漏洞数
        /// </summary>
        [JsonProperty("HighLevelVulCount")]
        public long? HighLevelVulCount{ get; set; }

        /// <summary>
        /// 中危漏洞数
        /// </summary>
        [JsonProperty("MediumLevelVulCount")]
        public long? MediumLevelVulCount{ get; set; }

        /// <summary>
        /// 低危漏洞数
        /// </summary>
        [JsonProperty("LowLevelVulCount")]
        public long? LowLevelVulCount{ get; set; }

        /// <summary>
        /// 严重漏洞数
        /// </summary>
        [JsonProperty("CriticalLevelVulCount")]
        public long? CriticalLevelVulCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "HighLevelVulCount", this.HighLevelVulCount);
            this.SetParamSimple(map, prefix + "MediumLevelVulCount", this.MediumLevelVulCount);
            this.SetParamSimple(map, prefix + "LowLevelVulCount", this.LowLevelVulCount);
            this.SetParamSimple(map, prefix + "CriticalLevelVulCount", this.CriticalLevelVulCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

