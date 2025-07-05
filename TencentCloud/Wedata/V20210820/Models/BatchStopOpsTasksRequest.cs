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

    public class BatchStopOpsTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 批量停止任务的TaskId
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 是否终止已生成的实例
        /// </summary>
        [JsonProperty("KillInstance")]
        public bool? KillInstance{ get; set; }

        /// <summary>
        /// 是否异步模式
        /// </summary>
        [JsonProperty("AsyncMode")]
        public bool? AsyncMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "KillInstance", this.KillInstance);
            this.SetParamSimple(map, prefix + "AsyncMode", this.AsyncMode);
        }
    }
}

