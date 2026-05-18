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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// <p>任务标题</p>
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// <p>任务描述</p>
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// <p>任务标签</p>
        /// </summary>
        [JsonProperty("TaskTag")]
        public string TaskTag{ get; set; }

        /// <summary>
        /// <p>任务状态(1001 -- 未开始   1002 -- 进行中  1003 -- 暂停中   1004 -- 任务结束)</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// <p>任务更新时间</p>
        /// </summary>
        [JsonProperty("TaskUpdateTime")]
        public string TaskUpdateTime{ get; set; }

        /// <summary>
        /// <p>0--未开始，1--进行中，2--已完成</p>
        /// </summary>
        [JsonProperty("TaskPreCheckStatus")]
        public long? TaskPreCheckStatus{ get; set; }

        /// <summary>
        /// <p>环境检查是否通过</p>
        /// </summary>
        [JsonProperty("TaskPreCheckSuccess")]
        public bool? TaskPreCheckSuccess{ get; set; }

        /// <summary>
        /// <p>演练是否符合预期 1-符合预期 2-不符合预期</p>
        /// </summary>
        [JsonProperty("TaskExpect")]
        public long? TaskExpect{ get; set; }

        /// <summary>
        /// <p>关联应用ID</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>关联应用名称</p>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// <p>验证项ID</p>
        /// </summary>
        [JsonProperty("VerifyId")]
        public ulong? VerifyId{ get; set; }

        /// <summary>
        /// <p>状态类型: 0 -- 无状态，1 -- 成功，2-- 失败，3--终止</p>
        /// </summary>
        [JsonProperty("TaskStatusType")]
        public ulong? TaskStatusType{ get; set; }

        /// <summary>
        /// <p>架构ID</p>
        /// </summary>
        [JsonProperty("ArchId")]
        public string ArchId{ get; set; }

        /// <summary>
        /// <p>架构名称</p>
        /// </summary>
        [JsonProperty("ArchName")]
        public string ArchName{ get; set; }

        /// <summary>
        /// <p>来源</p>
        /// </summary>
        [JsonProperty("TaskSource")]
        public long? TaskSource{ get; set; }

        /// <summary>
        /// <p>云资源标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskTag", this.TaskTag);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "TaskUpdateTime", this.TaskUpdateTime);
            this.SetParamSimple(map, prefix + "TaskPreCheckStatus", this.TaskPreCheckStatus);
            this.SetParamSimple(map, prefix + "TaskPreCheckSuccess", this.TaskPreCheckSuccess);
            this.SetParamSimple(map, prefix + "TaskExpect", this.TaskExpect);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "VerifyId", this.VerifyId);
            this.SetParamSimple(map, prefix + "TaskStatusType", this.TaskStatusType);
            this.SetParamSimple(map, prefix + "ArchId", this.ArchId);
            this.SetParamSimple(map, prefix + "ArchName", this.ArchName);
            this.SetParamSimple(map, prefix + "TaskSource", this.TaskSource);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

