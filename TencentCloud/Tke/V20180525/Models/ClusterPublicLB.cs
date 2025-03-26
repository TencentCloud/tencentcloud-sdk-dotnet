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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterPublicLB : AbstractModel
    {
        
        /// <summary>
        /// 是否开启公网访问LB
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 允许访问的来源CIDR列表
        /// </summary>
        [JsonProperty("AllowFromCidrs")]
        public string[] AllowFromCidrs{ get; set; }

        /// <summary>
        /// 安全策略放通单个IP或CIDR(例如: "192.168.1.0/24",默认为拒绝所有)
        /// </summary>
        [JsonProperty("SecurityPolicies")]
        public string[] SecurityPolicies{ get; set; }

        /// <summary>
        /// 外网访问相关的扩展参数，格式为json
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// 新内外网功能，需要传递安全组
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArraySimple(map, prefix + "AllowFromCidrs.", this.AllowFromCidrs);
            this.SetParamArraySimple(map, prefix + "SecurityPolicies.", this.SecurityPolicies);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
        }
    }
}

