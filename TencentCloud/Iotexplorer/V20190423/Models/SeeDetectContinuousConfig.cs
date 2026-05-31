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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeDetectContinuousConfig : AbstractModel
    {
        
        /// <summary>
        /// 检测标签。可选值：
        /// - `person_motionless`：人物静止
        /// </summary>
        [JsonProperty("DetectType")]
        public string DetectType{ get; set; }

        /// <summary>
        /// 启用检测的按日周期起始时间分钟数。取值范围：0 ~ 1440
        /// </summary>
        [JsonProperty("DailyStartTime")]
        public long? DailyStartTime{ get; set; }

        /// <summary>
        /// 启用检测的按日周期结束时间分钟数。取值范围：0 ~ 1440
        /// </summary>
        [JsonProperty("DailyEndTime")]
        public long? DailyEndTime{ get; set; }

        /// <summary>
        /// 检测间隔分钟数。取值范围：5 ~ 60。
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DetectType", this.DetectType);
            this.SetParamSimple(map, prefix + "DailyStartTime", this.DailyStartTime);
            this.SetParamSimple(map, prefix + "DailyEndTime", this.DailyEndTime);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
        }
    }
}

