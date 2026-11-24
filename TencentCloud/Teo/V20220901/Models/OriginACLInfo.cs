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

    public class OriginACLInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>七层加速域名源站防护模式，取值有：<li>all：自动纳入防护模式，站点内所有七层加速域名已纳入源站防护列表，包含后续新增的七层加速域名；</li><li>specific：指定加入防护模式，仅防护已绑定的七层加速域名。</li></p>
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// <p>启用了特定回源 IP 网段回源的七层加速域名列表。源站防护未开启时为空。</p>
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// <p>四层代理实例源站防护模式，取值有：<li>all：自动纳入防护模式，站点内所有四层代理实例已纳入源站防护列表，包含后续新增的四层代理实例；</li><li>specific：指定加入防护模式，仅防护已绑定的四层代理实例。</li></p>
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// <p>启用了特定回源 IP 网段回源的四层代理实例列表。源站防护未开启时为空。</p>
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// <p>当前生效的回源 IP 网段。源站防护未开启时为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentOriginACL")]
        public CurrentOriginACL CurrentOriginACL{ get; set; }

        /// <summary>
        /// <p>当回源 IP 网段发生更新时，该字段会返回下一个版本将要生效的回源 IP 网段，包含与当前回源 IP 网段的对比。无更新或者源站防护未开启时该字段为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextOriginACL")]
        public NextOriginACL NextOriginACL{ get; set; }

        /// <summary>
        /// <p>源站防护状态，取值有：</p><li>online：已生效；</li><li>offline：已停用；</li><li>updating: 配置部署中。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>源站防护回源ACL控制域。</p>
        /// </summary>
        [JsonProperty("OriginACLFamily")]
        public string OriginACLFamily{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "L7EnableMode", this.L7EnableMode);
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
            this.SetParamObj(map, prefix + "CurrentOriginACL.", this.CurrentOriginACL);
            this.SetParamObj(map, prefix + "NextOriginACL.", this.NextOriginACL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

