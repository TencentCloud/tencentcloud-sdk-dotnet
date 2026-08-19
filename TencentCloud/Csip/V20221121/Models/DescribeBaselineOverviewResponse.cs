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

    public class DescribeBaselineOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>基线概览统计数据（主机/集群未通过项数、近一年修复数）。</p>
        /// </summary>
        [JsonProperty("Statistics")]
        public BaselineOverviewStatistic Statistics{ get; set; }

        /// <summary>
        /// <p>最近一次基线扫描完成时间。</p>
        /// </summary>
        [JsonProperty("LatestScanTime")]
        public string LatestScanTime{ get; set; }

        /// <summary>
        /// <p>当前是否已启用任意周期性扫描。true 启用，false 未启用。</p>
        /// </summary>
        [JsonProperty("EnableCycleScan")]
        public bool? EnableCycleScan{ get; set; }

        /// <summary>
        /// <p>当前进行中的扫描主任务数量。</p>
        /// </summary>
        [JsonProperty("ScanningTaskCount")]
        public ulong? ScanningTaskCount{ get; set; }

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
            this.SetParamObj(map, prefix + "Statistics.", this.Statistics);
            this.SetParamSimple(map, prefix + "LatestScanTime", this.LatestScanTime);
            this.SetParamSimple(map, prefix + "EnableCycleScan", this.EnableCycleScan);
            this.SetParamSimple(map, prefix + "ScanningTaskCount", this.ScanningTaskCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

