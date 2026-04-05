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
        /// <p>名称，最大长度不能超过60个字节。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>地域。</p>
        /// </summary>
        [JsonProperty("EndpointGroupRegion")]
        public string EndpointGroupRegion{ get; set; }

        /// <summary>
        /// <p>终端节点配置。</p>
        /// </summary>
        [JsonProperty("EndpointConfigurations")]
        public EndpointConfigurations[] EndpointConfigurations{ get; set; }

        /// <summary>
        /// <p>检查协议。支持&#39;TCP&#39;, &#39;HTTP&#39;, &#39;HTTPS&#39;, &#39;PING&#39;, &#39;CUSTOM&#39;。</p>
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// <p>描述信息，最大长度不能超过100个字节。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>检查端口。</p>
        /// </summary>
        [JsonProperty("CheckPort")]
        public string CheckPort{ get; set; }

        /// <summary>
        /// <p>检查内容。</p>
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// <p>检查请求。</p>
        /// </summary>
        [JsonProperty("CheckSendContext")]
        public string CheckSendContext{ get; set; }

        /// <summary>
        /// <p>检查返回结果。</p>
        /// </summary>
        [JsonProperty("CheckRecvContext")]
        public string CheckRecvContext{ get; set; }

        /// <summary>
        /// <p>是否开启健康检查。</p>
        /// </summary>
        [JsonProperty("EnableHealthCheck")]
        public bool? EnableHealthCheck{ get; set; }

        /// <summary>
        /// <p>响应超时时间。</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>健康检查间隔。</p>
        /// </summary>
        [JsonProperty("HealthCheckInterval")]
        public ulong? HealthCheckInterval{ get; set; }

        /// <summary>
        /// <p>不健康阀值。</p>
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }

        /// <summary>
        /// <p>健康阈值。</p>
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// <p>回源协议。</p>
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// <p>检查域名。</p>
        /// </summary>
        [JsonProperty("CheckDomain")]
        public string CheckDomain{ get; set; }

        /// <summary>
        /// <p>检查URL。</p>
        /// </summary>
        [JsonProperty("CheckPath")]
        public string CheckPath{ get; set; }

        /// <summary>
        /// <p>请求方式。</p>
        /// </summary>
        [JsonProperty("CheckMethod")]
        public string CheckMethod{ get; set; }

        /// <summary>
        /// <p>状态检测码。</p>
        /// </summary>
        [JsonProperty("StatusMask")]
        public string[] StatusMask{ get; set; }

        /// <summary>
        /// <p>端口映射。</p>
        /// </summary>
        [JsonProperty("PortOverrides")]
        public PortOverride[] PortOverrides{ get; set; }

        /// <summary>
        /// <p>运用商类型。</p>
        /// </summary>
        [JsonProperty("IspType")]
        public string IspType{ get; set; }

        /// <summary>
        /// <p>HPPTS加密算法套件</p>
        /// </summary>
        [JsonProperty("CipherPolicyId")]
        public string CipherPolicyId{ get; set; }


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
        }
    }
}

