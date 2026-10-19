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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>防护IP数</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("PublicIpUsed")]
        public long? PublicIpUsed{ get; set; }

        /// <summary>
        /// <p>防护实例数</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("InstanceUsed")]
        public long? InstanceUsed{ get; set; }

        /// <summary>
        /// <p>统计日期</p>
        /// </summary>
        [JsonProperty("StatDate")]
        public string StatDate{ get; set; }

        /// <summary>
        /// <p>处理流量</p>
        /// </summary>
        [JsonProperty("TodayTrafficGB")]
        public float? TodayTrafficGB{ get; set; }

        /// <summary>
        /// <p>防护天数</p>
        /// </summary>
        [JsonProperty("ProtectDays")]
        public long? ProtectDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicIpUsed", this.PublicIpUsed);
            this.SetParamSimple(map, prefix + "InstanceUsed", this.InstanceUsed);
            this.SetParamSimple(map, prefix + "StatDate", this.StatDate);
            this.SetParamSimple(map, prefix + "TodayTrafficGB", this.TodayTrafficGB);
            this.SetParamSimple(map, prefix + "ProtectDays", this.ProtectDays);
        }
    }
}

