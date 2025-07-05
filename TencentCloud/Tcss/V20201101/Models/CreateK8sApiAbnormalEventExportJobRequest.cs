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

    public class CreateK8sApiAbnormalEventExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。
        /// <li>TimeRange - string -是否必填: 否 - 时间范围筛选 ["2022-03-31 16:55:00", "2022-03-31 17:00:00"]</li>
        /// <li>MatchRules - string  - 是否必填: 否 -命中规则筛选</li>
        /// <li>RiskLevel - string  - 是否必填: 否 -威胁等级筛选</li>
        /// <li>Status - string  - 是否必填: 否 -事件状态筛选</li>
        /// <li>MatchRuleType - string  - 是否必填: 否 -命中规则类型筛选</li>
        /// <li>ClusterRunningStatus - string  - 是否必填: 否 -集群运行状态</li>
        /// <li>ClusterName - string  - 是否必填: 否 -集群名称</li>
        /// <li>ClusterID - string  - 是否必填: 否 -集群ID</li>
        /// </summary>
        [JsonProperty("Filters")]
        public RunTimeFilters[] Filters{ get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }

        /// <summary>
        /// 导出字段
        /// </summary>
        [JsonProperty("ExportField")]
        public string[] ExportField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
            this.SetParamArraySimple(map, prefix + "ExportField.", this.ExportField);
        }
    }
}

