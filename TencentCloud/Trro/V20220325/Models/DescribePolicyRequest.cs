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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 查看权限的项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 查看的权限模式，black为黑名单，white为白名单，不填默认为当前项目生效的权限模式
        /// </summary>
        [JsonProperty("PolicyMode")]
        public string PolicyMode{ get; set; }

        /// <summary>
        /// 模糊匹配模式，remoteMatch为远端设备ID匹配，fieldMatch为现场ID匹配，不填默认为remoteMatch
        /// </summary>
        [JsonProperty("SearchMode")]
        public string SearchMode{ get; set; }

        /// <summary>
        /// 模糊匹配关键字，不填默认不进行模糊匹配
        /// </summary>
        [JsonProperty("SearchWords")]
        public string SearchWords{ get; set; }

        /// <summary>
        /// 每页返回的最大数量，不填默认为10
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 当前页码，不填默认为1（首页）
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PolicyMode", this.PolicyMode);
            this.SetParamSimple(map, prefix + "SearchMode", this.SearchMode);
            this.SetParamSimple(map, prefix + "SearchWords", this.SearchWords);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
        }
    }
}

