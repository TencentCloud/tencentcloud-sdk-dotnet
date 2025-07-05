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

    public class CreateApplicationProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 当 ProxyType=hostname 时，表示域名或子域名；
        /// 当 ProxyType=instance 时，表示代理名称。
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// 调度模式，取值有：
        /// <li>ip：表示Anycast IP调度；</li>
        /// <li>domain：表示CNAME调度。</li>
        /// </summary>
        [JsonProperty("PlatType")]
        public string PlatType{ get; set; }

        /// <summary>
        /// 是否开启安全，取值有：
        /// <li>0：关闭安全；</li>
        /// <li>1：开启安全。</li>
        /// </summary>
        [JsonProperty("SecurityType")]
        public long? SecurityType{ get; set; }

        /// <summary>
        /// 是否开启加速，取值有：
        /// <li>0：关闭加速；</li>
        /// <li>1：开启加速。</li>
        /// </summary>
        [JsonProperty("AccelerateType")]
        public long? AccelerateType{ get; set; }

        /// <summary>
        /// 四层代理模式，取值有： <li>instance：表示实例模式。</li>不填写使用默认值instance。
        /// </summary>
        [JsonProperty("ProxyType")]
        public string ProxyType{ get; set; }

        /// <summary>
        /// 会话保持时间，取值范围：30-3600，单位：秒。
        /// 不填写使用默认值600。
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// Ipv6 访问配置。
        /// 不填写表示关闭 Ipv6 访问。
        /// </summary>
        [JsonProperty("Ipv6")]
        public Ipv6 Ipv6{ get; set; }

        /// <summary>
        /// 规则详细信息。
        /// 不填写则不创建规则。
        /// </summary>
        [JsonProperty("ApplicationProxyRules")]
        public ApplicationProxyRule[] ApplicationProxyRules{ get; set; }

        /// <summary>
        /// 中国大陆加速优化配置。不填写表示关闭中国大陆加速优化。
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public AccelerateMainland AccelerateMainland{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "PlatType", this.PlatType);
            this.SetParamSimple(map, prefix + "SecurityType", this.SecurityType);
            this.SetParamSimple(map, prefix + "AccelerateType", this.AccelerateType);
            this.SetParamSimple(map, prefix + "ProxyType", this.ProxyType);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamObj(map, prefix + "Ipv6.", this.Ipv6);
            this.SetParamArrayObj(map, prefix + "ApplicationProxyRules.", this.ApplicationProxyRules);
            this.SetParamObj(map, prefix + "AccelerateMainland.", this.AccelerateMainland);
        }
    }
}

