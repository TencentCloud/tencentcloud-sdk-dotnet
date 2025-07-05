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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApplicationListRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目空间id，本次查询返回的应用均关联至该空间
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public ulong? WorkspaceId{ get; set; }

        /// <summary>
        /// 应用token
        /// </summary>
        [JsonProperty("ApplicationToken")]
        public string ApplicationToken{ get; set; }

        /// <summary>
        /// 应用id数组，可选，填了则表示根据id批量查询
        /// </summary>
        [JsonProperty("ApplicationId")]
        public ulong?[] ApplicationId{ get; set; }

        /// <summary>
        /// 请求页号
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 页容量，默认为10
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "ApplicationToken", this.ApplicationToken);
            this.SetParamArraySimple(map, prefix + "ApplicationId.", this.ApplicationId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

