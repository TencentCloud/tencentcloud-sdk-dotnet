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

    public class RemoveIp6RulesRequest : AbstractModel
    {
        
        /// <summary>
        /// IPV6转换规则所属的转换实例唯一ID，形如ip6-xxxxxxxx
        /// </summary>
        [JsonProperty("Ip6TranslatorId")]
        public string Ip6TranslatorId{ get; set; }

        /// <summary>
        /// 待删除IPV6转换规则，形如rule6-xxxxxxxx
        /// </summary>
        [JsonProperty("Ip6RuleIds")]
        public string[] Ip6RuleIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip6TranslatorId", this.Ip6TranslatorId);
            this.SetParamArraySimple(map, prefix + "Ip6RuleIds.", this.Ip6RuleIds);
        }
    }
}

