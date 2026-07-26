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

    public class CreateTimerTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 |  |
        /// | 1 | 页面手动创建 |
        /// | 2 | 自然语言对话创建 |
        /// </summary>
        [JsonProperty("CreateSource")]
        public long? CreateSource{ get; set; }

        /// <summary>
        /// 输入上下文
        /// </summary>
        [JsonProperty("InputContextSnapshot")]
        public string InputContextSnapshot{ get; set; }

        /// <summary>
        /// 模型
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 提示词
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 推送配置
        /// </summary>
        [JsonProperty("PushConfig")]
        public TimerPushConfig PushConfig{ get; set; }

        /// <summary>
        /// 定时配置
        /// </summary>
        [JsonProperty("Schedule")]
        public TimerScheduleConfig Schedule{ get; set; }

        /// <summary>
        /// skill
        /// </summary>
        [JsonProperty("SkillSnapshot")]
        public string SkillSnapshot{ get; set; }

        /// <summary>
        /// 空间
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 工具
        /// </summary>
        [JsonProperty("ToolSnapshot")]
        public string ToolSnapshot{ get; set; }

        /// <summary>
        /// 工作空间
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// 主用户
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// 子用户
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateSource", this.CreateSource);
            this.SetParamSimple(map, prefix + "InputContextSnapshot", this.InputContextSnapshot);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamObj(map, prefix + "PushConfig.", this.PushConfig);
            this.SetParamObj(map, prefix + "Schedule.", this.Schedule);
            this.SetParamSimple(map, prefix + "SkillSnapshot", this.SkillSnapshot);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "ToolSnapshot", this.ToolSnapshot);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
        }
    }
}

