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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyIp6RuleRequest : AbstractModel
    {
        
        /// <summary>
        /// IPV6转换实例唯一ID，形如ip6-xxxxxxxx
        /// </summary>
        [JsonProperty("Ip6TranslatorId")]
        public string Ip6TranslatorId{ get; set; }

        /// <summary>
        /// IPV6转换规则唯一ID，形如rule6-xxxxxxxx
        /// </summary>
        [JsonProperty("Ip6RuleId")]
        public string Ip6RuleId{ get; set; }

        /// <summary>
        /// IPV6转换规则修改后的名称
        /// </summary>
        [JsonProperty("Ip6RuleName")]
        public string Ip6RuleName{ get; set; }

        /// <summary>
        /// IPV6转换规则修改后的IPV4地址
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// IPV6转换规则修改后的IPV4端口号
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip6TranslatorId", this.Ip6TranslatorId);
            this.SetParamSimple(map, prefix + "Ip6RuleId", this.Ip6RuleId);
            this.SetParamSimple(map, prefix + "Ip6RuleName", this.Ip6RuleName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
        }
    }
}

