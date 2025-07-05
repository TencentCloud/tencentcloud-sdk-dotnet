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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称，[a-zA-Z0-9-\.]* 长度128
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则脚本，长度65535
        /// </summary>
        [JsonProperty("RuleScript")]
        public string RuleScript{ get; set; }

        /// <summary>
        /// 规则描述，最长1024
        /// </summary>
        [JsonProperty("RuleDesc")]
        public string RuleDesc{ get; set; }

        /// <summary>
        /// 标签，key-value结构的数组，最多关联50组标签
        /// </summary>
        [JsonProperty("Tags")]
        public StringKV[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleScript", this.RuleScript);
            this.SetParamSimple(map, prefix + "RuleDesc", this.RuleDesc);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

