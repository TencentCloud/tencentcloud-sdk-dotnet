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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteBlockIgnoreRuleNewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>是否删除全部</p>
        /// </summary>
        [JsonProperty("DeleteAll")]
        public long? DeleteAll{ get; set; }

        /// <summary>
        /// <p>blocklist 封禁列表 whitelist 白名单列表</p>
        /// </summary>
        [JsonProperty("ShowType")]
        public string ShowType{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>规则列表</p>
        /// </summary>
        [JsonProperty("Rules")]
        public BanAndAllowRuleDel[] Rules{ get; set; }

        /// <summary>
        /// <p>封禁：1，放通：100，<br>主要用于全部删除时区分列表类型</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeleteAll", this.DeleteAll);
            this.SetParamSimple(map, prefix + "ShowType", this.ShowType);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
        }
    }
}

