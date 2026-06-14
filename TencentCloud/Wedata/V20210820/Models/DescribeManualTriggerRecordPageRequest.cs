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

    public class DescribeManualTriggerRecordPageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>触发运行名称</p>
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// <p>工作流过滤关键字，工作流名称 or 工作流ID</p>
        /// </summary>
        [JsonProperty("WorkflowKeyword")]
        public string WorkflowKeyword{ get; set; }

        /// <summary>
        /// <p>触发运行提交人过滤，多个提交人用英文逗号分割</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>触发提交创建时间过滤，起始时间</p>
        /// </summary>
        [JsonProperty("TriggerStartTime")]
        public string TriggerStartTime{ get; set; }

        /// <summary>
        /// <p>触发提交创建时间过滤，结束时间</p>
        /// </summary>
        [JsonProperty("TriggerEndTime")]
        public string TriggerEndTime{ get; set; }

        /// <summary>
        /// <p>页码，整型</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页数目，整型</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>触发ID</p>
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "WorkflowKeyword", this.WorkflowKeyword);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "TriggerStartTime", this.TriggerStartTime);
            this.SetParamSimple(map, prefix + "TriggerEndTime", this.TriggerEndTime);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
        }
    }
}

