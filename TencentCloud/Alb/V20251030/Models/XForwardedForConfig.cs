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

    public class XForwardedForConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否通过 ALB-ID 头字段获取负载均衡实例ID。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XForwardedForAlbIdEnabled")]
        public bool? XForwardedForAlbIdEnabled{ get; set; }

        /// <summary>
        /// 是否通过X-Forwarded-Client-srcport头字段获取访问负载均衡实例客户端的端口。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XForwardedForClientSrcPortEnabled")]
        public bool? XForwardedForClientSrcPortEnabled{ get; set; }

        /// <summary>
        /// 是否开启通过X-Forwarded-Host头字段获取访问负载均衡实例客户端的域名。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XForwardedForHostEnabled")]
        public bool? XForwardedForHostEnabled{ get; set; }

        /// <summary>
        /// 指定如何处理 X-Forwarded-For（XFF）HTTP 头字段。
        /// - **append**:  附加模式（默认），将客户端的真实 IP 地址附加到 X-Forwarded-For 头的末尾，保留原有的 XFF 链路信息
        /// - **remove**:  删除模式，移除 X-Forwarded-For 头字段，不将该头传递给后端服务器
        /// - **passthrough**: 透传模式，保持 X-Forwarded-For 头不变，直接透传给后端服务器，不做任何修改
        /// </summary>
        [JsonProperty("XForwardedForMode")]
        public string XForwardedForMode{ get; set; }

        /// <summary>
        /// 是否通过X-Forwarded-Port头字段获取负载均衡实例的监听端口。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XForwardedForPortEnabled")]
        public bool? XForwardedForPortEnabled{ get; set; }

        /// <summary>
        /// 是否通过X-Forwarded-Proto头字段获取负载均衡实例的监听协议。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XForwardedForProtoEnabled")]
        public bool? XForwardedForProtoEnabled{ get; set; }

        /// <summary>
        /// 是否通过 X-Tencent-Client-IDN 头访问 客户端证书的颁发者 $ssl_client_i_dn。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XTencentClientIDNEnabled")]
        public bool? XTencentClientIDNEnabled{ get; set; }

        /// <summary>
        /// 是否通过 X-Tencent-Client-SDN 头访问客户端证书的主题$ssl_client_s_dn。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XTencentClientSDNEnabled")]
        public bool? XTencentClientSDNEnabled{ get; set; }

        /// <summary>
        /// 是否通过 X-Tencent-Client-Serial 头访问 客户端证书的序列号 $ssl_client_serial。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XTencentClientSerialEnabled")]
        public bool? XTencentClientSerialEnabled{ get; set; }

        /// <summary>
        /// 是通过 X-Tencent-Client-Verify 头访问 客户端证书的验证结果 $ssl_client_verify。
        /// - **true**：是。
        /// - **false**：否。
        /// </summary>
        [JsonProperty("XTencentClientVerifyEnabled")]
        public bool? XTencentClientVerifyEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "XForwardedForAlbIdEnabled", this.XForwardedForAlbIdEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForClientSrcPortEnabled", this.XForwardedForClientSrcPortEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForHostEnabled", this.XForwardedForHostEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForMode", this.XForwardedForMode);
            this.SetParamSimple(map, prefix + "XForwardedForPortEnabled", this.XForwardedForPortEnabled);
            this.SetParamSimple(map, prefix + "XForwardedForProtoEnabled", this.XForwardedForProtoEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientIDNEnabled", this.XTencentClientIDNEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientSDNEnabled", this.XTencentClientSDNEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientSerialEnabled", this.XTencentClientSerialEnabled);
            this.SetParamSimple(map, prefix + "XTencentClientVerifyEnabled", this.XTencentClientVerifyEnabled);
        }
    }
}

