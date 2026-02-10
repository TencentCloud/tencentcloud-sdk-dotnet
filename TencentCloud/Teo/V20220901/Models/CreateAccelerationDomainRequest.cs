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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccelerationDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 加速域名所属站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 加速域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 源站信息。
        /// </summary>
        [JsonProperty("OriginInfo")]
        public OriginInfo OriginInfo{ get; set; }

        /// <summary>
        /// 回源协议，取值有：
        /// <li>FOLLOW：协议跟随；</li>
        /// <li>HTTP：HTTP 协议回源；</li>
        /// <li>HTTPS：HTTPS 协议回源。</li>不填默认为：FOLLOW。
        /// </summary>
        [JsonProperty("OriginProtocol")]
        public string OriginProtocol{ get; set; }

        /// <summary>
        /// HTTP 回源端口，默认值80，取值：1～65535。
        /// 当 OriginProtocol = FOLLOW 或 HTTP 时生效。
        /// </summary>
        [JsonProperty("HttpOriginPort")]
        public ulong? HttpOriginPort{ get; set; }

        /// <summary>
        /// HTTPS 回源端口，默认值443，取值：1～65535。
        /// 当 OriginProtocol = FOLLOW 或 HTTPS 时生效。
        /// </summary>
        [JsonProperty("HttpsOriginPort")]
        public ulong? HttpsOriginPort{ get; set; }

        /// <summary>
        /// IPv6 状态，取值有：
        /// <li>follow：遵循站点 IPv6 配置；</li>
        /// <li>on：开启状态；</li>
        /// <li>off：关闭状态。</li>不填默认为：follow。
        /// </summary>
        [JsonProperty("IPv6Status")]
        public string IPv6Status{ get; set; }

        /// <summary>
        /// 指定域名绑定的共享 CNAME 地址，不传时使用默认 CNAME。
        /// 绑定共享 CNAME 要求所有域名的调度策略保持一致，以下配置将影响调度策略，在不一致时绑定共享 CNAME 将按照以下方式处理：
        /// - IPv6 访问：不允许创建域名，请修改 IPv6Status 已保持与共享 CNAME 绑定的其余域名配置一致；
        /// - DDoS 防护：如果选择的共享 CNAME 已启用 DDoS 防护，则创建域名时，将默认为该域名启用 DDoS 防护。
        /// - 中国大陆网络优化（国际加速）：不允许创建域名，请保持当前域名的中国大陆网络优化（国际加速）配置与共享 CNAME 绑定的其余域名一致后重试。
        /// 
        /// 注：共享 CNAME 当前仍在内测中，如需使用，请联系我们开通。
        /// </summary>
        [JsonProperty("SharedCNAME")]
        public string SharedCNAME{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamObj(map, prefix + "OriginInfo.", this.OriginInfo);
            this.SetParamSimple(map, prefix + "OriginProtocol", this.OriginProtocol);
            this.SetParamSimple(map, prefix + "HttpOriginPort", this.HttpOriginPort);
            this.SetParamSimple(map, prefix + "HttpsOriginPort", this.HttpsOriginPort);
            this.SetParamSimple(map, prefix + "IPv6Status", this.IPv6Status);
            this.SetParamSimple(map, prefix + "SharedCNAME", this.SharedCNAME);
        }
    }
}

