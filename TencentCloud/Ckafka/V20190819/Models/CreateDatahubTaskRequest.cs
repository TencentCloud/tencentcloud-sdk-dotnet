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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDatahubTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务类型，SOURCE数据接入，SINK数据流出
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 数据源
        /// </summary>
        [JsonProperty("SourceResource")]
        public DatahubResource SourceResource{ get; set; }

        /// <summary>
        /// 数据目标
        /// </summary>
        [JsonProperty("TargetResource")]
        public DatahubResource TargetResource{ get; set; }

        /// <summary>
        /// 数据处理规则
        /// </summary>
        [JsonProperty("TransformParam")]
        public TransformParam TransformParam{ get; set; }

        /// <summary>
        /// 实例连接参数【已废弃】
        /// </summary>
        [JsonProperty("PrivateLinkParam")]
        [System.Obsolete]
        public PrivateLinkParam PrivateLinkParam{ get; set; }

        /// <summary>
        /// 选择所要绑定的SchemaId
        /// </summary>
        [JsonProperty("SchemaId")]
        public string SchemaId{ get; set; }

        /// <summary>
        /// 数据处理规则
        /// </summary>
        [JsonProperty("TransformsParam")]
        public TransformsParam TransformsParam{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 任务描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamObj(map, prefix + "SourceResource.", this.SourceResource);
            this.SetParamObj(map, prefix + "TargetResource.", this.TargetResource);
            this.SetParamObj(map, prefix + "TransformParam.", this.TransformParam);
            this.SetParamObj(map, prefix + "PrivateLinkParam.", this.PrivateLinkParam);
            this.SetParamSimple(map, prefix + "SchemaId", this.SchemaId);
            this.SetParamObj(map, prefix + "TransformsParam.", this.TransformsParam);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

