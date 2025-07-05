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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// 类型族
        /// </summary>
        [JsonProperty("HostTypeFamily")]
        public string HostTypeFamily{ get; set; }

        /// <summary>
        /// 总CPU
        /// </summary>
        [JsonProperty("CpuTotal")]
        public float? CpuTotal{ get; set; }

        /// <summary>
        /// 可用CPU
        /// </summary>
        [JsonProperty("CpuAvailable")]
        public float? CpuAvailable{ get; set; }

        /// <summary>
        /// 总内存
        /// </summary>
        [JsonProperty("MemTotal")]
        public float? MemTotal{ get; set; }

        /// <summary>
        /// 可用内存
        /// </summary>
        [JsonProperty("MemAvailable")]
        public float? MemAvailable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostTypeFamily", this.HostTypeFamily);
            this.SetParamSimple(map, prefix + "CpuTotal", this.CpuTotal);
            this.SetParamSimple(map, prefix + "CpuAvailable", this.CpuAvailable);
            this.SetParamSimple(map, prefix + "MemTotal", this.MemTotal);
            this.SetParamSimple(map, prefix + "MemAvailable", this.MemAvailable);
        }
    }
}

