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

    public class MsgRecord : AbstractModel
    {
        
        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 当前记录所对应的 Session ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 关联记录ID
        /// </summary>
        [JsonProperty("RelatedRecordId")]
        public string RelatedRecordId{ get; set; }

        /// <summary>
        /// 是否来自自己
        /// </summary>
        [JsonProperty("IsFromSelf")]
        public bool? IsFromSelf{ get; set; }

        /// <summary>
        /// 发送者名称
        /// </summary>
        [JsonProperty("FromName")]
        public string FromName{ get; set; }

        /// <summary>
        /// 发送者头像
        /// </summary>
        [JsonProperty("FromAvatar")]
        public string FromAvatar{ get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        [JsonProperty("HasRead")]
        public bool? HasRead{ get; set; }

        /// <summary>
        /// 评价
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// 是否评分
        /// </summary>
        [JsonProperty("CanRating")]
        public bool? CanRating{ get; set; }

        /// <summary>
        /// 是否展示反馈按钮
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CanFeedback")]
        public bool? CanFeedback{ get; set; }

        /// <summary>
        /// 记录类型
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 引用来源
        /// </summary>
        [JsonProperty("References")]
        public MsgRecordReference[] References{ get; set; }

        /// <summary>
        /// 评价原因
        /// </summary>
        [JsonProperty("Reasons")]
        public string[] Reasons{ get; set; }

        /// <summary>
        /// 是否大模型
        /// </summary>
        [JsonProperty("IsLlmGenerated")]
        public bool? IsLlmGenerated{ get; set; }

        /// <summary>
        /// 图片链接，可公有读
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageUrls")]
        public string[] ImageUrls{ get; set; }

        /// <summary>
        /// 当次 token 统计信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenStat")]
        public TokenStat TokenStat{ get; set; }

        /// <summary>
        /// 回复方式
        /// 1:大模型直接回复;
        /// 2:保守回复, 未知问题回复;
        /// 3:拒答问题回复;
        /// 4:敏感回复;
        /// 5:问答对直接回复, 已采纳问答对优先回复;
        /// 6:欢迎语回复;
        /// 7:并发超限回复;
        /// 8:全局干预知识;
        /// 9:任务流程过程回复, 当历史记录中 task_flow.type = 0 时, 为大模型回复;
        /// 10:任务流程答案回复;
        /// 11:搜索引擎回复;
        /// 12:知识润色后回复;
        /// 13:图片理解回复;
        /// 14:实时文档回复;
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplyMethod")]
        public ulong? ReplyMethod{ get; set; }

        /// <summary>
        /// 选项卡, 用于多轮对话
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptionCards")]
        public string[] OptionCards{ get; set; }

        /// <summary>
        /// 任务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskFlow")]
        public TaskFlowInfo TaskFlow{ get; set; }

        /// <summary>
        /// 用户传入的文件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileInfos")]
        public FileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// 参考来源引用位置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuoteInfos")]
        public QuoteInfo[] QuoteInfos{ get; set; }

        /// <summary>
        /// Agent的思考过程信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentThought")]
        public AgentThought AgentThought{ get; set; }

        /// <summary>
        /// 扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public ExtraInfo ExtraInfo{ get; set; }

        /// <summary>
        /// 工作流信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkFlow")]
        public WorkflowInfo WorkFlow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RelatedRecordId", this.RelatedRecordId);
            this.SetParamSimple(map, prefix + "IsFromSelf", this.IsFromSelf);
            this.SetParamSimple(map, prefix + "FromName", this.FromName);
            this.SetParamSimple(map, prefix + "FromAvatar", this.FromAvatar);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "HasRead", this.HasRead);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "CanRating", this.CanRating);
            this.SetParamSimple(map, prefix + "CanFeedback", this.CanFeedback);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamArraySimple(map, prefix + "Reasons.", this.Reasons);
            this.SetParamSimple(map, prefix + "IsLlmGenerated", this.IsLlmGenerated);
            this.SetParamArraySimple(map, prefix + "ImageUrls.", this.ImageUrls);
            this.SetParamObj(map, prefix + "TokenStat.", this.TokenStat);
            this.SetParamSimple(map, prefix + "ReplyMethod", this.ReplyMethod);
            this.SetParamArraySimple(map, prefix + "OptionCards.", this.OptionCards);
            this.SetParamObj(map, prefix + "TaskFlow.", this.TaskFlow);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "QuoteInfos.", this.QuoteInfos);
            this.SetParamObj(map, prefix + "AgentThought.", this.AgentThought);
            this.SetParamObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamObj(map, prefix + "WorkFlow.", this.WorkFlow);
        }
    }
}

