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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadTaskCreationAttrs : AbstractModel
    {
        
        /// <summary>
        /// <p>预热任务类型，枚举值，MetadataLoad｜DistributedLoad。</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>任务优先级，数值越高代表优先级越高，边界值 1-9999，默认值为 1</p>
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// <p>任务描述，支持中文</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>元数据预热任务参数，用于仅预热元数据时入参。入参数TaskType为MetadataLoad时，该参数不应为空。</p>
        /// </summary>
        [JsonProperty("MetadataLoadAttrs")]
        public MetadataLoadAttrs MetadataLoadAttrs{ get; set; }

        /// <summary>
        /// <p>数据预热任务参数。入参数TaskType为DistributedLoad时，该参数不应为空。</p>
        /// </summary>
        [JsonProperty("DistributedLoadAttrs")]
        public DistributedLoadAttrs DistributedLoadAttrs{ get; set; }

        /// <summary>
        /// <p>将任务执行报告写入 COS 的路径，如果不需要报告则入参空</p>
        /// </summary>
        [JsonProperty("ReportPath")]
        public string ReportPath{ get; set; }

        /// <summary>
        /// <p>仅预热数据任务参数。入参数TaskType为LoadData时，该参数不应为空。</p>
        /// </summary>
        [JsonProperty("LoadDataAttrs")]
        public LoadDataAttrs LoadDataAttrs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "MetadataLoadAttrs.", this.MetadataLoadAttrs);
            this.SetParamObj(map, prefix + "DistributedLoadAttrs.", this.DistributedLoadAttrs);
            this.SetParamSimple(map, prefix + "ReportPath", this.ReportPath);
            this.SetParamObj(map, prefix + "LoadDataAttrs.", this.LoadDataAttrs);
        }
    }
}

