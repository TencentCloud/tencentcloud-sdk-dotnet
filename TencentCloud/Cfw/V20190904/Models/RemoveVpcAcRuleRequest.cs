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

    public class RemoveVpcAcRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则的uuid列表，可通过查询规则列表获取，注意：如果传入的是[-1]将删除所有规则
        /// </summary>
        [JsonProperty("RuleUuids")]
        public long?[] RuleUuids{ get; set; }

        /// <summary>
        /// 仅当RuleUuids为-1时有效；0：删除Ipv4规则，1：删除Ipv6规则；默认为Ipv4类型规则
        /// </summary>
        [JsonProperty("IpVersion")]
        public ulong? IpVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RuleUuids.", this.RuleUuids);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
        }
    }
}

