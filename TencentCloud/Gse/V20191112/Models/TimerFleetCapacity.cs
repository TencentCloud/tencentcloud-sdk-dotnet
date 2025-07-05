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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimerFleetCapacity : AbstractModel
    {
        
        /// <summary>
        /// 扩缩容配置服务器舰队ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 期望实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DesiredInstances")]
        public long? DesiredInstances{ get; set; }

        /// <summary>
        /// 最小实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinSize")]
        public long? MinSize{ get; set; }

        /// <summary>
        /// 最大实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxSize")]
        public long? MaxSize{ get; set; }

        /// <summary>
        /// 伸缩容间隔，单位：分钟
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScalingInterval")]
        public long? ScalingInterval{ get; set; }

        /// <summary>
        /// 扩缩容类型（手动1，自动2、未定义0）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScalingType")]
        public long? ScalingType{ get; set; }

        /// <summary>
        /// 基于目标的扩展策略的设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetConfiguration")]
        public TargetConfiguration TargetConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamSimple(map, prefix + "DesiredInstances", this.DesiredInstances);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "ScalingInterval", this.ScalingInterval);
            this.SetParamSimple(map, prefix + "ScalingType", this.ScalingType);
            this.SetParamObj(map, prefix + "TargetConfiguration.", this.TargetConfiguration);
        }
    }
}

