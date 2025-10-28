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

    public class IPReputationGroup : AbstractModel
    {
        
        /// <summary>
        /// IP 情报库（原客户端画像分析）的执行动作。SecurityAction 的 Name 取值支持：<li>Deny：拦截；</li><li>Monitor：观察；</li><li>Disabled：未启用，不启用指定规则；</li><li>Challenge：挑战，其中 ChallengeActionParameters 中的 ChallengeOption 支持 JSChallenge 和 ManagedChallenge。</li>
        /// </summary>
        [JsonProperty("BaseAction")]
        public SecurityAction BaseAction{ get; set; }

        /// <summary>
        /// IP 情报库（原客户端画像分析）的具体配置，用于覆盖 BaseAction 中的默认配置。其中 BotManagementActionOverrides 的 Ids 中可以填写：<li>IPREP_WEB_AND_DDOS_ATTACKERS_LOW：网络攻击 - 一般置信度；</li><li>IPREP_WEB_AND_DDOS_ATTACKERS_MID：网络攻击 - 中等置信度；</li><li>IPREP_WEB_AND_DDOS_ATTACKERS_HIGH：网络攻击 - 高置信度；</li><li>IPREP_PROXIES_AND_ANONYMIZERS_LOW：网络代理 - 一般置信度；</li><li>IPREP_PROXIES_AND_ANONYMIZERS_MID：网络代理 - 中等置信度；</li><li>IPREP_PROXIES_AND_ANONYMIZERS_HIGH：网络代理 - 高置信度；</li><li>IPREP_SCANNING_TOOLS_LOW：扫描器 - 一般置信度；</li><li>IPREP_SCANNING_TOOLS_MID：扫描器 - 中等置信度；</li><li>IPREP_SCANNING_TOOLS_HIGH：扫描器 - 高置信度；</li><li>IPREP_ATO_ATTACKERS_LOW：账号接管攻击 - 一般置信度；</li><li>IPREP_ATO_ATTACKERS_MID：账号接管攻击 - 中等置信度；</li><li>IPREP_ATO_ATTACKERS_HIGH：账号接管攻击 - 高置信度；</li><li>IPREP_WEB_SCRAPERS_AND_TRAFFIC_BOTS_LOW：恶意 BOT - 一般置信度；</li><li>IPREP_WEB_SCRAPERS_AND_TRAFFIC_BOTS_MID：恶意 BOT - 中等置信度；</li><li>IPREP_WEB_SCRAPERS_AND_TRAFFIC_BOTS_HIGH：恶意 BOT - 高置信度。</li>
        /// </summary>
        [JsonProperty("BotManagementActionOverrides")]
        public BotManagementActionOverrides[] BotManagementActionOverrides{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BaseAction.", this.BaseAction);
            this.SetParamArrayObj(map, prefix + "BotManagementActionOverrides.", this.BotManagementActionOverrides);
        }
    }
}

