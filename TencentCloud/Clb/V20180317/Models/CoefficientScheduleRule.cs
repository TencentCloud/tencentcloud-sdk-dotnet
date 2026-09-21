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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CoefficientScheduleRule : AbstractModel
    {
        
        /// <summary>
        /// <p>1～7，表示周一至周日</p>
        /// </summary>
        [JsonProperty("Weekdays")]
        public ulong?[] Weekdays{ get; set; }

        /// <summary>
        /// <p>00:00～23:59，固定 UTC+8，窗口左闭</p><p>参数格式：HH:mm</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>大于 StartTime，最大 24:00，窗口右开；跨午夜拆分并调整星期</p><p>参数格式：HH:mm</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>有限非负数，建议最多 6 位小数；0 免费、0.5 半价、1 原价，可大于 1；倍率计算后的价格须在服务支持的数值范围内</p>
        /// </summary>
        [JsonProperty("Multiplier")]
        public float? Multiplier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Weekdays.", this.Weekdays);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Multiplier", this.Multiplier);
        }
    }
}

