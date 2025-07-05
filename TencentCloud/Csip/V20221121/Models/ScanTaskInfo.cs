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

    public class ScanTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务状态码：1等待开始  2正在扫描  3扫描出错 4扫描完成
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 任务进度
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 任务完成时间
        /// </summary>
        [JsonProperty("TaskTime")]
        public string TaskTime{ get; set; }

        /// <summary>
        /// 报告ID
        /// </summary>
        [JsonProperty("ReportId")]
        public string ReportId{ get; set; }

        /// <summary>
        /// 报告名称
        /// </summary>
        [JsonProperty("ReportName")]
        public string ReportName{ get; set; }

        /// <summary>
        /// 扫描计划，0-周期任务,1-立即扫描,2-定时扫描,3-自定义
        /// </summary>
        [JsonProperty("ScanPlan")]
        public long? ScanPlan{ get; set; }

        /// <summary>
        /// 关联的资产数
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// APP ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户主账户ID
        /// </summary>
        [JsonProperty("UIN")]
        public string UIN{ get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "TaskTime", this.TaskTime);
            this.SetParamSimple(map, prefix + "ReportId", this.ReportId);
            this.SetParamSimple(map, prefix + "ReportName", this.ReportName);
            this.SetParamSimple(map, prefix + "ScanPlan", this.ScanPlan);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "UIN", this.UIN);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

