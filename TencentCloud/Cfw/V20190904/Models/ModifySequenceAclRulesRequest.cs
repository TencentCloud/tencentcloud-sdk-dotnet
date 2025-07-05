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

    public class ModifySequenceAclRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则快速排序：OrderIndex，原始序号；NewOrderIndex：新序号
        /// </summary>
        [JsonProperty("RuleChangeItems")]
        public RuleChangeItem[] RuleChangeItems{ get; set; }

        /// <summary>
        /// 规则方向：1，入站；0，出站
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RuleChangeItems.", this.RuleChangeItems);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

