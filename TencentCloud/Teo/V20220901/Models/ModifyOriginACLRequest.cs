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

    public class ModifyOriginACLRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>七层加速域名源站防护模式，默认值: specific。<li>all：<strong>自动纳入防护模式</strong>，站点内所有七层加速域名将自动加入到源站防护列表中，包含后续新增的七层加速域名；</li><li>specific：<strong>指定加入防护模式</strong>，需要人工指定期望加入到源站防护的七层加速域名（通过 L7Hosts 参数指定），未指定的资源不会加入到源站防护列表中，后续的防护资源调整可通过 ModifyOriginACL 接口进行。</li>注意：取值为 all 时，L7Hosts 请保留为空；当站点下七层加速域名数量超过 200 时，请先通过 specific 模式启用，剩余资源通过 ModifyOriginACL 接口启用后，再通过 ModifyOriginACL 接口切换为 all。</p>
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// <p>四层代理实例源站防护模式，默认值: specific。<li>all：<strong>自动纳入防护模式</strong>，站点内所有四层代理实例将自动加入到源站防护列表中，包含后续新增的四层代理实例资源；</li><li>specific：<strong>指定加入防护模式</strong>，需要人工指定期望加入到源站防护的四层代理实例（通过 L4ProxyIds 参数指定），未指定的资源不会加入到源站防护列表中，后续的防护资源调整可通过 ModifyOriginACL 接口进行。</li>注意：取值为 all 时，L4ProxyIds 请保留为空；当站点下四层代理实例数量超过 100 时，请先通过 specific 模式启用，剩余资源通过 ModifyOriginACL 接口启用后，再通过 ModifyOriginACL 接口切换为 all。</p>
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// <p>需要启用/关闭特定回源 IP 网段回源的实例。<br>注意：本参数仅适用于 <strong>指定加入防护模式</strong> 下的资源调整；当对应层级的源站防护模式为 all 时，该类型的资源列表由系统自动维护，本参数中请勿包含该类型的资源，如需手动调整，请先通过 L7EnableMode/L4EnableMode 将对应层级切换为 specific。</p>
        /// </summary>
        [JsonProperty("OriginACLEntities")]
        public OriginACLEntity[] OriginACLEntities{ get; set; }

        /// <summary>
        /// <p>源站防护回源ACL控制域，不填则默认不变；控制域信息可以通过DescribeAvailableOriginACLFamily接口查询获得。<br>具体取值说明如下：</p><li>gaz：标准全球可用区控制域；</li><li>mlc：标准中国大陆可用区控制域；</li><li>emc：标准全球(不含中国大陆)可用区控制域；</li><li>plat-gaz：精简全球可用区控制域；</li><li>plat-mlc：精简中国大陆可用区控制域；</li><li>plat-emc：精简全球(不含中国大陆)可用区控制域；</li>
        /// </summary>
        [JsonProperty("OriginACLFamily")]
        public string OriginACLFamily{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "L7EnableMode", this.L7EnableMode);
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArrayObj(map, prefix + "OriginACLEntities.", this.OriginACLEntities);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

