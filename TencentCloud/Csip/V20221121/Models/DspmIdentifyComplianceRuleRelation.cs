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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmIdentifyComplianceRuleRelation : AbstractModel
    {
        
        /// <summary>
        /// <p>数据项ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// <p>数据项名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>级别ID</p>
        /// </summary>
        [JsonProperty("LevelId")]
        public ulong? LevelId{ get; set; }

        /// <summary>
        /// <p>级别名称</p>
        /// </summary>
        [JsonProperty("LevelName")]
        public string LevelName{ get; set; }

        /// <summary>
        /// <p>级别程度</p><p>单位：分数</p>
        /// </summary>
        [JsonProperty("LevelScore")]
        public ulong? LevelScore{ get; set; }

        /// <summary>
        /// <p>结构化规则状态</p><p>枚举值：</p><ul><li>0： 未配置</li><li>1： 已配置</li></ul>
        /// </summary>
        [JsonProperty("StructuredStatus")]
        public ulong? StructuredStatus{ get; set; }

        /// <summary>
        /// <p>非结构化规则状态</p><p>枚举值：</p><ul><li>0： 未配置</li><li>1： 已配置</li></ul>
        /// </summary>
        [JsonProperty("UnStructuredStatus")]
        public ulong? UnStructuredStatus{ get; set; }

        /// <summary>
        /// <p>数据项开启状态</p><p>枚举值：</p><ul><li>0： 未开启</li><li>1： 已开启</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "LevelName", this.LevelName);
            this.SetParamSimple(map, prefix + "LevelScore", this.LevelScore);
            this.SetParamSimple(map, prefix + "StructuredStatus", this.StructuredStatus);
            this.SetParamSimple(map, prefix + "UnStructuredStatus", this.UnStructuredStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

