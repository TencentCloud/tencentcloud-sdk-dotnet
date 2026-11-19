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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduledTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>定时任务唯一标识</p>
        /// </summary>
        [JsonProperty("ScheduledTaskId")]
        public string ScheduledTaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>任务提示词</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>六段 cron 表达式</p>
        /// </summary>
        [JsonProperty("Schedule")]
        public string Schedule{ get; set; }

        /// <summary>
        /// <p>任务状态：1=ACTIVE，2=PAUSED</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>会话类型：1=数据分析，2=数据工程</p>
        /// </summary>
        [JsonProperty("SessionType")]
        public long? SessionType{ get; set; }

        /// <summary>
        /// <p>分析空间 ID</p>
        /// </summary>
        [JsonProperty("AnalysisSpaceId")]
        public string AnalysisSpaceId{ get; set; }

        /// <summary>
        /// <p>工作空间 ID</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>创建人 UIN</p>
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// <p>创建时间，毫秒级 Unix 时间戳字符串</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最近修改时间，毫秒级 Unix 时间戳字符串</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>生效开始时间，上海时区本地零点的毫秒时间戳字符串；0 表示不传</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>生效结束时间，上海时区本地零点的毫秒时间戳字符串；0 表示不传</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>技能 ID 列表</p>
        /// </summary>
        [JsonProperty("SkillIds")]
        public string SkillIds{ get; set; }

        /// <summary>
        /// <p>模型 ID</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>调度类型：1=每天，2=间隔，3=单次</p>
        /// </summary>
        [JsonProperty("ScheduleType")]
        public long? ScheduleType{ get; set; }

        /// <summary>
        /// <p>最近修改人 UIN</p>
        /// </summary>
        [JsonProperty("UpdateUserUin")]
        public string UpdateUserUin{ get; set; }

        /// <summary>
        /// <p>mcpId列表（逗号分隔）</p>
        /// </summary>
        [JsonProperty("MCPIds")]
        public string MCPIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScheduledTaskId", this.ScheduledTaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "Schedule", this.Schedule);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamSimple(map, prefix + "AnalysisSpaceId", this.AnalysisSpaceId);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SkillIds", this.SkillIds);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ScheduleType", this.ScheduleType);
            this.SetParamSimple(map, prefix + "UpdateUserUin", this.UpdateUserUin);
            this.SetParamSimple(map, prefix + "MCPIds", this.MCPIds);
        }
    }
}

