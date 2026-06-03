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

    public class CreateMetaAndDataSyncDatahubTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务名称</p><p>64字符内</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>同步源连接</p><p>参数格式：resource-test</p>
        /// </summary>
        [JsonProperty("SourceResourceId")]
        public string SourceResourceId{ get; set; }

        /// <summary>
        /// <p>同步目标连接</p><p>参数格式：resource-test</p>
        /// </summary>
        [JsonProperty("TargetResourceId")]
        public string TargetResourceId{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Offset类型，最开始位置earliest，最新位置latest，时间点位置timestamp</p><p>枚举值：</p><ul><li>earliest： 最开始位置</li><li>latest： 最新位置</li><li>timestamp： 时间点位置</li></ul>
        /// </summary>
        [JsonProperty("OffsetType")]
        public string OffsetType{ get; set; }

        /// <summary>
        /// <p>正则匹配Topic列表</p><p>与TopicList参数二选一</p>
        /// </summary>
        [JsonProperty("TopicRegularExpression")]
        public string TopicRegularExpression{ get; set; }

        /// <summary>
        /// <p>多选topic列表</p><p>与TopicRegularExpression参数二选一</p>
        /// </summary>
        [JsonProperty("TopicList")]
        public string[] TopicList{ get; set; }

        /// <summary>
        /// <p>Topic 前缀</p>
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// <p>Topic前缀分隔符</p><p>仅支持 &quot;.&quot; / &quot;-&quot; / &quot;_&quot;</p>
        /// </summary>
        [JsonProperty("Separator")]
        public string Separator{ get; set; }

        /// <summary>
        /// <p>连接器任务描述</p><p>128字符内</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "SourceResourceId", this.SourceResourceId);
            this.SetParamSimple(map, prefix + "TargetResourceId", this.TargetResourceId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "OffsetType", this.OffsetType);
            this.SetParamSimple(map, prefix + "TopicRegularExpression", this.TopicRegularExpression);
            this.SetParamArraySimple(map, prefix + "TopicList.", this.TopicList);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "Separator", this.Separator);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

