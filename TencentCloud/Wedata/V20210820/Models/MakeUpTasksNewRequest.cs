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

    public class MakeUpTasksNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 补录的当前任务的taskId数组
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// 补录开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 补录结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 补录选项标识，1表示当前任务；2表示当前及下游任务；3表示下游任务
        /// </summary>
        [JsonProperty("MakeUpType")]
        public ulong? MakeUpType{ get; set; }

        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// true: 检查父任务实例状态；false: 不检查父任务实例状态
        /// </summary>
        [JsonProperty("CheckParent")]
        public bool? CheckParent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MakeUpType", this.MakeUpType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CheckParent", this.CheckParent);
        }
    }
}

