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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRelatedUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("RoleId")]
        public long? RoleId{ get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// 页面含量
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 环境类型
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 新角色id
        /// </summary>
        [JsonProperty("RoleStringId")]
        public string RoleStringId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "RoleStringId", this.RoleStringId);
        }
    }
}

