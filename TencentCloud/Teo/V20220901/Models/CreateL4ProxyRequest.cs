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

    public class CreateL4ProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 四层代理实例名称，可输入 1-50 个字符，允许的字符为 a-z、0-9、-，且 - 不能单独注册或连续使用，不能放在开头或结尾。创建完成后不支持修改。
        /// </summary>
        [JsonProperty("ProxyName")]
        public string ProxyName{ get; set; }

        /// <summary>
        /// 四层代理实例加速区域。
        /// <li>mainland：中国大陆可用区；</li>
        /// <li>overseas：全球可用区（不含中国大陆）；</li>
        /// <li>global：全球可用区。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 是否开启 IPv6 访问，不填写时默认为 off。该配置仅在部分加速区域和安全防护配置下支持开启，详情请参考 [新建四层代理实例](https://cloud.tencent.com/document/product/1552/90025) 。取值为：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// 
        /// </summary>
        [JsonProperty("Ipv6")]
        public string Ipv6{ get; set; }

        /// <summary>
        /// 是否开启固定 IP，不填写时默认为 off。该配置仅在部分加速区域和安全防护配置下支持开启，详情请参考 [新建四层代理实例](https://cloud.tencent.com/document/product/1552/90025) 。取值为：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("StaticIp")]
        public string StaticIp{ get; set; }

        /// <summary>
        /// 是否开启中国大陆网络优化，不填写时默认为 off。该配置仅在部分加速区域和安全防护配置下支持开启，详情请参考 [新建四层代理实例](https://cloud.tencent.com/document/product/1552/90025) 。取值为：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// </summary>
        [JsonProperty("AccelerateMainland")]
        public string AccelerateMainland{ get; set; }

        /// <summary>
        /// L3/L4 DDoS 防护配置，不填写时默认使用平台默认防护选项。详情参考 [独立 DDoS 防护](https://cloud.tencent.com/document/product/1552/95994)。
        /// </summary>
        [JsonProperty("DDosProtectionConfig")]
        public DDosProtectionConfig DDosProtectionConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyName", this.ProxyName);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "StaticIp", this.StaticIp);
            this.SetParamSimple(map, prefix + "AccelerateMainland", this.AccelerateMainland);
            this.SetParamObj(map, prefix + "DDosProtectionConfig.", this.DDosProtectionConfig);
        }
    }
}

