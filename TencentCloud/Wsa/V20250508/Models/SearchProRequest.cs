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

namespace TencentCloud.Wsa.V20250508.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchProRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>搜索词</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>返回结果类型，不传默认为0。（<strong>仅标准版、尊享版支持该参数</strong>）</p><p>枚举值：</p><ul><li>0： 公开网页信源结果（自然结果）</li><li>1： 优质权威垂直信源结果（VR 卡）</li><li>2： 混合结果（自然结果+VR卡）</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// <p>指定网址搜索/过滤。（<strong>仅标准版、尊享版、旗舰版支持该参数</strong>）</p><ul><li>指定网址搜索：需要查询某个特定网址的内容时，传入&quot;Site=qq.com&quot;，实现只搜索qq.com的结果；每次搜索仅支持指定一个域名。</li><li>指定网址过滤：需要排除某个特定网址的内容时，传入&quot;Site=exclude:qq.com|sohu.com&quot;，实现过滤qq.com和sohu.com的结果；每次搜索最多支持过滤五个域名。</li></ul><p>注意： 该参数与mode参数共同使用时，仅对公开网页信源结果（自然结果）生效，对优质权威垂直信源结果（VR卡）不生效。</p>
        /// </summary>
        [JsonProperty("Site")]
        public string Site{ get; set; }

        /// <summary>
        /// <p>控制返回结果条数，可取值：cnt=10/20/30/40/50。（<strong>仅尊享版、旗舰版支持该参数</strong>）</p><p>枚举值：</p><ul><li>10： 返回10条结果</li><li>20： 返回20条结果</li><li>30： 返回30条结果</li><li>40： 返回40条结果</li><li>50： 返回50条结果</li></ul>
        /// </summary>
        [JsonProperty("Cnt")]
        public ulong? Cnt{ get; set; }

        /// <summary>
        /// <p>垂直领域搜索。（<strong>仅尊享版、旗舰版支持该参数</strong>）</p><p>枚举值：</p><ul><li>gov： 政府</li><li>news： 新闻</li><li>acad： 学术</li><li>finance： 财经</li></ul>
        /// </summary>
        [JsonProperty("Industry")]
        public string Industry{ get; set; }

        /// <summary>
        /// <p>搜索时效范围（<strong>仅标准版、尊享版、旗舰版支持该参数</strong>）</p><ul><li><p>d[N]：最近N天，N取值1-30整数。</p></li><li><p>m[N]：最近N月，N取值1-12整数。</p></li><li><p>y[N]：最近N年，N取值1-5整数。</p></li></ul><p>示例说明：</p><ul><li><p>d1/m1/y1：当天/当月/当年。<br>例如，2026.6.15分别传参d1/m1/y1进行搜索，则搜索结果的时间范围分别为“2026.6.15”/“2026.6”/“2026”，以此类推。</p></li><li><p>d/m/y：N值为空时，默认N=1，即等效入参d1/m1/y1。</p></li><li><p>未传参时，默认不生效。</p></li><li><p>d、m、y不支持组合使用。</p></li></ul><p>枚举值：</p><ul><li>d7： 最近七天</li><li>m3： 最近三月</li><li>y2： 最近两年</li><li>d： 当天</li><li>m： 当月</li><li>y： 当年</li></ul>
        /// </summary>
        [JsonProperty("Freshness")]
        public string Freshness{ get; set; }

        /// <summary>
        /// <p>返回附件子链信息（<strong>仅旗舰版支持该参数</strong>）</p><p>附件子链信息包括&quot;子链标题&quot;和&quot;子链URL&quot;，单个doc最多返回10条子链信息。</p><ul><li>true：返回</li><li>false：不返回</li><li>未传参时默认不返回</li></ul>
        /// </summary>
        [JsonProperty("Deeplinks")]
        public bool? Deeplinks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Site", this.Site);
            this.SetParamSimple(map, prefix + "Cnt", this.Cnt);
            this.SetParamSimple(map, prefix + "Industry", this.Industry);
            this.SetParamSimple(map, prefix + "Freshness", this.Freshness);
            this.SetParamSimple(map, prefix + "Deeplinks", this.Deeplinks);
        }
    }
}

