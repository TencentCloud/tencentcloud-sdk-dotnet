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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAssetScanRequest : AbstractModel
    {
        
        /// <summary>
        /// 扫描范围：1端口, 2端口+漏扫
        /// </summary>
        [JsonProperty("ScanRange")]
        public long? ScanRange{ get; set; }

        /// <summary>
        /// 扫描深度：'heavy', 'medium', 'light'
        /// </summary>
        [JsonProperty("ScanDeep")]
        public string ScanDeep{ get; set; }

        /// <summary>
        /// 扫描类型：1立即扫描 2 周期任务
        /// </summary>
        [JsonProperty("RangeType")]
        public long? RangeType{ get; set; }

        /// <summary>
        /// RangeType为2 是必须添加，定时任务时间
        /// </summary>
        [JsonProperty("ScanPeriod")]
        public string ScanPeriod{ get; set; }

        /// <summary>
        /// 立即扫描这个字段传过滤的扫描集合
        /// </summary>
        [JsonProperty("ScanFilterIp")]
        public string[] ScanFilterIp{ get; set; }

        /// <summary>
        /// 1全量2单个
        /// </summary>
        [JsonProperty("ScanType")]
        public long? ScanType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScanRange", this.ScanRange);
            this.SetParamSimple(map, prefix + "ScanDeep", this.ScanDeep);
            this.SetParamSimple(map, prefix + "RangeType", this.RangeType);
            this.SetParamSimple(map, prefix + "ScanPeriod", this.ScanPeriod);
            this.SetParamArraySimple(map, prefix + "ScanFilterIp.", this.ScanFilterIp);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
        }
    }
}

