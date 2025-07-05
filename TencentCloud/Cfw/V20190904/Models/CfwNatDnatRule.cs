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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CfwNatDnatRule : AbstractModel
    {
        
        /// <summary>
        /// 网络协议，可选值：TCP、UDP。
        /// </summary>
        [JsonProperty("IpProtocol")]
        public string IpProtocol{ get; set; }

        /// <summary>
        /// 弹性IP。
        /// </summary>
        [JsonProperty("PublicIpAddress")]
        public string PublicIpAddress{ get; set; }

        /// <summary>
        /// 公网端口。
        /// </summary>
        [JsonProperty("PublicPort")]
        public long? PublicPort{ get; set; }

        /// <summary>
        /// 内网地址。
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }

        /// <summary>
        /// 内网端口。
        /// </summary>
        [JsonProperty("PrivatePort")]
        public long? PrivatePort{ get; set; }

        /// <summary>
        /// NAT防火墙转发规则描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IpProtocol", this.IpProtocol);
            this.SetParamSimple(map, prefix + "PublicIpAddress", this.PublicIpAddress);
            this.SetParamSimple(map, prefix + "PublicPort", this.PublicPort);
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
            this.SetParamSimple(map, prefix + "PrivatePort", this.PrivatePort);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

