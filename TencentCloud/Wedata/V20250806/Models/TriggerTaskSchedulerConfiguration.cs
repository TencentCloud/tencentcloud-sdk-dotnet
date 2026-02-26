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

    public class TriggerTaskSchedulerConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 上游依赖数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpstreamDependencyConfigList")]
        public DependencyTriggerTaskBrief[] UpstreamDependencyConfigList{ get; set; }

        /// <summary>
        /// 任务调度优先级 运行优先级 4高 5中 6低 , 默认:6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunPriorityType")]
        public long? RunPriorityType{ get; set; }

        /// <summary>
        /// 重试策略 重试等待时间,单位分钟: 默认: 5
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryWaitMinute")]
        public long? RetryWaitMinute{ get; set; }

        /// <summary>
        /// 重试策略 最大尝试次数, 默认: 4
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxRetryNumber")]
        public long? MaxRetryNumber{ get; set; }

        /// <summary>
        /// 超时处理策略 运行耗时超时（单位：分钟）默认为 -1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionTTLMinute")]
        public long? ExecutionTTLMinute{ get; set; }

        /// <summary>
        /// 超时处理策略 等待总时长耗时超时（单位：分钟）默认为 -1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitExecutionTotalTTLMinute")]
        public long? WaitExecutionTotalTTLMinute{ get; set; }

        /// <summary>
        /// 重跑&补录配置, 默认为 ALL; , ALL 运行成功或失败后皆可重跑或补录, FAILURE 运行成功后不可重跑或补录，运行失败后可重跑或补录, NONE 运行成功或失败后皆不可重跑或补录;
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowRedoType")]
        public string AllowRedoType{ get; set; }

        /// <summary>
        /// 输出参数数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamTaskOutList")]
        public OutTaskParameter[] ParamTaskOutList{ get; set; }

        /// <summary>
        /// 输入参数数组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamTaskInList")]
        public InTaskParameter[] ParamTaskInList{ get; set; }

        /// <summary>
        /// 产出登记
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskOutputRegistryList")]
        public TaskDataRegistry[] TaskOutputRegistryList{ get; set; }

        /// <summary>
        /// - 任务依赖运行条件，默认为ALL_SUCCESS，暂时只支持工作流调度项目下配置
        /// - ALL_SUCCESS： 全部成功：所有上游依赖任务都达到终态时，进行依赖判断，如果上游全部都成功，则依赖判断成功，否则如果上游有一个跳过运行，则标记为跳过运行，其余情况标记为上游失败
        /// - ALL_FAILED：全部失败：所有上游依赖任务都达到终态时，进行依赖判断，如果上游状态都是失败或者上游失败，则依赖判断成功，否则就标记为跳过运行
        /// - ALL_DONE：全部完成：所有上游依赖任务都达到终态时，进行依赖判断，直接是依赖判断成功
        /// - ALL_DONE_AT_LEAST_ONE_SUCCESS：上游全部完成至少一个成功: 所有上游依赖任务都达到终态时，进行依赖判断，至少有一个成功，则依赖判断成功，否则就是跳过运行
        /// - ALL_SKIPPED：上游全部都跳过: 所有上游依赖任务都达到终态时，进行依赖判断，所有的上游都是跳过状态才算依赖判断成功，否则当前节点就是跳过运行
        /// - ONE_FAILED：至少一个失败: 上游只要有一个失败了，就进行依赖判断，且依赖判断成功，如果上游全部完成但是没有失败，则跳过运行
        /// - ONE_SUCCESS：至少一个成功：上游只要有一个成功，就进行依赖判断，且依赖判断成功，如果上游全部完成但是没有成功，则跳过运行
        /// - ONE_DONE：至少一个完成：上游只要有一个完成了，就进行依赖判断，且依赖判断成功，否则还是等待上游
        /// - NONE_FAILED：上游全部完成，没有失败: 所有上游依赖任务都达到终态时，进行依赖判断，如果上游都是成功或者跳过运行，则依赖判断成功，否则标记为上游失败
        /// - ALL_DONE_NONE_FAILED_AT_LEAST_ONE_SUCCESS：上游全部完成，没有失败，至少有一个成功: 所有上游依赖任务都达到终态时，进行依赖判断，上游没有一个失败且至少有一个成功的情况下，依赖判断成功，否则就是跳过运行
        /// - NONE_SKIPPED：上游全部完成，没有跳过运行: 所有上游依赖任务都达到终态时，进行依赖判断, 如果上游状态全部都是成功、失败、上游失败状态，则依赖判断成功，否则为跳过运行
        /// - ALL_DONE_AT_LEAST_ONE_FAILED：上游全部完成至少一个失败: 所有上游依赖任务都达到终态时，进行依赖判断，至少有一个失败，则依赖判断成功，否则就是跳过运行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyTriggerPolicy")]
        public string DependencyTriggerPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "UpstreamDependencyConfigList.", this.UpstreamDependencyConfigList);
            this.SetParamSimple(map, prefix + "RunPriorityType", this.RunPriorityType);
            this.SetParamSimple(map, prefix + "RetryWaitMinute", this.RetryWaitMinute);
            this.SetParamSimple(map, prefix + "MaxRetryNumber", this.MaxRetryNumber);
            this.SetParamSimple(map, prefix + "ExecutionTTLMinute", this.ExecutionTTLMinute);
            this.SetParamSimple(map, prefix + "WaitExecutionTotalTTLMinute", this.WaitExecutionTotalTTLMinute);
            this.SetParamSimple(map, prefix + "AllowRedoType", this.AllowRedoType);
            this.SetParamArrayObj(map, prefix + "ParamTaskOutList.", this.ParamTaskOutList);
            this.SetParamArrayObj(map, prefix + "ParamTaskInList.", this.ParamTaskInList);
            this.SetParamArrayObj(map, prefix + "TaskOutputRegistryList.", this.TaskOutputRegistryList);
            this.SetParamSimple(map, prefix + "DependencyTriggerPolicy", this.DependencyTriggerPolicy);
        }
    }
}

