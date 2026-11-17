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

    public class ConversationMessageExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>智能体图标</p>
        /// </summary>
        [JsonProperty("AgentIcon")]
        public string AgentIcon{ get; set; }

        /// <summary>
        /// <p>智能体名称</p>
        /// </summary>
        [JsonProperty("AgentName")]
        public string AgentName{ get; set; }

        /// <summary>
        /// <p>消息处理耗时</p>
        /// </summary>
        [JsonProperty("Elapsed")]
        public string Elapsed{ get; set; }

        /// <summary>
        /// <p>父消息 ID</p>
        /// </summary>
        [JsonProperty("ParentMessageId")]
        public string ParentMessageId{ get; set; }

        /// <summary>
        /// <p>关联记录 ID</p>
        /// </summary>
        [JsonProperty("RelatedRecordId")]
        public string RelatedRecordId{ get; set; }

        /// <summary>
        /// <p>消息处理开始时间戳（毫秒）</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>工具图标</p>
        /// </summary>
        [JsonProperty("ToolIcon")]
        public string ToolIcon{ get; set; }

        /// <summary>
        /// <p>工具名称</p>
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// <p>Trace ID</p>
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// <p>是否可以反馈</p>
        /// </summary>
        [JsonProperty("CanFeedback")]
        public bool? CanFeedback{ get; set; }

        /// <summary>
        /// <p>是否可以点赞点踩</p>
        /// </summary>
        [JsonProperty("CanRate")]
        public bool? CanRate{ get; set; }

        /// <summary>
        /// <p>消息处理开始时间戳（毫秒）</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>是否已读</p>
        /// </summary>
        [JsonProperty("HasRead")]
        public bool? HasRead{ get; set; }

        /// <summary>
        /// <p>是否大模型生成</p>
        /// </summary>
        [JsonProperty("IsModelGenerated")]
        public bool? IsModelGenerated{ get; set; }

        /// <summary>
        /// <p>用户反馈标签列表</p>
        /// </summary>
        [JsonProperty("ReasonList")]
        public string[] ReasonList{ get; set; }

        /// <summary>
        /// <p>回复方式</p>
        /// </summary>
        [JsonProperty("ReplyMethod")]
        public long? ReplyMethod{ get; set; }

        /// <summary>
        /// <p>用户打分</p>
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// <p>子 Agent 运行 Id</p>
        /// </summary>
        [JsonProperty("SubAgentRunId")]
        public string SubAgentRunId{ get; set; }

        /// <summary>
        /// <p>是否是子 Agent 的消息</p>
        /// </summary>
        [JsonProperty("IsSubAgent")]
        public bool? IsSubAgent{ get; set; }

        /// <summary>
        /// <p>子 Agent 线程 ID</p>
        /// </summary>
        [JsonProperty("SubAgentThreadId")]
        public string SubAgentThreadId{ get; set; }

        /// <summary>
        /// <p>是否是 Agent Team 模式下的 teammate 成员</p>
        /// </summary>
        [JsonProperty("IsTeammate")]
        public bool? IsTeammate{ get; set; }

        /// <summary>
        /// <p>Agent Team 模式下的 teammate 名称</p>
        /// </summary>
        [JsonProperty("TeammateName")]
        public string TeammateName{ get; set; }

        /// <summary>
        /// <p>工作流节点名称</p>
        /// </summary>
        [JsonProperty("WorkflowNodeName")]
        public string WorkflowNodeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentIcon", this.AgentIcon);
            this.SetParamSimple(map, prefix + "AgentName", this.AgentName);
            this.SetParamSimple(map, prefix + "Elapsed", this.Elapsed);
            this.SetParamSimple(map, prefix + "ParentMessageId", this.ParentMessageId);
            this.SetParamSimple(map, prefix + "RelatedRecordId", this.RelatedRecordId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "ToolIcon", this.ToolIcon);
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamSimple(map, prefix + "CanFeedback", this.CanFeedback);
            this.SetParamSimple(map, prefix + "CanRate", this.CanRate);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "HasRead", this.HasRead);
            this.SetParamSimple(map, prefix + "IsModelGenerated", this.IsModelGenerated);
            this.SetParamArraySimple(map, prefix + "ReasonList.", this.ReasonList);
            this.SetParamSimple(map, prefix + "ReplyMethod", this.ReplyMethod);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "SubAgentRunId", this.SubAgentRunId);
            this.SetParamSimple(map, prefix + "IsSubAgent", this.IsSubAgent);
            this.SetParamSimple(map, prefix + "SubAgentThreadId", this.SubAgentThreadId);
            this.SetParamSimple(map, prefix + "IsTeammate", this.IsTeammate);
            this.SetParamSimple(map, prefix + "TeammateName", this.TeammateName);
            this.SetParamSimple(map, prefix + "WorkflowNodeName", this.WorkflowNodeName);
        }
    }
}

