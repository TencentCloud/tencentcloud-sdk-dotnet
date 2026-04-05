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

    public class ListenerSet : AbstractModel
    {
        
        /// <summary>
        /// 全球加速实例ID。
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// 监听器ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 监听器名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 监听器描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 协议。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口范围。
        /// </summary>
        [JsonProperty("PortRanges")]
        public PortRanges PortRanges{ get; set; }

        /// <summary>
        /// 是否打开七层获取源IP方式。
        /// </summary>
        [JsonProperty("XForwardedForRealIp")]
        public bool? XForwardedForRealIp{ get; set; }

        /// <summary>
        /// 开启会话保持。
        /// </summary>
        [JsonProperty("ClientAffinity")]
        public string ClientAffinity{ get; set; }

        /// <summary>
        /// 会话保持时间。
        /// </summary>
        [JsonProperty("ClientAffinityTime")]
        public ulong? ClientAffinityTime{ get; set; }

        /// <summary>
        /// SSL解析方式。
        /// </summary>
        [JsonProperty("CertificationType")]
        public string CertificationType{ get; set; }

        /// <summary>
        /// 服务器证书。
        /// </summary>
        [JsonProperty("ServerCertificates")]
        public string[] ServerCertificates{ get; set; }

        /// <summary>
        /// 客户端证书。
        /// </summary>
        [JsonProperty("ClientCaCertificates")]
        public string[] ClientCaCertificates{ get; set; }

        /// <summary>
        /// TLS密码套件包。
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// HTTP版本。
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }

        /// <summary>
        /// 请求超时时间。
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 监听路由类型。
        /// </summary>
        [JsonProperty("ListenerType")]
        public string ListenerType{ get; set; }

        /// <summary>
        /// 监听器状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 所属监听器终端节点组个数。
        /// </summary>
        [JsonProperty("EndpointGroupCounts")]
        public ulong? EndpointGroupCounts{ get; set; }

        /// <summary>
        /// 四层获取源IP方式。
        /// </summary>
        [JsonProperty("GetRealIpType")]
        public string GetRealIpType{ get; set; }

        /// <summary>
        /// 连接超时时间。
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "PortRanges.", this.PortRanges);
            this.SetParamSimple(map, prefix + "XForwardedForRealIp", this.XForwardedForRealIp);
            this.SetParamSimple(map, prefix + "ClientAffinity", this.ClientAffinity);
            this.SetParamSimple(map, prefix + "ClientAffinityTime", this.ClientAffinityTime);
            this.SetParamSimple(map, prefix + "CertificationType", this.CertificationType);
            this.SetParamArraySimple(map, prefix + "ServerCertificates.", this.ServerCertificates);
            this.SetParamArraySimple(map, prefix + "ClientCaCertificates.", this.ClientCaCertificates);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ListenerType", this.ListenerType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EndpointGroupCounts", this.EndpointGroupCounts);
            this.SetParamSimple(map, prefix + "GetRealIpType", this.GetRealIpType);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
        }
    }
}

