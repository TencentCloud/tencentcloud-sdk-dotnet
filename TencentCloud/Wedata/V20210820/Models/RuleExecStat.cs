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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleExecStat : AbstractModel
    {
        
        /// <summary>
        /// 规则运行总数
        /// </summary>
        [JsonProperty("TotalCnt")]
        public ulong? TotalCnt{ get; set; }

        /// <summary>
        /// 环比规则运行总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTotalCnt")]
        public ulong? LastTotalCnt{ get; set; }

        /// <summary>
        /// 规则运行总数占比
        /// </summary>
        [JsonProperty("TotalCntRatio")]
        public float? TotalCntRatio{ get; set; }

        /// <summary>
        /// 规则运行总数环比变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTotalCntRatio")]
        public float? LastTotalCntRatio{ get; set; }

        /// <summary>
        /// 规则触发数
        /// </summary>
        [JsonProperty("TriggerCnt")]
        public ulong? TriggerCnt{ get; set; }

        /// <summary>
        /// 环比规则触发数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTriggerCnt")]
        public ulong? LastTriggerCnt{ get; set; }

        /// <summary>
        /// 触发占总数占比
        /// </summary>
        [JsonProperty("TriggerCntRatio")]
        public float? TriggerCntRatio{ get; set; }

        /// <summary>
        /// 环比规则触发数变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTriggerCntRatio")]
        public float? LastTriggerCntRatio{ get; set; }

        /// <summary>
        /// 规则报警数
        /// </summary>
        [JsonProperty("AlarmCnt")]
        public ulong? AlarmCnt{ get; set; }

        /// <summary>
        /// 环比规则报警数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastAlarmCnt")]
        public ulong? LastAlarmCnt{ get; set; }

        /// <summary>
        /// 报警占总数占比
        /// </summary>
        [JsonProperty("AlarmCntRatio")]
        public float? AlarmCntRatio{ get; set; }

        /// <summary>
        /// 环比报警数变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastAlarmCntRatio")]
        public float? LastAlarmCntRatio{ get; set; }

        /// <summary>
        /// 阻塞发生数
        /// </summary>
        [JsonProperty("PipelineCnt")]
        public ulong? PipelineCnt{ get; set; }

        /// <summary>
        /// 环比阻塞发生数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastPipelineCnt")]
        public ulong? LastPipelineCnt{ get; set; }

        /// <summary>
        /// 阻塞占总数占比
        /// </summary>
        [JsonProperty("PipelineCntRatio")]
        public float? PipelineCntRatio{ get; set; }

        /// <summary>
        /// 环比阻塞发生数变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastPipelineCntRatio")]
        public float? LastPipelineCntRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCnt", this.TotalCnt);
            this.SetParamSimple(map, prefix + "LastTotalCnt", this.LastTotalCnt);
            this.SetParamSimple(map, prefix + "TotalCntRatio", this.TotalCntRatio);
            this.SetParamSimple(map, prefix + "LastTotalCntRatio", this.LastTotalCntRatio);
            this.SetParamSimple(map, prefix + "TriggerCnt", this.TriggerCnt);
            this.SetParamSimple(map, prefix + "LastTriggerCnt", this.LastTriggerCnt);
            this.SetParamSimple(map, prefix + "TriggerCntRatio", this.TriggerCntRatio);
            this.SetParamSimple(map, prefix + "LastTriggerCntRatio", this.LastTriggerCntRatio);
            this.SetParamSimple(map, prefix + "AlarmCnt", this.AlarmCnt);
            this.SetParamSimple(map, prefix + "LastAlarmCnt", this.LastAlarmCnt);
            this.SetParamSimple(map, prefix + "AlarmCntRatio", this.AlarmCntRatio);
            this.SetParamSimple(map, prefix + "LastAlarmCntRatio", this.LastAlarmCntRatio);
            this.SetParamSimple(map, prefix + "PipelineCnt", this.PipelineCnt);
            this.SetParamSimple(map, prefix + "LastPipelineCnt", this.LastPipelineCnt);
            this.SetParamSimple(map, prefix + "PipelineCntRatio", this.PipelineCntRatio);
            this.SetParamSimple(map, prefix + "LastPipelineCntRatio", this.LastPipelineCntRatio);
        }
    }
}

