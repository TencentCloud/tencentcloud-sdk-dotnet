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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 用户状态 Enabled：启用， Disabled：禁用。
        /// </summary>
        [JsonProperty("UserStatus")]
        public string UserStatus{ get; set; }

        /// <summary>
        /// 用户类型  Manual：手动创建，Synchronized：外部导入。
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// 过滤条件。  目前仅支持用户名，邮箱，用户userId，描述
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }

        /// <summary>
        /// 每页的最大数据条数。  取值范围：1~100。  默认值：10。
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// 查询返回结果下一页的令牌。首次调用 API 不需要NextToken。  当您首次调用 API 时，如果返回数据总条数超过MaxResults限制，数据会被截断，只返回MaxResults条数据，同时，返回参数IsTruncated为true，返回一个NextToken。您可以使用上一次返回的NextToken继续调用 API，其他请求参数保持不变，查询被截断的数据。您可以按此方法经过多次查询，直到IsTruncated为false时，表示全部数据查询完毕。
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 筛选的用户组，该用户组关联的子用户会返回IsSelected=1
        /// </summary>
        [JsonProperty("FilterGroups")]
        public string[] FilterGroups{ get; set; }

        /// <summary>
        /// 排序的字段，目前只支持CreateTime，默认是CreateTime字段
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// 排序类型：Desc 倒序 Asc  正序，需要你和SortField一起设置
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "UserStatus", this.UserStatus);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamArraySimple(map, prefix + "FilterGroups.", this.FilterGroups);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
        }
    }
}

