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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IntervalSchedule : AbstractModel
    {
        
        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartAt")]
        public string StartAt{ get; set; }

        /// <summary>
        /// 
        /// 枚举值:
        /// | 枚举值 | uint |
        /// | --- | --- |
        /// | INTERVAL_UNIT_UNSPECIFIED | 0 |
        /// | INTERVAL_UNIT_HOUR | 1 |
        /// | INTERVAL_UNIT_DAY | 2 |
        /// </summary>
        [JsonProperty("Unit")]
        public long? Unit{ get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartAt", this.StartAt);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

