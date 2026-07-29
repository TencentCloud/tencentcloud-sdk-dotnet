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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthReportTask : AbstractModel
    {
        
        /// <summary>
        /// <p>异步任务请求 ID。</p>
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public long? AsyncRequestId{ get; set; }

        /// <summary>
        /// <p>任务的触发来源，支持的取值包括：&quot;DAILY_INSPECTION&quot; - 实例巡检；&quot;SCHEDULED&quot; - 定时生成；&quot;MANUAL&quot; - 手动触发。</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>任务完成进度，单位%。</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// <p>任务创建时间，如“2025-09-30 12:13:14”。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务开始执行时间，如“2025-09-30 13:13:14”。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>任务完成执行时间，如“2025-09-30 14:13:14”。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>任务所属实例的基础信息。</p>
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public InstanceBasicInfo InstanceInfo{ get; set; }

        /// <summary>
        /// <p>健康报告中的健康信息。</p>
        /// </summary>
        [JsonProperty("HealthStatus")]
        public HealthStatus HealthStatus{ get; set; }

        /// <summary>
        /// <p>任务所属实例的标签信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
            this.SetParamObj(map, prefix + "HealthStatus.", this.HealthStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

