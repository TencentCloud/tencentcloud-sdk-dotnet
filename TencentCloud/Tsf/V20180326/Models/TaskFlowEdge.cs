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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskFlowEdge : AbstractModel
    {
        
        /// <summary>
        /// 节点 ID，节点类型为任务时为任务ID，节点类型为逻辑节点"且"时为 AND，为逻辑节点"或"时为 OR，节点类型为头节点时为字符串"head"
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// 子节点 ID，节点类型为任务时为任务ID，节点类型为逻辑节点"且"时为 AND，为逻辑节点"或"时为 OR
        /// </summary>
        [JsonProperty("ChildNodeId")]
        public string ChildNodeId{ get; set; }

        /// <summary>
        /// 是否核心任务,Y/N
        /// </summary>
        [JsonProperty("CoreNode")]
        public string CoreNode{ get; set; }

        /// <summary>
        /// 边类型，上下游任务依赖触发关系。一共2个值，Y：成功触发，N：失败触发
        /// </summary>
        [JsonProperty("EdgeType")]
        public string EdgeType{ get; set; }

        /// <summary>
        /// 任务节点类型，一共有4种类型，AND：逻辑节点且，OR：逻辑节点或，TASK：任务节点，START：头节点
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// X轴坐标位置
        /// </summary>
        [JsonProperty("PositionX")]
        public string PositionX{ get; set; }

        /// <summary>
        /// Y轴坐标位置
        /// </summary>
        [JsonProperty("PositionY")]
        public string PositionY{ get; set; }

        /// <summary>
        /// 图 ID，新建工作流时自动生成，不需要填写，查看工作流图时后端返回
        /// </summary>
        [JsonProperty("GraphId")]
        public string GraphId{ get; set; }

        /// <summary>
        /// 工作流 ID，新建工作流时自动生成，不需要填写，查看工作流图时后端返回
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 任务ID，新建工作流时不需要填写，查看工作流图时后端返回
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务历史ID，新建工作流时不需要填写，查看工作流图时后端返回
        /// </summary>
        [JsonProperty("TaskLogId")]
        public string TaskLogId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "ChildNodeId", this.ChildNodeId);
            this.SetParamSimple(map, prefix + "CoreNode", this.CoreNode);
            this.SetParamSimple(map, prefix + "EdgeType", this.EdgeType);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "PositionX", this.PositionX);
            this.SetParamSimple(map, prefix + "PositionY", this.PositionY);
            this.SetParamSimple(map, prefix + "GraphId", this.GraphId);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskLogId", this.TaskLogId);
        }
    }
}

