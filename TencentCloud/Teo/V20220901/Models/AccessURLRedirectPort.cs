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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessURLRedirectPort : AbstractModel
    {
        
        /// <summary>
        /// <p>目标端口配置</p><p>枚举值：</p><ul><li>FollowProtocol： 使用目标协议的默认端口。重定向地址中不显式指定端口，由目标协议使用默认端口，HTTP 使用 80，HTTPS 使用 443。</li><li>FollowRequest： 跟随客户端请求的目标端口。请求地址显式携带端口时沿用该端口；未显式携带时，重定向地址中不携带端口。</li><li>Custom： 使用指定的自定义端口。</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>自定义目标端口。</p><p>取值范围：[1, 65535]</p><p>当 Action 为 Custom 时，此字段必填；当 Action 为 FollowProtocol 或 FollowRequest 时，此字段不生效。</p>
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Value", this.Value);
        }
    }
}

