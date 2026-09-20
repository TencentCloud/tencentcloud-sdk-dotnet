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

    public class DescribeAvailableOriginACLFamilyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>过滤条件，Filters.Values 的上限为 20。该参数不填写时，返回当前站点下所有可用版本。源站防护的 IP 段控制域包含标准控制域和精简控制域。标准控制域和精简控制域主要区别在于提供的回源 IP 网段数量差异，后者数量更少,但是使用上有限制，如需使用请联系技术支持。具体取值说明如下：<br>详细的过滤条件如下：<br>OriginACLFamily：按照控制域进行过滤；</p><li>gaz：标准全球可用区控制域；</li><li>mlc：标准中国大陆可用区控制域；</li><li>emc：标准全球(不含中国大陆)可用区控制域；</li><li>plat-gaz：精简全球可用区控制域；</li><li>plat-mlc：精简中国大陆可用区控制域；</li><li>plat-emc：精简全球(不含中国大陆)可用区控制域；</li><li>plat-specific-gaz：定制版控全球可用区制域；</li><li>plat-specific-mlc：定制版控中国大陆可用区控制域；</li><li>plat-specific-emc：定制版控全球（不含中国大陆）可用区控制域。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>分页查询偏移量，默认为 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>分页查询限制数目，默认值：20，最大值：100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

