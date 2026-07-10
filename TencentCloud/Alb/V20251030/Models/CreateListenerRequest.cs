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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// 默认转发规则动作列表。目前监听器仅支持添加 1 个默认转发规则动作。
        /// </summary>
        [JsonProperty("DefaultActions")]
        public DefaultAction[] DefaultActions{ get; set; }

        /// <summary>
        /// 负载均衡实例前端使用的端口。  取值：1~65535。
        /// </summary>
        [JsonProperty("ListenerPort")]
        public ulong? ListenerPort{ get; set; }

        /// <summary>
        /// 监听协议。  取值：HTTP、HTTPS 或 QUIC。
        /// </summary>
        [JsonProperty("ListenerProtocol")]
        public string ListenerProtocol{ get; set; }

        /// <summary>
        /// 负载均衡实例 ID，格式为 alb- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 监听器配置的CA证书ID列表。目前监听器仅支持添加 1 个 CA 证书。
        /// 当 CaEnabled 参数取值为 true 时，此参数必填。
        /// </summary>
        [JsonProperty("CaCertificateIds")]
        public string[] CaCertificateIds{ get; set; }

        /// <summary>
        /// 是否开启双向认证。
        /// 取值：
        /// true：开启。
        /// false（默认值）：不开启。
        /// </summary>
        [JsonProperty("CaEnabled")]
        public bool? CaEnabled{ get; set; }

        /// <summary>
        /// 服务器证书 ID 列表。
        /// </summary>
        [JsonProperty("CertificateIds")]
        public string[] CertificateIds{ get; set; }

        /// <summary>
        /// 客户端Token，用于保证请求的幂等性。  
        /// 
        /// 从您的客户端生成一个参数值，确保不同请求间该参数值唯一。ClientToken只支持ASCII字符。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 是否开启Gzip压缩。取值:true(默认值):是。false:否
        /// </summary>
        [JsonProperty("GzipEnabled")]
        public bool? GzipEnabled{ get; set; }

        /// <summary>
        /// 是否开启HTTP/2特性。HTTP 协议默认 false，HTTPS 协议默认 true。只有 HTTPS 协议支持此参数。
        /// </summary>
        [JsonProperty("Http2Enabled")]
        public bool? Http2Enabled{ get; set; }

        /// <summary>
        /// 连接空闲超时时间。单位：秒。
        /// 取值范围：1~600。
        /// 默认值：15。
        /// 如果在超时时间内一直没有访问请求，负载均衡会断开当前连接，在下次请求到来时创建新的连接。
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// 自定义监听名称。  长度为 1~255 个字符，必须是中文和无害字符串中的字符，  可包含中文、字母、数字、短划线（-）、正斜线（/）、半角句号（.）、下划线（_）。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 请求超时时间。单位：秒。
        /// 取值：1~600。
        /// 默认值：60。
        /// 如果在超时时间内后端服务器没有返回响应，负载均衡将放弃等待，并给客户端返回HTTP 504错误码。
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// 安全策略 ID，格式为 tls- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("SecurityPolicyId")]
        public string SecurityPolicyId{ get; set; }

        /// <summary>
        /// 标签列表。最大支持20个。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// X-Forwarded-For配置
        /// </summary>
        [JsonProperty("XForwardedForConfig")]
        public XForwardedForConfig XForwardedForConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DefaultActions.", this.DefaultActions);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
            this.SetParamSimple(map, prefix + "ListenerProtocol", this.ListenerProtocol);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamArraySimple(map, prefix + "CaCertificateIds.", this.CaCertificateIds);
            this.SetParamSimple(map, prefix + "CaEnabled", this.CaEnabled);
            this.SetParamArraySimple(map, prefix + "CertificateIds.", this.CertificateIds);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "GzipEnabled", this.GzipEnabled);
            this.SetParamSimple(map, prefix + "Http2Enabled", this.Http2Enabled);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "SecurityPolicyId", this.SecurityPolicyId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "XForwardedForConfig.", this.XForwardedForConfig);
        }
    }
}

