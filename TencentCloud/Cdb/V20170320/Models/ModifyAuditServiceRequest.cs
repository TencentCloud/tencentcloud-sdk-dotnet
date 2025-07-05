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

    public class ModifyAuditServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDBInstances](https://cloud.tencent.com/document/product/236/15872) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 日志保留时长。支持值包括：
        /// 7 - 一周；
        /// 30 - 一个月；
        /// 90 - 三个月；
        /// 180 - 六个月；
        /// 365 - 一年；
        /// 1095 - 三年；
        /// 1825 - 五年。
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public ulong? LogExpireDay{ get; set; }

        /// <summary>
        /// 高频日志保留时长。默认值为7，此项取值需小于等于 LogExpireDay，支持值包括：
        /// 3 - 3天；
        /// 7 - 一周；
        /// 30 - 一个月；
        /// 90 - 三个月；
        /// 180 - 六个月；
        /// 365 - 一年；
        /// 1095 - 三年；
        /// 1825 - 五年。
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public ulong? HighLogExpireDay{ get; set; }

        /// <summary>
        /// 修改实例审计规则为全审计。
        /// </summary>
        [JsonProperty("AuditAll")]
        public bool? AuditAll{ get; set; }

        /// <summary>
        /// 废弃。
        /// </summary>
        [JsonProperty("AuditRuleFilters")]
        [System.Obsolete]
        public AuditRuleFilters[] AuditRuleFilters{ get; set; }

        /// <summary>
        /// 规则模板 ID。可通过 [DescribeAuditRuleTemplates](https://cloud.tencent.com/document/api/236/101811) 接口获取。
        /// </summary>
        [JsonProperty("RuleTemplateIds")]
        public string[] RuleTemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamSimple(map, prefix + "AuditAll", this.AuditAll);
            this.SetParamArrayObj(map, prefix + "AuditRuleFilters.", this.AuditRuleFilters);
            this.SetParamArraySimple(map, prefix + "RuleTemplateIds.", this.RuleTemplateIds);
        }
    }
}

