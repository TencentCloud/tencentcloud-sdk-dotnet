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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDrInstancePageRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务来源 ADHOC || WORKFLOW
        /// </summary>
        [JsonProperty("TaskSource")]
        public string TaskSource{ get; set; }

        /// <summary>
        /// 索引页码
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 提交开始时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 提交结束时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 文件夹id
        /// </summary>
        [JsonProperty("FolderIds")]
        public string[] FolderIds{ get; set; }

        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("WorkflowIds")]
        public string[] WorkflowIds{ get; set; }

        /// <summary>
        /// 只看我的
        /// </summary>
        [JsonProperty("JustMe")]
        public bool? JustMe{ get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("TaskTypes")]
        public string[] TaskTypes{ get; set; }

        /// <summary>
        /// 试运行提交人userId列表
        /// </summary>
        [JsonProperty("SubmitUsers")]
        public string[] SubmitUsers{ get; set; }

        /// <summary>
        /// 试运行状态
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskSource", this.TaskSource);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "FolderIds.", this.FolderIds);
            this.SetParamArraySimple(map, prefix + "WorkflowIds.", this.WorkflowIds);
            this.SetParamSimple(map, prefix + "JustMe", this.JustMe);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
            this.SetParamArraySimple(map, prefix + "SubmitUsers.", this.SubmitUsers);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
        }
    }
}

