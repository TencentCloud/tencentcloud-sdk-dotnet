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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>全球加速实例ID。</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>名称，最大长度不能超过60个字节。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>端口范围。</p>
        /// </summary>
        [JsonProperty("PortRanges")]
        public PortRanges PortRanges{ get; set; }

        /// <summary>
        /// <p>描述信息，最大长度不能超过100个字节。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>监听类型，默认为智能路由。</p>
        /// </summary>
        [JsonProperty("ListenerType")]
        public string ListenerType{ get; set; }

        /// <summary>
        /// <p>协议，默认为TCP。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>连接空闲等待时间。</p>
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// <p>四层获取源IP方式，支持&#39;TOA&#39;, &#39;ProxyProtocol&#39;。</p>
        /// </summary>
        [JsonProperty("GetRealIpType")]
        public string GetRealIpType{ get; set; }

        /// <summary>
        /// <p>是否开启会话保持。</p>
        /// </summary>
        [JsonProperty("ClientAffinity")]
        public string ClientAffinity{ get; set; }

        /// <summary>
        /// <p>请求超时时间。</p>
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// <p>是否打开七层获取源IP方式。</p>
        /// </summary>
        [JsonProperty("XForwardedForRealIp")]
        public bool? XForwardedForRealIp{ get; set; }

        /// <summary>
        /// <p>解析方式。UNIDIRECTIONAL：双向。MUTUAL：单向。</p>
        /// </summary>
        [JsonProperty("CertificationType")]
        public string CertificationType{ get; set; }

        /// <summary>
        /// <p>加密算法套件。</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>服务器证书。</p>
        /// </summary>
        [JsonProperty("ServerCertificates")]
        public string[] ServerCertificates{ get; set; }

        /// <summary>
        /// <p>客户端证书。</p>
        /// </summary>
        [JsonProperty("ClientCaCertificates")]
        public string[] ClientCaCertificates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "PortRanges.", this.PortRanges);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ListenerType", this.ListenerType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "GetRealIpType", this.GetRealIpType);
            this.SetParamSimple(map, prefix + "ClientAffinity", this.ClientAffinity);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "XForwardedForRealIp", this.XForwardedForRealIp);
            this.SetParamSimple(map, prefix + "CertificationType", this.CertificationType);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamArraySimple(map, prefix + "ServerCertificates.", this.ServerCertificates);
            this.SetParamArraySimple(map, prefix + "ClientCaCertificates.", this.ClientCaCertificates);
        }
    }
}

