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

    public class L4ProxyRemoteAuth : AbstractModel
    {
        
        /// <summary>
        /// 四层远程鉴权开关，取值有：
        /// <li>on：表示开启;</li>
        /// <li>off：表示关闭。</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 远程鉴权服务地址，格式为: domain/ip:port。例：example.auth.com:8888
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 远程鉴权服务不可访问后，经过四层转发规则默认回源行为，取值有：
        /// <li>reject：表示进行拦截，拒绝访问;</li>
        /// <li>allow：表示允许通过。</li>
        /// </summary>
        [JsonProperty("ServerFaultyBehavior")]
        public string ServerFaultyBehavior{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "ServerFaultyBehavior", this.ServerFaultyBehavior);
        }
    }
}

