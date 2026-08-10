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

    public class DescribeVulFixableMachineListResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>可修复主机列表</p>
        /// </summary>
        [JsonProperty("Data")]
        public VulFixableMachineItem[] Data{ get; set; }

        /// <summary>
        /// <p>总数量</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>可一键修复的主机数量</p>
        /// </summary>
        [JsonProperty("FixableCount")]
        public long? FixableCount{ get; set; }

        /// <summary>
        /// <p>不可一键修复的主机数量</p>
        /// </summary>
        [JsonProperty("NotFixableCount")]
        public long? NotFixableCount{ get; set; }

        /// <summary>
        /// <p>漏洞维度汇总信息，展示被修复的漏洞列表概要</p>
        /// </summary>
        [JsonProperty("VulSummary")]
        public VulFixSummaryItem[] VulSummary{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "FixableCount", this.FixableCount);
            this.SetParamSimple(map, prefix + "NotFixableCount", this.NotFixableCount);
            this.SetParamArrayObj(map, prefix + "VulSummary.", this.VulSummary);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

