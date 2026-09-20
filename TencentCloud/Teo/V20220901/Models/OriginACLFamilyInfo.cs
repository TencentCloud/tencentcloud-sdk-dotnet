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

    public class OriginACLFamilyInfo : AbstractModel
    {
        
        /// <summary>
        /// 源站防护版本号。
        /// 格式说明：
        /// 标准版本：
        /// <li>gaz-xxxxx：全球；</li>
        /// <li>mlc-xxxxx：中国；</li>
        /// <li>emc-xxxxx：海外(全球不含中国)；</li>
        /// 精简版(平台级版本)：
        /// <li>plat-gaz-xxxxxx：精简全球版；</li>
        /// <li>plat-mlc-xxxxxx：精简中国版；</li>
        /// <li>plat-emc-xxxxxx：精简海外(全球不含中国)版；</li>
        /// 缩写说明：
        /// <li>gaz：Global AZ Availability Zone;</li>
        /// <li>mlc：mainlandChina;</li>
        /// <li>emc：Exclude mainlandChina.</li>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 版本生效时间，时间是北京时间 UTC+8， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("ActiveTime")]
        public string ActiveTime{ get; set; }

        /// <summary>
        /// 回源 IP 网段详情。	
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// 源站防护回源ACL控制域。取值说明如下：
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
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ActiveTime", this.ActiveTime);
            this.SetParamObj(map, prefix + "EntireAddresses.", this.EntireAddresses);
            this.SetParamSimple(map, prefix + "OriginACLFamily", this.OriginACLFamily);
        }
    }
}

