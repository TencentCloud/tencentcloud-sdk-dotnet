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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EntityInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>实体 ID</p>
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// <p>实体所属域</p><p>默认值：实体所在域，如TC，App</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>实体所属产品</p><p>参数格式：实体归属的产品，如CDB, Application</p>
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// <p>实体名称</p>
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// <p>实体类名称</p><p>参数格式：TC.CDB.Instance</p>
        /// </summary>
        [JsonProperty("EntityClassName")]
        public string EntityClassName{ get; set; }

        /// <summary>
        /// <p>动态属性（base 在前 + 字典序）</p>
        /// </summary>
        [JsonProperty("Attributes")]
        public EntityAttribute[] Attributes{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>关联日志主题</p>
        /// </summary>
        [JsonProperty("RelatedLogTopics")]
        public RelatedTopicItem[] RelatedLogTopics{ get; set; }

        /// <summary>
        /// <p> 实体资源ID </p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "EntityName", this.EntityName);
            this.SetParamSimple(map, prefix + "EntityClassName", this.EntityClassName);
            this.SetParamArrayObj(map, prefix + "Attributes.", this.Attributes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "RelatedLogTopics.", this.RelatedLogTopics);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

