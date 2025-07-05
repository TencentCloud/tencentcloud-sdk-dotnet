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

    public class TaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 异步任务 ID。
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public long? AsyncRequestId{ get; set; }

        /// <summary>
        /// 当前实例所有 proxy 列表。
        /// </summary>
        [JsonProperty("InstProxyList")]
        public string[] InstProxyList{ get; set; }

        /// <summary>
        /// 当前实例所有 proxy 数量。
        /// </summary>
        [JsonProperty("InstProxyCount")]
        public long? InstProxyCount{ get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务启动时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务的状态，支持的取值包括："created" - 新建；"chosen" - 待执行； "running" - 执行中；"failed" - 失败；"finished" - 已完成。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 完成 kill 任务的 proxyId。
        /// </summary>
        [JsonProperty("FinishedProxyList")]
        public string[] FinishedProxyList{ get; set; }

        /// <summary>
        /// kill 任务实行失败的 proxyId。
        /// </summary>
        [JsonProperty("FailedProxyList")]
        public string[] FailedProxyList{ get; set; }

        /// <summary>
        /// 任务结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务执行进度。
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
            this.SetParamArraySimple(map, prefix + "InstProxyList.", this.InstProxyList);
            this.SetParamSimple(map, prefix + "InstProxyCount", this.InstProxyCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "FinishedProxyList.", this.FinishedProxyList);
            this.SetParamArraySimple(map, prefix + "FailedProxyList.", this.FailedProxyList);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

