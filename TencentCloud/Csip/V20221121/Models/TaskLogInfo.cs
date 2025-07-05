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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskLogInfo : AbstractModel
    {
        
        /// <summary>
        /// 报告名称
        /// </summary>
        [JsonProperty("TaskLogName")]
        public string TaskLogName{ get; set; }

        /// <summary>
        /// 报告ID
        /// </summary>
        [JsonProperty("TaskLogId")]
        public string TaskLogId{ get; set; }

        /// <summary>
        /// 关联资产个数
        /// </summary>
        [JsonProperty("AssetsNumber")]
        public long? AssetsNumber{ get; set; }

        /// <summary>
        /// 安全风险数量
        /// </summary>
        [JsonProperty("RiskNumber")]
        public long? RiskNumber{ get; set; }

        /// <summary>
        /// 报告生成时间
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 任务状态码：0 初始值  1正在扫描  2扫描完成  3扫描出错，4停止，5暂停，6该任务已被重启过
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 关联任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 扫描开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务中心扫描任务ID
        /// </summary>
        [JsonProperty("TaskCenterTaskId")]
        public string TaskCenterTaskId{ get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 主账户ID
        /// </summary>
        [JsonProperty("UIN")]
        public string UIN{ get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 报告类型： 1安全体检 2日报 3周报 4月报
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }

        /// <summary>
        /// 报告模板id
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskLogName", this.TaskLogName);
            this.SetParamSimple(map, prefix + "TaskLogId", this.TaskLogId);
            this.SetParamSimple(map, prefix + "AssetsNumber", this.AssetsNumber);
            this.SetParamSimple(map, prefix + "RiskNumber", this.RiskNumber);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskCenterTaskId", this.TaskCenterTaskId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "UIN", this.UIN);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

