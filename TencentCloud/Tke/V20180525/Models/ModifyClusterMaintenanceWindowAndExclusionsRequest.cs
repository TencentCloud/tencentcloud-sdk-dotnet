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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterMaintenanceWindowAndExclusionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 维护开始时间
        /// </summary>
        [JsonProperty("MaintenanceTime")]
        public string MaintenanceTime{ get; set; }

        /// <summary>
        /// 维护时长（小时）
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 维护周期（一周中的哪几天）
        /// </summary>
        [JsonProperty("DayOfWeek")]
        public string[] DayOfWeek{ get; set; }

        /// <summary>
        /// 维护排除项
        /// </summary>
        [JsonProperty("Exclusions")]
        public MaintenanceExclusion[] Exclusions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "MaintenanceTime", this.MaintenanceTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArraySimple(map, prefix + "DayOfWeek.", this.DayOfWeek);
            this.SetParamArrayObj(map, prefix + "Exclusions.", this.Exclusions);
        }
    }
}

