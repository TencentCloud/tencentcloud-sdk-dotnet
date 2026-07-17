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

    public class RemoveEnterpriseSecurityGroupRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>规则的uuid，可通过查询规则列表获取</p>
        /// </summary>
        [JsonProperty("RuleUuid")]
        public long? RuleUuid{ get; set; }

        /// <summary>
        /// <p>删除类型，0是单条删除，RuleUuid填写删除规则id，1为全部删除，RuleUuid填0即可</p>
        /// </summary>
        [JsonProperty("RemoveType")]
        public long? RemoveType{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "RemoveType", this.RemoveType);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
        }
    }
}

