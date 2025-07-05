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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PermissionGroup : AbstractModel
    {
        
        /// <summary>
        /// 权限组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 权限组key
        /// </summary>
        [JsonProperty("GroupKey")]
        public string GroupKey{ get; set; }

        /// <summary>
        /// 是否隐藏分组，0否1是
        /// </summary>
        [JsonProperty("Hide")]
        public long? Hide{ get; set; }

        /// <summary>
        /// 权限集合
        /// </summary>
        [JsonProperty("Permissions")]
        public Permission[] Permissions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupKey", this.GroupKey);
            this.SetParamSimple(map, prefix + "Hide", this.Hide);
            this.SetParamArrayObj(map, prefix + "Permissions.", this.Permissions);
        }
    }
}

