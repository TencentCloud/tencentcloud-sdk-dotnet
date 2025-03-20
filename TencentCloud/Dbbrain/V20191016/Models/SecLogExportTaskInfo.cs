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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecLogExportTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 异步任务Id。
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public ulong? AsyncRequestId{ get; set; }

        /// <summary>
        /// 任务开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务执行进度。
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// 导出日志开始时间。
        /// </summary>
        [JsonProperty("LogStartTime")]
        public string LogStartTime{ get; set; }

        /// <summary>
        /// 导出日志结束时间。
        /// </summary>
        [JsonProperty("LogEndTime")]
        public string LogEndTime{ get; set; }

        /// <summary>
        /// 日志文件总大小，单位KB。
        /// </summary>
        [JsonProperty("TotalSize")]
        public ulong? TotalSize{ get; set; }

        /// <summary>
        /// 风险等级列表。0 无风险；1 低风险；2 中风险；3 高风险。
        /// </summary>
        [JsonProperty("DangerLevels")]
        public ulong?[] DangerLevels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "LogStartTime", this.LogStartTime);
            this.SetParamSimple(map, prefix + "LogEndTime", this.LogEndTime);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamArraySimple(map, prefix + "DangerLevels.", this.DangerLevels);
        }
    }
}

