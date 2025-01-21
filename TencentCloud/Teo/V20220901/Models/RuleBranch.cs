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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleBranch : AbstractModel
    {
        
        /// <summary>
        /// [匹配条件
        /// ](https://cloud.tencent.com/document/product/1552/90438#33f65828-c6c6-4b66-a011-25a20b548d5d)。
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// [操作](https://cloud.tencent.com/document/product/1552/90438#c7bd7e02-9247-4a72-b0e4-11c27cadb198)。<br>注意：Actions 和 SubRules 不可同时为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Actions")]
        public RuleEngineAction[] Actions{ get; set; }

        /// <summary>
        /// 子规则列表。此列表中时存在多条规则，按照从上往下的顺序依次执行。<br>注意：SubRules 和 Actions 不可同时为空。且当前只支持填写一层 SubRules。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubRules")]
        public RuleEngineSubRule[] SubRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamArrayObj(map, prefix + "Actions.", this.Actions);
            this.SetParamArrayObj(map, prefix + "SubRules.", this.SubRules);
        }
    }
}

