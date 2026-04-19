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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSAIConf : AbstractModel
    {
        
        /// <summary>
        /// <p>广告决策服务器URL(ADS)。注意：填了AdsUrl会自动代替覆盖AdsUrls[0]</p>
        /// </summary>
        [JsonProperty("AdsUrl")]
        public string AdsUrl{ get; set; }

        /// <summary>
        /// <p>广告决策服务器URL数组(ADS)</p>
        /// </summary>
        [JsonProperty("AdsUrls")]
        public string[] AdsUrls{ get; set; }

        /// <summary>
        /// <p>参数配置。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigAliases")]
        public ConfigAliasesInfo[] ConfigAliases{ get; set; }

        /// <summary>
        /// <p>是否开启广告标记透传。</p>
        /// </summary>
        [JsonProperty("AdMarkerPassthrough")]
        public bool? AdMarkerPassthrough{ get; set; }

        /// <summary>
        /// <p>如何处理广告中的标记,可选值[1-2]：<br>1:所有SCTE-35类型标记全部处理-all（默认）<br>2:SCTE-35enhanced，解析部分类型。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SCTE35AdType")]
        public ulong? SCTE35AdType{ get; set; }

        /// <summary>
        /// <p>默认广告url。</p>
        /// </summary>
        [JsonProperty("SlateAd")]
        public string SlateAd{ get; set; }

        /// <summary>
        /// <p>未填充的最大时长，单位：秒。</p>
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// <p>是否开启mpd location, true对应enable， false对应disable。</p>
        /// </summary>
        [JsonProperty("DashMPDLocation")]
        public bool? DashMPDLocation{ get; set; }

        /// <summary>
        /// <p>被视作广告的标记类型，可选值[1-8]：</p><ol><li>Splice insert<br>2.Provider advertisement</li><li>Distributor advertisement</li><li>Provider placement opportunity</li><li>Distributor placement opportunity</li><li>Break</li><li>Provider overlay placement opportunity</li><li>Distributor overlay placement opportunity。</li></ol>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdTriggers")]
        public ulong?[] AdTriggers{ get; set; }

        /// <summary>
        /// <p>被视作广告的分发限制类型，可选值[1-4]：<br>1:None<br>2:Restricted（默认） 3:Unrestricted<br>4.Both</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliveryRestrictions")]
        public ulong? DeliveryRestrictions{ get; set; }

        /// <summary>
        /// <p>源流CDN前缀，需要以http://或者https://开头。</p>
        /// </summary>
        [JsonProperty("SourceCDNPrefix")]
        public string SourceCDNPrefix{ get; set; }

        /// <summary>
        /// <p>广告CDN前缀，需要以http://或者https://开头。</p>
        /// </summary>
        [JsonProperty("AdCDNPrefix")]
        public string AdCDNPrefix{ get; set; }

        /// <summary>
        /// <p>预加载广告决策服务地址。注意：填了PreRollAdsUrl会自动代替覆盖PreRollAdsUrls[0]</p>
        /// </summary>
        [JsonProperty("PreRollAdsUrl")]
        public string PreRollAdsUrl{ get; set; }

        /// <summary>
        /// <p>预加载广告决策服务地址数组</p>
        /// </summary>
        [JsonProperty("PreRollAdsUrls")]
        public string[] PreRollAdsUrls{ get; set; }

        /// <summary>
        /// <p>预加载广告最大允许时长，0-3600。</p>
        /// </summary>
        [JsonProperty("PreRollMaxAllowedDuration")]
        public long? PreRollMaxAllowedDuration{ get; set; }

        /// <summary>
        /// <p>是否开启多次请求ADS,开启后将优先请求ADS，请求失败后再请求兜底广告</p>
        /// </summary>
        [JsonProperty("MultiRequest")]
        public bool? MultiRequest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AdsUrl", this.AdsUrl);
            this.SetParamArraySimple(map, prefix + "AdsUrls.", this.AdsUrls);
            this.SetParamArrayObj(map, prefix + "ConfigAliases.", this.ConfigAliases);
            this.SetParamSimple(map, prefix + "AdMarkerPassthrough", this.AdMarkerPassthrough);
            this.SetParamSimple(map, prefix + "SCTE35AdType", this.SCTE35AdType);
            this.SetParamSimple(map, prefix + "SlateAd", this.SlateAd);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "DashMPDLocation", this.DashMPDLocation);
            this.SetParamArraySimple(map, prefix + "AdTriggers.", this.AdTriggers);
            this.SetParamSimple(map, prefix + "DeliveryRestrictions", this.DeliveryRestrictions);
            this.SetParamSimple(map, prefix + "SourceCDNPrefix", this.SourceCDNPrefix);
            this.SetParamSimple(map, prefix + "AdCDNPrefix", this.AdCDNPrefix);
            this.SetParamSimple(map, prefix + "PreRollAdsUrl", this.PreRollAdsUrl);
            this.SetParamArraySimple(map, prefix + "PreRollAdsUrls.", this.PreRollAdsUrls);
            this.SetParamSimple(map, prefix + "PreRollMaxAllowedDuration", this.PreRollMaxAllowedDuration);
            this.SetParamSimple(map, prefix + "MultiRequest", this.MultiRequest);
        }
    }
}

