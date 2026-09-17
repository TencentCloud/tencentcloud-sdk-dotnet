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

    public class ModifyRoleEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>修改后的角色名，允许空串</p>
        /// </summary>
        [JsonProperty("RoleNameAfter")]
        public string RoleNameAfter{ get; set; }

        /// <summary>
        /// <p>修改后的签名档，允许空串</p>
        /// </summary>
        [JsonProperty("RoleSignatureAfter")]
        public string RoleSignatureAfter{ get; set; }

        /// <summary>
        /// <p>所属服务器ID，允许空串</p>
        /// </summary>
        [JsonProperty("ServerId")]
        public string ServerId{ get; set; }

        /// <summary>
        /// <p>编辑者账号信息</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// <p>角色信息</p>
        /// </summary>
        [JsonProperty("RoleInfo")]
        public Role RoleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleNameAfter", this.RoleNameAfter);
            this.SetParamSimple(map, prefix + "RoleSignatureAfter", this.RoleSignatureAfter);
            this.SetParamSimple(map, prefix + "ServerId", this.ServerId);
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamObj(map, prefix + "RoleInfo.", this.RoleInfo);
        }
    }
}

