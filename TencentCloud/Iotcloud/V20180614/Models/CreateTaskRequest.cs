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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务类型，取值为 “UpdateShadow” 或者 “PublishMessage”
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 执行任务的产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 执行任务的设备名的正则表达式
        /// </summary>
        [JsonProperty("DeviceNameFilter")]
        public string DeviceNameFilter{ get; set; }

        /// <summary>
        /// 任务开始执行的时间。 取值为 Unix 时间戳，单位秒，且需大于等于当前时间时间戳，0为系统当前时间时间戳，即立即执行，最大为当前时间86400秒后，超过则取值为当前时间86400秒后
        /// </summary>
        [JsonProperty("ScheduleTimeInSeconds")]
        public ulong? ScheduleTimeInSeconds{ get; set; }

        /// <summary>
        /// 任务描述细节，描述见下 Task
        /// </summary>
        [JsonProperty("Tasks")]
        public Task Tasks{ get; set; }

        /// <summary>
        /// 最长执行时间，单位秒，被调度后超过此时间仍未有结果则视为任务失败。取值为0-86400，默认为86400
        /// </summary>
        [JsonProperty("MaxExecutionTimeInSeconds")]
        public ulong? MaxExecutionTimeInSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceNameFilter", this.DeviceNameFilter);
            this.SetParamSimple(map, prefix + "ScheduleTimeInSeconds", this.ScheduleTimeInSeconds);
            this.SetParamObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "MaxExecutionTimeInSeconds", this.MaxExecutionTimeInSeconds);
        }
    }
}

