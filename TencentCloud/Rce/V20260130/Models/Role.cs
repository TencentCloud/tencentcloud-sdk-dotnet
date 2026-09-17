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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Role : AbstractModel
    {
        
        /// <summary>
        /// <p>角色ID</p>
        /// </summary>
        [JsonProperty("RoleId")]
        public string RoleId{ get; set; }

        /// <summary>
        /// <p>角色名称</p>
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// <p>个性签名</p>
        /// </summary>
        [JsonProperty("RoleSignature")]
        public string RoleSignature{ get; set; }

        /// <summary>
        /// <p>角色等级</p>
        /// </summary>
        [JsonProperty("RoleLevel")]
        public string RoleLevel{ get; set; }

        /// <summary>
        /// <p>角色总战力</p>
        /// </summary>
        [JsonProperty("RoleCe")]
        public float? RoleCe{ get; set; }

        /// <summary>
        /// <p>角色创建时间</p>
        /// </summary>
        [JsonProperty("RoleCreateTime")]
        public string RoleCreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RoleSignature", this.RoleSignature);
            this.SetParamSimple(map, prefix + "RoleLevel", this.RoleLevel);
            this.SetParamSimple(map, prefix + "RoleCe", this.RoleCe);
            this.SetParamSimple(map, prefix + "RoleCreateTime", this.RoleCreateTime);
        }
    }
}

