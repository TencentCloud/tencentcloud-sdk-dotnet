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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmIndicatorInfo : AbstractModel
    {
        
        /// <summary>
        /// 指标id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 告警指标,0表示任务失败，1表示任务运行超时，2表示任务停止，3表示任务暂停
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmIndicator")]
        public ulong? AlarmIndicator{ get; set; }

        /// <summary>
        /// 告警指标描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmIndicatorDesc")]
        public string AlarmIndicatorDesc{ get; set; }

        /// <summary>
        /// 指标阈值，1表示离线任务第一次运行失败，2表示离线任务所有重试完成后失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// 预计的超时时间，分钟级别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EstimatedTime")]
        public ulong? EstimatedTime{ get; set; }

        /// <summary>
        /// 实时任务告警需要的参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operator")]
        public ulong? Operator{ get; set; }

        /// <summary>
        /// 告警指标阈值单位：ms(毫秒)、s(秒)、min(分钟)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmIndicatorUnit")]
        public string AlarmIndicatorUnit{ get; set; }

        /// <summary>
        /// 告警周期
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 告警周期单位
        /// </summary>
        [JsonProperty("DurationUnit")]
        public string DurationUnit{ get; set; }

        /// <summary>
        /// 周期内最多告警次数
        /// </summary>
        [JsonProperty("MaxTimes")]
        public long? MaxTimes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AlarmIndicator", this.AlarmIndicator);
            this.SetParamSimple(map, prefix + "AlarmIndicatorDesc", this.AlarmIndicatorDesc);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "EstimatedTime", this.EstimatedTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "AlarmIndicatorUnit", this.AlarmIndicatorUnit);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "DurationUnit", this.DurationUnit);
            this.SetParamSimple(map, prefix + "MaxTimes", this.MaxTimes);
        }
    }
}

