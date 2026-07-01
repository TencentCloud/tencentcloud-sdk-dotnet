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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleAction : AbstractModel
    {
        
        /// <summary>
        /// <p>七层转发规则行为类型</p><p>枚举值：</p><ul><li>ForwardGroup： 转发策略为转发至终端节点组。</li><li>Drop： 转发策略为丢弃。</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleActionType")]
        public string RuleActionType{ get; set; }

        /// <summary>
        /// <p>七层转发规则行为值</p><p>当RuleActionType是Drop时，此字段不用传；当RuleActionType是ForwardGroup时，此字段必传，需要填写的是自定义终端节点组ID， 不支持配置默认终端节点组。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleActionValue")]
        public string RuleActionValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleActionType", this.RuleActionType);
            this.SetParamSimple(map, prefix + "RuleActionValue", this.RuleActionValue);
        }
    }
}

