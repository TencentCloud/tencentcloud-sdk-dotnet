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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficMirrorListener : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 七层监听器协议类型，可选值：http,https。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 监听器的监听端口。
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public ulong? LoadBalancerPort{ get; set; }

        /// <summary>
        /// 当前带宽。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 带宽上限。
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public ulong? MaxBandwidth{ get; set; }

        /// <summary>
        /// 监听器类型。
        /// </summary>
        [JsonProperty("ListenerType")]
        public string ListenerType{ get; set; }

        /// <summary>
        /// 认证方式：0（不认证，用于http），1（单向认证，用于https），2（双向认证，用于https）。
        /// </summary>
        [JsonProperty("SslMode")]
        public long? SslMode{ get; set; }

        /// <summary>
        /// 服务端证书ID。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 客户端证书ID。
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// 添加时间。
        /// </summary>
        [JsonProperty("AddTimestamp")]
        public string AddTimestamp{ get; set; }

        /// <summary>
        /// 负载均衡ID。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 私有网络名称。
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 私有网络Cidr。
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 负载均衡的VIP。
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// 负载均衡名称。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 负载均衡的IPV6的VIP。
        /// </summary>
        [JsonProperty("LoadBalancerVipv6s")]
        public string[] LoadBalancerVipv6s{ get; set; }

        /// <summary>
        /// 支持的IP协议类型。ipv4或者是ipv6。
        /// </summary>
        [JsonProperty("IpProtocolType")]
        public string IpProtocolType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "LoadBalancerPort", this.LoadBalancerPort);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamSimple(map, prefix + "ListenerType", this.ListenerType);
            this.SetParamSimple(map, prefix + "SslMode", this.SslMode);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamSimple(map, prefix + "AddTimestamp", this.AddTimestamp);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVipv6s.", this.LoadBalancerVipv6s);
            this.SetParamSimple(map, prefix + "IpProtocolType", this.IpProtocolType);
        }
    }
}

