/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebSearchRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 搜索的网页数量，默认20
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 指定域名，gov.cn 可匹配 *.gov.cn的域名。
        /// </summary>
        [JsonProperty("Site")]
        public string Site{ get; set; }

        /// <summary>
        /// 是否获取返回网页全文，默认 false。
        /// </summary>
        [JsonProperty("FetchContent")]
        public bool? FetchContent{ get; set; }

        /// <summary>
        /// 域名白名单，在不指定 Site 时，只保存匹配白名单域名的网页。
        /// </summary>
        [JsonProperty("WhiteSites")]
        public string[] WhiteSites{ get; set; }

        /// <summary>
        /// 域名黑名单，在不指定 Site 和白名单时，过滤黑名单中的域名。
        /// </summary>
        [JsonProperty("BlackSites")]
        public string[] BlackSites{ get; set; }

        /// <summary>
        /// 秒级时间冲，搜索网页的开始时间，默认不限制开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 秒级时间戳，搜索网页的结束时间，默认为现在。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 指定搜索引擎，可选混合搜索 mixed，或 bing, baidu, sogou, 默认为 sogou
        /// </summary>
        [JsonProperty("SearchEngine")]
        public string SearchEngine{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Site", this.Site);
            this.SetParamSimple(map, prefix + "FetchContent", this.FetchContent);
            this.SetParamArraySimple(map, prefix + "WhiteSites.", this.WhiteSites);
            this.SetParamArraySimple(map, prefix + "BlackSites.", this.BlackSites);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SearchEngine", this.SearchEngine);
        }
    }
}

