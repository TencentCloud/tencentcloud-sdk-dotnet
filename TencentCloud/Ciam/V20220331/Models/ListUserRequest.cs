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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListUserRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>用户目录ID</p>
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// <p>分页数据</p>
        /// </summary>
        [JsonProperty("Pageable")]
        public Pageable Pageable{ get; set; }

        /// <summary>
        /// <p>Key可选值为condition、userGroup、userOrg、weComUserOrg<li> <strong>condition</strong> </li>    Values = 查询条件，用户ID，用户名称，手机或邮箱<li> <strong>userGroup</strong> </li>    Values = 用户组ID<li> <strong>userOrg</strong> </li>    Values = 用户所属机构ID<li> <strong>weComUserOrg</strong> </li>    Values = 用户所属企业微信机构ID</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>返回信息是否为原文</p>
        /// </summary>
        [JsonProperty("Original")]
        public bool? Original{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamObj(map, prefix + "Pageable.", this.Pageable);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Original", this.Original);
        }
    }
}

