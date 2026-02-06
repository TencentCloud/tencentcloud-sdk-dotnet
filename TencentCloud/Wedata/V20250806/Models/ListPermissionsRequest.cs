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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListPermissionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源
        /// ResourceType：来源于TCCATALOG模块的GetGrantPrivilegesSTD接口中返回的ResourceType，并改为首字母大写，例如METALAKE对应Metalake
        /// ResourceUri，取决于 ResourceType，Metalake时固定为default，其他类别采用catalog的三段式结构，例如
        /// - Metalake，固定为default
        /// - Catalog，取catalogName
        /// - Schema，取catalogName.SchemaName
        /// - Table，取catalogName.SchemaName.TableName
        /// </summary>
        [JsonProperty("Resource")]
        public PrivilegeResource Resource{ get; set; }

        /// <summary>
        /// 过滤条件(此参数还未支持)
        /// </summary>
        [JsonProperty("Filters")]
        public SecurityFilter[] Filters{ get; set; }

        /// <summary>
        /// 排序字段(此参数还未支持)
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }

        /// <summary>
        /// 页参数(此参数还未支持)
        /// </summary>
        [JsonProperty("Page")]
        public Page Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamObj(map, prefix + "Page.", this.Page);
        }
    }
}

