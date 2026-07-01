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

    public class ModifyEndpointGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>全球加速实例ID。</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>监听器ID。</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>终端节点组ID。</p>
        /// </summary>
        [JsonProperty("EndpointGroupId")]
        public string EndpointGroupId{ get; set; }

        /// <summary>
        /// <p>终端节点配置。</p>
        /// </summary>
        [JsonProperty("EndpointConfigurations")]
        public EndpointConfigurations[] EndpointConfigurations{ get; set; }

        /// <summary>
        /// <p>名称。</p><p>入参限制：最大长度不能超过128个字节。</p><p>以大小写字母或中文开头。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>描述信息。</p><p>入参限制：最大长度不能超过100个字节。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>是否开启健康检查。</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>响应超时时间。</p><p>取值范围：[1, 100]</p><p>当开启健康检查时候，此参数必传。</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>健康检查间隔。</p><p>取值范围：[5, 300]</p><p>当开启健康检查时，此参数必传。</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>不健康阀值。</p><p>取值范围：[1, 10]</p><p>当开启健康检查时，此字段必传。</p>
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }

        /// <summary>
        /// <p>健康阀值。</p><p>取值范围：[1, 10]</p><p>当开启健康检查时，此字段必传。</p>
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// <p>检查协议。</p><p>入参限制：支持填写：&#39;TCP&#39;, &#39;HTTP&#39;, &#39;PING&#39;, &#39;CUSTOM&#39;。</p><p>1、当监听器是TCP时，可以选CUSTOM+TCP。<br>2、当监听器是UDP时，可以选PING+CUSTOM。<br>3、当监听器是HTTP或HTTPS时，可以选HTTP。</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// <p>检查端口。</p><p>取值范围：[1, 65535]</p><p>当CheckType是CUSTOM时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckPort")]
        public ulong? CheckPort{ get; set; }

        /// <summary>
        /// <p>检查内容。</p><p>入参限制：仅支持TEXT。</p><p>当CheckType是CUSTOM时，此字段必传。</p>
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// <p>检查请求。</p><p>入参限制：长度范围在1-500。</p><p>当CheckType是CUSTOM时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckSendContext")]
        public string CheckSendContext{ get; set; }

        /// <summary>
        /// <p>检查返回结果。</p><p>入参限制：长度范围在1-500。</p><p>当CheckType是CUSTOM时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckRecvContext")]
        public string CheckRecvContext{ get; set; }

        /// <summary>
        /// <p>检查域名。</p><p>入参限制：长度范围在3-80。</p><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckDomain")]
        public string CheckDomain{ get; set; }

        /// <summary>
        /// <p>检查URL。</p><p>入参限制：长度范围在3-80。</p><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckPath")]
        public string CheckPath{ get; set; }

        /// <summary>
        /// <p>请求方式。</p><p>入参限制：支持填写 &#39;GET&#39;, &#39;HEAD&#39;。</p><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>状态检测码。</p><p>入参限制：支持选择&#39;http_2xx&#39;, &#39;http_3xx&#39;, &#39;http_4xx&#39;, &#39;http_5xx&#39;。</p><p>当CheckType是HTTP时，此字段必传。</p>
        /// </summary>
        [JsonProperty("StatusMask")]
        public string[] StatusMask{ get; set; }

        /// <summary>
        /// <p>回源协议。</p><p>入参限制：支持选择：&#39;HTTP&#39;, &#39;HTTPS&#39;。</p><p>当监听器协议是HTTP时只能配置HTTP，是HTTPS时能配HTTP或HTTPS。</p>
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// <p>端口映射。</p><p>当监听器协议是HTTP或HTTPS支持配置一对。当监听器协议是UDP或TCP支持配置最多30对。</p>
        /// </summary>
        [JsonProperty("PortOverrides")]
        public PortOverride[] PortOverrides{ get; set; }

        /// <summary>
        /// <p>HPPTS加密算法套件</p><p>入参限制：支持选择&#39;tls_policy_1.0-2&#39;, &#39;tls_policy_1.1-2&#39;, &#39;tls_policy_1.2&#39;, &#39;tls_policy_1.2_strict&#39;, &#39;tls_policy_1.2_strict-1.3&#39;。</p><p>当监听器协议是HTTPS时，才支持修改此参数。</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }

        /// <summary>
        /// <p>仅HTTPS回源协议支持选择[&#39;HTTP/1.1&#39;, &#39;HTTP/2&#39;]</p><p>枚举值：</p><ul><li>HTTP/1.1： 版本HTTP/1.1</li><li>HTTP/2： 版本HTTP/2</li></ul>
        /// </summary>
        [JsonProperty("HttpVersion")]
        public string HttpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "EndpointGroupId", this.EndpointGroupId);
            this.SetParamArrayObj(map, prefix + "EndpointConfigurations.", this.EndpointConfigurations);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnableHealthCheck", this.EnableHealthCheck);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "HealthCheckInterval", this.HealthCheckInterval);
            this.SetParamSimple(map, prefix + "UnhealthyThreshold", this.UnhealthyThreshold);
            this.SetParamSimple(map, prefix + "HealthyThreshold", this.HealthyThreshold);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "CheckSendContext", this.CheckSendContext);
            this.SetParamSimple(map, prefix + "CheckRecvContext", this.CheckRecvContext);
            this.SetParamSimple(map, prefix + "CheckDomain", this.CheckDomain);
            this.SetParamSimple(map, prefix + "CheckPath", this.CheckPath);
            this.SetParamSimple(map, prefix + "CheckMethod", this.CheckMethod);
            this.SetParamArraySimple(map, prefix + "StatusMask.", this.StatusMask);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamArrayObj(map, prefix + "PortOverrides.", this.PortOverrides);
            this.SetParamSimple(map, prefix + "CipherPolicyId", this.CipherPolicyId);
            this.SetParamSimple(map, prefix + "HttpVersion", this.HttpVersion);
        }
    }
}

