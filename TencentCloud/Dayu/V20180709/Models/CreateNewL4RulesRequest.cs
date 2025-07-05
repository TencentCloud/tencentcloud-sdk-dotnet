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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNewL4RulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 高防产品代号：bgpip
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 添加规则资源列表
        /// </summary>
        [JsonProperty("IdList")]
        public string[] IdList{ get; set; }

        /// <summary>
        /// 添加规则IP列表
        /// </summary>
        [JsonProperty("VipList")]
        public string[] VipList{ get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [JsonProperty("Rules")]
        public L4RuleEntry[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
            this.SetParamArraySimple(map, prefix + "VipList.", this.VipList);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

