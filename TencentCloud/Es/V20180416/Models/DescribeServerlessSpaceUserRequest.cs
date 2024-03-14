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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeServerlessSpaceUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 空间的ID
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 游标
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 页条数
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 用户名列表过滤
        /// </summary>
        [JsonProperty("UserNames")]
        public string[] UserNames{ get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        [JsonProperty("UserTypes")]
        public long?[] UserTypes{ get; set; }

        /// <summary>
        /// 权限类型
        /// </summary>
        [JsonProperty("PrivilegeTypes")]
        public long?[] PrivilegeTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "UserNames.", this.UserNames);
            this.SetParamArraySimple(map, prefix + "UserTypes.", this.UserTypes);
            this.SetParamArraySimple(map, prefix + "PrivilegeTypes.", this.PrivilegeTypes);
        }
    }
}

