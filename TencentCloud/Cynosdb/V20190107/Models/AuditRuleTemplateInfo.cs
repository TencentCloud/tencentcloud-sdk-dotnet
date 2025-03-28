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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuditRuleTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则模板ID。
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public string RuleTemplateId{ get; set; }

        /// <summary>
        /// 规则模板名称。
        /// </summary>
        [JsonProperty("RuleTemplateName")]
        public string RuleTemplateName{ get; set; }

        /// <summary>
        /// 规则模板的过滤条件
        /// </summary>
        [JsonProperty("RuleFilters")]
        public RuleFilters[] RuleFilters{ get; set; }

        /// <summary>
        /// 规则模板描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 规则模板创建时间。
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// 规则模板修改时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateAt")]
        public string UpdateAt{ get; set; }

        /// <summary>
        /// 告警等级。1-低风险，2-中风险，3-高风险。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// 告警策略。0-不告警，1-告警。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmPolicy")]
        public ulong? AlarmPolicy{ get; set; }

        /// <summary>
        /// 模板状态。0-无任务 ，1-修改中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 规则模板应用在哪些在实例。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AffectedInstances")]
        public string[] AffectedInstances{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "RuleTemplateName", this.RuleTemplateName);
            this.SetParamArrayObj(map, prefix + "RuleFilters.", this.RuleFilters);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "UpdateAt", this.UpdateAt);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmPolicy", this.AlarmPolicy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "AffectedInstances.", this.AffectedInstances);
        }
    }
}

