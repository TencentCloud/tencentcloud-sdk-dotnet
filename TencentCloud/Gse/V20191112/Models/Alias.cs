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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Alias : AbstractModel
    {
        
        /// <summary>
        /// 别名的唯一标识符
        /// </summary>
        [JsonProperty("AliasId")]
        public string AliasId{ get; set; }

        /// <summary>
        /// 别名的全局唯一资源标识符
        /// </summary>
        [JsonProperty("AliasArn")]
        public string AliasArn{ get; set; }

        /// <summary>
        /// 名字，长度不小于1字符不超过1024字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 别名的可读说明，长度不小于1字符不超过1024字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 别名的路由配置
        /// </summary>
        [JsonProperty("RoutingStrategy")]
        public RoutingStrategy RoutingStrategy{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 上次修改此数据对象的时间
        /// </summary>
        [JsonProperty("LastUpdatedTime")]
        public string LastUpdatedTime{ get; set; }

        /// <summary>
        /// 标签列表，最大长度50组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AliasId", this.AliasId);
            this.SetParamSimple(map, prefix + "AliasArn", this.AliasArn);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "RoutingStrategy.", this.RoutingStrategy);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "LastUpdatedTime", this.LastUpdatedTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

