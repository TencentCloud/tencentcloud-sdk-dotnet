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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeRunDetail : AbstractModel
    {
        
        /// <summary>
        /// 节点运行的ID
        /// </summary>
        [JsonProperty("NodeRunId")]
        public string NodeRunId{ get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// 工作流运行实例的ID
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 节点类型。
        /// 1： 开始节点
        /// 2：参数提取节点
        /// 3：大模型节点
        /// 4：知识问答节点
        /// 5：知识检索节点
        /// 6：标签提取节点
        /// 7：代码执行节点
        /// 8：工具节点
        /// 9：逻辑判断节点
        /// 10：回复节点
        /// 11：选项卡节点
        /// 12：循环节点
        /// 13：意图识别节点
        /// 14：工作流节点
        /// 15：插件节点
        /// 16：结束节点
        /// 17: 变量聚合节点数据
        /// 18: 批处理节点
        /// 19: 消息队列节点
        /// </summary>
        [JsonProperty("NodeType")]
        public ulong? NodeType{ get; set; }

        /// <summary>
        /// 运行状态。0: 初始状态；1: 运行中；2: 运行成功； 3: 运行失败； 4: 已取消
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("FailCode")]
        public string FailCode{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// 消耗时间（毫秒）
        /// </summary>
        [JsonProperty("CostMilliseconds")]
        public ulong? CostMilliseconds{ get; set; }

        /// <summary>
        /// 消耗的token总数
        /// </summary>
        [JsonProperty("TotalTokens")]
        public ulong? TotalTokens{ get; set; }

        /// <summary>
        /// 输入变量信息
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 节点的输入的完整内容的链接。（当Input内容超过限制的时候此字段才有值）
        /// </summary>
        [JsonProperty("InputRef")]
        public string InputRef{ get; set; }

        /// <summary>
        /// 输出变量信息
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 节点的输出的完整内容的链接。（当Output内容超过限制的时候此字段才有值）
        /// </summary>
        [JsonProperty("OutputRef")]
        public string OutputRef{ get; set; }

        /// <summary>
        /// 原始输出信息。部分节点才有值，如工具节点、代码节点
        /// </summary>
        [JsonProperty("TaskOutput")]
        public string TaskOutput{ get; set; }

        /// <summary>
        /// 任务的原始输出的完整内容的链接。（当TaskOutput内容超过限制的时候此字段才有值）
        /// </summary>
        [JsonProperty("TaskOutputRef")]
        public string TaskOutputRef{ get; set; }

        /// <summary>
        /// 节点的日志
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// 节点的日志的完整内容的链接志（当Log内容超过限制的时候才有值）
        /// </summary>
        [JsonProperty("LogRef")]
        public string LogRef{ get; set; }

        /// <summary>
        /// 开始时间戳（毫秒）
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间戳（毫秒）
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// LLM统计信息。
        /// </summary>
        [JsonProperty("StatisticInfos")]
        public StatisticInfo[] StatisticInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeRunId", this.NodeRunId);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "FailCode", this.FailCode);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "CostMilliseconds", this.CostMilliseconds);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "InputRef", this.InputRef);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "OutputRef", this.OutputRef);
            this.SetParamSimple(map, prefix + "TaskOutput", this.TaskOutput);
            this.SetParamSimple(map, prefix + "TaskOutputRef", this.TaskOutputRef);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "LogRef", this.LogRef);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "StatisticInfos.", this.StatisticInfos);
        }
    }
}

