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

    public class RemoveAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则的uuid列表，可通过查询规则列表获取，注意：如果传入的是[-1]将删除所有规则
        /// </summary>
        [JsonProperty("RuleUuid")]
        public long?[] RuleUuid{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "RuleUuid.", this.RuleUuid);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

