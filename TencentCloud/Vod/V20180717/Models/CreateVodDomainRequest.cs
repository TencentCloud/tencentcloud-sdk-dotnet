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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVodDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要接入点播的加速域名。注意：不支持填写泛域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 需要开启 CDN 加速的区域：
        /// <li>Chinese Mainland：中国境内（不包含港澳台）。</li>
        /// <li>Outside Chinese Mainland: 中国境外。</li>
        /// <li>Global: 全球范围。</li>
        /// 如果没有设置 AccelerateArea， 点播会根据用户在腾讯云设置的地域信息自动开通中国境内或者中国境外的 CDN 加速。开启中国境内加速的域名，需要先[备案域名](/document/product/243/18905)。
        /// </summary>
        [JsonProperty("AccelerateArea")]
        public string AccelerateArea{ get; set; }

        /// <summary>
        /// 域名类型，取值有： <li>VOD：使用 VOD 产品分发的域名；</li> <li>EdgeOne：使用 EdgeOne 产品分发的域名。</li>不填默认取值为 VOD 。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "AccelerateArea", this.AccelerateArea);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

