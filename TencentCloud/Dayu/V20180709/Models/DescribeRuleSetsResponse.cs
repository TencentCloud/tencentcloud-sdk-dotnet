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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRuleSetsResponse : AbstractModel
    {
        
        /// <summary>
        /// 规则记录数数组，取值说明:
        /// Key值为"Id"时，Value表示资源ID
        /// Key值为"RuleIdList"时，Value值表示资源的规则ID，多个规则ID用","分割
        /// Key值为"RuleNameList"时，Value值表示资源的规则名，多个规则名用","分割
        /// Key值为"RuleNum"时，Value值表示资源的规则数
        /// </summary>
        [JsonProperty("L4RuleSets")]
        public KeyValueRecord[] L4RuleSets{ get; set; }

        /// <summary>
        /// 规则记录数数组，取值说明:
        /// Key值为"Id"时，Value表示资源ID
        /// Key值为"RuleIdList"时，Value值表示资源的规则ID，多个规则ID用","分割
        /// Key值为"RuleNameList"时，Value值表示资源的规则名，多个规则名用","分割
        /// Key值为"RuleNum"时，Value值表示资源的规则数
        /// </summary>
        [JsonProperty("L7RuleSets")]
        public KeyValueRecord[] L7RuleSets{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "L4RuleSets.", this.L4RuleSets);
            this.SetParamArrayObj(map, prefix + "L7RuleSets.", this.L7RuleSets);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

