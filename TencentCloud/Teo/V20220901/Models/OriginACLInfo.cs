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

    public class OriginACLInfo : AbstractModel
    {
        
        /// <summary>
        /// 启用了特定回源 IP 网段回源的七层加速域名列表。源站防护未开启时为空。
        /// </summary>
        [JsonProperty("L7Hosts")]
        public string[] L7Hosts{ get; set; }

        /// <summary>
        /// 启用了特定回源 IP 网段回源的四层代理实例列表。源站防护未开启时为空。
        /// </summary>
        [JsonProperty("L4ProxyIds")]
        public string[] L4ProxyIds{ get; set; }

        /// <summary>
        /// 当前生效的回源 IP 网段。源站防护未开启时为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentOriginACL")]
        public CurrentOriginACL CurrentOriginACL{ get; set; }

        /// <summary>
        /// 当回源 IP 网段发生更新时，该字段会返回下一个版本将要生效的回源 IP 网段，包含与当前回源 IP 网段的对比。无更新或者源站防护未开启时该字段为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextOriginACL")]
        public NextOriginACL NextOriginACL{ get; set; }

        /// <summary>
        /// 源站防护状态，取值有：
        /// <li>online：已生效；</li>
        /// <li>offline：已停用；</li>
        /// <li>updating: 配置部署中。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "L7Hosts.", this.L7Hosts);
            this.SetParamArraySimple(map, prefix + "L4ProxyIds.", this.L4ProxyIds);
            this.SetParamObj(map, prefix + "CurrentOriginACL.", this.CurrentOriginACL);
            this.SetParamObj(map, prefix + "NextOriginACL.", this.NextOriginACL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

