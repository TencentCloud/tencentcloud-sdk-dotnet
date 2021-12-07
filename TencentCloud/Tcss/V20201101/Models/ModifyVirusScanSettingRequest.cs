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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVirusScanSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否开启定期扫描
        /// </summary>
        [JsonProperty("EnableScan")]
        public bool? EnableScan{ get; set; }

        /// <summary>
        /// 检测周期每隔多少天
        /// </summary>
        [JsonProperty("Cycle")]
        public ulong? Cycle{ get; set; }

        /// <summary>
        /// 扫描开始时间
        /// </summary>
        [JsonProperty("BeginScanAt")]
        public string BeginScanAt{ get; set; }

        /// <summary>
        /// 扫描全部路径
        /// </summary>
        [JsonProperty("ScanPathAll")]
        public bool? ScanPathAll{ get; set; }

        /// <summary>
        /// 当ScanPathAll为true 生效 0扫描以下路径 1、扫描除以下路径
        /// </summary>
        [JsonProperty("ScanPathType")]
        public ulong? ScanPathType{ get; set; }

        /// <summary>
        /// 超时时长
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 扫描范围0容器1主机节点
        /// </summary>
        [JsonProperty("ScanRangeType")]
        public ulong? ScanRangeType{ get; set; }

        /// <summary>
        /// true 全选，false 自选
        /// </summary>
        [JsonProperty("ScanRangeAll")]
        public bool? ScanRangeAll{ get; set; }

        /// <summary>
        /// 自选扫描范围的容器id或者主机id 根据ScanRangeType决定
        /// </summary>
        [JsonProperty("ScanIds")]
        public string[] ScanIds{ get; set; }

        /// <summary>
        /// 扫描路径
        /// </summary>
        [JsonProperty("ScanPath")]
        public string[] ScanPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableScan", this.EnableScan);
            this.SetParamSimple(map, prefix + "Cycle", this.Cycle);
            this.SetParamSimple(map, prefix + "BeginScanAt", this.BeginScanAt);
            this.SetParamSimple(map, prefix + "ScanPathAll", this.ScanPathAll);
            this.SetParamSimple(map, prefix + "ScanPathType", this.ScanPathType);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ScanRangeType", this.ScanRangeType);
            this.SetParamSimple(map, prefix + "ScanRangeAll", this.ScanRangeAll);
            this.SetParamArraySimple(map, prefix + "ScanIds.", this.ScanIds);
            this.SetParamArraySimple(map, prefix + "ScanPath.", this.ScanPath);
        }
    }
}

