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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCfsRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 权限组 ID
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// 可以填写单个 IP 或者单个网段，例如 10.1.10.11 或者 10.10.1.0/24。默认来访地址为*表示允许所有。同时需要注意，此处需填写 CVM 的内网 IP。
        /// </summary>
        [JsonProperty("AuthClientIp")]
        public string AuthClientIp{ get; set; }

        /// <summary>
        /// 规则优先级，参数范围1-100。 其中 1 为最高，100为最低
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 读写权限, 值为 RO、RW；其中 RO 为只读，RW 为读写，不填默认为只读
        /// </summary>
        [JsonProperty("RWPermission")]
        public string RWPermission{ get; set; }

        /// <summary>
        /// 用户权限，值为 all_squash、no_all_squash、root_squash、no_root_squash。其中all_squash为所有访问用户都会被映射为匿名用户或用户组；no_all_squash为访问用户会先与本机用户匹配，匹配失败后再映射为匿名用户或用户组；root_squash为将来访的root用户映射为匿名用户或用户组；no_root_squash为来访的root用户保持root帐号权限。不填默认为root_squash。
        /// </summary>
        [JsonProperty("UserPermission")]
        public string UserPermission{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "AuthClientIp", this.AuthClientIp);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "RWPermission", this.RWPermission);
            this.SetParamSimple(map, prefix + "UserPermission", this.UserPermission);
        }
    }
}

