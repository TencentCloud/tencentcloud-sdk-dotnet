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

    public class EnableOriginACLRequest : AbstractModel
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
        /// <p>需要开启源站防护的七层加速域名列表，仅当参数 L7EnableMode 为 specific 时生效。本字段最多支持一次开启 200 个七层加速域名；当期望开启的域名个数超过 200 时，请联合使用 ModifyOriginACL 接口进行分片配置。</p>
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// <p>四层代理实例源站防护模式，默认值: specific。<li>all：<strong>自动纳入防护模式</strong>，站点内所有四层代理实例将自动加入到源站防护列表中，包含后续新增的四层代理实例资源；</li><li>specific：<strong>指定加入防护模式</strong>，需要人工指定期望加入到源站防护的四层代理实例（通过 L4ProxyIds 参数指定），未指定的资源不会加入到源站防护列表中，后续的防护资源调整可通过 ModifyOriginACL 接口进行。</li>注意：取值为 all 时，L4ProxyIds 请保留为空；当站点下四层代理实例数量超过 100 时，请先通过 specific 模式启用，剩余资源通过 ModifyOriginACL 接口启用后，再通过 ModifyOriginACL 接口切换为 all。</p>
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// <p>需要开启源站防护的四层代理实例列表，仅当参数 L4EnableMode 为 specific 时生效。本字段最多支持一次开启 100 个四层代理实例；当期望开启的四层代理实例个数超过 100 时，请联合使用 ModifyOriginACL 接口进行分片配置。</p>
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// <p>源站防护回源ACL控制域，不填则默认用标准全球控制域；可用控制域信息可以通过DescribeAvailableOriginACLFamily接口查询获得。<br>具体取值说明如下：</p><li>gaz：标准全球可用区控制域；</li><li>mlc：标准中国大陆可用区控制域；</li><li>emc：标准全球(不含中国大陆)可用区控制域；</li><li>plat-gaz：精简全球可用区控制域；</li><li>plat-mlc：精简中国大陆可用区控制域；</li><li>plat-emc：精简全球(不含中国大陆)可用区控制域；</li>
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
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamSimple(map, prefix + "L4EnableMode", this.L4EnableMode);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

