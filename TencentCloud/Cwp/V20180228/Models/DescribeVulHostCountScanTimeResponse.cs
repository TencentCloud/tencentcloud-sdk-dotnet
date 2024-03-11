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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulHostCountScanTimeResponse : AbstractModel
    {
        
        /// <summary>
        /// 总漏洞数
        /// </summary>
        [JsonProperty("TotalVulCount")]
        public ulong? TotalVulCount{ get; set; }

        /// <summary>
        /// 漏洞影响主机数
        /// </summary>
        [JsonProperty("VulHostCount")]
        public ulong? VulHostCount{ get; set; }

        /// <summary>
        /// 扫描时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 是否第一次检测
        /// </summary>
        [JsonProperty("IfFirstScan")]
        public bool? IfFirstScan{ get; set; }

        /// <summary>
        /// 运行中的任务号, 没有任务则为0
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 最后一次修复漏洞的时间
        /// </summary>
        [JsonProperty("LastFixTime")]
        public string LastFixTime{ get; set; }

        /// <summary>
        /// 是否有支持自动修复的漏洞事件
        /// </summary>
        [JsonProperty("hadAutoFixVul")]
        public bool? hadAutoFixVul{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalVulCount", this.TotalVulCount);
            this.SetParamSimple(map, prefix + "VulHostCount", this.VulHostCount);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "IfFirstScan", this.IfFirstScan);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "LastFixTime", this.LastFixTime);
            this.SetParamSimple(map, prefix + "hadAutoFixVul", this.hadAutoFixVul);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

