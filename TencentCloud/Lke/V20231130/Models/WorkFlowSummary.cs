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

    public class WorkFlowSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>工作流ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>工作流名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// <p>工作流运行ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// <p>节点信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunNodes")]
        public WorkflowRunNodeInfo[] RunNodes{ get; set; }

        /// <summary>
        /// <p>选项卡</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptionCards")]
        public string[] OptionCards{ get; set; }

        /// <summary>
        /// <p>多气泡的输出结果</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Outputs")]
        public string[] Outputs{ get; set; }

        /// <summary>
        /// <p>工作流发布时间，unix时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowReleaseTime")]
        public string WorkflowReleaseTime{ get; set; }

        /// <summary>
        /// <p>中间消息</p>
        /// </summary>
        [JsonProperty("PendingMessages")]
        public string[] PendingMessages{ get; set; }

        /// <summary>
        /// <p>选项卡索引</p>
        /// </summary>
        [JsonProperty("OptionCardIndex")]
        public OptionCardIndex OptionCardIndex{ get; set; }

        /// <summary>
        /// <p>工作流多气泡输出</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Contents")]
        public Content[] Contents{ get; set; }

        /// <summary>
        /// <p>标识选项卡为单选还是双选</p><p>枚举值：</p><ul><li>0： 单选</li><li>1： 多选</li></ul>
        /// </summary>
        [JsonProperty("OptionMode")]
        public long? OptionMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamArrayObj(map, prefix + "RunNodes.", this.RunNodes);
            this.SetParamArraySimple(map, prefix + "OptionCards.", this.OptionCards);
            this.SetParamArraySimple(map, prefix + "Outputs.", this.Outputs);
            this.SetParamSimple(map, prefix + "WorkflowReleaseTime", this.WorkflowReleaseTime);
            this.SetParamArraySimple(map, prefix + "PendingMessages.", this.PendingMessages);
            this.SetParamObj(map, prefix + "OptionCardIndex.", this.OptionCardIndex);
            this.SetParamArrayObj(map, prefix + "Contents.", this.Contents);
            this.SetParamSimple(map, prefix + "OptionMode", this.OptionMode);
        }
    }
}

