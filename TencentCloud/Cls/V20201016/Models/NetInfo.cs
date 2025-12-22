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

    public class NetInfo : AbstractModel
    {
        
        /// <summary>
        /// 网络地址
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 认证token
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// 网络类型;1：内网；2:外网
        /// </summary>
        [JsonProperty("NetType")]
        public ulong? NetType{ get; set; }

        /// <summary>
        /// 所属网络；如果网络类型为内网，该字段必填
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 网络服务类型；如果网络类型为内网，该字段必填
        /// - 0:云上cvm
        /// - 3:云上专线网关
        /// - 11:云联网
        /// - 1025:云上clb
        /// </summary>
        [JsonProperty("VirtualGatewayType")]
        public ulong? VirtualGatewayType{ get; set; }

        /// <summary>
        /// 认证机制，是否使用SSL，默认不使用
        /// </summary>
        [JsonProperty("IsSSL")]
        public bool? IsSSL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VirtualGatewayType", this.VirtualGatewayType);
            this.SetParamSimple(map, prefix + "IsSSL", this.IsSSL);
        }
    }
}

