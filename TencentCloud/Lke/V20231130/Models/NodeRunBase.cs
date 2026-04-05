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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeRunBase : AbstractModel
    {
        
        /// <summary>
        /// <p>节点运行的ID</p>
        /// </summary>
        [JsonProperty("NodeRunId")]
        public string NodeRunId{ get; set; }

        /// <summary>
        /// <p>节点ID</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>工作流运行实例的ID</p>
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// <p>节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>节点类型。<br>1： 开始节点<br>2：参数提取节点<br>3：大模型节点<br>4：知识问答节点<br>5：知识检索节点<br>6：标签提取节点<br>7：代码执行节点<br>8：工具节点<br>9：逻辑判断节点<br>10：回复节点<br>11：选项卡节点<br>12：循环节点<br>13：意图识别节点<br>14：工作流节点<br>15：插件节点<br>16：结束节点<br>17: 变量聚合节点数据<br>18: 批处理节点<br>19: 消息队列节点</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public ulong? NodeType{ get; set; }

        /// <summary>
        /// <p>运行状态。0: 初始状态；1: 运行中；2: 运行成功； 3: 运行失败； 4: 已取消</p>
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// <p>错误码</p>
        /// </summary>
        [JsonProperty("FailCode")]
        public string FailCode{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// <p>消耗时间（毫秒）</p>
        /// </summary>
        [JsonProperty("CostMilliseconds")]
        public ulong? CostMilliseconds{ get; set; }

        /// <summary>
        /// <p>消耗的token总数</p>
        /// </summary>
        [JsonProperty("TotalTokens")]
        public ulong? TotalTokens{ get; set; }

        /// <summary>
        /// <p>分支下标列表</p><p>单位：无</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BranchIndexList")]
        public long?[] BranchIndexList{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "BranchIndexList.", this.BranchIndexList);
        }
    }
}

