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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteSmoothMigrationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务ID，可在[DescribeSmoothMigrationTaskList](https://cloud.tencent.com/document/api/1493/119997)接口返回的[SmoothMigrationTaskItem](https://cloud.tencent.com/document/api/1493/96031#SmoothMigrationTaskItem)或控制台中获得。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

