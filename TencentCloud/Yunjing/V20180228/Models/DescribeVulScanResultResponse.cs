/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulScanResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 漏洞数量。
        /// </summary>
        [JsonProperty("VulNum")]
        public ulong? VulNum{ get; set; }

        /// <summary>
        /// 专业版机器数。
        /// </summary>
        [JsonProperty("ProVersionNum")]
        public ulong? ProVersionNum{ get; set; }

        /// <summary>
        /// 受影响的专业版主机数。
        /// </summary>
        [JsonProperty("ImpactedHostNum")]
        public ulong? ImpactedHostNum{ get; set; }

        /// <summary>
        /// 主机总数。
        /// </summary>
        [JsonProperty("HostNum")]
        public ulong? HostNum{ get; set; }

        /// <summary>
        /// 基础版机器数。
        /// </summary>
        [JsonProperty("BasicVersionNum")]
        public ulong? BasicVersionNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "ProVersionNum", this.ProVersionNum);
            this.SetParamSimple(map, prefix + "ImpactedHostNum", this.ImpactedHostNum);
            this.SetParamSimple(map, prefix + "HostNum", this.HostNum);
            this.SetParamSimple(map, prefix + "BasicVersionNum", this.BasicVersionNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

