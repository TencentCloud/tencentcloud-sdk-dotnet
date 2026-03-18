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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NumberInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>号码</p>
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// <p>绑定的外呼技能组</p>
        /// </summary>
        [JsonProperty("CallOutSkillGroupIds")]
        public ulong?[] CallOutSkillGroupIds{ get; set; }

        /// <summary>
        /// <p>号码状态，1-正常，2-欠费停用，4-管理员停用，5-违规停用</p>
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>是否自携号码</p><p>枚举值：</p><ul><li>0： 非自携</li><li>1： 自携</li></ul>
        /// </summary>
        [JsonProperty("CostType")]
        public long? CostType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamArraySimple(map, prefix + "CallOutSkillGroupIds.", this.CallOutSkillGroupIds);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CostType", this.CostType);
        }
    }
}

