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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CrossBorderFlowMonitorData : AbstractModel
    {
        
        /// <summary>
        /// 入带宽，单位：`bps`。
        /// </summary>
        [JsonProperty("InBandwidth")]
        public long?[] InBandwidth{ get; set; }

        /// <summary>
        /// 出带宽，单位：`bps`。
        /// </summary>
        [JsonProperty("OutBandwidth")]
        public long?[] OutBandwidth{ get; set; }

        /// <summary>
        /// 入包，单位：`pps`。
        /// </summary>
        [JsonProperty("InPkg")]
        public long?[] InPkg{ get; set; }

        /// <summary>
        /// 出包，单位：`pps`。
        /// </summary>
        [JsonProperty("OutPkg")]
        public long?[] OutPkg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InBandwidth.", this.InBandwidth);
            this.SetParamArraySimple(map, prefix + "OutBandwidth.", this.OutBandwidth);
            this.SetParamArraySimple(map, prefix + "InPkg.", this.InPkg);
            this.SetParamArraySimple(map, prefix + "OutPkg.", this.OutPkg);
        }
    }
}

