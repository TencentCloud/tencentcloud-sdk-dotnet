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

    public class BasicBotSettings : AbstractModel
    {
        
        /// <summary>
        /// 客户端 IP 的来源 IDC 配置，用于处置来自 IDC（数据中心） 的客户端 IP 的访问请求。此类来源请求不是由移动端或浏览器端直接访问。
        /// </summary>
        [JsonProperty("SourceIDC")]
        public SourceIDC SourceIDC{ get; set; }

        /// <summary>
        /// 搜索引擎爬虫配置，用于处置来自搜索引擎爬虫的请求。此类请求的 IP、User-Agent 或 rDNS 结果匹配已知搜索引擎爬虫。
        /// </summary>
        [JsonProperty("SearchEngineBots")]
        public SearchEngineBots SearchEngineBots{ get; set; }

        /// <summary>
        /// 商业或开源工具 UA 特征配置（原 UA 特征规则），用于处置来自已知商业工具或开源工具的访问请求。此类请求的 User-Agent 头部符合已知商业或开源工具特征。
        /// </summary>
        [JsonProperty("KnownBotCategories")]
        public KnownBotCategories KnownBotCategories{ get; set; }

        /// <summary>
        /// IP 威胁情报库（原客户端画像分析）配置，用于处置近期访问行为具有特定风险特征的客户端 IP。
        /// </summary>
        [JsonProperty("IPReputation")]
        public IPReputation IPReputation{ get; set; }

        /// <summary>
        /// Bot 智能分析的具体配置。
        /// </summary>
        [JsonProperty("BotIntelligence")]
        public BotIntelligence BotIntelligence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SourceIDC.", this.SourceIDC);
            this.SetParamObj(map, prefix + "SearchEngineBots.", this.SearchEngineBots);
            this.SetParamObj(map, prefix + "KnownBotCategories.", this.KnownBotCategories);
            this.SetParamObj(map, prefix + "IPReputation.", this.IPReputation);
            this.SetParamObj(map, prefix + "BotIntelligence.", this.BotIntelligence);
        }
    }
}

