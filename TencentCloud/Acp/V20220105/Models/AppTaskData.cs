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

namespace TencentCloud.Acp.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppTaskData : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskID")]
        public string TaskID{ get; set; }

        /// <summary>
        /// 任务类型, 0:基础版, 1:专家版, 2:本地化
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 0:默认值(待检测/待咨询), 1.检测中, 2:待评估, 3:评估中, 4:任务完成/咨询完成, 5:任务失败, 6:咨询中;
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("TaskErrMsg")]
        public string TaskErrMsg{ get; set; }

        /// <summary>
        /// 任务来源,0:小程序诊断, 1:预留字段(暂未使用), 2:app诊断(android)
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 应用信息
        /// </summary>
        [JsonProperty("AppInfo")]
        public AppInfoItem AppInfo{ get; set; }

        /// <summary>
        /// 任务启动时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务完成时间(更新时间)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 联系人信息
        /// </summary>
        [JsonProperty("ContactName")]
        public string ContactName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskErrMsg", this.TaskErrMsg);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamObj(map, prefix + "AppInfo.", this.AppInfo);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ContactName", this.ContactName);
        }
    }
}

