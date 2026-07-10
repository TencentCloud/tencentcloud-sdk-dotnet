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

    public class DescribeListenerDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 监听器绑定的CA证书ID列表。
        /// </summary>
        [JsonProperty("CaCertificateIds")]
        public string[] CaCertificateIds{ get; set; }

        /// <summary>
        /// 是否开启双向认证。
        /// </summary>
        [JsonProperty("CaEnabled")]
        public bool? CaEnabled{ get; set; }

        /// <summary>
        /// 服务器证书 ID 列表。
        /// </summary>
        [JsonProperty("CertificateIds")]
        public string[] CertificateIds{ get; set; }

        /// <summary>
        /// 监听器实例的创建时间。格式：ISO 8601（例如 2025-01-01T08:30:00+08:00）
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 规则动作列表。
        /// </summary>
        [JsonProperty("DefaultActions")]
        public DefaultAction[] DefaultActions{ get; set; }

        /// <summary>
        /// 是否启用 Gzip 压缩。
        /// </summary>
        [JsonProperty("GzipEnabled")]
        public bool? GzipEnabled{ get; set; }

        /// <summary>
        /// 是否开启HTTP/2特性。
        /// </summary>
        [JsonProperty("Http2Enabled")]
        public bool? Http2Enabled{ get; set; }

        /// <summary>
        /// 指定连接空闲超时时间。单位：秒。
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// 监听器 ID，格式为 lst- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 自定义监听名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 负载均衡实例前端使用的端口。
        /// </summary>
        [JsonProperty("ListenerPort")]
        public ulong? ListenerPort{ get; set; }

        /// <summary>
        /// 监听协议。
        /// </summary>
        [JsonProperty("ListenerProtocol")]
        public string ListenerProtocol{ get; set; }

        /// <summary>
        /// 监听器状态。取值:=
        /// 
        /// - **Active**: 运行中。
        /// - **Provisioning**：创建中。
        /// - **Configuring**：变配中。
        /// - **ProvisionFailed**：创建失败
        /// </summary>
        [JsonProperty("ListenerStatus")]
        public string ListenerStatus{ get; set; }

        /// <summary>
        /// 负载均衡实例 ID，格式为 alb- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 监听器实例的最后变更时间。格式：ISO 8601（例如 2025-01-01T08:30:00+08:00）
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 请求超时时间。单位：秒。
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// 安全策略 ID，格式为 tls- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("SecurityPolicyId")]
        public string SecurityPolicyId{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// XForwardedFor配置。
        /// </summary>
        [JsonProperty("XForwardedForConfig")]
        public XForwardedForConfig XForwardedForConfig{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CaCertificateIds.", this.CaCertificateIds);
            this.SetParamSimple(map, prefix + "CaEnabled", this.CaEnabled);
            this.SetParamArraySimple(map, prefix + "CertificateIds.", this.CertificateIds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "DefaultActions.", this.DefaultActions);
            this.SetParamSimple(map, prefix + "GzipEnabled", this.GzipEnabled);
            this.SetParamSimple(map, prefix + "Http2Enabled", this.Http2Enabled);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
            this.SetParamSimple(map, prefix + "ListenerProtocol", this.ListenerProtocol);
            this.SetParamSimple(map, prefix + "ListenerStatus", this.ListenerStatus);
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamSimple(map, prefix + "SecurityPolicyId", this.SecurityPolicyId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "XForwardedForConfig.", this.XForwardedForConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

