/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateOfflineTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 间隔，可选，默认1。非空。默认 1
        /// </summary>
        [JsonProperty("CycleStep")]
        public long? CycleStep{ get; set; }

        /// <summary>
        /// 延时执行时间，单位分钟
        /// </summary>
        [JsonProperty("DelayTime")]
        public long? DelayTime{ get; set; }

        /// <summary>
        /// 任务结束数据时间。非空。默认当前时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// 当前日期
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 跟之前调用调度接口保持一致27
        /// </summary>
        [JsonProperty("TypeId")]
        public long? TypeId{ get; set; }

        /// <summary>
        /// 时间指定，如月任务指定1，3号，则填入 1，3。非空。默认 "" 月任务：如具体1，3号则写 "1,3"，指定月末不可和具体号数一起输入，仅能为 "L"
        /// </summary>
        [JsonProperty("TaskAction")]
        public string TaskAction{ get; set; }

        /// <summary>
        /// 区分画布和表单
        /// </summary>
        [JsonProperty("TaskMode")]
        public string TaskMode{ get; set; }

        /// <summary>
        /// 导入编排空间配置
        /// </summary>
        [JsonProperty("TaskImportInfo")]
        public TaskImportInfo TaskImportInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CycleStep", this.CycleStep);
            this.SetParamSimple(map, prefix + "DelayTime", this.DelayTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TypeId", this.TypeId);
            this.SetParamSimple(map, prefix + "TaskAction", this.TaskAction);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamObj(map, prefix + "TaskImportInfo.", this.TaskImportInfo);
        }
    }
}

