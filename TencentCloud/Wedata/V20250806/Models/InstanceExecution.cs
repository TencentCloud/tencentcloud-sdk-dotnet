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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceExecution : AbstractModel
    {
        
        /// <summary>
        /// 实例唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// **实例生命周期编号，标识实例的某一次执行**
        /// 
        /// 例如：周期实例第一次运行的编号为0，用户后期又重跑了该实例，第二次执行的编号为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifeRoundNum")]
        public ulong? LifeRoundNum{ get; set; }

        /// <summary>
        /// **实例状态**
        /// - WAIT_EVENT: 等待事件
        /// - WAIT_UPSTREAM: 等待上游
        /// - WAIT_RUN: 等待运行
        /// - RUNNING: 运行中
        /// - SKIP_RUNNING: 跳过运行
        /// - FAILED_RETRY: 失败重试
        /// - EXPIRED: 失败
        /// - COMPLETED: 成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// **实例运行触发类型**
        /// 
        /// - RERUN 表示重跑
        /// - ADDITION 表示补录
        /// - PERIODIC 表示周期
        /// - APERIODIC 表示非周期
        /// - RERUN_SKIP_RUN 表示重跑 - 空跑
        /// - ADDITION_SKIP_RUN 表示补录 - 空跑
        /// - PERIODIC_SKIP_RUN 表示周期 - 空跑
        /// - APERIODIC_SKIP_RUN 表示非周期 - 空跑
        /// - MANUAL_TRIGGER 表示手动触发
        /// - RERUN_MANUAL_TRIGGER 表示手动触发 - 重跑
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunType")]
        public string RunType{ get; set; }

        /// <summary>
        /// 失败重试次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// **实例执行生命周期列表**
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionPhaseList")]
        public InstanceExecutionPhase[] ExecutionPhaseList{ get; set; }

        /// <summary>
        /// 耗费时间, 单位ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "LifeRoundNum", this.LifeRoundNum);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamArrayObj(map, prefix + "ExecutionPhaseList.", this.ExecutionPhaseList);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
        }
    }
}

