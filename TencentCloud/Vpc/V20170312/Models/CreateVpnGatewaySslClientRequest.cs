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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVpnGatewaySslClientRequest : AbstractModel
    {
        
        /// <summary>
        /// SSL-VPN-SERVER 实例ID。
        /// </summary>
        [JsonProperty("SslVpnServerId")]
        public string SslVpnServerId{ get; set; }

        /// <summary>
        /// SSL-VPN-CLIENT实例Name。不可和SslVpnClientNames同时使用。
        /// </summary>
        [JsonProperty("SslVpnClientName")]
        public string SslVpnClientName{ get; set; }

        /// <summary>
        /// SSL-VPN-CLIENT实例Name数字。批量创建时使用。不可和SslVpnClientName同时使用。
        /// </summary>
        [JsonProperty("SslVpnClientNames")]
        public string[] SslVpnClientNames{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SslVpnServerId", this.SslVpnServerId);
            this.SetParamSimple(map, prefix + "SslVpnClientName", this.SslVpnClientName);
            this.SetParamArraySimple(map, prefix + "SslVpnClientNames.", this.SslVpnClientNames);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

