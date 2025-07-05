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

    public class L4Proxy : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 四层代理实例 ID。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 四层代理实例名称。
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// 四层代理实例的加速区域。 
        /// <li>mainland：中国大陆可用区；</li>
        /// <li>overseas： 全球可用区（不含中国大陆）；</li>
        ///  <li>global：全球可用区。</li>	
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 接入 CNAME。
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 开启固定 IP 后，该值会返回对应的接入 IP；未开启时，该值为空。
        /// </summary>
        [JsonProperty("Ips")]
        public string[] Ips{ get; set; }

        /// <summary>
        /// 四层代理实例状态。
        /// <li>online：已启用；</li>
        /// <li>offline：已停用；</li>
        /// <li>progress：部署中；</li>	
        /// <li>stopping：停用中；</li>
        /// <li>banned：已封禁；</li>
        /// <li>fail：部署失败/停用失败。</li>	
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 是否开启 IPv6 访问。 
        /// <li>on：开启；</li> 
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Ipv6")]
        public string Ipv6{ get; set; }

        /// <summary>
        /// 是否开启固定 IP。
        ///  <li>on：开启；</li> <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("StaticIp")]
        public string StaticIp{ get; set; }

        /// <summary>
        /// 是否开启中国大陆网络优化。
        ///  <li>on：开启</li> <li>off：关闭</li>
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public string AccelerateMainland{ get; set; }

        /// <summary>
        /// 安全防护配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DDosProtectionConfig")]
        public DDosProtectionConfig DDosProtectionConfig{ get; set; }

        /// <summary>
        /// 四层代理实例下的转发规则数量。
        /// </summary>
        [JsonProperty("L4ProxyRuleCount")]
        public long? L4ProxyRuleCount{ get; set; }

        /// <summary>
        /// 最新变更时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamArraySimple(map, prefix + "Ips.", this.Ips);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "StaticIp", this.StaticIp);
            this.SetParamSimple(map, prefix + "AccelerateMainland", this.AccelerateMainland);
            this.SetParamObj(map, prefix + "DDosProtectionConfig.", this.DDosProtectionConfig);
            this.SetParamSimple(map, prefix + "L4ProxyRuleCount", this.L4ProxyRuleCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

