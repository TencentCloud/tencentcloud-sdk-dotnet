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
        /// <p>SSL-VPN SERVER 实例ID</p>
        /// </summary>
        [JsonProperty("SslVpnServerId")]
        public string SslVpnServerId{ get; set; }

        /// <summary>
        /// <p>SSL-VPN SERVER NAME</p>
        /// </summary>
        [JsonProperty("SslVpnServerName")]
        public string SslVpnServerName{ get; set; }

        /// <summary>
        /// <p>本端地址</p>
        /// </summary>
        [JsonProperty("LocalAddress")]
        public string[] LocalAddress{ get; set; }

        /// <summary>
        /// <p>客户端地址</p>
        /// </summary>
        [JsonProperty("RemoteAddress")]
        public string RemoteAddress{ get; set; }

        /// <summary>
        /// <p>SSL VPN服务端监听协议。当前仅支持 UDP。默认UDP</p>
        /// </summary>
        [JsonProperty("SslVpnProtocol")]
        [System.Obsolete]
        public string SslVpnProtocol{ get; set; }

        /// <summary>
        /// <p>SSL VPN服务端监听协议端口。</p>
        /// </summary>
        [JsonProperty("SslVpnPort")]
        public long? SslVpnPort{ get; set; }

        /// <summary>
        /// <p>加密算法。可选值 &#39;AES-128-CBC&#39;, &#39;AES-192-CBC&#39;, &#39;AES-256-CBC&#39;, &#39;AES-128-GCM&#39;, &#39;AES-192-GCM&#39;, &#39;AES-256-GCM&#39;, 默认AES-128-CBC。</p>
        /// </summary>
        [JsonProperty("EncryptAlgorithm")]
        public string EncryptAlgorithm{ get; set; }

        /// <summary>
        /// <p>认证算法。可选 &#39;SHA1&#39;, &#39;MD5&#39;, &#39;SHA224&#39;, &#39;SHA256&#39;, &#39;SHA384&#39;, &#39;SHA512&#39;，默认SHA1。</p>
        /// </summary>
        [JsonProperty("IntegrityAlgorithm")]
        public string IntegrityAlgorithm{ get; set; }

        /// <summary>
        /// <p>是否支持压缩。当前不支持压缩。默认False。</p>
        /// </summary>
        [JsonProperty("Compress")]
        public bool? Compress{ get; set; }

        /// <summary>
        /// <p>是否开启SSO认证。默认为False。该功能当前需要申请开白使用。</p>
        /// </summary>
        [JsonProperty("SsoEnabled")]
        public bool? SsoEnabled{ get; set; }

        /// <summary>
        /// <p>SAML-DATA</p>
        /// </summary>
        [JsonProperty("SamlData")]
        public string SamlData{ get; set; }

        /// <summary>
        /// <p>DNS Server地址</p>
        /// </summary>
        [JsonProperty("DnsServers")]
        public DnsServers DnsServers{ get; set; }


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
            this.SetParamObj(map, prefix + "DnsServers.", this.DnsServers);
        }
    }
}

