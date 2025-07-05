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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCompliancePeriodTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 要修改的定时任务的ID，由DescribeCompliancePeriodTaskList接口返回。
        /// </summary>
        [JsonProperty("PeriodTaskId")]
        public ulong? PeriodTaskId{ get; set; }

        /// <summary>
        /// 定时任务的周期规则。不填时，不修改。
        /// </summary>
        [JsonProperty("PeriodRule")]
        public CompliancePeriodTaskRule PeriodRule{ get; set; }

        /// <summary>
        /// 设置合规标准。不填时，不修改。
        /// </summary>
        [JsonProperty("StandardSettings")]
        public ComplianceBenchmarkStandardEnable[] StandardSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeriodTaskId", this.PeriodTaskId);
            this.SetParamObj(map, prefix + "PeriodRule.", this.PeriodRule);
            this.SetParamArrayObj(map, prefix + "StandardSettings.", this.StandardSettings);
        }
    }
}

