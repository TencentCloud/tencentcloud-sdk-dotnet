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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDatahubTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>任务并发上限</p>
        /// </summary>
        [JsonProperty("TasksMax")]
        public long? TasksMax{ get; set; }

        /// <summary>
        /// <p>数据同步限流值上限</p>单位：MB/s
        /// </summary>
        [JsonProperty("SyncThrottleLimit")]
        public long? SyncThrottleLimit{ get; set; }

        /// <summary>
        /// <p>开启自动扩容</p>枚举值：<ul><li> true： 自动扩容</li><li> false： 手动扩容</li></ul>
        /// </summary>
        [JsonProperty("AutoExpandFlag")]
        public bool? AutoExpandFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TasksMax", this.TasksMax);
            this.SetParamSimple(map, prefix + "SyncThrottleLimit", this.SyncThrottleLimit);
            this.SetParamSimple(map, prefix + "AutoExpandFlag", this.AutoExpandFlag);
        }
    }
}

