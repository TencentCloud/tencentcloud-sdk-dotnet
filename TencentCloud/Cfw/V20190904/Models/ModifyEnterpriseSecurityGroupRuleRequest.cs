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

    public class ModifyEnterpriseSecurityGroupRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>规则的uuid，可通过查询规则列表获取</p>
        /// </summary>
        [JsonProperty("RuleUuid")]
        public ulong? RuleUuid{ get; set; }

        /// <summary>
        /// <p>修改类型，0：修改规则内容；1：修改单条规则开关状态；2：修改所有规则开关状态</p>
        /// </summary>
        [JsonProperty("ModifyType")]
        public ulong? ModifyType{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>编辑后的企业安全组规则数据；修改规则状态不用填该字段</p>
        /// </summary>
        [JsonProperty("Data")]
        public SecurityGroupRule Data{ get; set; }

        /// <summary>
        /// <p>0是关闭,1是开启</p>
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleUuid", this.RuleUuid);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

