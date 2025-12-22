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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EsInfo : AbstractModel
    {
        
        /// <summary>
        /// es类型。 1:云es, 2:自建es
        /// </summary>
        [JsonProperty("EsType")]
        public ulong? EsType{ get; set; }

        /// <summary>
        /// 访问方式 1:内网, 2:外网。自建es必填
        /// </summary>
        [JsonProperty("AccessMode")]
        public ulong? AccessMode{ get; set; }

        /// <summary>
        /// 实例id。云es实例必填
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 访问地址。自建es必填
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 访问端口。自建es必填
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 所属网络。自建es且访问方式为内网访问时必填
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 网络服务类型。自建es且访问方式为内网访问时必填。
        /// 负载均衡 CLB:1025 云服务器CVM:0
        /// </summary>
        [JsonProperty("VirtualGatewayType")]
        public ulong? VirtualGatewayType{ get; set; }

        /// <summary>
        /// 密码。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EsType", this.EsType);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VirtualGatewayType", this.VirtualGatewayType);
            this.SetParamSimple(map, prefix + "Password", this.Password);
        }
    }
}

