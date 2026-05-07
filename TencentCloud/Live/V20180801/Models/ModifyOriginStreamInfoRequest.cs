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

    public class ModifyOriginStreamInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>域名。</p>
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// <p>源站播放协议，可取值：rtmp、flv、hls、dash、hls|dash、customization。</p>
        /// </summary>
        [JsonProperty("OriginStreamPlayType")]
        public string OriginStreamPlayType{ get; set; }

        /// <summary>
        /// <p>播放协议，可取值：rtmp、flv、hls、dash、hls|dash、customization。<br>自定义回源协议填写 customization。</p>
        /// </summary>
        [JsonProperty("CdnStreamPlayType")]
        public string[] CdnStreamPlayType{ get; set; }

        /// <summary>
        /// <p>原站类型：<br>1 =&gt; 直播原站。<br>2 =&gt; mediaPackage。</p>
        /// </summary>
        [JsonProperty("OriginStreamType")]
        public long? OriginStreamType{ get; set; }

        /// <summary>
        /// <p>原站地址信息，每项用冒号分割域名（ip）、端口信息。<br>端口为空也要带上分号，表示取默认端口。<br>自定义回源协议填写 customization。</p>
        /// </summary>
        [JsonProperty("OriginAddress")]
        public string[] OriginAddress{ get; set; }

        /// <summary>
        /// <p>原站地址类型：<br>1 =&gt; IP 类型。<br>2 =&gt; 域名类型。</p>
        /// </summary>
        [JsonProperty("OriginAddressType")]
        public long? OriginAddressType{ get; set; }

        /// <summary>
        /// <p>自定义名称</p>
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// <p>原站 host。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// </summary>
        [JsonProperty("OriginHost")]
        public string OriginHost{ get; set; }

        /// <summary>
        /// <p>超时时间，单位 ms，取值范围：1 ～ 60000，默认值：10000。</p>
        /// </summary>
        [JsonProperty("OriginTimeout")]
        public long? OriginTimeout{ get; set; }

        /// <summary>
        /// <p>重试次数，单位 次，取值范围：1 ～ 10，默认值：10。</p>
        /// </summary>
        [JsonProperty("OriginRetryTimes")]
        public long? OriginRetryTimes{ get; set; }

        /// <summary>
        /// <p>是否透传 http 头信息，可取值：on、off。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// </summary>
        [JsonProperty("PassThroughHttpHeader")]
        public string PassThroughHttpHeader{ get; set; }

        /// <summary>
        /// <p>是否透传相应，可取值：on、off。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// </summary>
        [JsonProperty("PassThroughResponse")]
        public string PassThroughResponse{ get; set; }

        /// <summary>
        /// <p>是否透传参数，可取值：on、off。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// </summary>
        [JsonProperty("PassThroughParam")]
        public string PassThroughParam{ get; set; }

        /// <summary>
        /// <p>索引缓存，单位 ms，取值范围：1 ～ 60000，默认值：10000。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// </summary>
        [JsonProperty("IndexerCache")]
        public long? IndexerCache{ get; set; }

        /// <summary>
        /// <p>分片缓存，单位 ms，取值范围：1 ～ 60000，默认值：10000。<br>当原站播放协议为 hls 时，传递该字段才会生效。</p>
        /// </summary>
        [JsonProperty("FragmentCache")]
        public long? FragmentCache{ get; set; }

        /// <summary>
        /// <p>分片数，单位 个，取值范围：1 ～ 10，默认值：3。</p>
        /// </summary>
        [JsonProperty("HlsPlayFragmentCount")]
        public long? HlsPlayFragmentCount{ get; set; }

        /// <summary>
        /// <p>分片时长，单位 ms，取值范围：1 ～ 10000，默认值：3000。</p>
        /// </summary>
        [JsonProperty("HlsPlayFragmentDuration")]
        public long? HlsPlayFragmentDuration{ get; set; }

        /// <summary>
        /// <p>时间戳修正，可取值：on、off，默认值：off。<br>当原站播放协议为 rtmp、flv 时，传递该字段才会生效。</p>
        /// </summary>
        [JsonProperty("TimeJitter")]
        public string TimeJitter{ get; set; }

        /// <summary>
        /// <p>https 回源，可取值：on、off，默认值：off。<br>当原站播放协议为flv、hls时，传递此字段才会生效。</p>
        /// </summary>
        [JsonProperty("UsingHttps")]
        public string UsingHttps{ get; set; }

        /// <summary>
        /// <p>遵循原站，可取值：on、off，默认值：off。<br>当原站播放协议为hls时，传递此字段才会生效。</p>
        /// </summary>
        [JsonProperty("CacheFollowOrigin")]
        public string CacheFollowOrigin{ get; set; }

        /// <summary>
        /// <p>状态码缓存，数组元素格式：<br>cacheKey:interval<br>cacheKey 可取值：cache_400_sec、cache_403_sec、cache_404_sec、cache_405_sec、cache_500_sec、cache_503_sec、cache_504_sec。<br>interval 单位 ms。<br>当原站播放协议为hls时，传递此字段才会生效。</p>
        /// </summary>
        [JsonProperty("CacheStatusCode")]
        public string[] CacheStatusCode{ get; set; }

        /// <summary>
        /// <p>url改写， 格式为： url1&lt;|&gt;url2; 其中，&lt;|&gt; 为分隔符。<br>url1、url2 长度限制100，不可包含特殊字符。<br>当原站播放协议为hls时，传递此字段才会生效。</p>
        /// </summary>
        [JsonProperty("UrlReplaceRules")]
        public string[] UrlReplaceRules{ get; set; }

        /// <summary>
        /// <p>options 支持，可取值：on、off，默认值：off。<br>当原站播放协议为hls时，传递此字段才会生效。</p>
        /// </summary>
        [JsonProperty("OptionsRequest")]
        public string OptionsRequest{ get; set; }

        /// <summary>
        /// <p>follow 301/302，可取值：on、off，默认值：off。<br>当原站播放协议为hls时，传递此字段才会生效。</p>
        /// </summary>
        [JsonProperty("FollowRedirect")]
        public string FollowRedirect{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置索引缓存保留指定参数列表，最多支持 30 组，每个参数小于等于 20 字符。</p>
        /// </summary>
        [JsonProperty("IndexerKeepParam")]
        public string[] IndexerKeepParam{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置分片缓存保留指定参数列表，最多支持 30 组，每个参数小于等于 20 字符。</p>
        /// </summary>
        [JsonProperty("FragmentKeepParam")]
        public string[] FragmentKeepParam{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamType = 2 时有效，表示 mediapackage 具体类型：<br>media_package =&gt; 仅配置普通频道。<br>media_package_pure_ad =&gt; 仅配置广告。<br>media_package_mix_ad =&gt; 同时配置普通频道和广告。<br>注意：配置时候，优先使用 media_package。和 MediaPackageChannelTypes 字段配合使用。</p>
        /// </summary>
        [JsonProperty("MediaPackageType")]
        public string MediaPackageType{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamType = 2 且 MediaPackageType = media_package 时有效，表示 mediapackage 频道类型，可组合如下值：normal（频道）、ssai（广告）、linear_assembly（线性组装）。</p>
        /// </summary>
        [JsonProperty("MediaPackageChannelTypes")]
        public string[] MediaPackageChannelTypes{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置索引自定义 header，最大支持 10 组，每一组参数、取值用空格分开，允许字符规则如下：<br>头部参数：由大小写字母、数字及-组成，长度支持1 ～100个字符，黑名单：Host、Connection、Content-Length、Range。<br>头部取值：不支持中文、不支持以$开头，长度支持1 ～ 100个字符，不允许有空格。</p>
        /// </summary>
        [JsonProperty("IndexerHeader")]
        public string[] IndexerHeader{ get; set; }

        /// <summary>
        /// <p>当 OriginStreamPlayType 为 hls 时生效，设置分片自定义 header，最大支持 10 组，每一组参数、取值用空格分开，允许字符规则如下：<br>头部参数：由大小写字母、数字及-组成，长度支持1 ～100个字符，黑名单：Host、Connection、Content-Length、Range。<br>头部取值：不支持中文、不支持以$开头，长度支持1 ～ 100个字符，不允许有空格。</p>
        /// </summary>
        [JsonProperty("FragmentHeader")]
        public string[] FragmentHeader{ get; set; }

        /// <summary>
        /// <p>自定义回源规则列表，当 OriginStreamPlayType 为 customization 时候生效。</p>
        /// </summary>
        [JsonProperty("CustomizationRules")]
        public OriginStreamCustomizationRule[] CustomizationRules{ get; set; }

        /// <summary>
        /// <p>缓存格式规则。<br>0：默认格式。<br>1：云直播源站格式。<br>当 OriginStreamPlayType 为 customization 时候生效。</p>
        /// </summary>
        [JsonProperty("CacheFormatRule")]
        public long? CacheFormatRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "OriginStreamPlayType", this.OriginStreamPlayType);
            this.SetParamArraySimple(map, prefix + "CdnStreamPlayType.", this.CdnStreamPlayType);
            this.SetParamSimple(map, prefix + "OriginStreamType", this.OriginStreamType);
            this.SetParamArraySimple(map, prefix + "OriginAddress.", this.OriginAddress);
            this.SetParamSimple(map, prefix + "OriginAddressType", this.OriginAddressType);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "OriginHost", this.OriginHost);
            this.SetParamSimple(map, prefix + "OriginTimeout", this.OriginTimeout);
            this.SetParamSimple(map, prefix + "OriginRetryTimes", this.OriginRetryTimes);
            this.SetParamSimple(map, prefix + "PassThroughHttpHeader", this.PassThroughHttpHeader);
            this.SetParamSimple(map, prefix + "PassThroughResponse", this.PassThroughResponse);
            this.SetParamSimple(map, prefix + "PassThroughParam", this.PassThroughParam);
            this.SetParamSimple(map, prefix + "IndexerCache", this.IndexerCache);
            this.SetParamSimple(map, prefix + "FragmentCache", this.FragmentCache);
            this.SetParamSimple(map, prefix + "HlsPlayFragmentCount", this.HlsPlayFragmentCount);
            this.SetParamSimple(map, prefix + "HlsPlayFragmentDuration", this.HlsPlayFragmentDuration);
            this.SetParamSimple(map, prefix + "TimeJitter", this.TimeJitter);
            this.SetParamSimple(map, prefix + "UsingHttps", this.UsingHttps);
            this.SetParamSimple(map, prefix + "CacheFollowOrigin", this.CacheFollowOrigin);
            this.SetParamArraySimple(map, prefix + "CacheStatusCode.", this.CacheStatusCode);
            this.SetParamArraySimple(map, prefix + "UrlReplaceRules.", this.UrlReplaceRules);
            this.SetParamSimple(map, prefix + "OptionsRequest", this.OptionsRequest);
            this.SetParamSimple(map, prefix + "FollowRedirect", this.FollowRedirect);
            this.SetParamArraySimple(map, prefix + "IndexerKeepParam.", this.IndexerKeepParam);
            this.SetParamArraySimple(map, prefix + "FragmentKeepParam.", this.FragmentKeepParam);
            this.SetParamSimple(map, prefix + "MediaPackageType", this.MediaPackageType);
            this.SetParamArraySimple(map, prefix + "MediaPackageChannelTypes.", this.MediaPackageChannelTypes);
            this.SetParamArraySimple(map, prefix + "IndexerHeader.", this.IndexerHeader);
            this.SetParamArraySimple(map, prefix + "FragmentHeader.", this.FragmentHeader);
            this.SetParamArrayObj(map, prefix + "CustomizationRules.", this.CustomizationRules);
            this.SetParamSimple(map, prefix + "CacheFormatRule", this.CacheFormatRule);
        }
    }
}

