/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// 七层加速域名开启源站防护的模式。
        /// <li>all：针对站点下的所有七层加速域名开启。</li>
        /// <li>specific：针对站点下指定的七层加速域名开启。</li>当参数为空时，默认为 specific。
        /// </summary>
        [JsonProperty("L7EnableMode")]
        public string L7EnableMode{ get; set; }

        /// <summary>
        /// 开启源站防护的七层加速域名列表，仅当参数 L7EnableMode 为 specific 时生效。L7EnableMode 为 all 时，请保留此参数为空。单次最大仅支持填写 200 个七层加速域名。
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// 四层代理实例开启源站防护的模式。
        /// <li>all：针对站点下的所有四层代理实例开启。</li>
        /// <li>specific：针对站点下指定的四层代理实例开启。</li>当参数为空时，默认为 specific。
        /// </summary>
        [JsonProperty("L4EnableMode")]
        public string L4EnableMode{ get; set; }

        /// <summary>
        /// 开启源站防护的四层代理实例列表，仅当参数 L4EnableMode 为 specific 时生效。L4EnableMode 为 all 时，请保留此参数为空。单次最大仅支持填写 100 个四层代理实例。
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }


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
        }
    }
}

