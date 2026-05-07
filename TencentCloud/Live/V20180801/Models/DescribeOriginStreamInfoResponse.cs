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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOriginStreamInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>配置状态信息：0 配置中，1 成功，2 关闭中，3 关闭成功。</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>播放类型。</p>
        /// </summary>
        [JsonProperty("CdnStreamPlayType")]
        public string[] CdnStreamPlayType{ get; set; }

        /// <summary>
        /// <p>原站配置类型：1 直播原站。<br>2 streamPackage。</p>
        /// </summary>
        [JsonProperty("OriginStreamType")]
        public long? OriginStreamType{ get; set; }

        /// <summary>
        /// <p>原站播放类型。</p>
        /// </summary>
        [JsonProperty("OriginStreamPlayType")]
        public string OriginStreamPlayType{ get; set; }

        /// <summary>
        /// <p>原站地址类型：1 ip，2 域名。</p>
        /// </summary>
        [JsonProperty("OriginAddressType")]
        public long? OriginAddressType{ get; set; }

        /// <summary>
        /// <p>原站地址信息，每项用分号分割域名（ip）、端口信息。<br>端口为空也要带上分号，表示取默认端口。</p>
        /// </summary>
        [JsonProperty("OriginAddress")]
        public string[] OriginAddress{ get; set; }

        /// <summary>
        /// <p>超时时间，单位 ms。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginTimeout")]
        public long? OriginTimeout{ get; set; }

        /// <summary>
        /// <p>重试次数，单位 次。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginRetryTimes")]
        public long? OriginRetryTimes{ get; set; }

        /// <summary>
        /// <p>时间戳修正，可取值：on、off。<br>当原站播放协议为 rtmp、flv 时，传递该字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeJitter")]
        public string TimeJitter{ get; set; }

        /// <summary>
        /// <p>分片数，单位 个。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HlsPlayFragmentCount")]
        public long? HlsPlayFragmentCount{ get; set; }

        /// <summary>
        /// <p>分片时长，单位 ms。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HlsPlayFragmentDuration")]
        public long? HlsPlayFragmentDuration{ get; set; }

        /// <summary>
        /// <p>是否透传 http 头信息，可取值：on、off。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassThroughHttpHeader")]
        public string PassThroughHttpHeader{ get; set; }

        /// <summary>
        /// <p>是否透传相应，可取值：on、off。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassThroughResponse")]
        public string PassThroughResponse{ get; set; }

        /// <summary>
        /// <p>是否透传参数，可取值：on、off。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassThroughParam")]
        public string PassThroughParam{ get; set; }

        /// <summary>
        /// <p>原站 host。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OriginHost")]
        public string OriginHost{ get; set; }

        /// <summary>
        /// <p>索引缓存，单位 ms。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexerCache")]
        public long? IndexerCache{ get; set; }

        /// <summary>
        /// <p>分片缓存，单位 ms。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FragmentCache")]
        public long? FragmentCache{ get; set; }

        /// <summary>
        /// <p>域名。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// <p>https 回源，可取值：on、off。<br>当原站播放协议为flv、hls时，传递此字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UsingHttps")]
        public string UsingHttps{ get; set; }

        /// <summary>
        /// <p>是否遵循原站，可取值：on、off。<br>当原站播放协议为hls时，此字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheFollowOrigin")]
        public string CacheFollowOrigin{ get; set; }

        /// <summary>
        /// <p>状态码缓存，数组元素格式：<br>cacheKey:interval<br>cacheKey 可取值：cache_400_sec、cache_403_sec、cache_404_sec、cache_405_sec、cache_500_sec、cache_503_sec、cache_504_sec。<br>interval 单位 ms。<br>当原站播放协议为hls时，此字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CacheStatusCode")]
        public string[] CacheStatusCode{ get; set; }

        /// <summary>
        /// <p>url改写， 格式为： url1&lt;|&gt;url2; 其中，&lt;|&gt; 为分隔符。<br>url1、url2 长度限制100，不可包含特殊字符。<br>当原站播放协议为hls时，此字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UrlReplaceRules")]
        public string[] UrlReplaceRules{ get; set; }

        /// <summary>
        /// <p>是否 options 支持，可取值：on、off。<br>当原站播放协议为hls时，此字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OptionsRequest")]
        public string OptionsRequest{ get; set; }

        /// <summary>
        /// <p>是否 follow 301/302，可取值：on、off。<br>当原站播放协议为hls时，此字段才会生效。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public string FollowRedirect{ get; set; }

        /// <summary>
        /// <p>源站类型 OriginStreamType 为 2 时，该字段有效。 代表源站地址 OriginAddress 对应的地区 region。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamPackageRegion")]
        public string[] StreamPackageRegion{ get; set; }

        /// <summary>
        /// <p>客户名。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置索引缓存保留指定参数列表，最多支持 30 组，每个参数小于等于 20 字符。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexerKeepParam")]
        public string[] IndexerKeepParam{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置分片缓存保留指定参数列表，最多支持 30 组，每个参数小于等于 20 字符。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FragmentKeepParam")]
        public string[] FragmentKeepParam{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamType = 2 时有效，表示 mediapackage 具体类型：<br>media_package =&gt; 仅配置普通频道。<br>media_package_pure_ad =&gt; 仅配置广告。<br>media_package_mix_ad =&gt; 同时配置普通频道和广告。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaPackageType")]
        public string MediaPackageType{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamType = 2 且 MediaPackageType = media_package 时有效，表示 mediapackage 频道类型，可组合如下值：normal（频道）、ssai（广告）、linear_assembly（线性组装）。</p>
        /// </summary>
        [JsonProperty("MediaPackageChannelTypes")]
        public string[] MediaPackageChannelTypes{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置索引自定义 header，每一组参数、取值用空格分开。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexerHeader")]
        public string[] IndexerHeader{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置分片自定义 header，每一组参数、取值用空格分开。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FragmentHeader")]
        public string[] FragmentHeader{ get; set; }

        /// <summary>
        /// <p>自定义规则列表。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomizationRules")]
        public OriginStreamCustomizationRule[] CustomizationRules{ get; set; }

        /// <summary>
        /// <p>缓存格式规则。<br>0：默认格式。<br>1：云直播源站格式。<br>当 OriginStreamPlayType 为 customization 时候生效。</p>
        /// </summary>
        [JsonProperty("CacheFormatRule")]
        public long? CacheFormatRule{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "CdnStreamPlayType.", this.CdnStreamPlayType);
            this.SetParamSimple(map, prefix + "OriginStreamType", this.OriginStreamType);
            this.SetParamSimple(map, prefix + "OriginStreamPlayType", this.OriginStreamPlayType);
            this.SetParamSimple(map, prefix + "OriginAddressType", this.OriginAddressType);
            this.SetParamArraySimple(map, prefix + "OriginAddress.", this.OriginAddress);
            this.SetParamSimple(map, prefix + "OriginTimeout", this.OriginTimeout);
            this.SetParamSimple(map, prefix + "OriginRetryTimes", this.OriginRetryTimes);
            this.SetParamSimple(map, prefix + "TimeJitter", this.TimeJitter);
            this.SetParamSimple(map, prefix + "HlsPlayFragmentCount", this.HlsPlayFragmentCount);
            this.SetParamSimple(map, prefix + "HlsPlayFragmentDuration", this.HlsPlayFragmentDuration);
            this.SetParamSimple(map, prefix + "PassThroughHttpHeader", this.PassThroughHttpHeader);
            this.SetParamSimple(map, prefix + "PassThroughResponse", this.PassThroughResponse);
            this.SetParamSimple(map, prefix + "PassThroughParam", this.PassThroughParam);
            this.SetParamSimple(map, prefix + "OriginHost", this.OriginHost);
            this.SetParamSimple(map, prefix + "IndexerCache", this.IndexerCache);
            this.SetParamSimple(map, prefix + "FragmentCache", this.FragmentCache);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "UsingHttps", this.UsingHttps);
            this.SetParamSimple(map, prefix + "CacheFollowOrigin", this.CacheFollowOrigin);
            this.SetParamArraySimple(map, prefix + "CacheStatusCode.", this.CacheStatusCode);
            this.SetParamArraySimple(map, prefix + "UrlReplaceRules.", this.UrlReplaceRules);
            this.SetParamSimple(map, prefix + "OptionsRequest", this.OptionsRequest);
            this.SetParamSimple(map, prefix + "FollowRedirect", this.FollowRedirect);
            this.SetParamArraySimple(map, prefix + "StreamPackageRegion.", this.StreamPackageRegion);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamArraySimple(map, prefix + "IndexerKeepParam.", this.IndexerKeepParam);
            this.SetParamArraySimple(map, prefix + "FragmentKeepParam.", this.FragmentKeepParam);
            this.SetParamSimple(map, prefix + "MediaPackageType", this.MediaPackageType);
            this.SetParamArraySimple(map, prefix + "MediaPackageChannelTypes.", this.MediaPackageChannelTypes);
            this.SetParamArraySimple(map, prefix + "IndexerHeader.", this.IndexerHeader);
            this.SetParamArraySimple(map, prefix + "FragmentHeader.", this.FragmentHeader);
            this.SetParamArrayObj(map, prefix + "CustomizationRules.", this.CustomizationRules);
            this.SetParamSimple(map, prefix + "CacheFormatRule", this.CacheFormatRule);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

