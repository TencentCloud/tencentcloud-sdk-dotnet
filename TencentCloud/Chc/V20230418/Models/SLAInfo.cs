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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SLAInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>SLA 状态</p><p>枚举值：</p><ul><li>InSLA： SLA 内</li><li>Overdue： 已超时</li><li>Completed： 已完成</li></ul>
        /// </summary>
        [JsonProperty("SLAStatus")]
        public string SLAStatus{ get; set; }

        /// <summary>
        /// <p>到期时间</p>
        /// </summary>
        [JsonProperty("DueTime")]
        public string DueTime{ get; set; }

        /// <summary>
        /// <p>剩余时长</p><p>单位：小时</p>
        /// </summary>
        [JsonProperty("RemainingHours")]
        public float? RemainingHours{ get; set; }

        /// <summary>
        /// <p>超时时长</p><p>单位：小时</p>
        /// </summary>
        [JsonProperty("OverdueHours")]
        public float? OverdueHours{ get; set; }

        /// <summary>
        /// <p>SLA 工作日天数</p><p>单位：天</p>
        /// </summary>
        [JsonProperty("SLADays")]
        public ulong? SLADays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SLAStatus", this.SLAStatus);
            this.SetParamSimple(map, prefix + "DueTime", this.DueTime);
            this.SetParamSimple(map, prefix + "RemainingHours", this.RemainingHours);
            this.SetParamSimple(map, prefix + "OverdueHours", this.OverdueHours);
            this.SetParamSimple(map, prefix + "SLADays", this.SLADays);
        }
    }
}

