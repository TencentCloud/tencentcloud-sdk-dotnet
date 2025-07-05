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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PGroupRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 允许访问的客户端IP
        /// </summary>
        [JsonProperty("AuthClientIp")]
        public string AuthClientIp{ get; set; }

        /// <summary>
        /// 读写权限, ro为只读，rw为读写
        /// </summary>
        [JsonProperty("RWPermission")]
        public string RWPermission{ get; set; }

        /// <summary>
        /// all_squash：所有访问用户（含 root 用户）都会被映射为匿名用户或用户组。
        /// no_all_squash：所有访问用户（含 root 用户）均保持原有的 UID/GID 信息。
        /// root_squash：将来访的 root 用户映射为匿名用户或用户组，非 root 用户保持原有的 UID/GID 信息。
        /// no_root_squash：与 no_all_squash 效果一致，所有访问用户（含 root 用户）均保持原有的 UID/GID 信息
        /// </summary>
        [JsonProperty("UserPermission")]
        public string UserPermission{ get; set; }

        /// <summary>
        /// 规则优先级，1-100。 其中 1 为最高，100为最低
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "AuthClientIp", this.AuthClientIp);
            this.SetParamSimple(map, prefix + "RWPermission", this.RWPermission);
            this.SetParamSimple(map, prefix + "UserPermission", this.UserPermission);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

