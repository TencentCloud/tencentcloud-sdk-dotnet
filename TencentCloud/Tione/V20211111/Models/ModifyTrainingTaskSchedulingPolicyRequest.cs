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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTrainingTaskSchedulingPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>训练任务 id</p>
        /// </summary>
        [JsonProperty("TrainingTaskId")]
        public string TrainingTaskId{ get; set; }

        /// <summary>
        /// <p>TI工作空间ID</p><p>使用非默认空间必须填写工作空间ID，使用默认空间无需填写工作空间ID。</p>
        /// </summary>
        [JsonProperty("TiProjectId")]
        public string TiProjectId{ get; set; }

        /// <summary>
        /// <p>是否开启跨资源组调度。缺省为 false，仅改优先级时若任务已开启需显式传 true，否则会被关闭。</p>
        /// </summary>
        [JsonProperty("CrossResourceGroupScheduling")]
        public bool? CrossResourceGroupScheduling{ get; set; }

        /// <summary>
        /// <p>调度策略</p>
        /// </summary>
        [JsonProperty("SchedulePolicy")]
        public SchedulePolicy SchedulePolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrainingTaskId", this.TrainingTaskId);
            this.SetParamSimple(map, prefix + "TiProjectId", this.TiProjectId);
            this.SetParamSimple(map, prefix + "CrossResourceGroupScheduling", this.CrossResourceGroupScheduling);
            this.SetParamObj(map, prefix + "SchedulePolicy.", this.SchedulePolicy);
        }
    }
}

