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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateScdnDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Web 攻击防护（WAF）配置
        /// </summary>
        [JsonProperty("Waf")]
        public ScdnWafConfig Waf{ get; set; }

        /// <summary>
        /// 自定义防护策略配置
        /// </summary>
        [JsonProperty("Acl")]
        public ScdnAclConfig Acl{ get; set; }

        /// <summary>
        /// CC 防护配置，目前 CC 防护默认开启
        /// </summary>
        [JsonProperty("CC")]
        public ScdnConfig CC{ get; set; }

        /// <summary>
        /// DDOS 防护配置，目前 DDoS 防护默认开启
        /// </summary>
        [JsonProperty("Ddos")]
        public ScdnDdosConfig Ddos{ get; set; }

        /// <summary>
        /// BOT 防护配置
        /// </summary>
        [JsonProperty("Bot")]
        public ScdnBotConfig Bot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamObj(map, prefix + "Waf.", this.Waf);
            this.SetParamObj(map, prefix + "Acl.", this.Acl);
            this.SetParamObj(map, prefix + "CC.", this.CC);
            this.SetParamObj(map, prefix + "Ddos.", this.Ddos);
            this.SetParamObj(map, prefix + "Bot.", this.Bot);
        }
    }
}

