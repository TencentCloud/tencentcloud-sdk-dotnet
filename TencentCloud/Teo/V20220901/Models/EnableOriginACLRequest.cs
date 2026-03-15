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
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 站点首次开启源站防护时，为七层加速域名配置特定回源 IP 网段的模式。
        /// <li>all：针对当前站点下的所有七层加速域名开启，当域名数量超过 200 时，请先通过 specific 模式启用 200 个域名，剩余资源通过 ModifyOriginACL 接口启用。</li>
        /// <li>specific：针对站点下指定的七层加速域名开启。</li>注意：当参数为空时，默认为 specific。后续新增七层加速域名/四层代理实例均请通过 ModifyOriginACL 接口配置。
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// 开启源站防护的七层加速域名列表，仅当参数 L7EnableMode 为 specific 时生效。L7EnableMode 为 all 时，请保留此参数为空。单次最大仅支持填写 200 个七层加速域名。
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// 站点首次开启源站防护时，为四层代理实例配置特定回源 IP 网段的模式。
        /// <li>all：针对当前站点下的所有四层代理实例开启，当实例数量超过 100 时，请先通过 specific 模式启用 100 个域名，剩余资源通过 ModifyOriginACL 接口启用。</li>
        /// <li>specific：针对站点下指定的四层代理实例开启。</li>注意：当参数为空时，默认为 specific。后续新增七层加速域名/四层代理实例均请通过 ModifyOriginACL 接口配置。
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// 开启源站防护的四层代理实例列表，仅当参数 L4EnableMode 为 specific 时生效。L4EnableMode 为 all 时，请保留此参数为空。单次最大仅支持填写 100 个四层代理实例。
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// 源站防护回源ACL控制域，不填则默认用标准全球控制域；可用控制域信息可以通过DescribeAvailableOriginACLFamily接口查询获得。
        /// 具体取值说明如下：
        /// <li>gaz：标准全球可用区控制域；</li>
        /// <li>mlc：标准中国大陆可用区控制域；</li>
        /// <li>emc：标准全球(不含中国大陆)可用区控制域；</li>
        /// <li>plat-gaz：精简全球可用区控制域；</li>
        /// <li>plat-mlc：精简中国大陆可用区控制域；</li>
        /// <li>plat-emc：精简全球(不含中国大陆)可用区控制域；</li>
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

