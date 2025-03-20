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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareTaskItem : AbstractModel
    {
        
        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 对比任务 Id
        /// </summary>
        [JsonProperty("CompareTaskId")]
        public string CompareTaskId{ get; set; }

        /// <summary>
        /// 对比任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 对比任务状态, 可能的值：created - 创建完成；readyRun - 等待运行；running - 运行中；success - 成功；stopping - 结束中；failed - 失败；canceled - 已终止
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 对比任务配置
        /// </summary>
        [JsonProperty("Config")]
        public CompareObject Config{ get; set; }

        /// <summary>
        /// 对比任务校验详情
        /// </summary>
        [JsonProperty("CheckProcess")]
        public ProcessProgress CheckProcess{ get; set; }

        /// <summary>
        /// 对比任务运行详情
        /// </summary>
        [JsonProperty("CompareProcess")]
        public ProcessProgress CompareProcess{ get; set; }

        /// <summary>
        /// 对比结果, 可能的值：same - 一致；different - 不一致；skipAll - 跳过
        /// </summary>
        [JsonProperty("Conclusion")]
        public string Conclusion{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 任务启动时间
        /// </summary>
        [JsonProperty("StartedAt")]
        public string StartedAt{ get; set; }

        /// <summary>
        /// 对比结束时间
        /// </summary>
        [JsonProperty("FinishedAt")]
        public string FinishedAt{ get; set; }

        /// <summary>
        /// 对比类型，dataCheck(完整数据对比)、sampleDataCheck(抽样数据对比)、rowsCount(行数对比)
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 对比配置信息
        /// </summary>
        [JsonProperty("Options")]
        public CompareOptions Options{ get; set; }

        /// <summary>
        /// 一致性校验提示信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "CompareTaskId", this.CompareTaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "CheckProcess.", this.CheckProcess);
            this.SetParamObj(map, prefix + "CompareProcess.", this.CompareProcess);
            this.SetParamSimple(map, prefix + "Conclusion", this.Conclusion);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "StartedAt", this.StartedAt);
            this.SetParamSimple(map, prefix + "FinishedAt", this.FinishedAt);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamObj(map, prefix + "Options.", this.Options);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

