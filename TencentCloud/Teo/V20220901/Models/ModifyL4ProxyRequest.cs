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

    public class ModifyL4ProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 应用 ID。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 是否开启 IPv6 访问。 不填该参数时，表示不修改该配置。该配置仅在部分加速区域和安全防护配置下支持开启，详情请参考 [新建四层代理实例](https://cloud.tencent.com/document/product/1552/90025) 。取值为：
        /// <li>on：开启；</li> 
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("Ipv6")]
        public string Ipv6{ get; set; }

        /// <summary>
        /// 是否开启中国大陆网络优化。不填该参数时，表示不修改该配置。该配置仅在部分加速区域和安全防护配置下支持开启，详情请参考 [新建四层代理实例](https://cloud.tencent.com/document/product/1552/90025) 。取值为：
        /// <li>on：开启；</li> 
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public string AccelerateMainland{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "AccelerateMainland", this.AccelerateMainland);
        }
    }
}

