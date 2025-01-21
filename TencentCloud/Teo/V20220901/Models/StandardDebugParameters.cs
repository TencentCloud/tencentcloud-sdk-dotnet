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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StandardDebugParameters : AbstractModel
    {
        
        /// <summary>
        /// Debug 功能开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 允许的客户端来源。支持填写 IPv4 以及 IPv6 的 IP 网段。0.0.0.0/0 表示允许所有 IPv4 客户端进行调试；::/0 表示允许所有 IPv6 客户端进行调试；不能填写 127.0.0.1。<br>注意：当 Switch 字段为 on 时，此字段必填，且填写个数为 1～100；当 Switch 为 off 时，无需填写此字段，若填写则不生效。
        /// </summary>
        [JsonProperty("AllowClientIPList")]
        public string[] AllowClientIPList{ get; set; }

        /// <summary>
        /// Debug 功能到期时间。超出设置的时间，则功能失效。<br>注意：当 Switch 为 on 时，此字段必填；当 Switch 为 off 时，无需填写此字段，若填写则不生效。
        /// </summary>
        [JsonProperty("Expires")]
        public string Expires{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "AllowClientIPList.", this.AllowClientIPList);
            this.SetParamSimple(map, prefix + "Expires", this.Expires);
        }
    }
}

