/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerScalingPolicy : AbstractModel
    {
        
        /// <summary>
        /// 定时器ID，进行encode，填写时更新
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimerId")]
        public string TimerId{ get; set; }

        /// <summary>
        /// 定时器名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimerName")]
        public string TimerName{ get; set; }

        /// <summary>
        /// 定时器状态(未定义0、未生效1、生效中2、已停止3、已过期4)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimerStatus")]
        public long? TimerStatus{ get; set; }

        /// <summary>
        /// 定时器弹性伸缩策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimerFleetCapacity")]
        public TimerFleetCapacity TimerFleetCapacity{ get; set; }

        /// <summary>
        /// 重复周期配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimerConfiguration")]
        public TimerConfiguration TimerConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimerId", this.TimerId);
            this.SetParamSimple(map, prefix + "TimerName", this.TimerName);
            this.SetParamSimple(map, prefix + "TimerStatus", this.TimerStatus);
            this.SetParamObj(map, prefix + "TimerFleetCapacity.", this.TimerFleetCapacity);
            this.SetParamObj(map, prefix + "TimerConfiguration.", this.TimerConfiguration);
        }
    }
}

