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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Record : AbstractModel
    {
        
        /// <summary>
        /// 问题内容
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// 回答内容
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// 思考内容
        /// </summary>
        [JsonProperty("Think")]
        public string Think{ get; set; }

        /// <summary>
        /// 任务列表
        /// </summary>
        [JsonProperty("TaskList")]
        public Task[] TaskList{ get; set; }

        /// <summary>
        /// 记录创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 记录更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 记录id
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 总结内容
        /// </summary>
        [JsonProperty("FinalSummary")]
        public string FinalSummary{ get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 1=赞，2=踩，0=无反馈
        /// </summary>
        [JsonProperty("Feedback")]
        public long? Feedback{ get; set; }

        /// <summary>
        /// 数据库信息
        /// </summary>
        [JsonProperty("DbInfo")]
        public string DbInfo{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("ErrorContext")]
        public string ErrorContext{ get; set; }

        /// <summary>
        /// TaskList的string字符串
        /// </summary>
        [JsonProperty("TaskListStr")]
        public string TaskListStr{ get; set; }

        /// <summary>
        /// 知识库id列表
        /// </summary>
        [JsonProperty("KnowledgeBaseIds")]
        public string[] KnowledgeBaseIds{ get; set; }

        /// <summary>
        /// 上下文
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamSimple(map, prefix + "Think", this.Think);
            this.SetParamArrayObj(map, prefix + "TaskList.", this.TaskList);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "FinalSummary", this.FinalSummary);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "Feedback", this.Feedback);
            this.SetParamSimple(map, prefix + "DbInfo", this.DbInfo);
            this.SetParamSimple(map, prefix + "ErrorContext", this.ErrorContext);
            this.SetParamSimple(map, prefix + "TaskListStr", this.TaskListStr);
            this.SetParamArraySimple(map, prefix + "KnowledgeBaseIds.", this.KnowledgeBaseIds);
            this.SetParamSimple(map, prefix + "Context", this.Context);
        }
    }
}

