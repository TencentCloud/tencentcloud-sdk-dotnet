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

    public class DescribeEscapeEventTypeSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 容器逃逸事件数
        /// </summary>
        [JsonProperty("ContainerEscapeEventCount")]
        public long? ContainerEscapeEventCount{ get; set; }

        /// <summary>
        /// 程序提权事件数
        /// </summary>
        [JsonProperty("ProcessPrivilegeEventCount")]
        public long? ProcessPrivilegeEventCount{ get; set; }

        /// <summary>
        /// 风险容器事件数
        /// </summary>
        [JsonProperty("RiskContainerEventCount")]
        public long? RiskContainerEventCount{ get; set; }

        /// <summary>
        /// 逃逸事件待处理数
        /// </summary>
        [JsonProperty("PendingEscapeEventCount")]
        public long? PendingEscapeEventCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ContainerEscapeEventCount", this.ContainerEscapeEventCount);
            this.SetParamSimple(map, prefix + "ProcessPrivilegeEventCount", this.ProcessPrivilegeEventCount);
            this.SetParamSimple(map, prefix + "RiskContainerEventCount", this.RiskContainerEventCount);
            this.SetParamSimple(map, prefix + "PendingEscapeEventCount", this.PendingEscapeEventCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

