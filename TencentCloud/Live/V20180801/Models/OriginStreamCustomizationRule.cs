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

    public class OriginStreamCustomizationRule : AbstractModel
    {
        
        /// <summary>
        /// <p>匹配规则，可选项如下：<br>.m3u8、.mpd、.ts、.mp4、.m4s、.m4a、.m4i、.m4v、.m4f、.aac、.webm。</p>
        /// </summary>
        [JsonProperty("MatchRule")]
        public string MatchRule{ get; set; }

        /// <summary>
        /// <p>原站地址类型： 1 =&gt; IP 类型。 2 =&gt; 域名类型。</p>
        /// </summary>
        [JsonProperty("OriginAddressType")]
        public long? OriginAddressType{ get; set; }

        /// <summary>
        /// <p>原站 host。</p>
        /// </summary>
        [JsonProperty("OriginHost")]
        public string OriginHost{ get; set; }

        /// <summary>
        /// <p>原站地址信息，每项用冒号分割域名（ip）、端口信息。 端口为空也要带上分号，表示取默认端口。</p>
        /// </summary>
        [JsonProperty("OriginAddress")]
        public string[] OriginAddress{ get; set; }

        /// <summary>
        /// <p>是否透传 http 头信息，可取值：on、off。</p>
        /// </summary>
        [JsonProperty("PassThroughHttpHeader")]
        public string PassThroughHttpHeader{ get; set; }

        /// <summary>
        /// <p>是否透传相应，可取值：on、off。</p>
        /// </summary>
        [JsonProperty("PassThroughResponse")]
        public string PassThroughResponse{ get; set; }

        /// <summary>
        /// <p>是否透传参数，可取值：on、off。</p>
        /// </summary>
        [JsonProperty("PassThroughParam")]
        public string PassThroughParam{ get; set; }

        /// <summary>
        /// <p>url改写， 格式为： url1&lt;|&gt;url2; 其中，&lt;|&gt; 为分隔符。 url1、url2 长度限制100，不可包含特殊字符。</p>
        /// </summary>
        [JsonProperty("UrlReplaceRules")]
        public string[] UrlReplaceRules{ get; set; }

        /// <summary>
        /// <p>options 支持，可取值：on、off，默认值：off。</p>
        /// </summary>
        [JsonProperty("OptionsRequest")]
        public string OptionsRequest{ get; set; }

        /// <summary>
        /// <p>回源超时时间，单位 ms，取值范围：1 ～ 60000，默认值：10000。</p>
        /// </summary>
        [JsonProperty("OriginTimeout")]
        public long? OriginTimeout{ get; set; }

        /// <summary>
        /// <p>重试次数，单位 次，取值范围：1 ～ 10。</p>
        /// </summary>
        [JsonProperty("OriginRetryTimes")]
        public long? OriginRetryTimes{ get; set; }

        /// <summary>
        /// <p>状态码缓存，数组元素格式： cacheKey:interval cacheKey 可取值：cache_400_sec、cache_403_sec、cache_404_sec、cache_405_sec、cache_500_sec、cache_503_sec、cache_504_sec。 interval 单位 s。</p>
        /// </summary>
        [JsonProperty("CacheStatusCode")]
        public string[] CacheStatusCode{ get; set; }

        /// <summary>
        /// <p>缓存时间，单位 s，取值范围：0 ～ 31536000。</p>
        /// </summary>
        [JsonProperty("Cache")]
        public long? Cache{ get; set; }

        /// <summary>
        /// <p>缓存键。</p>
        /// </summary>
        [JsonProperty("KeepParam")]
        public string[] KeepParam{ get; set; }

        /// <summary>
        /// <p>设置索引自定义 header，最大支持 10 组，每一组参数、取值用空格分开，允许字符规则如下： 头部参数：由大小写字母、数字及-组成，长度支持1 ～100个字符，黑名单：Host、Connection、Content-Length、Range。 头部取值：不支持中文、不支持以$开头，长度支持1 ～ 100个字符，不允许有空格。</p>
        /// </summary>
        [JsonProperty("HttpHeader")]
        public string[] HttpHeader{ get; set; }

        /// <summary>
        /// <p>自定义回源缓存随源配置。<br>0：不开启。<br>1：开启。</p>
        /// </summary>
        [JsonProperty("CustomizationCacheFollowOrigin")]
        public long? CustomizationCacheFollowOrigin{ get; set; }

        /// <summary>
        /// <p>缓存 Http 头部键。</p>
        /// </summary>
        [JsonProperty("KeepHttpHeader")]
        public string[] KeepHttpHeader{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchRule", this.MatchRule);
            this.SetParamSimple(map, prefix + "OriginAddressType", this.OriginAddressType);
            this.SetParamSimple(map, prefix + "OriginHost", this.OriginHost);
            this.SetParamArraySimple(map, prefix + "OriginAddress.", this.OriginAddress);
            this.SetParamSimple(map, prefix + "PassThroughHttpHeader", this.PassThroughHttpHeader);
            this.SetParamSimple(map, prefix + "PassThroughResponse", this.PassThroughResponse);
            this.SetParamSimple(map, prefix + "PassThroughParam", this.PassThroughParam);
            this.SetParamArraySimple(map, prefix + "UrlReplaceRules.", this.UrlReplaceRules);
            this.SetParamSimple(map, prefix + "OptionsRequest", this.OptionsRequest);
            this.SetParamSimple(map, prefix + "OriginTimeout", this.OriginTimeout);
            this.SetParamSimple(map, prefix + "OriginRetryTimes", this.OriginRetryTimes);
            this.SetParamArraySimple(map, prefix + "CacheStatusCode.", this.CacheStatusCode);
            this.SetParamSimple(map, prefix + "Cache", this.Cache);
            this.SetParamArraySimple(map, prefix + "KeepParam.", this.KeepParam);
            this.SetParamArraySimple(map, prefix + "HttpHeader.", this.HttpHeader);
            this.SetParamSimple(map, prefix + "CustomizationCacheFollowOrigin", this.CustomizationCacheFollowOrigin);
            this.SetParamArraySimple(map, prefix + "KeepHttpHeader.", this.KeepHttpHeader);
        }
    }
}

