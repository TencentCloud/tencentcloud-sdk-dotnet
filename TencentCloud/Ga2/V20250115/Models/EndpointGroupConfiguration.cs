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

    public class EndpointGroupConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>终端节点组名称。</p><p>最大长度不能超过128个字节。必须以字母（a-z, A-Z）或中文字符开头。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>终端节点组所在地域。</p>
        /// </summary>
        [JsonProperty("EndpointGroupRegion")]
        public string EndpointGroupRegion{ get; set; }

        /// <summary>
        /// <p>终端节点配置。</p>
        /// </summary>
        [JsonProperty("EndpointConfigurations")]
        public EndpointConfigurations[] EndpointConfigurations{ get; set; }

        /// <summary>
        /// <p>检查协议。支持配置&#39;TCP&#39;, &#39;HTTP&#39;, &#39;PING&#39;, &#39;CUSTOM&#39;。</p><p>枚举值：</p><ul><li>TCP： 当终端节点组所在监听器协议是TCP时，可以选择检查协议为TCP。</li><li>HTTP： 当终端节点组所在监听器协议是HTTP或HTTPS时，可以选择检查协议为HTTP。</li><li>PING： 当终端节点组所在监听器协议是UDP时，可以选择检查协议为PING。</li><li>CUSTOM： 当终端节点组所在监听器协议是UDP或TCP时，可以选择检查协议为CUSTOM。</li></ul><p>当开启健康检查时此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// <p>描述信息。</p><p>默认值：默认值为空，代表不配置描述信息。</p><p>最大长度不能超过100个字节。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>检查端口。</p><p>入参限制：范围是1-65535。</p><p>当CheckType为CUSTOM时候，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckPort")]
        public string CheckPort{ get; set; }

        /// <summary>
        /// <p>检查内容。支持配置&#39;TEXT&#39;。</p><p>枚举值：</p><ul><li>TEXT： 文本内容。</li></ul><p>当CheckType为CUSTOM时候，此字段必传。</p>
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// <p>检查请求。</p><p>入参限制：字节长度要在1-500范围内。</p><p>当CheckType为CUSTOM时候，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckSendContext")]
        public string CheckSendContext{ get; set; }

        /// <summary>
        /// <p>检查返回结果。</p><p>入参限制：字节长度要在1-500范围内。</p><p>当CheckType为CUSTOM时候，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckRecvContext")]
        public string CheckRecvContext{ get; set; }

        /// <summary>
        /// <p>是否开启健康检查。</p><p>默认值：False</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>响应超时时间。</p><p>取值范围：[1, 100]</p><p>默认值：2</p><p>开启健康检查时，此字段必传。</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>健康检查间隔。</p><p>取值范围：[5, 300]</p><p>默认值：30</p><p>开启健康检查，此字段必传。</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>不健康阀值。</p><p>取值范围：[1, 10]</p><p>默认值：3</p><p>开启健康检查，此字段必传。</p>
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }

        /// <summary>
        /// <p>健康阈值。</p><p>取值范围：[1, 10]</p><p>默认值：3</p><p>开启健康检查，此字段必传。</p>
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// <p>回源协议。支持配置&#39;HTTP&#39;, &#39;HTTPS&#39;。</p><p>枚举值：</p><ul><li>HTTP： HTTP回源；当终端节点组所在监听器协议是HTTP或HTTPS时可以配置HTTP。</li><li>HTTPS： HTTPS回源；当终端节点组所在监听器协议是HTTPS时可以配置HTTPS。</li></ul><p>当终端节点组所在监听器协议为HTTP或HTTPS时候，此字段必传。</p>
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// <p>检查域名。</p><p>入参限制：字节长度范围是3-80。</p><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckDomain")]
        public string CheckDomain{ get; set; }

        /// <summary>
        /// <p>检查URL。</p><p>参数格式：必须满足正则：^[a-zA-Z0-9_.\-\/]{1,80}$</p><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckPath")]
        public string CheckPath{ get; set; }

        /// <summary>
        /// <p>请求方式。支持配置&#39;GET&#39;, &#39;HEAD&#39;。</p><p>枚举值：</p><ul><li>GET： 请求方式为GET。</li><li>HEAD： 请求方式为HEAD。</li></ul><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>状态检测码。支持配置&#39;http_2xx&#39;, &#39;http_3xx&#39;, &#39;http_4xx&#39;, &#39;http_5xx&#39;。</p><p>枚举值：</p><ul><li>http_2xx： 2开头的http code。</li><li>http_3xx： 3开头的http code。</li><li>http_4xx： 4开头的http code。</li><li>http_5xx： 5开头的http code。</li></ul><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("StatusMask")]
        public string[] StatusMask{ get; set; }

        /// <summary>
        /// <p>端口映射。</p><p>入参限制：七层支持1个端口映射，四层支持最多30个端口映射。</p>
        /// </summary>
        [JsonProperty("PortOverrides")]
        public PortOverride[] PortOverrides{ get; set; }

        /// <summary>
        /// <p>运营商类型。支持配置&#39;CMCC&#39;, &#39;CTCC&#39;, &#39;CUCC&#39;。</p><p>枚举值：</p><ul><li>CMCC： 中国移动</li><li>CUCC： 中国联通</li><li>CTCC： 中国电信</li></ul><p>当终端节点组地域为三网地域时，此字段必传。</p>
        /// </summary>
        [JsonProperty("IspType")]
        public string IspType{ get; set; }

        /// <summary>
        /// <p>HPPTS加密算法套件；支持配置&#39;tls_policy_1.0-2&#39;, &#39;tls_policy_1.1-2&#39;, &#39;tls_policy_1.2&#39;, &#39;tls_policy_1.2_strict&#39;, &#39;tls_policy_1.2_strict-1.3&#39;；</p><p>枚举值：</p><ul><li>tls_policy_1.0-2： 加密算法套件。</li><li>tls_policy_1.1-2： 加密算法套件。</li><li>tls_policy_1.2： 加密算法套件。</li><li>tls_policy_1.2_strict： 加密算法套件。</li><li>tls_policy_1.2_strict-1.3： 加密算法套件。</li></ul><p>当回源协议为HTTPS，此字段必传。</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>回源协议。支持配置&#39;HTTP/1.1&#39;, &#39;HTTP/2&#39;。</p><p>枚举值：</p><ul><li>HTTP/1.1： 版本HTTP/1.1</li><li>HTTP/2： 版本HTTP/2</li></ul><p>当回源协议为HTTPS时，此字段必传。</p>
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "EndpointGroupRegion", this.EndpointGroupRegion);
            this.SetParamArrayObj(map, prefix + "EndpointConfigurations.", this.EndpointConfigurations);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "CheckSendContext", this.CheckSendContext);
            this.SetParamSimple(map, prefix + "CheckRecvContext", this.CheckRecvContext);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "UnhealthyThreshold", this.UnhealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthyThreshold", this.HealthyThreshold);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "CheckDomain", this.CheckDomain);
            this.SetParamSimple(map, prefix + "CheckPath", this.CheckPath);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamArraySimple(map, prefix + "StatusMask.", this.StatusMask);
            this.SetParamArrayObj(map, prefix + "PortOverrides.", this.PortOverrides);
            this.SetParamSimple(map, prefix + "IspType", this.IspType);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
        }
    }
}

