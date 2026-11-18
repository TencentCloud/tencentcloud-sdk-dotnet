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

    public class OpenAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>CDB 实例 ID。可通过 <a href="https://cloud.tencent.com/document/product/236/15872">DescribeDBInstances</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>审计日志保存时长。</p><p>枚举值：</p><ul><li>7： 一周</li><li>30： 一个月</li><li>90： 三个月</li><li>180： 六个月</li><li>365： 一年</li><li>1095： 三年</li><li>1825： 五年</li></ul>
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// <p>高频审计日志保存时长。</p><p>枚举值：</p><ul><li>7： 一周</li><li>30： 一个月</li><li>90： 三个月</li><li>180： 六个月</li><li>365： 一年</li><li>1095： 三年</li><li>1825： 五年</li></ul><p>默认值：7</p><p>此项取值需小于等于 LogExpireDay。</p>
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public ulong? HighLogExpireDay{ get; set; }

        /// <summary>
        /// <p>审计规则（该参数已废弃，不再生效）。</p>
        /// </summary>
        [JsonProperty("AuditRuleFilters")]
        [System.Obsolete]
        public AuditRuleFilters[] AuditRuleFilters{ get; set; }

        /// <summary>
        /// <p>规则模板 ID。</p>
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }

        /// <summary>
        /// <p>审计类型。true - 全审计；默认 false - 规则审计。</p>
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamArrayObj(map, prefix + "AuditRuleFilters.", this.AuditRuleFilters);
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
            this.SetParamSimple(map, prefix + "AuditAll", this.AuditAll);
        }
    }
}

