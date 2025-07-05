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

    public class InstanceLifeCycleVO : AbstractModel
    {
        
        /// <summary>
        /// 实例唯一标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// **实例状态**
        /// 
        /// - [0] 表示 等待事件
        /// - [12] 表示 等待上游
        /// - [6, 7, 9, 10, 18] 表示 等待运行
        /// - [1, 19, 22] 表示 运行中
        /// - [21] 表示 跳过运行
        /// - [3] 表示 失败重试
        /// - [8, 4, 5, 13] 表示 失败
        /// - [2] 表示 成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceState")]
        public ulong? InstanceState{ get; set; }

        /// <summary>
        /// **实例生命周期编号，标识实例的某一次执行**
        /// 
        /// 例如：周期实例第一次运行的编号为0，用户后期又重跑了该实例，第二次执行的编号为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifeRoundNum")]
        public ulong? LifeRoundNum{ get; set; }

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
        /// **实例生命周期列表**
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifeCycleDetailList")]
        public InstanceLifeDetailDto[] LifeCycleDetailList{ get; set; }

        /// <summary>
        /// **实例代码文件**
        /// 该文件内容为当次执行实例运行使用的代码，仅部分任务支持
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeFileName")]
        public string CodeFileName{ get; set; }

        /// <summary>
        /// **下发执行ID**
        /// 统一执行平台下发执行到新版执行机标识某次执行的唯一ID，存量老执行机下发执行没有此ID。
        /// 如果不知道执行机版本是否支持此ID，可以联系腾讯云运维同学
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// 日志所在执行节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// 日志文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginFileName")]
        public string OriginFileName{ get; set; }

        /// <summary>
        /// **实例日志类型**
        /// 
        /// - run: 运行; 
        /// - kill: 终止
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 耗费时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostTime")]
        public string CostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "LifeRoundNum", this.LifeRoundNum);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamArrayObj(map, prefix + "LifeCycleDetailList.", this.LifeCycleDetailList);
            this.SetParamSimple(map, prefix + "CodeFileName", this.CodeFileName);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "OriginFileName", this.OriginFileName);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
        }
    }
}

