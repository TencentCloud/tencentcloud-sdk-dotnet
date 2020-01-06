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

    public class Ip6Translator : AbstractModel
    {
        
        /// <summary>
        /// IPV6转换实例唯一ID，形如ip6-xxxxxxxx
        /// </summary>
        [JsonProperty("Ip6TranslatorId")]
        public string Ip6TranslatorId{ get; set; }

        /// <summary>
        /// IPV6转换实例名称
        /// </summary>
        [JsonProperty("Ip6TranslatorName")]
        public string Ip6TranslatorName{ get; set; }

        /// <summary>
        /// IPV6地址
        /// </summary>
        [JsonProperty("Vip6")]
        public string Vip6{ get; set; }

        /// <summary>
        /// IPV6转换地址所属运营商
        /// </summary>
        [JsonProperty("IspName")]
        public string IspName{ get; set; }

        /// <summary>
        /// 转换实例状态，限于CREATING,RUNNING,DELETING,MODIFYING
        /// </summary>
        [JsonProperty("TranslatorStatus")]
        public string TranslatorStatus{ get; set; }

        /// <summary>
        /// IPV6转换实例创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 绑定的IPV6转换规则数量
        /// </summary>
        [JsonProperty("Ip6RuleCount")]
        public long? Ip6RuleCount{ get; set; }

        /// <summary>
        /// IPV6转换规则信息
        /// </summary>
        [JsonProperty("IP6RuleSet")]
        public Ip6Rule[] IP6RuleSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip6TranslatorId", this.Ip6TranslatorId);
            this.SetParamSimple(map, prefix + "Ip6TranslatorName", this.Ip6TranslatorName);
            this.SetParamSimple(map, prefix + "Vip6", this.Vip6);
            this.SetParamSimple(map, prefix + "IspName", this.IspName);
            this.SetParamSimple(map, prefix + "TranslatorStatus", this.TranslatorStatus);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Ip6RuleCount", this.Ip6RuleCount);
            this.SetParamArrayObj(map, prefix + "IP6RuleSet.", this.IP6RuleSet);
        }
    }
}

