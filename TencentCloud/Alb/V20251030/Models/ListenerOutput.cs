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

    public class ListenerOutput : AbstractModel
    {
        
        /// <summary>
        /// 是否开启双向认证。
        /// </summary>
        [JsonProperty("CaEnable")]
        public bool? CaEnable{ get; set; }

        /// <summary>
        /// 监听器实例的创建时间。格式：ISO 8601（例如 2025-01-01T08:30:00+08:00）
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否启用 Gzip 压缩。
        /// </summary>
        [JsonProperty("GzipEnabled")]
        public bool? GzipEnabled{ get; set; }

        /// <summary>
        /// 是否启用http2。
        /// </summary>
        [JsonProperty("Http2Enable")]
        public bool? Http2Enable{ get; set; }

        /// <summary>
        /// 空闲超时时间。
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public ulong? IdleTimeout{ get; set; }

        /// <summary>
        /// 监听器 ID，格式为 lst- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 监听器端口。
        /// </summary>
        [JsonProperty("ListenerPort")]
        public ulong? ListenerPort{ get; set; }

        /// <summary>
        /// 监听器协议。
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
        /// 监听器实例的最后变更时间。格式：ISO 8601（例如 2025-01-01T08:30:00+08:00）
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 请求超时时间。
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public ulong? RequestTimeout{ get; set; }

        /// <summary>
        /// 标签。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 安全策略 ID。
        /// </summary>
        [JsonProperty("TlsSecurityPolicyId")]
        public string TlsSecurityPolicyId{ get; set; }

        /// <summary>
        /// XForwardedFor配置。
        /// </summary>
        [JsonProperty("XForwardedForConfig")]
        public XForwardedForConfig XForwardedForConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaEnable", this.CaEnable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "GzipEnabled", this.GzipEnabled);
            this.SetParamSimple(map, prefix + "Http2Enable", this.Http2Enable);
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
            this.SetParamSimple(map, prefix + "ListenerProtocol", this.ListenerProtocol);
            this.SetParamSimple(map, prefix + "ListenerStatus", this.ListenerStatus);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RequestTimeout", this.RequestTimeout);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "TlsSecurityPolicyId", this.TlsSecurityPolicyId);
            this.SetParamObj(map, prefix + "XForwardedForConfig.", this.XForwardedForConfig);
        }
    }
}

