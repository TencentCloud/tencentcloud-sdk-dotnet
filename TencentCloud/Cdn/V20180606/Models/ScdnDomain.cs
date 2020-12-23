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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScdnDomain : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 当前状态，取值online | offline | process
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Waf 状态默认为‘/’，取值 close | intercept | observe
        /// </summary>
        [JsonProperty("Waf")]
        public string Waf{ get; set; }

        /// <summary>
        /// Acl 状态默认为‘/’，取值 close | open
        /// </summary>
        [JsonProperty("Acl")]
        public string Acl{ get; set; }

        /// <summary>
        /// CC 状态默认为‘/’，取值 close | open
        /// </summary>
        [JsonProperty("CC")]
        public string CC{ get; set; }

        /// <summary>
        /// Ddos 状态默认为‘/’，取值 close | open
        /// </summary>
        [JsonProperty("Ddos")]
        public string Ddos{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Acl 规则数
        /// </summary>
        [JsonProperty("AclRuleNumbers")]
        public ulong? AclRuleNumbers{ get; set; }

        /// <summary>
        /// Bot 状态默认为‘/’，取值 close | open
        /// </summary>
        [JsonProperty("Bot")]
        public string Bot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Waf", this.Waf);
            this.SetParamSimple(map, prefix + "Acl", this.Acl);
            this.SetParamSimple(map, prefix + "CC", this.CC);
            this.SetParamSimple(map, prefix + "Ddos", this.Ddos);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AclRuleNumbers", this.AclRuleNumbers);
            this.SetParamSimple(map, prefix + "Bot", this.Bot);
        }
    }
}

