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

    public class DescribeVirusScanConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启定期扫描</p>
        /// </summary>
        [JsonProperty("EnableScan")]
        public bool? EnableScan{ get; set; }

        /// <summary>
        /// <p>检测周期每隔多少天</p>
        /// </summary>
        [JsonProperty("Cycle")]
        public ulong? Cycle{ get; set; }

        /// <summary>
        /// <p>扫描开始时间</p>
        /// </summary>
        [JsonProperty("BeginScanAt")]
        public string BeginScanAt{ get; set; }

        /// <summary>
        /// <p>超时时长，单位小时</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// <p>SCAN_NODE:扫描节点<br>SCAN_CONTAINER:扫描容器</p>
        /// </summary>
        [JsonProperty("ScanRangeType")]
        public string ScanRangeType{ get; set; }

        /// <summary>
        /// <p>自选扫描范围的容器id或者节点id</p>
        /// </summary>
        [JsonProperty("ScanIDs")]
        public ScanRangeInfo[] ScanIDs{ get; set; }

        /// <summary>
        /// <p>自选排除或扫描的地址</p>
        /// </summary>
        [JsonProperty("ScanPath")]
        public string[] ScanPath{ get; set; }

        /// <summary>
        /// <p>扫描路径模式：<br>SCAN_PATH_ALL：全部路径<br>SCAN_PATH_DEFAULT：默认路径<br>SCAN_PATH_USER_DEFINE：用户自定义路径</p>
        /// </summary>
        [JsonProperty("ScanPathMode")]
        public string ScanPathMode{ get; set; }

        /// <summary>
        /// <p>true:包含路径<br>false:排除路径</p>
        /// </summary>
        [JsonProperty("IsIncludePath")]
        public bool? IsIncludePath{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnableScan", this.EnableScan);
            this.SetParamSimple(map, prefix + "Cycle", this.Cycle);
            this.SetParamSimple(map, prefix + "BeginScanAt", this.BeginScanAt);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ScanRangeType", this.ScanRangeType);
            this.SetParamArrayObj(map, prefix + "ScanIDs.", this.ScanIDs);
            this.SetParamArraySimple(map, prefix + "ScanPath.", this.ScanPath);
            this.SetParamSimple(map, prefix + "ScanPathMode", this.ScanPathMode);
            this.SetParamSimple(map, prefix + "IsIncludePath", this.IsIncludePath);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

