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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmSensitiveScanTaskConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否定时任务
        /// </summary>
        [JsonProperty("IsScheduled")]
        public bool? IsScheduled{ get; set; }

        /// <summary>
        /// 调度周期配置
        /// </summary>
        [JsonProperty("ScheduleConfig")]
        public DspmScheduleConfig ScheduleConfig{ get; set; }

        /// <summary>
        /// 是否立即扫描
        /// </summary>
        [JsonProperty("IsRunAtOnce")]
        public bool? IsRunAtOnce{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsScheduled", this.IsScheduled);
            this.SetParamObj(map, prefix + "ScheduleConfig.", this.ScheduleConfig);
            this.SetParamSimple(map, prefix + "IsRunAtOnce", this.IsRunAtOnce);
        }
    }
}

