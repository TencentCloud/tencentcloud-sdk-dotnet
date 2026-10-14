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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWorkflowRunRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用ID, 获取方法参看如何获取 <a href="https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa">AppId</a></p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>工作流运行实例ID</p>
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// <p>指定的子工作流对应的NodePath。 格式：[&lt;node_id&gt;[&lt;index&gt;].]*&lt;node_id&gt;[&lt;index&gt;]  此路径用于定位一个具体的工作流实例（Workflow Run），可以是主工作流实例或某个子工作流节点产生的子实例。 路径由点号（.）分隔的节点标识符组成，每个节点标识符格式为 节点ID[实例索引]。 节点ID (node_id)：子工作流所属的节点的ID。 实例索引 (index)：“实例索引” 在工作流节点的时候为空，循环、批处理节点非空，从1开始。 示例： &quot;&quot; 或 不设置 -&gt; 查询主工作流实例 (父工作流) &quot;node_id_a&quot; -&gt; 查询由主工作流中工作流节点node_id_a对应的子工作流实例 &quot;node_id_a.node_id_b[1]&quot; -&gt; 查询工作流节点node_id_a对应的子工作流的循环节点node_id_b的第1轮循环的子工作流运行状态</p>
        /// </summary>
        [JsonProperty("SubWorkflowNodePath")]
        public string SubWorkflowNodePath{ get; set; }

        /// <summary>
        /// <p>是否需要返回工作流的流程图配置</p>
        /// </summary>
        [JsonProperty("IncludeWorkflowGraph")]
        public bool? IncludeWorkflowGraph{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "SubWorkflowNodePath", this.SubWorkflowNodePath);
            this.SetParamSimple(map, prefix + "IncludeWorkflowGraph", this.IncludeWorkflowGraph);
        }
    }
}

