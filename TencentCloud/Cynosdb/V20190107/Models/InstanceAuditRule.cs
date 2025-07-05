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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAuditRule : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 是否是规则审计。true-规则审计，false-全审计。
        /// </summary>
        [JsonProperty("AuditRule")]
        public bool? AuditRule{ get; set; }

        /// <summary>
        /// 审计规则详情。仅当AuditRule=true时有效。
        /// </summary>
        [JsonProperty("AuditRuleFilters")]
        public AuditRuleFilters[] AuditRuleFilters{ get; set; }

        /// <summary>
        /// 是否是审计策略
        /// </summary>
        [JsonProperty("OldRule")]
        public bool? OldRule{ get; set; }

        /// <summary>
        /// 实例应用的规则模板详情
        /// </summary>
        [JsonProperty("RuleTemplates")]
        public RuleTemplateInfo[] RuleTemplates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AuditRule", this.AuditRule);
            this.SetParamArrayObj(map, prefix + "AuditRuleFilters.", this.AuditRuleFilters);
            this.SetParamSimple(map, prefix + "OldRule", this.OldRule);
            this.SetParamArrayObj(map, prefix + "RuleTemplates.", this.RuleTemplates);
        }
    }
}

