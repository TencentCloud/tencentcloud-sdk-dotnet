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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogRuleTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// 模板ID。
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public string RuleTemplateId{ get; set; }

        /// <summary>
        /// 规则模板名
        /// </summary>
        [JsonProperty("RuleTemplateName")]
        public string RuleTemplateName{ get; set; }

        /// <summary>
        /// 告警等级。1-低风险，2-中风险，3-高风险。
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public string AlarmLevel{ get; set; }

        /// <summary>
        /// 规则模板变更状态：0-未变更；1-已变更；2-已删除
        /// </summary>
        [JsonProperty("RuleTemplateStatus")]
        public long? RuleTemplateStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "RuleTemplateName", this.RuleTemplateName);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "RuleTemplateStatus", this.RuleTemplateStatus);
        }
    }
}

