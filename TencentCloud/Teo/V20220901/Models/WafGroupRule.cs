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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WafGroupRule : AbstractModel
    {
        
        /// <summary>
        /// 规则id。
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 规则描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 等级描述。
        /// </summary>
        [JsonProperty("RuleLevelDesc")]
        public string RuleLevelDesc{ get; set; }

        /// <summary>
        /// 规则标签。部分类型的规则不存在该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleTags")]
        public string[] RuleTags{ get; set; }

        /// <summary>
        /// 更新时间，格式为YYYY-MM-DD hh:mm:ss。部分类型的规则不存在该参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 状态，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>为空时对应接口Status无意义，例如仅查询规则详情时。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 规则类型名。
        /// </summary>
        [JsonProperty("RuleTypeName")]
        public string RuleTypeName{ get; set; }

        /// <summary>
        /// 规则类型id。
        /// </summary>
        [JsonProperty("RuleTypeId")]
        public long? RuleTypeId{ get; set; }

        /// <summary>
        /// 规则类型描述。
        /// </summary>
        [JsonProperty("RuleTypeDesc")]
        public string RuleTypeDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RuleLevelDesc", this.RuleLevelDesc);
            this.SetParamArraySimple(map, prefix + "RuleTags.", this.RuleTags);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleTypeName", this.RuleTypeName);
            this.SetParamSimple(map, prefix + "RuleTypeId", this.RuleTypeId);
            this.SetParamSimple(map, prefix + "RuleTypeDesc", this.RuleTypeDesc);
        }
    }
}

