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

    public class CustomWhiteRule : AbstractModel
    {
        
        /// <summary>
        /// 访问目的
        /// </summary>
        [JsonProperty("DstIP")]
        public string DstIP{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("IdsRuleId")]
        public string IdsRuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("IdsRuleName")]
        public string IdsRuleName{ get; set; }

        /// <summary>
        /// 访问源
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DstIP", this.DstIP);
            this.SetParamSimple(map, prefix + "IdsRuleId", this.IdsRuleId);
            this.SetParamSimple(map, prefix + "IdsRuleName", this.IdsRuleName);
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
        }
    }
}

