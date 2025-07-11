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

    public class DDosProtectionConfig : AbstractModel
    {
        
        /// <summary>
        /// 中国大陆地区独立 DDoS 防护的规格。详情请参考 [独立 DDoS 防护相关费用](https://cloud.tencent.com/document/product/1552/94162)
        /// <li>PLATFORM：平台默认防护，即不开启独立 DDoS 防护；</li>
        /// <li>BASE30_MAX300：开启独立 DDoS 防护，提供 30 Gbps 保底防护带宽以及 300 Gbps 弹性防护带宽；</li>
        /// <li>BASE60_MAX600：开启独立 DDoS 防护，提供 60 Gbps 保底防护带宽以及 600 Gbps 弹性防护带宽。</li>不填写参数时，取默认值 PLATFORM。
        /// </summary>
        [JsonProperty("LevelMainland")]
        public string LevelMainland{ get; set; }

        /// <summary>
        /// 中国大陆地区独立 DDoS 防护的弹性防护带宽配置。
        /// 仅当开启中国大陆区域独立 DDos 防护时有效（详见 LevelMainland 参数配置），且取值范围有如下限制：
        /// <li>开启中国大陆地区独立 DDoS 防护，使用 30 Gbps 保底防护带宽规格时（ LevelMainland 参数值为 BASE30_MAX300 ）：有效取值范围为 30 至 300，单位为 Gbps；</li>
        /// <li>开启中国大陆地区独立 DDoS 防护，使用 60 Gbps 保底防护带宽规格时（ LevelMainland 参数值为 BASE60_MAX600 ）：有效取值范围为 60 至 600，单位为 Gbps；</li>
        /// <li>使用平台默认防护（ LevelMainland 参数值为 PLATFORM ）：不支持配置，本参数值无效。</li>
        /// </summary>
        [JsonProperty("MaxBandwidthMainland")]
        public ulong? MaxBandwidthMainland{ get; set; }

        /// <summary>
        /// 全球（除中国大陆以外）地区独立 DDoS 防护的规格。
        /// <li>PLATFORM：平台默认防护，即不开启独立 DDoS 防护；</li>
        /// <li>ANYCAST300：开启独立 DDoS 防护，提供 300 Gbps 防护带宽；</li>
        /// <li>ANYCAST_ALLIN：开启独立 DDoS 防护，使用全部可用防护资源进行防护。</li>不填写参数时，取默认值 PLATFORM。
        /// </summary>
        [JsonProperty("LevelOverseas")]
        public string LevelOverseas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LevelMainland", this.LevelMainland);
            this.SetParamSimple(map, prefix + "MaxBandwidthMainland", this.MaxBandwidthMainland);
            this.SetParamSimple(map, prefix + "LevelOverseas", this.LevelOverseas);
        }
    }
}

