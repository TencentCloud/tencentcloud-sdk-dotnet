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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>任务 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>任务描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>关联 Agent ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// <p>提示词模板</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromptTemplate")]
        public string PromptTemplate{ get; set; }

        /// <summary>
        /// <p>输出格式: markdown / json</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// <p>触发类型: manual / cron / webhook</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>Cron 表达式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CronExpr")]
        public string CronExpr{ get; set; }

        /// <summary>
        /// <p>Cron 时区</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CronTimezone")]
        public string CronTimezone{ get; set; }

        /// <summary>
        /// <p>关联技能 ID 列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkillIds")]
        public string[] SkillIds{ get; set; }

        /// <summary>
        /// <p>关联 MCP 端点 ID 列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("McpEndpointIds")]
        public string[] McpEndpointIds{ get; set; }

        /// <summary>
        /// <p>超时时间(秒)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeoutSec")]
        public long? TimeoutSec{ get; set; }

        /// <summary>
        /// <p>重试次数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryCount")]
        public long? RetryCount{ get; set; }

        /// <summary>
        /// <p>通知id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotifyIds")]
        public string[] NotifyIds{ get; set; }

        /// <summary>
        /// <p>是否启用</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "PromptTemplate", this.PromptTemplate);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "CronExpr", this.CronExpr);
            this.SetParamSimple(map, prefix + "CronTimezone", this.CronTimezone);
            this.SetParamArraySimple(map, prefix + "SkillIds.", this.SkillIds);
            this.SetParamArraySimple(map, prefix + "McpEndpointIds.", this.McpEndpointIds);
            this.SetParamSimple(map, prefix + "TimeoutSec", this.TimeoutSec);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamArraySimple(map, prefix + "NotifyIds.", this.NotifyIds);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

