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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVpnGatewaySslServerRequest : AbstractModel
    {
        
        /// <summary>
        /// SSL-VPN SERVER 实例ID
        /// </summary>
        [JsonProperty("SslVpnServerId")]
        public string SslVpnServerId{ get; set; }

        /// <summary>
        /// SSL-VPN SERVER NAME
        /// </summary>
        [JsonProperty("SslVpnServerName")]
        public string SslVpnServerName{ get; set; }

        /// <summary>
        /// 本端地址
        /// </summary>
        [JsonProperty("LocalAddress")]
        public string[] LocalAddress{ get; set; }

        /// <summary>
        /// 客户端地址
        /// </summary>
        [JsonProperty("RemoteAddress")]
        public string RemoteAddress{ get; set; }

        /// <summary>
        /// SSL VPN服务端监听协议。当前仅支持 UDP。默认UDP
        /// </summary>
        [JsonProperty("SslVpnProtocol")]
        public string SslVpnProtocol{ get; set; }

        /// <summary>
        /// SSL VPN服务端监听协议端口。
        /// </summary>
        [JsonProperty("SslVpnPort")]
        public long? SslVpnPort{ get; set; }

        /// <summary>
        /// 加密算法。可选 'AES-128-CBC','AES-192-CBC', 'AES-256-CBC', 默认AES-128-CBC。
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// 认证算法。可选 'SHA1'，默认SHA1。
        /// </summary>
        [JsonProperty("IntegrityAlgorithm")]
        public string IntegrityAlgorithm{ get; set; }

        /// <summary>
        /// 是否支持压缩。当前不支持压缩。默认False。
        /// </summary>
        [JsonProperty("Compress")]
        public bool? Compress{ get; set; }

        /// <summary>
        /// 是否开启SSO认证。默认为False。该功能当前需要申请开白使用。
        /// </summary>
        [JsonProperty("SsoEnabled")]
        public bool? SsoEnabled{ get; set; }

        /// <summary>
        /// SAML-DATA
        /// </summary>
        [JsonProperty("SamlData")]
        public string SamlData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SslVpnServerId", this.SslVpnServerId);
            this.SetParamSimple(map, prefix + "SslVpnServerName", this.SslVpnServerName);
            this.SetParamArraySimple(map, prefix + "LocalAddress.", this.LocalAddress);
            this.SetParamSimple(map, prefix + "RemoteAddress", this.RemoteAddress);
            this.SetParamSimple(map, prefix + "SslVpnProtocol", this.SslVpnProtocol);
            this.SetParamSimple(map, prefix + "SslVpnPort", this.SslVpnPort);
            this.SetParamSimple(map, prefix + "EncryptAlgorithm", this.EncryptAlgorithm);
            this.SetParamSimple(map, prefix + "IntegrityAlgorithm", this.IntegrityAlgorithm);
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
            this.SetParamSimple(map, prefix + "SsoEnabled", this.SsoEnabled);
            this.SetParamSimple(map, prefix + "SamlData", this.SamlData);
        }
    }
}

