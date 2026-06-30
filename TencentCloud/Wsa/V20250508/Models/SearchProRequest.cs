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
        /// <p>返回结果类型，0-自然检索结果(默认)，1-多模态VR结果，2-混合结果（多模态VR结果+自然检索结果）</p>
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// <p>指定域名站内搜索（用于过滤自然检索结果）<br>注意： mode=1模式下，参数无效；mode=0模式下，对所有结果生效；mode=2模式下，对输出的自然结果生效</p>
        /// </summary>
        [JsonProperty("Site")]
        public string Site{ get; set; }

        /// <summary>
        /// <p>起始时间（用于过滤自然检索结果），精确到秒时间戳格式<br>注意： mode=1模式下，参数无效；mode=0模式下，对所有结果生效；mode=2模式下，对输出的自然结果生效</p>
        /// </summary>
        [JsonProperty("FromTime")]
        public long? FromTime{ get; set; }

        /// <summary>
        /// <p>结束时间（用于过滤自然检索结果），精确到秒时间戳格式<br>注意：mode=1模式下，参数无效；mode=0模式下，对所有结果生效；mode=2模式下，对输出的自然结果生效</p>
        /// </summary>
        [JsonProperty("ToTime")]
        public long? ToTime{ get; set; }

        /// <summary>
        /// <p>cnt=10/20/30/40/50，最多可支持返回50条搜索结果，<strong>仅限尊享版使用</strong></p>
        /// </summary>
        [JsonProperty("Cnt")]
        public ulong? Cnt{ get; set; }

        /// <summary>
        /// <p>Industry=gov/news/acad/finance，对应党政机关、权威媒体、学术（英文）、金融，<strong>仅限尊享版使用</strong></p>
        /// </summary>
        [JsonProperty("Industry")]
        public string Industry{ get; set; }

        /// <summary>
        /// <p>搜索实效范围（仅旗舰版参数）</p><ul><li>d[N]：最近N天，N取值1-30整数。</li><li>m[N]：最近N月，N取值1-12整数。</li><li>y[N]：最近N年，N取值1-5整数。</li></ul><p>示例说明：</p><ul><li>d1/m1/y1：当天/当月/当年。<br>例如，2026.6.15分别传参d1/m1/y1进行搜索，则搜索结果的时间范围分别为“2026.6.15”/“2026.6”/“2026”，以此类推。</li><li>d/m/y：N值为空时，默认N=1，即等效入参d1/m1/y1。</li><li>未传参时，默认不生效。</li></ul><p>枚举值：</p><ul><li>d7： 最近七天</li><li>m3： 最近三月</li><li>y2： 最近两年</li><li>d： 当天</li><li>m： 当月</li><li>y： 当年</li></ul>
        /// </summary>
        [JsonProperty("Freshness")]
        public string Freshness{ get; set; }

        /// <summary>
        /// <p>返回子链信息（仅旗舰版参数）</p><p>子链信息包括&quot;子链标题&quot;和&quot;子链URL&quot;，单个doc最多返回10条子链信息。</p><ul><li>true：返回</li><li>false：不返回</li><li>未传参时默认不返回</li></ul>
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
            this.SetParamSimple(map, prefix + "FromTime", this.FromTime);
            this.SetParamSimple(map, prefix + "ToTime", this.ToTime);
            this.SetParamSimple(map, prefix + "Cnt", this.Cnt);
            this.SetParamSimple(map, prefix + "Industry", this.Industry);
            this.SetParamSimple(map, prefix + "Freshness", this.Freshness);
            this.SetParamSimple(map, prefix + "Deeplinks", this.Deeplinks);
        }
    }
}

