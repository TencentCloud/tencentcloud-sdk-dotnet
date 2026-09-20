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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListConsoleUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>页码，从1开始，默认1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页大小，默认10，最小10，最大200</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>用户名称与 UIN 模糊匹配</p>
        /// </summary>
        [JsonProperty("UserKeyword")]
        public string UserKeyword{ get; set; }

        /// <summary>
        /// <p>用于过滤角色关联的用户</p><p>枚举值：</p><ul><li>2001： 控制台管理员</li><li>2002： 控制台成员</li></ul>
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }

        /// <summary>
        /// <p>多字段排序，如 [{Name: &#39;CreateTime&#39;, Direction: &#39;Desc&#39;}, {Name: &#39;UserName&#39;, Direction: &#39;Asc&#39;}]，默认按创建时间降序</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "UserKeyword", this.UserKeyword);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
        }
    }
}

