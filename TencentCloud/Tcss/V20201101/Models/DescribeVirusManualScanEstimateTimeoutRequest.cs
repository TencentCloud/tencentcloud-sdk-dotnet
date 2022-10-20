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

    public class DescribeVirusManualScanEstimateTimeoutRequest : AbstractModel
    {
        
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScanRangeType", this.ScanRangeType);
            this.SetParamSimple(map, prefix + "ScanRangeAll", this.ScanRangeAll);
            this.SetParamArraySimple(map, prefix + "ScanIds.", this.ScanIds);
        }
    }
}

